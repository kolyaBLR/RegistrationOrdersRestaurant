using RestaurantBase.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantBase.Entity;

namespace RestaurantBase.Concrete
{
    public class CategoryDishRepository : ICategoryDishRepository
    {
        private EFDbContext Context = new EFDbContext();

        public IEnumerable<CategoryDish> CategoryDish
        {
            get { return Context.CategoryDish; }
        }

        public CategoryDish Delete(int CategoryDishId)
        {
            CategoryDish element = Context.CategoryDish.Find(CategoryDishId);
            Context.CategoryDish.Remove(element);
            Context.SaveChanges();
            return element;
        }

        public CategoryDish Find(int CategoryDishId)
        {
            return Context.CategoryDish.Find(CategoryDishId);
        }

        public void Save(CategoryDish CategoryDish)
        {
            if (CategoryDish.CategoryDishId == 0)
                Context.CategoryDish.Add(CategoryDish);
            else
            {
                CategoryDish element = Context.CategoryDish.Find(CategoryDish.CategoryDishId);
                element.Name = CategoryDish.Name;
            }
            Context.SaveChanges();
        }
    }
}
