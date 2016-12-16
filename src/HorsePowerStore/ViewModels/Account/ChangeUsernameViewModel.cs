using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace HorsePowerStore.ViewModels.Account
{
    public class ChangeUsernameViewModel : IValidatableObject
    {
        [Required]
        [DataType(DataType.Text)]
        public string Email { get; set; } // OLD USERNAME, TYPICALLY THEIR EMAIL ON FIRST RESET

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [MinLength(6, ErrorMessage = "Username must be over 5 characters")]
        [MaxLength(19, ErrorMessage = "Username must be under 20 characters")]
        public string Username { get; set; } 

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext) // modelState validation
        {
            var results = new List<ValidationResult>();
            // usernames can be alpha-numeric, contain underscores (_), and have periods (.)
            var regex = Regex.IsMatch(Username, @"^[a-zA-Z0-9_.]+$"); 

            if (!regex)
            {
                results.Add(new ValidationResult("Username Invalid", new string[] { "Username" }));
            }

            return results;
        }
    }
}
