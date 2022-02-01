using BLL.Interfaces;
using Domain;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployerStorageAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SkillController: ControllerBase
    {
        private readonly ISkillService skillService;
        public SkillController(ISkillService skillService)
        {
            this.skillService = skillService;
        }

        [HttpPost]
        public void CreateSkill(Skill skill)
        {
            skillService.Add(skill);

            skillService.SaveChanges();
        }
    }
}
