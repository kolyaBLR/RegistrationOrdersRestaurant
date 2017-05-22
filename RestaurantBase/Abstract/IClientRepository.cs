using RestaurantBase.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBase.Abstract
{
    public interface IClientRepository
    {
        IEnumerable<Client> Client { get; }
        void Save(Client Client);
        Client Delete(int ClientId);
    }
}
