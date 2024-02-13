using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SurveyForm.Models.DbEntities
{
    [Table("state")] // Specify the table name here with small 's'
    public class State
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string StateName { get; set; }
        public List<City>Cities { get; set; }
    }
}
