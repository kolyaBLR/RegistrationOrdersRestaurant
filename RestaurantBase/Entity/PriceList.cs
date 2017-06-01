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
        public int PriceListId { get; set; }

        [Required]
        public int ClientId { get; set; }

        [Required]
        public int TableId { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}