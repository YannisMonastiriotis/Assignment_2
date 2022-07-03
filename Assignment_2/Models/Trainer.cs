using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Assignment_2.Models
{
    public class Trainer
    {


        [StringLength(50)]
        public string LastName { get; set; }


        [StringLength(30)]
        public string MiddleName { get; set; }


        [StringLength(50)]
        public string FirstName { get; set; }


        [StringLength(56)]
        public string Country { get; set; }

        [StringLength(35)]
        public string City { get; set; }



        [StringLength(35)]

        public string StreetName { get; set; }



        public ushort StreetNo { get; set; }

        [DataType(DataType.MultilineText)]
        public string Details { get; set; }

        public string PhoneNum { get; set; }

        [StringLength(10)]
        public string Gender { get; set; }

        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }


        [EmailAddress]
        public string EmailAddress { get; set; }


        public DateTime BirthDate { get; set; }

        [NotMapped]
        public int Age { get; }

        [NotMapped]
        public string FullName { get; }

        [NotMapped]
        public string Address { get; }

    }
}