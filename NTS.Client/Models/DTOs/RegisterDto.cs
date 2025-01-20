﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NTS.Client.Models.DTOs
{
    public class RegisterDto
    {
        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required, PasswordPropertyText]
        public string Password { get; set; } = string.Empty;

        [Required, Compare("Password")]
        public string ConfirmPassword { get; set; } = string.Empty;

        [Required]
        public string FullName { get; set; } = string.Empty;

        [Required, Phone]
        public int PhoneNumber { get; set; }

        [Required, EmailAddress]
        public string RecoveryEmail { get; set; } = string.Empty;

        [Required]
        public DateTime? DateJoined { get; set; }
    }
}
