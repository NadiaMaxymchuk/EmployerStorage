using Domain;
using System;
using System.Collections.Generic;

namespace BLL.Interfaces
{
    public interface IEmployerService: IBaseService<Employer>
    {
        public Employer GetFullEmployerInfo(Guid Id);
        public IEnumerable<Employer> GetAllEmployer();
        
        public void Update(Employer employer);
    }
}
