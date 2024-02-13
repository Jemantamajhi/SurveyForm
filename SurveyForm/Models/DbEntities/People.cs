using System.ComponentModel.DataAnnotations;

namespace SurveyForm.Models.DbEntities
{
    public class People
    {
        [Key] // Set Id as primary key
        public int Id { get; set; }

        [Required] // Ensure Name is not null
        [RegularExpression(@"^[a-zA-Z0-9_]*$", ErrorMessage = "Nmae can only contain letters.")]
        public string? Name { get; set; }

        [Required] // Ensure ContactNo is not null
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Contact number must be 10 digits.")]
        public string? ContactNo { get; set; }

        [Required] // Ensure EmailId is not null
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string? EmailId { get; set; }

        [Required] // Ensure HouseNo is not null
        public string? HouseNo { get; set; }

        [Required] // Ensure Area is not null
        public string? Area { get; set; }

        [Required] // Ensure State is not null
        public string State { get; set; }
        [Required]
        public string City { get; set; }

       

      
      
    }
}
