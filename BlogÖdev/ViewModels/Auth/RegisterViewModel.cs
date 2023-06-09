﻿using System.ComponentModel.DataAnnotations;

namespace BlogÖdev.ViewModels.Auth
{
    public class RegisterViewModel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [RegularExpression("[a-zA-Z0-9]{8}",ErrorMessage ="Your password should be at least 8 character")]
        public string Password { get; set; }

    }
}
