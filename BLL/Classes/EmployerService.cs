using System;
using System.Collections.Generic;
using System.Text;
using BLL.Interfaces;
using Domain;
using System.Linq;

namespace BLL.Classes
{
    public class EmployerService: BaseService<Employer>, IEmployerService
    {
        private readonly EmployerContext context;
        public EmployerService(EmployerContext context):base(context)
        {
            this.context = context; 
        }
        public Employer GetFullEmployerInfo(Guid Id)
        {
            return context.Employers.FirstOrDefault(x=>x.Id==Id);
        }


    }
}
