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
            CategoryListDish();
        }

        private void CategoryListDish()
        {
            TableLayoutPanel categoryList = new TableLayoutPanel()
            {
                Dock = DockStyle.Left,
                ColumnCount = 1,
                RowCount = 0,
                Width = 100,
                AutoScroll = true
            };
            FormComponents components = new FormComponents();
            Button categoryButton = new Button()
            {
                Dock = DockStyle.Top,
                Text = "Все",
                Margin = new Padding(0),
                Name = "0",
            };
            categoryButton.Click += CategoryButton_Click;
            categoryList.Controls.Add(categoryButton);
            foreach (var category in repositoryCategoryDish.CategoryDish)
            {
                categoryButton = components.CategoryButton(category);
                categoryButton.Click += CategoryButton_Click;
                categoryList.Controls.Add(categoryButton);
            }

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

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            Button category = sender as Button;
            panelDish.Controls.Clear();
            countLabelDish.Clear();
            ListDish(Convert.ToInt32(category.Name));
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Button add = sender as Button;
            foreach (var item in countLabelDish)
            {
                if (item.Key == Convert.ToInt32(add.Name))
                {
                    int sum = Convert.ToInt32(item.Value.Text);
                    sum++;
                    item.Value.Text = sum.ToString();
                }
            }

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Button delete = sender as Button;
            foreach (var item in countLabelDish)
            {
                if (item.Key == Convert.ToInt32(delete.Name))
                {
                    int sum = Convert.ToInt32(item.Value.Text);
                    sum--;
                    if (sum >= 0)
                        item.Value.Text = sum.ToString();
                    else
                        sum = 0;
                }
            }
        }
    }
}