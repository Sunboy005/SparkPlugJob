using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public record ClientCompany
    {
        public string CompanyName { get; init; }
        public string CompanyWebsite { get; set; }
    }
}
