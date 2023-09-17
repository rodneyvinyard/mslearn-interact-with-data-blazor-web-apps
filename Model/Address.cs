using System.ComponentModel.DataAnnotations;
namespace BlazingPizza
{
    public class Address
    {
        public int Id { get; set; }

        [Required, MinLength(3, ErrorMessage = "Please enter a Name with at least 3 characters."), MaxLength(100, ErrorMessage = "Please enter a Name less than 101 characters.")]
        public string Name { get; set; }

        [Required, MinLength(5, ErrorMessage = "Please enter an Address with at least 5 characters."), MaxLength(100, ErrorMessage = "Please enter an Address less than 101 characters.")]
        public string Line1 { get; set; }

        [MaxLength(100)]
        public string Line2 { get; set; }

        [Required, MinLength(3, ErrorMessage = "Please enter a City with at least 3 characters."), MaxLength(50, ErrorMessage = "Please enter a City less than 51 characters.")]
        public string City { get; set; }

        [Required, MinLength(3, ErrorMessage = "Please enter a Region with at least 3 characters."), MaxLength(20, ErrorMessage = "Please enter a Region less than 21 characters.")]
        public string Region { get; set; }

        [Required, RegularExpression(@"^([0-9]{5})$", ErrorMessage = "Please enter a valid, 5 digit Postal Code.")]
        public string PostalCode { get; set; }
    }
}
