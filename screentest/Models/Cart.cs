using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScreenTest.Models
{
    public class Cart
    {
       
        public int ID { get; set; }
        public string CartId { get; set; }
        public int ItemId { get; set; }
        public int Count { get; set; }
        public System.DateTime DateCreated { get; set; }
        public virtual Product Item { get; set; }
    }
}