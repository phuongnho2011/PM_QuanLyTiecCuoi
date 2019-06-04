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
    public class ServicesViewModel : BaseViewModel
    {
        private ObservableCollection<DICHVU> _List;
        public ObservableCollection<DICHVU> List { get => _List; set { _List = value; OnPropertyChanged(); } }

        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }


        private DICHVU _SelectedItem;
        public DICHVU SelectedItem
        {
            get => _SelectedItem;
            set
            {
                _SelectedItem = value;
                OnPropertyChanged();
                if (SelectedItem != null)
                {
                    TENDV = SelectedItem.TENDV;
                    DONGIA = SelectedItem.DONGIA;
                    MOTA = SelectedItem.MOTA;
                    GHICHU = SelectedItem.GHICHU;
                }
            }
        }

        private string _TENDV;
        public string TENDV { get => _TENDV; set { _TENDV = value; OnPropertyChanged(); } }

        private Nullable<decimal> _DONGIA;
        public Nullable<decimal> DONGIA { get => _DONGIA; set { _DONGIA = value; OnPropertyChanged(); } }

        private string _MOTA;
        public string MOTA { get => _MOTA; set { _MOTA = value; OnPropertyChanged(); } }

        private string _GHICHU;
        public string GHICHU { get => _GHICHU; set { _GHICHU = value; OnPropertyChanged(); } }

        public ServicesViewModel()
        {
            List = new ObservableCollection<DICHVU>(DataProvider.Ins.DB.DICHVUs);

            AddCommand = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(TENDV))
                    return false;
                var displayList = DataProvider.Ins.DB.DICHVUs.Where(x => x.TENDV == TENDV);
                if (displayList == null || displayList.Count() != 0)
                    return false;

                return true;

            }, (p) =>
            {
                var dichvu = new DICHVU() { TENDV = TENDV, DONGIA = DONGIA, MOTA = MOTA, GHICHU = GHICHU };

                DataProvider.Ins.DB.DICHVUs.Add(dichvu);
                DataProvider.Ins.DB.SaveChanges();

                List.Add(dichvu);
            });

            EditCommand = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(TENDV) || SelectedItem == null)
                    return false;
                var displayList = DataProvider.Ins.DB.DICHVUs.Where(x => x.TENDV == TENDV).Where(x => x.GHICHU == GHICHU).Where(x => x.DONGIA == DONGIA).Where(x => x.MOTA == MOTA);
                if (displayList == null || displayList.Count() != 0)
                    return false;
                return true;
            }, (p) =>
            {
                var dichvu = DataProvider.Ins.DB.DICHVUs.Where(x => x.IDDV == SelectedItem.IDDV).SingleOrDefault();
                dichvu.TENDV = TENDV;           
                dichvu.DONGIA = DONGIA;
                dichvu.MOTA = MOTA;
                dichvu.GHICHU = GHICHU;
                DataProvider.Ins.DB.SaveChanges();

                SelectedItem.TENDV = TENDV;
                SelectedItem.DONGIA = DONGIA;
                SelectedItem.MOTA = MOTA;
                SelectedItem.GHICHU = GHICHU;
            });
        }
    }
}
