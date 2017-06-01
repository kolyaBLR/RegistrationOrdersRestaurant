using RestaurantBase.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBase.Abstract
{
    public interface ICategoryDishRepository
    {
        IEnumerable<CategoryDish> CategoryDish { get; }
        void Save(CategoryDish CategoryDish);
        CategoryDish Delete(int CategoryDishId);
        CategoryDish Find(int CategoryDishId);
    }
}
