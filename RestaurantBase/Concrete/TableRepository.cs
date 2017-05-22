using RestaurantBase.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantBase.Entity;

namespace RestaurantBase.Concrete
{
    public class TableRepository : ITableRepository
    {
        private EFDbContext Context = new EFDbContext();

        public IEnumerable<Table> Table
        {
            get { return Context.Table; }
        }

        public Table Delete(int tableId)
        {
            Table element = Context.Table.Find(tableId);
            Context.Table.Remove(element);
            Context.SaveChanges();
            return element;
        }

        public void Save(Table table)
        {
            if (table.TableId == 0)
                Context.Table.Add(table);
            else
            {
                Table element = Context.Table.Find(table.TableId);
                element.Count = table.Count;
                element.Number = table.Number;
                element.Description = table.Description;
                Context.Table.Add(element);
            }
            Context.SaveChanges();
        }

        public IEnumerable<Table> SearchSpare()
        {
            throw new NotImplementedException();
        }
    }
}
