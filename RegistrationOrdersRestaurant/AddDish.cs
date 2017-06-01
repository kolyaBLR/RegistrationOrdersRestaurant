using RestaurantBase.Abstract;
using RestaurantBase.Concrete;
using RestaurantBase.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationOrdersRestaurant
{
    public partial class AddDish : Form
    {
        private IDishRepository repositoryDish;
        private ICategoryDishRepository repositoryCategoryDish;
        private Dish dish = new Dish();

        public AddDish(int dishId = 0)
        {
            InitializeComponent();
            repositoryDish = new DishRepository();
            repositoryCategoryDish = new CategoryDishRepository();

            if (dishId != 0)
                 dish = repositoryDish.Dish.FirstOrDefault(d => d.DishId == dishId);

            NameBox.Text = dish.Name;
            DescriptionBox.Text = dish.Description;
            PriceBox.Text = dish.Price.ToString();

            foreach (var category in repositoryCategoryDish.CategoryDish)
            {
                CategoryBox.Items.Add(category.Name);
                if (category.CategoryDishId == dish.CategoryDishId)
                    CategoryBox.Text = category.Name;
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string message = "";
            if (NameBox.Text.Length > 50)
                message += "Название не должно быть длинне чем 50 символов.\n";
            if (NameBox.Text.Length == 0)
                message += "Название не должно быть пустым.\n";
            if (DescriptionBox.Text.Length > 200)
                message += "Описание не должно быть длинне чем 200 символов.\n";
            if (DescriptionBox.Text.Length == 0)
                message += "Описание не должно быть пустым.\n";
            if (CategoryBox.Text == "" || CategoryBox.Text == "0")
                message += "Выберите категорию.\n";
            try
            {
                Convert.ToDecimal(PriceBox.Text);
            }
            catch
            {
                message += "Введите корректную цену.\n";
            }  

            if (message == "")
            {
                dish.Name = NameBox.Text;
                dish.Description = DescriptionBox.Text;
                dish.Price = Convert.ToDecimal(PriceBox.Text);
                foreach (var category in repositoryCategoryDish.CategoryDish)
                    if (category.Name == CategoryBox.Text)
                        dish.CategoryDishId = category.CategoryDishId;
                repositoryDish.Save(dish);
                MessageBox.Show("Блюдо успешно добавлено.");
                Close();
            }
            else
                MessageBox.Show(message, "Ошибка записи");
        }

        private void CloseBox_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PriceBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar >= 59) && e.KeyChar != 44 && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
