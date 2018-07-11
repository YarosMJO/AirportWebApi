using System.ComponentModel.DataAnnotations;

namespace Shared.Dtos
{
    public class HouseDto
    {
        [Required]
        public int Id { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        [Required]
        [DataType(DataType.PostalCode)]
        public int ZipCode { get; set; }
    }
}
