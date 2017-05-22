using RestaurantBase.Concrete;
using RestaurantBase.Abstract;
using RestaurantBase.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationOrdersRestaurant
{
    public partial class Menu : Form
    {
        private IDishRepository repositoryDish;

        public Menu()
        {
            InitializeComponent();
            repositoryDish = new DishRepository();
            repositoryDish.Save(
                new Dish()
                {
                    Name = "Салат",
                    CategoryDishId = 1,
                    Price = 555
                    //DishId = 1
                }
            );
        }
    }
}
