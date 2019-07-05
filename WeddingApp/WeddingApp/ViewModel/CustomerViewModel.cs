using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeddingApp.Model;

namespace WeddingApp.ViewModel
{
    public class CustomerViewModel : BaseViewModel
    {
        private ObservableCollection<KHACHHANG> _ListKH;
        public ObservableCollection<KHACHHANG> ListKH { get => _ListKH; set { _ListKH = value; OnPropertyChanged(); } }

    }
}
