using Domain;
using System;

namespace BLL.Interfaces
{
    public interface IEmployerService: IBaseService<Employer>
    {
        public Employer GetFullEmployerInfo(Guid Id);
    }
}
