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
        }

        public DbSet<WebServiceMVC.Models.Department> Department { get; set; } = default!;
    }
}
