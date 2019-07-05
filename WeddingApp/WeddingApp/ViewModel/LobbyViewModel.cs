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
                    SLBANTOIDA = SelectedItem.SLBANTOIDA;
                    GHICHU = SelectedItem.GHICHU;
                    TIECCUOI = SelectedItem.TIECCUOI;
                    TRANGTHAI = SelectedItem.TRANGTHAI;
                    LOAISANH = SelectedItem.LOAISANH;
                }
            }
        }

        private int _IDSANH { get; set; }
        public int IDSANH { get => _IDSANH; set { _IDSANH = value; OnPropertyChanged(); } }

        private string _TENSANH { get; set; }
        public string TENSANH { get => _TENSANH; set { _TENSANH = value; OnPropertyChanged(); } }

        private LOAISANH _LOAISANH { get; set; }
        public virtual LOAISANH LOAISANH { get => _LOAISANH; set { _LOAISANH = value; OnPropertyChanged(); } }

        private Nullable<int> _SLBANTOIDA { get; set; }
        public Nullable<int> SLBANTOIDA { get => _SLBANTOIDA; set { _SLBANTOIDA = value; OnPropertyChanged(); } }

        private string _GHICHU { get; set; }
        public string GHICHU { get => _GHICHU; set { _GHICHU = value; OnPropertyChanged(); } }

        private Nullable<int> _IDTIECCUOI { get; set; }
        public Nullable<int> IDTIECCUOI { get => _IDTIECCUOI; set { _IDTIECCUOI = value; OnPropertyChanged(); } }

        private Nullable<bool> _TRANGTHAI { get; set; }
        public Nullable<bool> TRANGTHAI { get => _TRANGTHAI; set { _TRANGTHAI = value; OnPropertyChanged(); } }

        private TIECCUOI _TIECCUOI { get; set; }
        public virtual TIECCUOI TIECCUOI { get => _TIECCUOI; set { _TIECCUOI = value; OnPropertyChanged(); } }

       


        // LOAI SANH AREA
        private ObservableCollection<LOAISANH> _ListLoaiSanh;
        public ObservableCollection<LOAISANH> ListLoaiSanh { get => _ListLoaiSanh; set { _ListLoaiSanh = value; OnPropertyChanged(); } }

        public ICommand AddCommandL { get; set; }
        public ICommand EditCommandL { get; set; }
        public ICommand DeleteCommandL { get; set; }

        private LOAISANH _SelectedItemL;
        public LOAISANH SelectedItemL
        {
            get => _SelectedItemL;
            set
            {
                _SelectedItemL = value;
                OnPropertyChanged();
                if (SelectedItemL != null)
                {
                    IDLOAISANH = SelectedItemL.IDLOAISANH;
                    TENLOAI = SelectedItemL.TENLOAI;
                    DGBANTOITHIEU = SelectedItemL.DGBANTOITHIEU;
                }
            }
        }

        public int _IDLOAISANH { get; set; }
        public int IDLOAISANH { get => _IDLOAISANH; set { _IDLOAISANH = value; OnPropertyChanged(); } }
        public string _TENLOAI { get; set; }
        public string TENLOAI { get => _TENLOAI; set { _TENLOAI = value; OnPropertyChanged(); } }
        public Nullable<decimal> _DGBANTOITHIEU { get; set; }
        public Nullable<decimal> DGBANTOITHIEU { get => _DGBANTOITHIEU; set { _DGBANTOITHIEU = value; OnPropertyChanged(); } }

        public LobbyViewModel()
        {
            ListSanh = new ObservableCollection<SANH>(DataProvider.Ins.DB.SANHs);
            ListLoaiSanh = new ObservableCollection<LOAISANH>(DataProvider.Ins.DB.LOAISANHs);

            AddCommand = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(TENSANH) || LOAISANH == null)
                    return false;
                var displayList = DataProvider.Ins.DB.SANHs.Where(x => x.TENSANH == TENSANH);
                if (displayList == null || displayList.Count() != 0)
                    return false;

                return true;

            }, (p) =>
            {
                var sanh = new SANH() { TENSANH = TENSANH, SLBANTOIDA = SLBANTOIDA, LOAISANH = LOAISANH, GHICHU = GHICHU, TIECCUOI = TIECCUOI };

                DataProvider.Ins.DB.SANHs.Add(sanh);
                DataProvider.Ins.DB.SaveChanges();

                ListSanh.Add(sanh);
            });

            AddCommandL = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(TENLOAI))
                    return false;
                var displayList = DataProvider.Ins.DB.LOAISANHs.Where(x => x.TENLOAI == TENLOAI);
                if (displayList == null || displayList.Count() != 0)
                    return false;

                return true;

            }, (p) =>
            {
                var loaisanh = new LOAISANH() { TENLOAI = TENLOAI, DGBANTOITHIEU = DGBANTOITHIEU};

                DataProvider.Ins.DB.LOAISANHs.Add(loaisanh);
                DataProvider.Ins.DB.SaveChanges();

                ListLoaiSanh.Add(loaisanh);
            });
        }

    }
}
