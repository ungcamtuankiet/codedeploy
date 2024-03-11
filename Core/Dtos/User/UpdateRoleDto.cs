﻿using System.ComponentModel.DataAnnotations;

namespace be_artwork_sharing_platform.Core.Dtos.User
{
    public class UpdateRoleDto
    {
        [Required(ErrorMessage = "UserName is required")]
        public string UserName { get; set; }

        public RoleType NewRole { get; set; }
    }

    public enum RoleType
    {
        CREATOR,
        CUSTOMER
    }
}
