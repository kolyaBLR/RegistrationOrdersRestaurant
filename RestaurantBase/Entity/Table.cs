using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBase.Entity
{
    public class Table
    {
        [Column("Id")]
        public int TableId { get; set; }

        public string Description { get; set; }

        [Required]
        public int Count { get; set; }

        [Required]
        public int Number { get; set; }
    }
}