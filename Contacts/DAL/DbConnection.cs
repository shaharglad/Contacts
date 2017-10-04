using Contacts.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Contacts.DAL
{
    public class DbConnection : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
    }
}