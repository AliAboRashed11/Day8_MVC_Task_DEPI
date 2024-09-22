using System.ComponentModel.DataAnnotations;

namespace Day6task.Models
{
    public class Login
    {
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.Password)]

        public int Password { get; set; }

    }
}
