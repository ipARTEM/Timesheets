using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Timesheets.API.Validations.Models
{
   // [Table("User", Schema="Test")]
    public class User
    {
        
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "имя")]
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string MiddleName { get; set; }

        [Required]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Некорректный адрес")]
        public string Email { get; set; }

        [StringLength(50, MinimumLength = 3, ErrorMessage = "Название компании должно быть от 3 до 50 символов")]
        public string Company { get; set; }

        [Required]
        public int Age { get; set; }
        public bool IsDeleted { get; set; } = false;

        [OneOf("I","you","she")]
        public string? Comment { get; set; }
    }
}
