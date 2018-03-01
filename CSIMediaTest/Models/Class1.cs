using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CSIMediaTest.Models
{
    public class CSIMediaTestDB : DbContext
    {
        public DbSet<Numbers> Numbers { get; set; }
    }
}