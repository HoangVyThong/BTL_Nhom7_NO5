//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BTL_Nhom7_N05.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChuQuanLy
    {
        public string Ten { get; set; }
        public string ID { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
    
        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}