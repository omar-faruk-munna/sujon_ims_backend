using System.ComponentModel.DataAnnotations;

namespace Ims.Model.User
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
