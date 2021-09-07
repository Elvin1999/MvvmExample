using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Models;

namespace WpfApp1.Repository
{
   public class FakeRepo
    {
        public List<Printer> GetAll()
        {
            return new List<Printer>
            {
                new Printer
                {
                    Color="Red",
                    Model="R100",
                    Vendor="Canon"
                },
                new Printer
                {
                    Color="Blue",
                    Model="LLL100",
                    Vendor="Hp"
                },
                new Printer
                {
                    Color="SkyBlue",
                    Model="R100",
                    Vendor="M100"
                },
                new Printer
                {
                    Color="Indigo",
                    Model="C202",
                    Vendor="Varta"
                }
            };
        }
    }
}
