using RestaurantBase.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBase.Abstract
{
    public interface IDishRepository
    {
        IEnumerable<Dish> Dish { get; }
        void Save(Dish dish);
        Dish Delete(int dishId);
    }
}
