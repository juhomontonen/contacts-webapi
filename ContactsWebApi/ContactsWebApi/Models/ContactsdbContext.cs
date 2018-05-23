using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsWebApi.Models
{
    public class ContactsdbContext : DbContext
    {
        public ContactsdbContext(DbContextOptions options) : base(options) { }

        public DbSet<Contact>    Contacts { get; set; }
    }
}
