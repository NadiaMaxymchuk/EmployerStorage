using BLL.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Classes
{
    public class EmployerSkillService: BaseService<Employer>, IEmployerService
    {
        private readonly EmployerContext context;
        public EmployerSkillService(EmployerContext context) : base(context)
        {
        }
    }
}
