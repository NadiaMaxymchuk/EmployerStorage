using BLL.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Classes
{
    public class CityService : BaseService<Employer>, IEmployerService
    {
        private readonly EmployerContext context;
        public CityService(EmployerContext context) : base(context)
        {
        }
    }
}
