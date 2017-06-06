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
        private IDishRepository repositoryDish = new DishRepository();
        private ICategoryDishRepository repositoryCategoryDish = new CategoryDishRepository();
        private Dictionary<int, int> countDish = new Dictionary<int, int>();
        private DataGridView dishGrid = new DataGridView();
        Panel panel = new Panel()
        {
            Dock = DockStyle.Fill
        };

        public Menu()
        {
            InitializeComponent();
            Controls.Add(panel);
            dishGrid.AllowUserToAddRows = false;
            dishGrid.RowCount = 0;
            dishGrid.ColumnCount = 6;
            dishGrid.Columns[0].HeaderText = "Id";
            dishGrid.Columns[1].HeaderText = "Название";
            dishGrid.Columns[2].HeaderText = "Описание";
            dishGrid.Columns[3].HeaderText = "Цена";
            dishGrid.Columns[4].HeaderText = "Кол-во";
            dishGrid.Columns[5].HeaderText = "Итоговая цена";
            dishGrid.Columns[0].ReadOnly = true;
            dishGrid.Columns[1].ReadOnly = true;
            dishGrid.Columns[2].ReadOnly = true;
            dishGrid.Columns[3].ReadOnly = true;
            dishGrid.Columns[5].ReadOnly = true;
            dishGrid.Dock = DockStyle.Fill;
            dishGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dishGrid.CellEndEdit += DishGrid_CellEndEdit;
            ListDish();
            LeftMenu();
        }

        public void ListDish(int categoryId = 0)
        {
            dishGrid.RowCount = 0;

            IEnumerable<Dish> dishes = categoryId == 0 ? repositoryDish.Dish :
                repositoryDish.Dish.Where(dish => dish.CategoryDishId == categoryId);

            foreach (var dish in dishes)
                dishGrid.Rows.Add(dish.DishId, dish.Name, dish.Description, dish.Price, "0", "0,00");
            dishGrid.Rows.Add("", "", "", "Итог:", "0", "0,00");
            panel.Controls.Add(dishGrid);
        }

        private void LeftMenu()
        {
            FormComponents components = new FormComponents();
            TableLayoutPanel categoryList = components.CategoryList();

            categoryList.Controls.Add(components.LabelText("Меню"));

            Button shop = components.MenuButton("Купить");
            shop.Click += Shop_Click;
            categoryList.Controls.Add(shop);

            Button claer = components.MenuButton("Очистить");
            claer.Click += Clear_Click;
            categoryList.Controls.Add(claer);

            categoryList.Controls.Add(components.LabelText(""));
            categoryList.Controls.Add(components.LabelText("Категории"));

            Button categoryButton = components.CategoryButton(new CategoryDish() { CategoryDishId = 0, Name = "Все" });
            categoryButton.Click += CategoryButton_Click;
            categoryList.Controls.Add(categoryButton);
            foreach (var category in repositoryCategoryDish.CategoryDish)
            {
                categoryButton = components.CategoryButton(category);
                categoryButton.Click += CategoryButton_Click;
                categoryList.Controls.Add(categoryButton);
            }

            categoryList.Controls.Add(components.LabelText(""));
            categoryList.Controls.Add(components.LabelText("Админка"));

            Button dish = components.MenuButton("Блюда");
            dish.Click += Dish_Click;
            categoryList.Controls.Add(dish);

            Button table = components.MenuButton("Столики");
            table.Click += Table_Click;
            categoryList.Controls.Add(table);

            Button addCategory = components.MenuButton("Категории");
            addCategory.Click += AddCategory_Click;
            categoryList.Controls.Add(addCategory);

            Controls.Add(categoryList);
        }

        public void AddCountDish(int key, int sum)
        {
            try
            {
                countDish.Add(key, sum);
            }
            catch
            {
                countDish.Remove(key);
                countDish.Add(key, sum);
            }
        }

        public void OpenCountDish()
        {
            decimal fullPrice = 0;
            int count = 0;
            foreach (var dish in countDish)
            {
                for (int i = 0; i < dishGrid.RowCount - 1; i++)
                {
                    if (dish.Key == Convert.ToInt32(dishGrid.Rows[i].Cells[0].Value))
                    {
                        dishGrid.Rows[i].Cells[4].Value = dish.Value;
                        decimal price = Convert.ToDecimal(dishGrid.Rows[i].Cells[3].Value);
                        fullPrice += price;
                        count += dish.Value;
                        dishGrid.Rows[i].Cells[5].Value = dish.Value * price;
                    }
                }
            }
            dishGrid.Rows[dishGrid.RowCount - 1].Cells[4].Value = count;
            dishGrid.Rows[dishGrid.RowCount - 1].Cells[5].Value = fullPrice * count;
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            Button category = sender as Button;
            ListDish(Convert.ToInt32(category.Name));
            OpenCountDish();
        }

        private void Shop_Click(object sender, EventArgs e)
        {
            if (countDish.Count != 0)
            {
                Shop form = new Shop(countDish);
                form.ShowDialog();
            }
            else
                MessageBox.Show("Карзина блюд пуста.");
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            countDish = new Dictionary<int, int>();
            for (int i = 0; i < dishGrid.RowCount; i++)
            {
                dishGrid.Rows[i].Cells[4].Value = "0";
                dishGrid.Rows[i].Cells[5].Value = "0,00";
            }
        }

        private void Dish_Click(object sender, EventArgs e)
        {
            ShowDish form = new ShowDish();
            form.ShowDialog();
            ListDish();
            OpenCountDish();
        }

        private void Table_Click(object sender, EventArgs e)
        {
            ShowTable form = new ShowTable();
            form.ShowDialog();
            ListDish();
            OpenCountDish();
        }

        private void AddCategory_Click(object sender, EventArgs e)
        {
            ShowCategory form = new ShowCategory();
            form.ShowDialog();
            ListDish();
            OpenCountDish();
        }

        private void DishGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Int32.TryParse(dishGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out int count);
            dishGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Math.Abs(count);
            decimal price = Convert.ToDecimal(dishGrid.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value);
            dishGrid.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value = count * price;
            int key = Convert.ToInt32(dishGrid.Rows[e.RowIndex].Cells[0].Value);
            AddCountDish(key, count);
            price = 0;
            count = 0;
            for (int i = 0; i < dishGrid.RowCount - 1; i++)
            {
                price += Convert.ToDecimal(dishGrid.Rows[i].Cells[e.ColumnIndex + 1].Value);
                count += Convert.ToInt32(dishGrid.Rows[i].Cells[e.ColumnIndex].Value);
            }
            dishGrid.Rows[dishGrid.RowCount - 1].Cells[e.ColumnIndex + 1].Value = price;
            dishGrid.Rows[dishGrid.RowCount - 1].Cells[e.ColumnIndex].Value = count;
        }
    }
}