using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBase.Entity
{
    public class CategoryDish
    {
        [Column("Id")]
        public int CategoryDishId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
