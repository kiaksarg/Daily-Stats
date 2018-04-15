using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Person
    {
        [Required]
        [Key]
        public Int64 Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public byte Type { get; set; }
        public int Rank { get; set; }
        //public bool IsVazife { get; set; }
        //public bool IsPayvar { get; set; }

        public bool IsBede { get; set; }
        public DateTime OffStartDate { get; set; }
        public DateTime OffEndDate { get; set; }

        public bool Enabled { get; set; }

        public State State { get; set; }
        public Property Property { get; set; }

    }
}
