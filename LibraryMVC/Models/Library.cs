using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryMVC.Models
{
    public class Library
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Rent_D { get; set; }
        public string Rent_L { get; set; }
        public string Avail { get; set; }
    }
}