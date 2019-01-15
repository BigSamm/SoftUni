namespace PetClinic.DataProcessor.Dtos.Import
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Xml.Serialization;

    [XmlType("Procedure")]
    public class ProcedureDto
    {
        [Required]
        [MinLength(3), MaxLength(40)]
        public string Vet { get; set; }

        [Required]
        [MinLength(3), MaxLength(20)]
        public string Animal { get; set; }

        [Required]
        public string DateTime { get; set; }

        [XmlArray("AnimalAids")]
        public AnimalAidDto[] AnimalAids { get; set; }
    }
}
