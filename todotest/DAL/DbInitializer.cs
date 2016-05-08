using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace todotest.DAL
{
    public class DbInitializer : DropCreateDatabaseIfModelChanges<TodoContext>
    {

    }
}