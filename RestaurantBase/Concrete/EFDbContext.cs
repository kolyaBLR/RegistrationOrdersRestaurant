using RestaurantBase.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBase.Concrete
{
    public class EFDbContext : DbContext
    {
        public EFDbContext() : base("Restauran") { }
        public DbSet<Dish> Dish { get; set; }
        public DbSet<CategoryDish> CategoryDish { get; set; }
        public DbSet<Table> Table { get; set; }
        public DbSet<Client> Client { get; set; }
    }
}