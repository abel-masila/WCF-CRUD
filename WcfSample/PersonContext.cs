using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WcfSample
{
    public class PersonContext:DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public PersonContext():base("Person")
        {

        }
    }
}