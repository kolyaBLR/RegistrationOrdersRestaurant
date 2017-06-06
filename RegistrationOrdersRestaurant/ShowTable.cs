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
    public partial class ShowTable : Form
    {
        private ITableRepository repositoryTable = new TableRepository();

        public ShowTable()
        {
            InitializeComponent();
            TableGrid.ColumnCount = 5;
            TableGrid.Columns[0].HeaderText = "Id";
            TableGrid.Columns[1].HeaderText = "Описание";
            TableGrid.Columns[2].HeaderText = "Кол-во мест";
            TableGrid.Columns[3].HeaderText = "Бронь";
            TableGrid.Columns[4].HeaderText = "Удалить";
            GetTables();
        }

        public void GetTables()
        {
            TableGrid.Rows.Clear();
            foreach (var table in repositoryTable.Table)
            {
                TableGrid.Rows.Add(table.TableId, table.Description, table.Count, table.Booking, "Удалить");
            }
        }

        private void CloseBox_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveBox_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < TableGrid.RowCount; i++)
            {
                int id = Convert.ToInt32(TableGrid.Rows[i].Cells[0].Value);
                bool status = TableGrid.Rows[i].Cells[3].Selected;
                repositoryTable.ChangeBooking(id, status);
            }
            Close();
        }

        private void AddBox_Click(object sender, EventArgs e)
        {
            AddTable form = new AddTable();
            form.ShowDialog();
            GetTables();
        }

        private void TableGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 4 && e.RowIndex != -1)
            {
                AddTable form = new AddTable(Convert.ToInt32(TableGrid.Rows[e.RowIndex].Cells[0].Value));
                form.ShowDialog();
                GetTables();
            }
        }

        private void TableGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex != -1)
            {
                if (MessageBox.Show("Вы действительно желаете удалить данный столик?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    repositoryTable.Delete(Convert.ToInt32(TableGrid.Rows[e.RowIndex].Cells[0].Value));
                    MessageBox.Show("Столик успешно удалён.");
                    GetTables();
                }
            }
        }
    }
}
