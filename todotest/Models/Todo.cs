using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace todotest.Models
{
    public class Todo
    {
        public int TodoId { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Completed { get; set; }
        public string Description { get; set; }
        public bool Done { get; set; }

        public Todo()
        {
            this.Created = DateTime.Now;
        }

    }
}