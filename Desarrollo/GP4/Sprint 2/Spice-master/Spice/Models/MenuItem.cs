using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Spice.Models
{
    public class MenuItem
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo es requerido")]
        [Display(Name = "Plato")]
        public string Name { get; set; }

        [Display(Name = "Descripcion")]
        public string Description { get; set; }

        public string Spicyness { get; set; }
        public enum ESpicy { NA=0,NotSpicy=1, Spicy=2, VerySpicy=3}

        [Display(Name = "Imagen")]
        public string Image { get; set; }

        [Display(Name="Categoria")]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        [Display(Name = "Sub categoria")]
        public int SubCategoryId { get; set; }

        [ForeignKey("SubCategoryId")]
        public virtual SubCategory SubCategory { get; set; }


        [Display(Name = "Precio")]
        public double Price { get; set; }


    }
}
