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
    public class FoodViewModel : BaseViewModel
    {


        private ObservableCollection<MONAN> _List;
        public ObservableCollection<MONAN> List { get => _List; set { _List = value; OnPropertyChanged(); } }

        private ObservableCollection<LOAIMA> _ListLoai;
        public ObservableCollection<LOAIMA> ListLoai { get => _ListLoai; set { _ListLoai = value; OnPropertyChanged(); } }

        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        public ICommand ThemLoai { get; set; }
        public ICommand XoaLoai { get; set; }
        public ICommand SuaLoai { get; set; }

        private LOAIMA _SelectedItemLoai;
        public LOAIMA SelectedItemLoai
        {
            get => _SelectedItemLoai;
            set
            {
                _SelectedItemLoai = value;
                OnPropertyChanged();
                if (SelectedItemLoai != null)
                {
                    TENLOAI = SelectedItemLoai.TENLOAI;
                }
            }
        }

        private string _TENLOAI;
        public string TENLOAI { get => _TENLOAI; set { _TENLOAI = value; OnPropertyChanged(); } }
        
        
        private MONAN _SelectedItem;
        public MONAN SelectedItem
        {
            get => _SelectedItem;
            set
            {
                _SelectedItem = value;
                OnPropertyChanged();
                if (SelectedItem != null)
                {
                    TENMON = SelectedItem.TENMON;
                    LOAIMA = SelectedItem.LOAIMA;
                    DONGIA = SelectedItem.DONGIA;
                    GHICHU = SelectedItem.GHICHU;
                }
            }
        }
        private string _TENMON;        
        private Nullable<decimal> _DONGIA;
        private string _GHICHU;
        public string TENMON { get => _TENMON; set { _TENMON = value; OnPropertyChanged(); } }
        public decimal? DONGIA { get => _DONGIA; set { _DONGIA = value; OnPropertyChanged(); } }
        public string GHICHU { get => _GHICHU; set { _GHICHU = value; OnPropertyChanged(); } }

        private LOAIMA _LOAIMA;
        public virtual LOAIMA LOAIMA { get => _LOAIMA; set { _LOAIMA = value; OnPropertyChanged(); } }

        public FoodViewModel()
        {
            List = new ObservableCollection<MONAN>(DataProvider.Ins.DB.MONANs);
            ListLoai = new ObservableCollection<LOAIMA>(DataProvider.Ins.DB.LOAIMAs);
            
            AddCommand = new RelayCommand<object>((p) =>
            {
                if(string.IsNullOrEmpty(TENMON) || LOAIMA == null)
                    return false;
                var displayList = DataProvider.Ins.DB.MONANs.Where(x => x.TENMON == TENMON);
                if (displayList == null || displayList.Count() != 0)
                    return false;

                return true;

            }, (p) =>
            {
                var monan = new MONAN() { TENMON = TENMON, DONGIA = DONGIA, IDLOAI = LOAIMA.IDLOAI, GHICHU = GHICHU};

                DataProvider.Ins.DB.MONANs.Add(monan);
                DataProvider.Ins.DB.SaveChanges();

                List.Add(monan);
            });

            EditCommand = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(TENMON) || LOAIMA == null || SelectedItem == null)
                    return false;                
                var displayList = DataProvider.Ins.DB.MONANs.Where(x => x.TENMON == TENMON).Where(x => x.GHICHU == GHICHU).Where(x => x.DONGIA == DONGIA).Where(x => x.IDLOAI == LOAIMA.IDLOAI);
                if (displayList == null || displayList.Count() != 0)
                    return false;

                return true;
            }, (p) =>
            {
                var monan = DataProvider.Ins.DB.MONANs.Where(x => x.IDMA == SelectedItem.IDMA).SingleOrDefault();
                monan.TENMON = TENMON;
                monan.LOAIMA = LOAIMA;
                monan.DONGIA = DONGIA;
                monan.GHICHU = GHICHU;
                DataProvider.Ins.DB.SaveChanges();

                SelectedItem.TENMON = TENMON;
                SelectedItem.LOAIMA = LOAIMA;
                SelectedItem.DONGIA = DONGIA;
                SelectedItem.GHICHU = GHICHU;
            });

            //DeleteCommand = new RelayCommand<object>((p) =>
            //{
            //    if (SelectedItem == null)
            //        return false;

            //    var displayList = DataProvider.Ins.DB.MONANs.Where(x => x.IDMA == SelectedItem.IDMA);
            //    if (displayList != null && displayList.Count() != 0)
            //        return true;

            //    return false;
            //}, (p) =>
            //{
            //    var MONAN = new MONAN() { TENMON = TENMON, LOAIMA = LOAIMA, DONGIA = DONGIA, GHICHU = GHICHU };
            //    foreach (MONAN monan in DataProvider.Ins.DB.MONANs)
            //    {
            //        if (monan.IDMA == MONAN.IDMA)
            //        {
            //            DataProvider.Ins.DB.MONANs.Remove(monan);
            //            List.Remove(monan);
            //        }
            //    }
            //    DataProvider.Ins.DB.SaveChanges();

            //});

            ThemLoai = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(TENLOAI))
                    return false;
                var displayList = DataProvider.Ins.DB.LOAIMAs.Where(x => x.TENLOAI == TENLOAI);
                if (displayList == null || displayList.Count() != 0)
                    return false;

                return true;
            }, (p) =>
            {
                var loaimonan = new LOAIMA() { TENLOAI = TENLOAI};

                DataProvider.Ins.DB.LOAIMAs.Add(loaimonan);
                DataProvider.Ins.DB.SaveChanges();

                ListLoai.Add(loaimonan);
            });

            SuaLoai = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(TENLOAI) || SelectedItemLoai == null)
                    return false;
                var displayList = DataProvider.Ins.DB.LOAIMAs.Where(x => x.TENLOAI == TENLOAI);
                if (displayList == null || displayList.Count() != 0)
                    return false;

                return true;
            }, (p) =>
            {
                var loaimonan = DataProvider.Ins.DB.LOAIMAs.Where(x => x.IDLOAI == SelectedItemLoai.IDLOAI).SingleOrDefault();
                loaimonan.TENLOAI = TENLOAI;
                DataProvider.Ins.DB.SaveChanges();

                SelectedItemLoai.TENLOAI = TENLOAI;               
            });
        }

    }
}
