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
    public partial class ShowPrice : Form
    {

        private IPriceListRepository repositoryPriceList = new PriceListRepository();

        public ShowPrice()
        {
            InitializeComponent();
            PriceGrid.ColumnCount = 4;
            PriceGrid.Columns[0].HeaderText = "Id";
            PriceGrid.Columns[1].HeaderText = "Id покупателя";
            PriceGrid.Columns[2].HeaderText = "Номер столика";
            PriceGrid.Columns[3].HeaderText = "Цена";
            GetPrice();
        }

        public void GetPrice()
        {
            PriceGrid.Rows.Clear();
            foreach (var priceList in repositoryPriceList.PriceList)
            {
                PriceGrid.Rows.Add(priceList.PriceListId, priceList.ClientId, priceList.TableId, priceList.Price);
            }
        }
    }
}
