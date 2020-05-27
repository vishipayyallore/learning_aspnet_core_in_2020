using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Simple.WebApp.Models;

namespace Simple.WebApp.Data
{
    public class SimpleWebAppContext : DbContext
    {
        public SimpleWebAppContext (DbContextOptions<SimpleWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<Simple.WebApp.Models.PersonInformation> Persons { get; set; }
    }
}
