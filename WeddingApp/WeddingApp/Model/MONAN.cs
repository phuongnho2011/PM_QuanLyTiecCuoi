//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WeddingApp.Model
{
    using System;
    using System.Collections.Generic;
    using WeddingApp.ViewModel;

    public partial class MONAN : BaseViewModel
    {
        private int _IDMA;
        public int IDMA { get => _IDMA; set { _IDMA = value; OnPropertyChanged(); } }

        private string _TENMON;
        public string TENMON { get => _TENMON; set { _TENMON = value; OnPropertyChanged(); } }

        private Nullable<decimal> _DONGIA;
        public Nullable<decimal> DONGIA { get => _DONGIA; set { _DONGIA = value; OnPropertyChanged(); } }

        private string _GHICHU;
        public string GHICHU { get => _GHICHU; set { _GHICHU = value; OnPropertyChanged(); } }

        private Nullable<int> _IDLOAI;
        public Nullable<int> IDLOAI { get => _IDLOAI; set { _IDLOAI = value; OnPropertyChanged(); } }

        private LOAIMA _LOAIMA;
        public virtual LOAIMA LOAIMA { get => _LOAIMA; set { _LOAIMA = value; OnPropertyChanged(); } }
    }
}
