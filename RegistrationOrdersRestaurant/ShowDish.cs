using RestaurantBase.Abstract;
using RestaurantBase.Concrete;
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
    public partial class ShowDish : Form
    {
        private IDishRepository repositoryDish = new DishRepository();
        private ICategoryDishRepository repositoryCategoryDish = new CategoryDishRepository();

        public ShowDish()
        {
            InitializeComponent();
            Dishes.ColumnCount = 6;
            Dishes.RowCount = 0;
            Dishes.Columns[0].HeaderText = "Id";
            Dishes.Columns[1].HeaderText = "Название";
            Dishes.Columns[2].HeaderText = "Категория";
            Dishes.Columns[3].HeaderText = "Цена";
            Dishes.Columns[4].HeaderText = "Удалить";
            GetDishes();
        }

        public void GetDishes()
        {
            Dishes.Rows.Clear();
            foreach (var dish in repositoryDish.Dish)
            {
                string categoryName;
                try
                {
                    categoryName = repositoryCategoryDish.Find(dish.CategoryDishId).Name;
                }
                catch
                {
                    categoryName = "Категория удалена";
                }
                Dishes.Rows.Add(dish.DishId, dish.Name, categoryName, dish.Price.ToString(), "x");
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddDish form = new AddDish();
            form.ShowDialog();
            GetDishes();
        }

        private void CloseBox_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Dishes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 4 && e.RowIndex != -1)
            {
                AddDish form = new AddDish(Convert.ToInt32(Dishes.Rows[e.RowIndex].Cells[0].Value));
                form.ShowDialog();
                GetDishes();
            }
        }

        private void Dishes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex != -1)
            {
                if (MessageBox.Show("Вы действительно желаете удалить данное блюдо?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    repositoryDish.Delete(Convert.ToInt32(Dishes.Rows[e.RowIndex].Cells[0].Value));
                    MessageBox.Show("Пользователь успешно удалён.");
                    GetDishes();
                }
            }
        }
    }
}
