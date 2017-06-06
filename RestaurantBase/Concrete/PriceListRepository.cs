using RestaurantBase.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantBase.Entity;

namespace RestaurantBase.Concrete
{
    public class PriceListRepository : IPriceListRepository
    {
        private EFDbContext Context = new EFDbContext();

        public IEnumerable<PriceList> PriceList
        {
            get { return Context.PriceList; }
        }

        public void Save(PriceList priceList)
        {
            if (priceList.PriceListId == 0)
                Context.PriceList.Add(priceList);
            else
            {
                PriceList element = Context.PriceList.Find(priceList.PriceListId);
                element.TableId = priceList.TableId;
                element.PriceListId = priceList.PriceListId;
                element.Price = priceList.Price;
                element.ClientId = priceList.ClientId;
                Context.PriceList.Add(element);
            }
            Context.SaveChanges();
        }
    }
}