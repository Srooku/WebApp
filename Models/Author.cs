using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string AuthorName { get; set; }
        public DateTime DateBirth { get; set; }
        public DateTime DateDeath { get; set; }

        public Author()
        {

        }
    }
}
