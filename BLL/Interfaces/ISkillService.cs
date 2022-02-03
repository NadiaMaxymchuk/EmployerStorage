using Domain;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public interface ISkillService: IBaseService<Skill>
    {
        public Skill GetFullSkillInfo(Guid Id);
        public IEnumerable<Skill> GetAllSkill();
        public void UpdateSkill(Skill skill);
    }
}
