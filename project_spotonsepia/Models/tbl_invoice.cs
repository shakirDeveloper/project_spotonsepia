//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace project_spotonsepia.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_invoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_invoice()
        {
            this.tbl_order = new HashSet<tbl_order>();
            this.tbl_seller = new HashSet<tbl_seller>();
        }
    
        public int inv_id { get; set; }
        public Nullable<System.DateTime> in_date { get; set; }
        public Nullable<double> total_bill { get; set; }
        public Nullable<int> ad_id_fk { get; set; }
        public Nullable<int> Ser_id_fk { get; set; }
        public Nullable<int> cus_id_fk { get; set; }
    
        public virtual tbl_admin tbl_admin { get; set; }
        public virtual tbl_customer tbl_customer { get; set; }
        public virtual tbl_services tbl_services { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_order> tbl_order { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_seller> tbl_seller { get; set; }
    }
}
