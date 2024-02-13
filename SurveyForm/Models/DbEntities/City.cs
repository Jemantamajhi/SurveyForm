using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SurveyForm.Models.DbEntities
{
    public class City
    {
        [Key] // Set Id as primary key
        public int Id { get; set; }

        [Required] // Ensure Name is not null
        public string Name { get; set; }

        [Required] // Ensure StateId is not null
        public int StateId { get; set; }

        [ForeignKey("StateId")] // Define StateId as foreign key
        public State State { get; set; }
    }
}
