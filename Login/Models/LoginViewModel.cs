using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Login.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Username or Email is required")]
        [MaxLength(50, ErrorMessage = "Max 20 characters allowed")]
        /*[RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
         @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
         @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Enter a valid email")]*/
        [DisplayName("Username or Email")]
        public String UserNameOrEmail { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Max 20 and min 5 characters allowed")]
        [DataType(DataType.Password)]
        public String Password { get; set; }
    }
}
