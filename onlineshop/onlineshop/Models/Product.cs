using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace onlineshop.Models
{
    
    public class Product
    {
        [Key]
        public int PRODUCTID { get; set; }
        public int CATEGORYID { get; set; }
        public String PRODUCTSKU { get; set; }
        public String NAME { get; set; }
        public String SHORTDESCRIPTION { get; set; }
        public String DESCRIPTION { get; set; }
        public int ISACTIVE { get; set; }
        public double UNITCOST { get; set; }
        public double UNITPRICE { get; set; }
        public double WEIGHT { get; set; }
        public double PRODUCTSTOCK { get; set; }
        public double PRODUCTDESCOUNT { get; set; }
        public String HEADER { get; set; }
        public String FOOTER { get; set; }
        public int ISTAXED { get; set; }
        public int ISDESCOUNT { get; set; }
        public String LOCATION { get; set; }
        public String SMALLIMAGE { get; set; }
        public String MEDIUMIMAGE { get; set; }
        public String LARGEIMAGE { get; set; }
        public String EXTRA1 { get; set; }
        public String EXTRA2 { get; set; }
       
    }
}