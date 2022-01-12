﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Spice.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Display(Name="Categoria")]
        [Required(ErrorMessage =("El nombre es necesario"))]
        public string Name { get; set; }
    }
}
