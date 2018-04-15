using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace DataModel
{
    public class Property
    {
        [Required]
        [Key]
        public Int64 Id { get; set; }
        public string Address { get; set; }
        public string Caption { get; set; }
        [Required]
        public bool Enabled { get; set; }

        public ICollection<Person> People { get; set; }
    }
}
