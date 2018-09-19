using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digi24.ViewModels
{
    public class UserRegistrationViewModel
    {
        [Required]
        public string FullName { get; set; }
        [Required]
        public string MobileNumber { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string AppSecret { get; set; }
    }
}
