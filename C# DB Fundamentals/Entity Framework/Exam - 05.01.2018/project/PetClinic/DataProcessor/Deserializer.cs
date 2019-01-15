namespace PetClinic.DataProcessor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using Newtonsoft.Json;

    using Data;
    using Dtos.Import;
    using Models;

    public class Deserializer
    {
        private const string ERROR_MESSAGE = "Error: Invalid data.";

        public static string ImportAnimalAids(PetClinicContext context, string jsonString)
        {
            var result = new StringBuilder();
            var animalAidsList = new List<AnimalAid>();

            AnimalAid[] animalAids = JsonConvert.DeserializeObject<AnimalAid[]>(jsonString);

            foreach (AnimalAid animalAid in animalAids)
            {
                if (!IsValid(animalAid))
                {
                    result.AppendLine(ERROR_MESSAGE);
                    continue;
                }

                if (animalAidsList.Any(aa => aa.Name == animalAid.Name))
                {
                    result.AppendLine(ERROR_MESSAGE);
                    continue;
                }

                animalAidsList.Add(animalAid);

                result.AppendLine($"Record {animalAid.Name} successfully imported.");
            }

            context.AddRange(animalAidsList);
            context.SaveChanges();

            return result.ToString();
        }

        public static string ImportAnimals(PetClinicContext context, string jsonString)
        {
            var result = new StringBuilder();

            var animalList = new List<Animal>();

            AnimalDto[] animalDtos = JsonConvert.DeserializeObject<AnimalDto[]>(jsonString);

            foreach (AnimalDto animalDto in animalDtos)
            {
                var passportDto = animalDto.Passport;

                if (!IsValid(animalDto) || !IsValid(passportDto))
                {
                    result.AppendLine(ERROR_MESSAGE);
                    continue;
                }

                if (animalList.Any(a => a.Passport.SerialNumber == passportDto.SerialNumber))
                {
                    result.AppendLine(ERROR_MESSAGE);
                    continue;
                }

                if (!IsValidPassportSerialNumber(passportDto.SerialNumber) ||
                    !IsValidPhoneNumber(passportDto.OwnerPhoneNumber))
                {
                    result.AppendLine(ERROR_MESSAGE);
                    continue;
                }

                DateTime registrationDate = DateTime.Parse(passportDto.RegistrationDate);
                var passport = new Passport
                {
                    SerialNumber = passportDto.SerialNumber,
                    OwnerName = passportDto.OwnerName,
                    OwnerPhoneNumber = passportDto.OwnerPhoneNumber,
                    RegistrationDate = registrationDate
                };

                var animal = new Animal
                {
                    Name = animalDto.Name,
                    Type = animalDto.Type,
                    Age = animalDto.Age,
                    Passport = passport
                };
                
                animalList.Add(animal);

                result.AppendLine($"Record {animal.Name} Passport №: {passport.SerialNumber} successfully imported.");
            }
            
            context.Animals.AddRange(animalList);
            context.SaveChanges();

            return result.ToString();
        }

        private static bool IsValidPhoneNumber(string ownerPhoneNumber)
        {
            if (ownerPhoneNumber.StartsWith("+359") &&
                ownerPhoneNumber.Count() == 13 &&
                ownerPhoneNumber.Skip(4).All(x => Char.IsDigit(x)))
            {
                return true;
            }

            if (ownerPhoneNumber.StartsWith("0") &&
                ownerPhoneNumber.Length == 10 &&
                ownerPhoneNumber.Skip(1).All(x => Char.IsDigit(x)))
            {
                return true;
            }

            return false;
        }

        private static bool IsValidPassportSerialNumber(string serialNumber)
        {
            if (serialNumber.Take(7).Any(x => !Char.IsLetter(x)))
                return false;

            if (serialNumber.Skip(7).Take(3).Any(x => !Char.IsDigit(x)))
                return false;

            return true;
        }

        public static string ImportVets(PetClinicContext context, string xmlString)
        {
            var result = new StringBuilder();
            var vetsList = new List<Vet>();
            
            var serializer = new XmlSerializer(typeof(VetDto[]), new XmlRootAttribute("Vets"));
            VetDto[] vetDtos = (VetDto[])serializer.Deserialize(new StringReader(xmlString));

            foreach (VetDto vetDto in vetDtos)
            {
                if (!IsValid(vetDto))
                {
                    result.AppendLine(ERROR_MESSAGE);
                    continue;
                }

                if (!IsValidPhoneNumber(vetDto.PhoneNumber))
                {
                    result.AppendLine(ERROR_MESSAGE);
                    continue;
                }

                if (vetsList.Any(v => v.PhoneNumber == vetDto.PhoneNumber))
                {
                    result.AppendLine(ERROR_MESSAGE);
                    continue;
                }

                var vet = new Vet
                {
                    Name = vetDto.Name,
                    Profession = vetDto.Profession,
                    Age = vetDto.Age,
                    PhoneNumber = vetDto.PhoneNumber
                };

                vetsList.Add(vet);

                result.AppendLine($"Record {vet.Name} successfully imported.");
            }

            context.Vets.AddRange(vetsList);
            context.SaveChanges();

            return result.ToString();
        }

        public static string ImportProcedures(PetClinicContext context, string xmlString)
        {
            var result = new StringBuilder();

            var procedures = new List<Procedure>();
            var procedureAnimalAids = new List<ProcedureAnimalAid>();

            var serializer = new XmlSerializer(typeof(ProcedureDto[]), new XmlRootAttribute("Procedures"));
            ProcedureDto[] procedureDtos = (ProcedureDto[])serializer.Deserialize(new StringReader(xmlString));

            foreach (ProcedureDto procDto in procedureDtos)
            {
                bool areValidAnimalAids = true;

                if (!IsValid(procDto))
                {
                    result.AppendLine(ERROR_MESSAGE);
                    continue;
                }

                foreach (AnimalAidDto animalAidDto in procDto.AnimalAids)
                {
                    if (!IsValid(animalAidDto))
                    {
                        areValidAnimalAids = false;
                        break;
                    }
                }

                if (!areValidAnimalAids)
                {
                    result.AppendLine(ERROR_MESSAGE);
                    continue;
                }

                Vet vet = context.Vets.FirstOrDefault(v => v.Name == procDto.Vet);
                Animal animal = context.Animals.FirstOrDefault(a => a.PassportSerialNumber == procDto.Animal);
                if (vet == null || animal == null)
                {
                    result.AppendLine(ERROR_MESSAGE);
                    continue;
                }

                IEnumerable<string> animalAidNames = procDto.AnimalAids.Select(aa => aa.Name);
                var animalAids = new List<AnimalAid>();

                bool allAidsExist = true;
                foreach (string name in animalAidNames)
                {
                    AnimalAid animalAid = context.AnimalAids.FirstOrDefault(aa => aa.Name == name);

                    if (animalAid == null)
                    {
                        allAidsExist = false;
                        break;
                    }

                    animalAids.Add(animalAid);
                }

                bool haveDuplicateNames = animalAidNames.GroupBy(n => n).Any(g => g.Count() > 1);
                if (!allAidsExist || haveDuplicateNames)
                {
                    result.AppendLine(ERROR_MESSAGE);
                    continue;
                }
                
                DateTime dateTime = DateTime.Parse(procDto.DateTime);
                var procedure = new Procedure
                {
                    Animal = animal,
                    Vet = vet,
                    DateTime = dateTime,
                };
                procedures.Add(procedure);

                foreach (AnimalAid animalAid in animalAids)
                {
                    var procAnimalAid = new ProcedureAnimalAid
                    {
                        Procedure = procedure,
                        AnimalAid = animalAid
                    };
                    procedureAnimalAids.Add(procAnimalAid);
                }

                result.AppendLine("Record successfully imported.");
            }

            context.ProceduresAnimalAids.AddRange(procedureAnimalAids);
            context.Procedures.AddRange(procedures);
            context.SaveChanges();

            return result.ToString();
        }

        private static bool IsValid(object obj)
        {
            var validationContext = new System.ComponentModel.DataAnnotations.ValidationContext(obj);
            var validationResults = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(obj, validationContext, validationResults, true);
            return isValid;
        }
    }
}