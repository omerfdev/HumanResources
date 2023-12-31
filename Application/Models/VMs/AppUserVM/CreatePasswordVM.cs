﻿using Application.ExtensionValidations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.VMs.AppUserDTO
{
    public class CreatePasswordVM
    {
        public int UserId { get; set; }
        [Required]
        [PasswordValidator]
        public string Password { get; set; }
        [Required]
        [PasswordValidator]
        public string RePassword { get; set; }
        public string Token { get; set; }
    }
}
