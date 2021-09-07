using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Models;
using WpfApp1.Repository;

namespace WpfApp1.ViewModels
{
   public class AppViewModel:BaseViewModel
    {
        public FakeRepo PrinterRepository { get; set; }
        public ObservableCollection<Printer> Printers { get; set; }

        public AppViewModel()
        {
            PrinterRepository = new FakeRepo();
            Printers = new ObservableCollection<Printer>(PrinterRepository.GetAll());
        }
    }
}
