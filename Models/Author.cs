﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Dobos_Stefania_Lab2._1.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public ICollection<Book>? Books { get; set; }

    }
}