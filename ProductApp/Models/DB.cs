using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProductApp.Models
{
    public class DB: DbContext
    {
        public DB() : base("DefaultConnection")
        {
        }

        public DbSet<ReviewModels> Reviews { get; set; }
    }
}