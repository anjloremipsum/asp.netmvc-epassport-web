//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EPassport.Models
{
    using EPassport.Validations;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class PassportApplicant
    {
        public int id { get; set; }


        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Enter last name")]
        [StringLength(35, MinimumLength = 2, ErrorMessage = "Enter a valid last name")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Use letters only")]
        public string LastName { get; set; }


        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Enter first name")]
        [StringLength(35, MinimumLength = 2, ErrorMessage = "Enter a valid first name")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Use letters only")]
        public string FirstName { get; set; }


        [Display(Name = "Middle Name")]
        [Required(ErrorMessage = "Enter middle name")]
        [StringLength(35, MinimumLength = 2, ErrorMessage = "Enter a valid middle name")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Use letters only")]
        public string MiddleName { get; set; }


        [Display(Name = "Date of Birth ")]
        [Required(ErrorMessage = "Please select birth date")]
        [CurrentDate(ErrorMessage = "Please select a valid birtdate")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DateOfBirth { get; set; }


        [Display(Name = "Place of Birth")]
        [Required(ErrorMessage = "Enter place of birth")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Enter a valid place of birth")]
        [RegularExpression(@"^[a-zA-Z0-9\s]+$", ErrorMessage = "Use letters and numbers only")]
        public string PlaceOfBirth { get; set; }


        [Required(ErrorMessage = "Choose Civil Status")]
        [Display(Name = "Civil Status")]
        //[CivilStatusValue(ErrorMessage = "Enter name of your husband or wife")]
        //[DateMinimumAge(18, ErrorMessage = "{0} must be someone at least {1} years of age")]
        public string CivilStatus { get; set; }


        [Display(Name = "Complete Address ")]
        [Required(ErrorMessage = "Enter complete address")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Enter a valid Address")]
        [RegularExpression(@"^[a-zA-Z0-9\s]+$", ErrorMessage = "Use letters and numbers only")]
        public string CompleteAddress { get; set; }


        [Display(Name = "Telephone Number")]
        [StringLength(15, MinimumLength = 11, ErrorMessage = "Enter atleast 11 digits")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Use numbers only")]
        [DataType(DataType.PhoneNumber)]
        public string TelephoneNumber { get; set; }


        [Display(Name = "Mobile Number")]
        [Required(ErrorMessage = "Enter mobile number")]
        [StringLength(15, MinimumLength = 11, ErrorMessage = "Enter atleast 11 digits")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "User numbers only")]
        [DataType(DataType.PhoneNumber)]
        public string MobileNumber { get; set; }


        [Display(Name = "Present Occupation")]
        [StringLength(35, MinimumLength = 5, ErrorMessage = "Enter a valid occupation")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Use letters only")]
        public string PresentOccupation { get; set; }


        [Display(Name = "Work Address ")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Enter a valid Address")]
        [RegularExpression(@"^[a-zA-Z0-9\s]+$", ErrorMessage = "Use letters and numbers only")]
        public string WorkAddress { get; set; }



        [Display(Name = "Email Address ")]
        [Required(ErrorMessage = "Enter email address")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Enter a email Address")]
        [RegularExpression(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
+ "@"
+ @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$", ErrorMessage = "Invalid email address")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string EmailAddress { get; set; }



        [Display(Name = "Name of Husband/Wife")]
        [StringLength(35, MinimumLength = 2, ErrorMessage = "Enter a valid name")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Use letters only")]
        //[CivilStatusValue(ErrorMessage = "Enter name of your husband or wife")]
        public string NameofWifeorHusband { get; set; }


        [Display(Name = "Citizenship")]
        public string Citizenship { get; set; }


        [Display(Name = "Name of Father")]
        [Required(ErrorMessage = "Enter name of father")]
        [StringLength(35, MinimumLength = 5, ErrorMessage = "Enter a valid name")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Use letters only")]
        public string NameOfFather { get; set; }


        [Required(ErrorMessage = "Select citizenship")]
        [Display(Name = "Father's Citizenship")]
        public string FatherCitizenship { get; set; }


        [Display(Name = "Name of Mother")]
        [Required(ErrorMessage = "Enter name of mother")]
        [StringLength(35, MinimumLength = 5, ErrorMessage = "Enter a valid name")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Use letters only ")]
        public string NameOfMother { get; set; }


        [Required(ErrorMessage = "Select citizenship")]
        [Display(Name = "Mother's Citizenship")]
        public string MotherCitizenship { get; set; }


        [Display(Name = "Citizenship Acquired By")]
        [Required(ErrorMessage = "Please select one")]
        public string CitizenshipAcquiredBy { get; set; }



        [Display(Name = "Foreign Passport Holder")]
        [Required(ErrorMessage = "Please choose")]
        public string ForeignPassHolder { get; set; }


        [Display(Name = "Foreign Passport")]

        public string ForeignPassport { get; set; }


        [Display(Name = "Phil. Passport Holder")]
        [Required(ErrorMessage = "Please choose")]
        public string PhilPassHolder { get; set; }

        [Display(Name = "Latest Passport Number(Phil)")]
        [MinLength(9, ErrorMessage = "Enter atleast 9 characters")]
        [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "Enter letters and numbers only")]
        public string LatestPhilPassNumber { get; set; }


        [Display(Name = "Date Issued")]
        [CurrentDate(ErrorMessage = "Please select a valid date")]
        public Nullable<System.DateTime> DateIssuedPhPassNum { get; set; }


        [Display(Name = "Traveling Companion")]
        [StringLength(35, MinimumLength = 5, ErrorMessage = "Enter a valid name")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Use letters only")]
        public string MinorTravelingCompanion { get; set; }

        [Display(Name = "Relationship")]
        [StringLength(35, MinimumLength = 3, ErrorMessage = "Enter a valid relationship")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Use letters only")]
        public string CompanionRelationship { get; set; }



        [Display(Name = "Contact Number")]
        [StringLength(15, MinimumLength = 11, ErrorMessage = "Enter atleast 11 digits")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Use numbers only")]
        [DataType(DataType.PhoneNumber)]
        public string CompanionContactNum { get; set; }

        public string TermsAndConditions { get; set; }
    }
}
