using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace project_spotonsepia.Models
{
    public class ContentViewModel
    {
        public string Name { get; set; }

        public string email { get; set; }

        public string password { get; set; }

       

        public string lastname { get; set; }
        public Nullable<System.DateTime> Dob { get; set; }

        public string Gender { get; set; }

        public Nullable<int> contact { get; set; }

        public string cus_address { get; set; }
        public Nullable<int> ad_id_fk { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Upload File")]
        [Required(ErrorMessage = "Please choose file to upload.")]
        public string file { get; set; }
    }

}