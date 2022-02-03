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
        private readonly ICompanyService companyService;
        public CompanyController(ICompanyService companyService)
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
