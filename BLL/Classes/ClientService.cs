using BLL.Interfaces;
using Domain;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Classes
{
    public class ClientService : BaseService<Client>, IClientService
    {
        private readonly EmployerContext context;
        public ClientService(EmployerContext context) : base(context)
        {
        }
    }
}
