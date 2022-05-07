﻿using System.ComponentModel.DataAnnotations;

namespace Ims.Model.User
{
    public class LoginWith2faViewModel
    {
        [Required]
        [StringLength(7, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Text)]
        public string TwoFactorCode { get; set; }

        public bool RememberMachine { get; set; }

        public bool RememberMe { get; set; }
    }
}
