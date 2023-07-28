using Catel.MVVM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeKeeper;

namespace Gui
{
    public class MainWindowViewModel
    {
        public MainWindowViewModel()
        {
            WatchModels = new ObservableCollection<WatchModel>()
            {
                new WatchModel(001, "Rolex", 100, 3, 200),
                new WatchModel(002, "Michael Kors", 800, 2, 120),
                new WatchModel(003, "Swatch", 50),
                new WatchModel(004, "Casio", 30),
            };

            AddToCartCommand = new Command(CalculateTotalCostExecute);
        }

        public ObservableCollection<WatchModel> WatchModels { get; set; }

        public ObservableCollection<string> OrderedList { get; set; }

        public int TotalCost { get; set; }

        public Command AddToCartCommand { get; }

        private void CalculateTotalCostExecute()
        {
            foreach (var id in OrderedList) 
            {

            }
        }
    }
}
