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
    public partial class ShowCategory : Form
    {
        private ICategoryDishRepository repositoryCategory = new CategoryDishRepository();

        public ShowCategory()
        {
            InitializeComponent();
            CategoryGrid.ColumnCount = 3;
            CategoryGrid.Columns[0].HeaderText = "Id";
            CategoryGrid.Columns[1].HeaderText = "Категория";
            CategoryGrid.Columns[2].HeaderText = "Удалить";
            GetCategory();
        }

        public void GetCategory()
        {
            CategoryGrid.Rows.Clear();
            foreach (var category in repositoryCategory.CategoryDish)
            {
                CategoryGrid.Rows.Add(category.CategoryDishId, category.Name, "x");
            }
        }

        private void CategoryGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 4 && e.RowIndex != -1)
            {
                AddCategory form = new AddCategory(Convert.ToInt32(CategoryGrid.Rows[e.RowIndex].Cells[0].Value));
                form.ShowDialog();
                GetCategory();
            }
        }

        private void CategoryGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex != -1)
            {
                if (MessageBox.Show("Вы действительно желаете удалить данную категорию?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    repositoryCategory.Delete(Convert.ToInt32(CategoryGrid.Rows[e.RowIndex].Cells[0].Value));
                    MessageBox.Show("Категоиря успешно удалена.");
                    GetCategory();
                }
            }
        }

        private void CloseBox_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddBox_Click(object sender, EventArgs e)
        {
            AddCategory form = new AddCategory();
            form.ShowDialog();
            GetCategory();
        }
    }
}
