using SecurityTest.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SecurityTest.Models
{
    public class PersonContext : DbContext
    {
        public PersonContext() : base("name=PersonContext")
        {
        }

        public DbSet<Person> People { get; set; }
        public DbSet<user> users { get; set; }
        public DbSet<userRole> userRole { get; set; }
    }
}
