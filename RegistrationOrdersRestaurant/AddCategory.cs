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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationOrdersRestaurant
{
    public partial class AddCategory : Form
    {
        private ICategoryDishRepository repositroyCategoryDish = new CategoryDishRepository();
        private int categoryId;

        public AddCategory(int categoryId = 0)
        {
            this.categoryId = categoryId;
            InitializeComponent();
        }

        private void CloseBox_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (NameBox.Text == "")
                MessageBox.Show("Введите название категории.");
            else
            {
                if (categoryId == 0)
                {
                    repositroyCategoryDish.Save(new CategoryDish()
                    {
                        Name = NameBox.Text
                    });
                }
                else
                {
                    CategoryDish element = repositroyCategoryDish.CategoryDish.FirstOrDefault(c => c.CategoryDishId == categoryId);
                    element.Name = NameBox.Text;
                    repositroyCategoryDish.Save(element);
                }
                MessageBox.Show("Категория успешно добавлена.");
                Close();
            }
        }
    }
}
