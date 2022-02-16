using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Carpe_Librum_Proto_0.Models
{
    public class BookSugestion
    {
        [Key]// Primary Key
        public int BookID { get; set; }
        [Display(Name = "Book Title")]
        public string Title { get; set; }
        [Display (Name = "Author")]
        public string Authour { get; set; }
        [Display (Name = "Publisher")]
        public string Publisher{ get; set; }
        [Display(Name = "Publication Date")]
        public string PublicationDate{ get; set; }
        [Display(Name = "Date Of Sugestion")]
        public DateTime GetDateTime { get; set; }

     
    }
}