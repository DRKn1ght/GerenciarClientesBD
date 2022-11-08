using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciarClientes.Models
{
    class GridCustomer
    {
        public string Name { get; set; }
        public string CPF { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }
        public double VisitCount { get; set; }
        public string OwnerName { get; set; }
    }
}
