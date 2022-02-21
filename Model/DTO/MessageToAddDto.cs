using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
    public class MessageToAddDto
    {
        [Required]
        public string customerName { get; set; }
        [Required]
        public  string customerEmail { get; set; }
        [Required]
        public string customerMessage { get; set; }
        [Required]
        public string _formName { get; set; }
        [Required]
        public string _formDomainName { get; set; }

    }
}
