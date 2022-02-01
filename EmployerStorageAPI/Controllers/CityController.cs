using BLL.Interfaces;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace EmployerStorageAPI.Controllers
{
    public class CityController: ControllerBase
    {
        private readonly IEmployerService employerService;
        public CityController(IEmployerService employerService)
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
