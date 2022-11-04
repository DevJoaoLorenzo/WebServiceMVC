using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebServiceMVC.Models;

namespace WebServiceMVC.Data
{
    public class WebServiceMVCContext : DbContext
    {
        public WebServiceMVCContext (DbContextOptions<WebServiceMVCContext> options)
            : base(options)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);
        }

        public DbSet<WebServiceMVC.Models.Department> Department { get; set; } = default!;
        public DbSet<WebServiceMVC.Models.Seller> Seller { get; set; } = default!;
        public DbSet<WebServiceMVC.Models.SalesRecord> SalesRecord { get; set; } = default!;
        
    }
}
