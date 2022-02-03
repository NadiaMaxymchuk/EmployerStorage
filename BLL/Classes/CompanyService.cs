using BLL.Interfaces;
using Domain;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Classes
{
    public class CompanyService: BaseService<Company>, ICompanyService
    {
        private readonly EmployerContext context;
        public CompanyService(EmployerContext context) : base(context)
        {
            this.context = context;
        }
        public Company GetFullCompanyInfo(Guid Id)
        {
            return context.Companies.FirstOrDefault(x => x.Id == Id);

        }

        public IEnumerable<Company> GetAllCompany()
        {
            return context.Companies.ToList();
        }


        public void UpdateCompany(Company company)
        {
            context.Companies.Update(company);
        }

    }
}
