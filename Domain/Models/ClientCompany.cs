using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class ClientCompany
    {

        public Guid ClientId { get; set; }
        public virtual Client Client { get; set; }
        public Guid CompanyId { get; set; }
        public virtual Company Company { get; set; }
    }
}
