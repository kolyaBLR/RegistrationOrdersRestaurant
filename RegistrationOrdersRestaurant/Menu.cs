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
        private ICategoryDishRepository repositoryCategoryDish;
        private Dictionary<int, Label> countLabelDish;
        private TableLayoutPanel panelDish;
        private Dictionary<int, int> countDish;

        public Menu()
        {
            countDish = new Dictionary<int, int>();
            countLabelDish = new Dictionary<int, Label>();
            repositoryDish = new DishRepository();
            repositoryCategoryDish = new CategoryDishRepository();
            InitializeComponent();
            panelDish = new TableLayoutPanel()
            {
                ColumnCount = 1,
                RowCount = 0,
                Dock = DockStyle.Fill,
                AutoScroll = true
            };
            Controls.Add(panelDish);
            ListDish();
            LeftMenu();
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
            categoryList.Controls.Add(components.LabelText("Администрирование"));

            Button dish = components.MenuButton("Блюда");
            dish.Click += Dish_Click;
            categoryList.Controls.Add(dish);

            Button table = components.MenuButton("Столики");
            table.Click += Table_Click;
            categoryList.Controls.Add(table);

            Controls.Add(categoryList);
        }

        public void ListDish(int categoryId = 0)
        {
            IEnumerable<Dish> dishes = categoryId == 0 ? repositoryDish.Dish :
                repositoryDish.Dish.Where(dish => dish.CategoryDishId == categoryId);
            panelDish.Height = dishes.Count() * 100 + 85;

            foreach (var dish in dishes)
            {
                FormComponents components = new FormComponents();
                Panel panel = components.Panel();
                Panel panelCount = components.PanelCount(dish);

                Button add = components.Add(dish);
                add.Click += Add_Click;
                Button delete = components.Delete(dish);
                delete.Click += Delete_Click;
                panelCount.Controls.Add(add);
                panelCount.Controls.Add(delete);

                Label countLabel = components.Count(dish);
                panelCount.Controls.Add(countLabel);
                countLabelDish.Add(dish.DishId, countLabel);

                panel.Controls.Add(components.Text(dish));
                panel.Controls.Add(panelCount);
                panel.Controls.Add(components.Image(dish));
                panelDish.Controls.Add(panel);
            }
            panelDish.Controls.Add(new Panel());
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
            foreach (var dish in countDish)
            {
                foreach (var control in countLabelDish)
                {
                    if (dish.Key == control.Key)
                    {
                        control.Value.Text = dish.Value.ToString();
                    }
                }
            }
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            Button category = sender as Button;
            panelDish.Controls.Clear();
            countLabelDish.Clear();
            ListDish(Convert.ToInt32(category.Name));
            OpenCountDish();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Button add = sender as Button;
            int sum = 0;
            int key = Convert.ToInt32(add.Name);
            foreach (var labelDish in countLabelDish)
            {
                if (labelDish.Key == key)
                {
                    sum = Convert.ToInt32(labelDish.Value.Text);
                    sum++;
                    labelDish.Value.Text = sum.ToString();
                }
            }
            AddCountDish(key, sum);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Button delete = sender as Button;
            int sum = 0;
            int key = Convert.ToInt32(delete.Name);
            foreach (var item in countLabelDish)
            {
                if (item.Key == key)
                {
                    sum = Convert.ToInt32(item.Value.Text);
                    sum--;
                    if (sum >= 0)
                        item.Value.Text = sum.ToString();
                    else
                        sum = 0;
                }
            }
            AddCountDish(key, sum);
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
            foreach (var item in countLabelDish.Values)
                item.Text = "0";
        }

        private void Dish_Click(object sender, EventArgs e)
        {
            ShowDish form = new ShowDish();
            form.ShowDialog();
        }

        private void Table_Click(object sender, EventArgs e)
        {
            Table form = new Table();
            form.ShowDialog();
        }
    }
}