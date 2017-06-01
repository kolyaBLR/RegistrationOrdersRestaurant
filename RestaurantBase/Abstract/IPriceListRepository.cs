using RestaurantBase.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBase.Abstract
{
    public interface IPriceListRepository
    {
        IEnumerable<PriceList> PriceList { get; }
        void Save(PriceList priceList);
    }
}
