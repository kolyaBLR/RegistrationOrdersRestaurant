using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBase.Entity
{
    public class PriceList
    {
        [Column("Id")]
        public int PriceListId;

        [Required]
        public int ClientId { get; set; }

        [NotMapped]
        public Client Client { get; set; }

        [Required]
        public int TableId { get; set; }

        [NotMapped]
        public Table Table { get; set; }

        [NotMapped]
        public Dish Dishes { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}
