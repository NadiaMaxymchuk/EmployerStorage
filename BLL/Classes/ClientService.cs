using BLL.Interfaces;
using Domain;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Classes
{
    public class ClientService : BaseService<Client>, IClientService
    {
        private readonly EmployerContext context;
        public ClientService(EmployerContext context) : base(context)
        {
            this.context = context;
        }
        public Client GetFullClientInfo(Guid Id)
        {
            return context.Clients.FirstOrDefault(x => x.Id == Id);


        }

        public IEnumerable<Client> GetAllClient()
        {
            return context.Clients.ToList();
        }
        public void UpdateClient(Client client)
        {
            context.Clients.Update(client);
        }
    }
}
