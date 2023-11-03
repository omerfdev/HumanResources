﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.DTOs.AppUserDTO
{
    public class AppUserLoginDTO
    {
        [Required]
        public string Email { get; set;}
        [Required]
        public string Password { get; set;}
    }
}
