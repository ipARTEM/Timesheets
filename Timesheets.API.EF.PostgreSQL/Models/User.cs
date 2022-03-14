using System.ComponentModel.DataAnnotations.Schema;

namespace Timesheets.API.EF.PostgreSQL.Models
{
    [Table("User", Schema="Test")]
    public class User
    {
        
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string MiddleName { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public int Age { get; set; }
        public bool IsDeleted { get; set; }
        public object? Comment { get; internal set; }
    }
}
