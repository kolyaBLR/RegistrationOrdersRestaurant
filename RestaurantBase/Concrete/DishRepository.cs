using RestaurantBase.Abstract;
using RestaurantBase.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBase.Concrete
{
    public class DishRepository : IDishRepository
    {
        EFDbContext Context = new EFDbContext();

        public IEnumerable<Dish> Dish
        {
            get { return Context.Dish; }
        }

        public void Save(Dish dish)
        {
            if (dish.DishId == 0)
                Context.Dish.Add(dish);
            else
            {
                Dish element = Context.Dish.Find(dish.DishId);
                element.Name = dish.Name;
                element.CategoryDishId = dish.CategoryDishId;
                element.Price = dish.Price;
            }
            Context.SaveChanges();
        }

        public Dish Delete(int dishId)
        {
            Dish element = Context.Dish.Find(dishId);
            Context.Dish.Remove(element);
            Context.SaveChanges();
            return element;
        }
    }
}
