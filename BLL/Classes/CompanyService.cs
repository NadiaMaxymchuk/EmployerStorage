using BLL.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Classes
{
    public class CompanyService: BaseService<Employer>, IEmployerService
    {
        private readonly EmployerContext context;
        public CompanyService(EmployerContext context) : base(context)
        {
        }
    }
}
