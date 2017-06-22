using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace onlineshop.Models
{
    public class Categories
    {
        [Key]
        public int CATEGORYID { get; set; }
        public String CATEGORYNAME { get; set; }
        public String DESCRIPTION { get; set; }
        public int ISACTIVE { get; set; }
        public int PARENTCATEGORY { get; set; }
    }
}