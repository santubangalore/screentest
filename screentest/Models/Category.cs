using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ScreenTest.Models
{
    public class Catagorie
    {
        [Key]
        [DisplayName("Catagorie ID")]
        public int ID { get; set; }

        [DisplayName("Catagorie")]
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}