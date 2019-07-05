using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeddingApp.Model;

namespace WeddingApp.ViewModel
{
    public class PartyViewModel : BaseViewModel
    {
        private ObservableCollection<TIECCUOI> _List;
        public ObservableCollection<TIECCUOI> List { get => _List; set { _List = value; OnPropertyChanged(); } }

    }
}
