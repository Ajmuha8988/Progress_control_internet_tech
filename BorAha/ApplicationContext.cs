using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BorAha
{
    class ApplicationContext : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Save> Saves { get; set; }

        public ApplicationContext() : base("DefaultConnection")
        {

        }
    }
}
