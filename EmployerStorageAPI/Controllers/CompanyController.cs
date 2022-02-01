using BLL.Interfaces;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace EmployerStorageAPI.Controllers
{
    public class CompanyController: ControllerBase
    {
        private readonly IEmployerService employerService;
        public CompanyController(IEmployerService employerService)
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
