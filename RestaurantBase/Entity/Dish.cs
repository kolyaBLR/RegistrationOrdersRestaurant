using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBase.Entity
{
    public class Dish
    {
        [Column("Id")]
        public int DishId { get; set; }

        [Required]
        //[MaxLength(50, ErrorMessage = "Длинна названия не более чем 50 символов.")]
        public string Name { get; set; }

        [Required]
        //[MaxLength(200, ErrorMessage = "Длинна названия не более чем 200 символов.")]
        public string Description { get; set; }

        [Required]
        public int CategoryDishId { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}