using BLL.Interfaces;
using Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;


namespace EmployerStorageAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployerController: ControllerBase
    {
        private readonly IEmployerService employerService;
        public EmployerController(IEmployerService employerService)
        {
            this.employerService = employerService;
        }

        [HttpPost]
        [Route("create")]
        public void CreateEmployer(Employer employer)
        {
            employerService.Add(employer);

            employerService.SaveChanges();
        }

        [HttpGet]
        [Route("employer/{Id}")]
        public async Task<IActionResult> GetFullInfo(Guid Id)
        {
             
            var result = employerService.GetFullEmployerInfo(Id);
            return Ok(result);
        }

        [HttpGet]
        [Route("employers/{Id}")]
        public async Task<IActionResult> GetEmployers()
        {
            var result = employerService.GetMany();
            return Ok(result);
             
        }

        [HttpDelete]
        [Route("delete/{Id}")]
        public async void DeleteEployer(Employer employer)
        {
            employerService.Remove(employer);
            employerService.SaveChanges();
        }


    }
}
