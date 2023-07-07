﻿using System.ComponentModel.DataAnnotations;

namespace Practical17.ViewModel
{
    public class LoginUser
    {
        [Key]
        [Required]
        [DataType(DataType.EmailAddress)]
        public required string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public required string Password { get; set; }
    }
}
