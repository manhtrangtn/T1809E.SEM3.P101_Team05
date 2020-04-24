using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;
using T1809E.SEM3.P101_Team05.Models;

namespace T1809E.SEM3.P101_Team05.Data
{
    public class DatabaseContext : IdentityDbContext<Account>
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public DatabaseContext() : base("name=DatabaseContext")
        {
        }

        public System.Data.Entity.DbSet<T1809E.SEM3.P101_Team05.Models.Product> Products { get; set; }
    }
}
