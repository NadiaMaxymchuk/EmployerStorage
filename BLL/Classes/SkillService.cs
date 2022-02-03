using BLL.Interfaces;
using Domain;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Classes
{
    public class SkillService: BaseService<Skill>, ISkillService
    {
        private readonly EmployerContext context;
        public SkillService(EmployerContext context) : base(context)
        {
        }

        

        public IEnumerable<Skill> GetAllSkill()
        {
            throw new NotImplementedException();
        }

        public Skill GetFullSkillInfo(Guid Id)
        {
            throw new NotImplementedException();
        }

        public void UpdateSkill(Skill skill)
        {
            throw new NotImplementedException();
        }
    }
}
