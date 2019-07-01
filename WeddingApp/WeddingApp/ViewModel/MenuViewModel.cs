using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WeddingApp.Model;

namespace WeddingApp.ViewModel
{
    public class MenuViewModel : BaseViewModel
    {
        private ObservableCollection<THUCDON> _ListMenu;
        public ObservableCollection<THUCDON> ListMenu { get => _ListMenu; set { _ListMenu = value; OnPropertyChanged(); } }

        private ObservableCollection<THUCDON_MONAN> _ListmenuAndfood;
        public ObservableCollection<THUCDON_MONAN> ListmenuAndfood { get => _ListmenuAndfood; set { _ListmenuAndfood = value; OnPropertyChanged(); } }

        public ICommand AddFoodCommand { get; set; }
        public ICommand AddServiceCommand { get; set; }
        public ICommand SaveCommand { get; set; }
        public ICommand DeleteCommand { get; set; }


    }

    
}
