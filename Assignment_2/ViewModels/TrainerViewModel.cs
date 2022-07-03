using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Assignment_2.ViewModels
{
 

        public class Trainer
        {
            [Required(ErrorMessage = "Last name is required.")]
            [StringLength(50)]
            [Display(Name = "Last Name")]
            [RegularExpression("/^[a-zA-ZàáâäãåąčćęèéêëėįìíîïłńòóôöõøùúûüųūÿýżźñçčšžÀÁÂÄÃÅĄĆČĖĘÈÉÊËÌÍÎÏĮŁŃÒÓÔÖÕØÙÚÛÜŲŪŸÝŻŹÑßÇŒÆČŠŽ∂ð ,.'-]+$/u")]
            public string LastName { get; set; }


            [StringLength(30)]
            [Display(Name = "Middle Name")]
             [RegularExpression("/^[a-zA-ZàáâäãåąčćęèéêëėįìíîïłńòóôöõøùúûüųūÿýżźñçčšžÀÁÂÄÃÅĄĆČĖĘÈÉÊËÌÍÎÏĮŁŃÒÓÔÖÕØÙÚÛÜŲŪŸÝŻŹÑßÇŒÆČŠŽ∂ð ,.'-]+$/u")]

             public string MiddleName { get; set; }

            [Display(Name = "First Name")]
            [RegularExpression("/^[a-zA-ZàáâäãåąčćęèéêëėįìíîïłńòóôöõøùúûüųūÿýżźñçčšžÀÁÂÄÃÅĄĆČĖĘÈÉÊËÌÍÎÏĮŁŃÒÓÔÖÕØÙÚÛÜŲŪŸÝŻŹÑßÇŒÆČŠŽ∂ð ,.'-]+$/u")]

            [Required(ErrorMessage = "First name is required.")]
            [StringLength(50)]

            public string FirstName { get; set; }

            [RegularExpression("  [a-zA-Z]{2,}")]
            [Required(ErrorMessage = "Country is required.")]
            [StringLength(56)]

            public string Country { get; set; }

            [RegularExpression("^([a-zA-Z\u0080-\u024F]+(?:. |-| |))*[a-zA-Z\u0080-\u024F]*$")]
            [Required(ErrorMessage = "City is required.")]
            [StringLength(35)]
            public string City { get; set; }

            [RegularExpression("^([a-zA-Z\u0080-\u024F]+(?:. |-| |))*[a-zA-Z\u0080-\u024F]*$")]
            [Required(ErrorMessage = "Street name is required.")]
            [StringLength(35)]
            [Display(Name = "Street Name")]
            public string StreetName { get; set; }


            [Display(Name = "Street Number")]
            [Required(ErrorMessage = "Street Number is required.")]
            [RegularExpression("^([1 - 9]+[0-9]* | [1-9])$")]
            public ushort StreetNo { get; set; }

            [RegularExpression("^[a - zA - Z] *$")]
            [DataType(DataType.MultilineText)]
            public string Details { get; set; }

            [Required(ErrorMessage = "Name is required.")]
            [Display(Name = "Phone Number")]
            [Phone(ErrorMessage = "  phone format.")]
            public string PhoneNum { get; set; }

             [StringLength(35)]
             [RegularExpression("/^[a-zA-Z\\s]*$/")]
             public string Gender { get; set; }

            
            [DataType(DataType.Currency)]
            public decimal Salary { get; set; }

             [Required(ErrorMessage = " Postal code is required.")]
             [RegularExpression("^\\d{3}\\s{0,1}\\d{2}$")]
             public ushort PostalCode { get; set; }

             [StringLength(350)]
             [Required(ErrorMessage =" Email required.")]
             [EmailAddress(ErrorMessage =" Wrong Email Format.")]
            public string EmailAddress { get; set; }

            [DataType(DataType.Date)]

            public DateTime BirthDate { get; set; }

            [NotMapped]
            public int Age
            {
            get
            {
                return DateTime.Now.Year - BirthDate.Year;
            }
            }


            [NotMapped]
            public string FullName
            {
            get
            {
                return $" {FirstName} {MiddleName} {LastName}";

            }
          }

          

            [NotMapped]
            public string Address
            {
            get 
            {
                 return $" {Country} : \n \t\t {City} - {StreetName}.{StreetNo} {PostalCode}"; 
            }
        }
            
        }
    }

//    get {
//            if (Gender != "M" || Gender != "F")
//            {
//                return $" {FirstName} {MiddleName} {LastName}";
//            }
//           string GetFullNameByGender(string Gender) => Gender == "M" ? $"Mr {FirstName} {MiddleName} {LastName}" : $"Ms {FirstName} {MiddleName} {LastName}";
//            return GetFullNameByGender(FullName);


//}