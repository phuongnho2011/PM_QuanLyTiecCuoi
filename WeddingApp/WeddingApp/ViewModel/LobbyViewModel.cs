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
    public class LobbyViewModel : BaseViewModel
    {
        private ObservableCollection<SANH> _ListSanh;
        public ObservableCollection<SANH> ListSanh { get => _ListSanh; set { _ListSanh = value; OnPropertyChanged(); } }

        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        private SANH _SelectedItem;
        public SANH SelectedItem
        {
            get => _SelectedItem;
            set
            {
                _SelectedItem = value;
                OnPropertyChanged();
                if (SelectedItem != null)
                {
                    TENSANH = SelectedItem.TENSANH;
                    LOAISANH = SelectedItem.LOAISANH;
                    SLBANTOIDA = SelectedItem.SLBANTOIDA;
                    DGBANTOITHIEU = SelectedItem.DGBANTOITHIEU;
                    GHICHU = SelectedItem.GHICHU;
                    TIECCUOI = SelectedItem.TIECCUOI;
                    TRANGTHAI = SelectedItem.TRANGTHAI;
                }
            }
        }

        public string TENSANH { get; set; }
        public string LOAISANH { get; set; }
        public Nullable<int> SLBANTOIDA { get; set; }
        public Nullable<decimal> DGBANTOITHIEU { get; set; }
        public string GHICHU { get; set; }
        public Nullable<int> IDTIECCUOI { get; set; }
        public Nullable<bool> TRANGTHAI { get; set; }
        public virtual TIECCUOI TIECCUOI { get; set; }

    }
}
