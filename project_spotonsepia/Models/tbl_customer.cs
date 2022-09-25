namespace project_spotonsepia.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class tbl_customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_customer()
        {
            this.tbl_invoice = new HashSet<tbl_invoice>();
            this.tbl_order = new HashSet<tbl_order>();
            this.tbl_seller = new HashSet<tbl_seller>();
            this.tbl_services = new HashSet<tbl_services>();
        }
    
        public int cus_id { get; set; }

        [Required(ErrorMessage = "*Required", AllowEmptyStrings = false)]
        [Display(Name = "First Name")]
        public string Name { get; set; }

         [Display(Name = "Email")]
        [Required(ErrorMessage = "*Required", AllowEmptyStrings = false)]
        public string cus_email { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "*Required", AllowEmptyStrings = false)]
        public string cus_password { get; set; }

        [Display(Name = "Upload Image")]
        public string cus_imge { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "*Required", AllowEmptyStrings = false)]
        public string last_name { get; set; }
        public Nullable<System.DateTime> Dob { get; set; }

        [Display(Name = "Gender")]
        [Required(ErrorMessage = "*Required", AllowEmptyStrings = false)]
        public string Gender { get; set; }

        [Display(Name = "Contact No.")]
        [Required(ErrorMessage = "*Required", AllowEmptyStrings = false)]
        public Nullable<int> contact { get; set; }

        [Display(Name = "Address")]
        [Required(ErrorMessage = "*Required", AllowEmptyStrings = false)]
        public string cus_address { get; set; }
        public Nullable<int> ad_id_fk { get; set; }
    
        public virtual tbl_admin tbl_admin { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_invoice> tbl_invoice { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_order> tbl_order { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_seller> tbl_seller { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_services> tbl_services { get; set; }
    }
}
