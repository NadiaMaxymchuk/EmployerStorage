using BLL.Interfaces;
using Domain;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployerStorageAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CityController: ControllerBase
    {
        private readonly ICityService cityService;
        public CityController(ICityService cityService)
        {
            this.cityService = cityService;
        }

        [HttpPost]
        public void CreateCity(City city )
        {
            cityService.Add(city);

            cityService.SaveChanges();
        }
    }
}
