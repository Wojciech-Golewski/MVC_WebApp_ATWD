using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVC_WebApp_ATWD.Models
{
    public class MVC_WebApp_ATWDContext : DbContext
    {
        public MVC_WebApp_ATWDContext (DbContextOptions<MVC_WebApp_ATWDContext> options)
            : base(options)
        {
        }

        public DbSet<MVC_WebApp_ATWD.Models.Movie> Movie { get; set; }
    }
}
