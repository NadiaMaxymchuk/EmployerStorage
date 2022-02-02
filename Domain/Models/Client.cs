using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Client
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Profile { get; set; } 
        public string Url { get; set; } 
        public virtual ICollection<ClientCompany> ClientCompanies { get; set; } 
    }
}
