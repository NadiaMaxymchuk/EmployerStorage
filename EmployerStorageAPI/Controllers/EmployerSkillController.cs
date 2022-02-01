using BLL.Interfaces;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace EmployerStorageAPI.Controllers
{
    public class EmployerSkillController: ControllerBase
    {
        private readonly IEmployerService employerService;
        public EmployerSkillController(IEmployerService employerService)
        {
            this.employerService = employerService;
        }

        [HttpPost]
        public void CreateEmployer(Employer employer)
        {
            employerService.Add(employer);

            employerService.SaveChanges();
        }
    }
}
