using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    public class Printer : Entity
    {
        public string Color { get; set; }
        public string Model { get; set; }
        public string Vendor { get; set; }
    }
}
