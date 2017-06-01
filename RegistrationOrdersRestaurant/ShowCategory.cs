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
            CategoryGrid.RowCount = 0;
            CategoryGrid.ColumnCount = 2;
            GetCategory();
        }

        public void GetCategory()
        {
            CategoryGrid.Rows.Clear();
            foreach (var category in repositoryCategory.CategoryDish)
            {
                CategoryGrid.Rows.Add(category.CategoryDishId, category.Name);
            }
        }
    }
}
