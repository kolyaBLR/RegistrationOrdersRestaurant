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
    public partial class AddTable : Form
    {
        private ITableRepository repositoryTable = new TableRepository();
        private int tableId;
        private Table table = new Table();

        public AddTable(int tableId = 0)
        {
            InitializeComponent();
            this.tableId = tableId;
            if (tableId != 0)
                table = repositoryTable.Table.FirstOrDefault(t => t.TableId == tableId);

            DescriptionBox.Text = table.Description;
            CountBox.Text = table.Count.ToString();
        }

        private void CountBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar >= 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (CountBox.Text == "")
                MessageBox.Show("Введите кол-во мест для столика.");
            else
            {
                if (tableId == 0)
                {
                    repositoryTable.Save(new Table()
                    {
                        Count = Convert.ToInt32(CountBox.Text),
                        Description = DescriptionBox.Text
                    });
                }
                else
                {
                    Table element = repositoryTable.Table.FirstOrDefault();
                    element.Count = Convert.ToInt32(CountBox.Text);
                    element.Description = DescriptionBox.Text;
                    repositoryTable.Save(element);
                }
                MessageBox.Show("Столик успешно добавлен.");
                Close();
            }
        }

        private void CloseBox_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
