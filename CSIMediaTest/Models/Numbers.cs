using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CSIMediaTest.Models
{
    [Table("Numbers")]
    public class Numbers
    {
        [Key]
       public int ID { get;  set; }
       public int Number { get; set; }
    }
}