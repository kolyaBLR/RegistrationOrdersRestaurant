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
    public partial class PriceListForm : Form
    {
        private ITableRepository repositoryTable = new TableRepository();
        private IPriceListRepository repositoryPriceList = new PriceListRepository();
        private IClientRepository repositoryClient = new ClientRepository();
        PriceList priceList = new PriceList();

        public PriceListForm(decimal price)
        {
            InitializeComponent();
            priceList.Price = price;
            PriceBox.Text = priceList.Price.ToString();
            foreach (var table in repositoryTable.Table)
            {
                if (!table.Booking)
                    TableBox.Items.Add(table.TableId);
            }
        }

        private void CloseBox_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddBox_Click(object sender, EventArgs e)
        {
            if (TableBox.Text == "")
                MessageBox.Show("Выберите столик.");
            else
            {
                Client client = repositoryClient.Client.FirstOrDefault(c => c.Name == ClientBox.Text);
                if (client != null)
                    priceList.ClientId = client.ClientId;
                else
                {
                    if (ClientBox.Text == "")
                        priceList.ClientId = 0;
                    else
                    {
                        repositoryClient.Save(new Client()
                        {
                            Name = ClientBox.Text
                        });
                    }
                    priceList.ClientId = repositoryClient.Client.FirstOrDefault(c => c.Name == ClientBox.Text).ClientId;
                }
                priceList.TableId = repositoryTable.Table.FirstOrDefault(t => t.TableId == Convert.ToInt32(TableBox.Text)).TableId;
                repositoryPriceList.Save(priceList);
                MessageBox.Show("Покупка успешно завершена.\nКлиент:" + ClientBox.Text + "\nСтолик:" + priceList.TableId + "\nЦена:" + priceList.Price);
                Application.Restart();
            }
        }

        private void TableBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Table table = repositoryTable.Table.FirstOrDefault(t => t.TableId == Convert.ToInt32(TableBox.Text));
            TableDescription.Text = table.Description + " кол-во мест:" + table.Count;
        }
    }
}