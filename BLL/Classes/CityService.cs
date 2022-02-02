using BLL.Interfaces;
using Domain;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Classes
{
    public class CityService : BaseService<City>, ICityService
    {
        private readonly EmployerContext context;
        public CityService(EmployerContext context) : base(context)
        {
        }
    }
}
