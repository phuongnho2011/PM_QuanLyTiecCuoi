using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WeddingApp.ViewModel
{
    class MainViewModel : BaseViewModel
    {
        public ICommand FoodCommand { get; set; }
        public MainViewModel()
        {
            FoodCommand = new RelayCommand<object>((p) => { return true; }, (p) => { FoodWindow wd = new FoodWindow(); wd.ShowDialog(); });
        }
    }
}
