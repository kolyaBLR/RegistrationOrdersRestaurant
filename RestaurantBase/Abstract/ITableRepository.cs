using RestaurantBase.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBase.Abstract
{
    public interface ITableRepository
    {
        IEnumerable<Table> Table { get; }
        void Save(Table table);
        Table Delete(int tableId);
        void ChangeBooking(int idTable, bool status);
    }
}
