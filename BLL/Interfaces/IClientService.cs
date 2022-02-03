using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public interface IClientService: IBaseService<Client>
    {
        public Client GetFullClientInfo(Guid Id);
        public IEnumerable<Client> GetAllClient();
        public void UpdateClient(Client client);
    }
}
