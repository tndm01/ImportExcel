//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyTeamApp.EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class TRANGTHAI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TRANGTHAI()
        {
            this.LOAITHIETBI_TRANGTHAI = new HashSet<LOAITHIETBI_TRANGTHAI>();
            this.TRANGTHAITBs = new HashSet<TRANGTHAITB>();
        }
    
        public string MaTrangThai { get; set; }
        public string NoiDung { get; set; }
        public Nullable<double> TieuChuanMin { get; set; }
        public Nullable<double> TieuChuanMax { get; set; }
        public Nullable<int> MucDo { get; set; }
        public string MaMau { get; set; }
        public string DonVi { get; set; }
        public string NoiDungCanhBao { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOAITHIETBI_TRANGTHAI> LOAITHIETBI_TRANGTHAI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRANGTHAITB> TRANGTHAITBs { get; set; }
    }
}
