using BLL.Classes;
using BLL.Interfaces;
using Domain;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

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
        [Route("create")]
        public void CreateCompany(Company company)
        {
            companyService.Add(company);

            companyService.SaveChanges();
        }

        [HttpGet]
        [Route("employer/{Id}")]
        public async Task<IActionResult> GetFull(Guid Id)
        {

            var result = companyService.GetFullCompanyInfo(Id);
            return Ok(result);
        }

        [HttpGet]
        [Route("company/{Id}")]
        public async Task<IActionResult> GetCompany()
        {
            var result = companyService.GetAllCompany();
            return Ok(result);

        }

        [HttpDelete]
        [Route("add/{Id}")]
        public async void DeleteEployer(Company company)
        {
            companyService.Remove(company);
            companyService.SaveChanges();
        }

    }
}
