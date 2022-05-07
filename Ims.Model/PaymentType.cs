﻿using System.ComponentModel.DataAnnotations;

namespace Ims.Model
{
    public class PaymentType
    {
        public int PaymentTypeId { get; set; }
        [Required]
        public string PaymentTypeName { get; set; }
        public string Description { get; set; }
    }
}
