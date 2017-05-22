using RestaurantBase.Abstract;
using RestaurantBase.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBase.Concrete
{
    public class ClientRepository : IClientRepository
    {
        private EFDbContext Context = new EFDbContext();

        public IEnumerable<Client> Client
        {
            get { return Context.Client; }
        }

        public Client Delete(int clientId)
        {
            Client element = Context.Client.Find(clientId);
            Context.Client.Remove(element);
            Context.SaveChanges();
            return element;
        }

        public void Save(Client client)
        {
            if (client.ClientId == 0)
                Context.Client.Add(client);
            else
            {
                Client element = Context.Client.Find(client.ClientId);
                element.Name = client.Name;
                Context.Client.Add(element);
            }
            Context.SaveChanges();
        }
    }
}
