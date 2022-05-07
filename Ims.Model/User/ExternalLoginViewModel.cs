﻿using System.ComponentModel.DataAnnotations;

namespace Ims.Model.User
{
    public class ExternalLoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
