using BLL.Classes;
using BLL.Interfaces;
using Domain;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployerStorageAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompanyController: ControllerBase
    {
        private readonly CompanyService companyService;
        public CompanyController(IEmployerService employerService)
        {
            this.companyService = companyService;
        }

        [HttpPost]
        public void CreateCompany(Company company)
        {
            companyService.Add(company);

            companyService.SaveChanges();
        }
    }
}
