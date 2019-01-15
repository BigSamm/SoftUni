namespace SoftJail.DataProcessor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;

    using Newtonsoft.Json;

    using Data;
    using Data.Models;
    using Data.Models.Enums;
    using ImportDto;

    public class Deserializer
    {
        private const string ERROR_MESSAGE = "Invalid Data";

        public static string ImportDepartmentsCells(SoftJailDbContext context, string jsonString)
        {
            var result = new StringBuilder();
            var cells = new List<Cell>();
            var departments = new List<Department>();

            DepartmentDto[] departmentDtos = JsonConvert.DeserializeObject<DepartmentDto[]>(jsonString);

            foreach (DepartmentDto depDto in departmentDtos)
            {
                if (!IsValid(depDto))
                {
                    result.AppendLine(ERROR_MESSAGE);
                    continue;
                }

                bool areValidCells = true;
                foreach (CellDto cellDto in depDto.Cells)
                {
                    if (!IsValid(cellDto))
                    {
                        areValidCells = false;
                        break;
                    }
                }

                if (!areValidCells)
                {
                    result.AppendLine(ERROR_MESSAGE);
                    continue;
                }

                var department = new Department { Name = depDto.Name };
                departments.Add(department);

                foreach (CellDto cellDto in depDto.Cells)
                {
                    var cell = new Cell
                    {
                        CellNumber = cellDto.CellNumber,
                        HasWindow = cellDto.HasWindow,
                        Department = department
                    };

                    cells.Add(cell);
                }

                result.AppendLine($"Imported {department.Name} with {depDto.Cells.Length} cells");
            }

            context.Cells.AddRange(cells);
            context.Departments.AddRange(departments);
            context.SaveChanges();

            return result.ToString();
        }

        public static string ImportPrisonersMails(SoftJailDbContext context, string jsonString)
        {
            var result = new StringBuilder();
            var prisoners = new List<Prisoner>();
            var mails = new List<Mail>();

            var prisonersDtos = JsonConvert.DeserializeObject<PrisonerDto[]>(jsonString);

            foreach (PrisonerDto prisDto in prisonersDtos)
            {
                if (!IsValid(prisDto))
                {
                    result.AppendLine(ERROR_MESSAGE);
                    continue;
                }

                bool isValidNickname = IsValidNickname(prisDto.Nickname);
                if (!isValidNickname)
                {
                    result.AppendLine(ERROR_MESSAGE);
                    continue;
                }

                bool areValidMails = true;
                foreach (MailDto mailDto in prisDto.Mails)
                {
                    bool isValidAddress = IsValidAddress(mailDto.Address);
                    if (!IsValid(mailDto) || !isValidAddress)
                    {
                        areValidMails = false;
                        break;
                    }
                }

                if (!areValidMails)
                {
                    result.AppendLine(ERROR_MESSAGE);
                    continue;
                }

                DateTime incarcerationDate = DateTime.ParseExact(prisDto.IncarcerationDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                DateTime? releaseDate = prisDto.ReleaseDate == null ? (DateTime?)null :
                    DateTime.ParseExact(prisDto.ReleaseDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                var prisoner = new Prisoner
                {
                    FullName = prisDto.FullName,
                    Nickname = prisDto.Nickname,
                    Age = prisDto.Age,
                    IncarcerationDate = incarcerationDate,
                    ReleaseDate = releaseDate,
                    Bail = prisDto.Bail,
                    CellId = prisDto.CellId
                };

                prisoners.Add(prisoner);

                foreach (MailDto mailDto in prisDto.Mails)
                {
                    var mail = new Mail
                    {
                        Description = mailDto.Description,
                        Sender = mailDto.Sender,
                        Address = mailDto.Address,
                        Prisoner = prisoner
                    };

                    mails.Add(mail);
                }

                result.AppendLine($"Imported {prisoner.FullName} {prisoner.Age} years old");
            }

            context.Mails.AddRange(mails);
            context.Prisoners.AddRange(prisoners);
            context.SaveChanges();

            return result.ToString();
        }

        private static bool IsValidAddress(string address)
        {
            foreach (char c in address)
            {
                if (!Char.IsDigit(c) && !Char.IsLetter(c) && c != ' ' && c != '.')
                    return false;
            }

            if (!address.EndsWith(" str."))
                return false;

            return true;
        }

        private static bool IsValidNickname(string nickname)
        {
            if (!nickname.StartsWith("The "))
                return false;

            if (!Char.IsUpper(nickname.Skip(4).First()))
                return false;

            if (!nickname.Skip(4).All(x => Char.IsLetter(x)))
                return false;

            return true;
        }

        public static string ImportOfficersPrisoners(SoftJailDbContext context, string xmlString)
        {
            var result = new StringBuilder();
            var officers = new List<Officer>();
            var officersPrisoners = new List<OfficerPrisoner>();

            var serializer = new XmlSerializer(typeof(OfficerDto[]), new XmlRootAttribute("Officers"));
            OfficerDto[] officersDtos = (OfficerDto[])serializer.Deserialize(new StringReader(xmlString));

            foreach (OfficerDto officerDto in officersDtos)
            {
                if (!IsValid(officerDto))
                {
                    result.AppendLine(ERROR_MESSAGE);
                    continue;
                }

                bool isValidPosition = Enum.TryParse(officerDto.Position, out Position position);
                bool isValidWeapon = Enum.TryParse(officerDto.Weapon, out Weapon weapon);

                if (!isValidPosition || !isValidWeapon)
                {
                    result.AppendLine(ERROR_MESSAGE);
                    continue;
                }

                var officer = new Officer
                {
                    FullName = officerDto.Name,
                    Salary = officerDto.Money,
                    Position = position,
                    Weapon = weapon,
                    DepartmentId = officerDto.DepartmentId
                };

                officers.Add(officer);

                foreach (OfficerPrisonerDto prisoner in officerDto.Prisoners)
                {
                    var officerPrisoner = new OfficerPrisoner
                    {
                        Officer = officer,
                        PrisonerId = prisoner.Id
                    };

                    officersPrisoners.Add(officerPrisoner);
                }

                result.AppendLine($"Imported {officer.FullName} ({officerDto.Prisoners.Length} prisoners)");
            }

            context.Officers.AddRange(officers);
            context.OfficersPrisoners.AddRange(officersPrisoners);
            context.SaveChanges();

            return result.ToString();
        }

        private static bool IsValid(object obj)
        {
            var validationContext = new ValidationContext(obj);
            var validationResults = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(obj, validationContext, validationResults, true);
            return isValid;
        }
    }
}