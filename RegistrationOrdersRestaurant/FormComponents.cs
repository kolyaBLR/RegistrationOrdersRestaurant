using RestaurantBase.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationOrdersRestaurant
{
    public class FormComponents
    {
        public Panel Panel()
        {
            return new Panel()
            {
                Dock = DockStyle.Fill,
                BorderStyle = BorderStyle.FixedSingle,
                Height = 150
            };
        }

        public Label Text(Dish dish)
        {
            return new Label()
            {
                Dock = DockStyle.Fill,
                Text = dish.Name + "\n" + dish.Description + "\n" + dish.Price.ToString(),
                Font = new Font("Time New Roman", 12, FontStyle.Regular),
                Padding = new Padding(10),
                BorderStyle = BorderStyle.FixedSingle,
            };
        }

        public Panel PanelCount(Dish dish)
        {
            return new Panel()
            {
                Dock = DockStyle.Right,
                BorderStyle = BorderStyle.FixedSingle,
                Width = 38,
                Name = dish.DishId.ToString()
            };
        }

        public Button Add(Dish dish)
        {
            return new Button()
            {
                Dock = DockStyle.Top,
                Width = 50,
                Name = dish.DishId.ToString(),
                Text = "+",
                Height = 35,
                Font = new Font("Time New Roman", 12, FontStyle.Regular)
            };
        }

        public Label Count(Dish dish)
        {
            return new Label()
            {
                Dock = DockStyle.Fill,
                Name = dish.DishId.ToString(),
                Text = "0",
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Time New Roman", 12, FontStyle.Regular)
            };
        }

        public Button Delete(Dish dish)
        {
            return new Button()
            {
                Dock = DockStyle.Bottom,
                Width = 50,
                Name = dish.DishId.ToString(),
                Text = "-",
                Height = 35,
                Font = new Font("Time New Roman", 12, FontStyle.Regular)
            };
        }

        public PictureBox Image(Dish dish)
        {
            return new PictureBox()
            {
                Dock = DockStyle.Right,
                Image = new Bitmap("C:/Users/bk97w/Desktop/images.jpg"),
                Height = 150,
                Width = 150,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Padding = new Padding(5)
            };
        }

        public Button CategoryButton(CategoryDish category)
        {
            return new Button()
            {
                Dock = DockStyle.Top,
                Text = category.Name,
                Margin = new Padding(0),
                Name = category.CategoryDishId.ToString()
            };
        }

        public Button MenuButton(string text)
        {
            return new Button()
            {
                Dock = DockStyle.Top,
                Text = text,
                Margin = new Padding(0)
            };
        }

        public Label LabelText(string text)
        {
            return new Label()
            {
                Dock = DockStyle.Top,
                Text = text,
                TextAlign = ContentAlignment.MiddleCenter
            };
        }

        public TableLayoutPanel CategoryList()
        {
            return new TableLayoutPanel()
            {
                Dock = DockStyle.Left,
                ColumnCount = 1,
                RowCount = 0,
                Width = 110,
                AutoScroll = true
            };
        }
    }
}