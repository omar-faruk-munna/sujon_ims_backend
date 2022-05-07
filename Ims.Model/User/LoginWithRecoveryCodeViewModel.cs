using System.ComponentModel.DataAnnotations;

namespace Ims.Model.User
{
    public class LoginWithRecoveryCodeViewModel
    {
        [Required]
        [DataType(DataType.Text)]
        public string RecoveryCode { get; set; }
    }
}
