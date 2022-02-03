using Domain;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public interface ICompanyService: IBaseService<Company>
    {
        public Company GetFullCompanyInfo(Guid Id);
        public IEnumerable<Company> GetAllCompany();
        public void UpdateCompany(Company company);

    }
}
