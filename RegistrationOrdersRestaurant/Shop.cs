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
    public partial class Shop : Form
    {
        private IDishRepository repositoryDish = new DishRepository();

        Dictionary<int, int> countDish;
        private decimal fullPrice;

        public Shop(Dictionary<int, int> countDish)
        {
            this.countDish = countDish;
            InitializeComponent();
            PriceGrid.ColumnCount = 4;
            PriceGrid.Columns[0].HeaderText = "Название";
            PriceGrid.Columns[1].HeaderText = "Цена рублей за одно блюдо";
            PriceGrid.Columns[2].HeaderText = "Кол-во";
            PriceGrid.Columns[3].HeaderText = "Итоговая цена рублей блюда";
            GePrice();
        }

        public void GePrice()
        {
            PriceGrid.Rows.Clear();
            decimal fullPrice = 0;
            foreach (var dish in countDish)
            {
                Dish element = repositoryDish.Dish.FirstOrDefault(d => d.DishId == Convert.ToInt32(dish.Key));
                fullPrice += dish.Value * element.Price;
                PriceGrid.Rows.Add(element.Name, element.Price.ToString(), dish.Value.ToString(), dish.Value * element.Price);
            }
            this.fullPrice = fullPrice;
            PriceGrid.Rows.Add("", "", "Общая стоимость:", fullPrice);
        }

        private void CloseBox_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            PriceListForm form = new PriceListForm(fullPrice);
            form.ShowDialog();
        }
    }
}
