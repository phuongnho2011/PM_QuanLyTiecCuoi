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
    
    public partial class HOPDONG
    {
        public int IDHD { get; set; }
        public Nullable<int> SLMONAN { get; set; }
        public Nullable<int> SLDV { get; set; }
        public Nullable<decimal> TONGTIEN_DVAM { get; set; }
        public Nullable<decimal> TTTHANHTOAN { get; set; }
        public Nullable<decimal> SOTIENDATCO { get; set; }
        public string QUYDINH { get; set; }
        public Nullable<int> ID_TIECCUOI { get; set; }
        public Nullable<int> ID_KHACHHANG { get; set; }
    
        public virtual KHACHHANG KHACHHANG { get; set; }
        public virtual TIECCUOI TIECCUOI { get; set; }
    }
}