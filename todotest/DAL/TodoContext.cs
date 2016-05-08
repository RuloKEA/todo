using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using todotest.Models;

namespace todotest.DAL
{
    public class TodoContext: DbContext
    {
        public DbSet<Todo> Todos { get; set; }
        public TodoContext():base("appharborcs")
        {
        }
    }
}