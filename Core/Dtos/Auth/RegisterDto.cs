﻿using be_artwork_sharing_platform.Core.Constancs;
using System.ComponentModel.DataAnnotations;

namespace be_artwork_sharing_platform.Core.Dtos.Auth
{
    public class RegisterDto
    {
        [Required]
        [StringLength(30)]
        public string FullName { get; set; }

        [Required(ErrorMessage = "UserName is required")]
        public string UserName { get; set; }
        [Required]
        [StringLength(30)]
        [RegularExpression(RegexConst.EMAIL, ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Password must be at least 8 characters and maximum 20 characters", MinimumLength = 8)]
        public string Password { get; set; }
        public string Address { get; set; } = string.Empty;
        [Required]
        [StringLength(15, ErrorMessage = "Phone number must be 0-15 characters")]
        [RegularExpression(RegexConst.PHONE_NUMBER, ErrorMessage = "Invalid phone number")]
        public string PhoneNo { get; set; } = string.Empty;
    }
}
