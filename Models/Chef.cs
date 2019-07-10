using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;

namespace chefsNdishes.Models
{
    // public class isEighteen : ValidationAttribute
    // {
    //     protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    //     {
    //         int age = 0;  
    //         age = DateTime.Now.Year - value.Year;  
    //         if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)  
    //             age = age - 1;  
    //         if (age < 18)
    //             return new ValidationResult("Need to be at least Eighteen Years Old");
    //         return ValidationResult.Success;
    //     }
    // }

    public class Chef
    {
        [Key]
        public int ChefId {get;set;}

        [Required(ErrorMessage = "Please enter a first name!")]
        public string FName {get;set;}

        [Required(ErrorMessage = "Please enter a last name!")]
        public string LName {get;set;}

        [Required(ErrorMessage = "Please enter a birthday!")]
        public DateTime Birthday {get;set;}

        public List<Dish> DishesCreated {get;set;}

        public int Age {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;

        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}