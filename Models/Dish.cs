using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;


namespace chefsNdishes.Models
{
    public class Dish
    {
        [Key]
        public int DishId {get;set;}

        [Required(ErrorMessage = "Please enter a dish name!")]
        public string Name {get;set;}


        [Required(ErrorMessage = "Please enter a level of tastiness!")]
        public int Tastiness {get;set;}

        [Required]
        [Range(1, Int32.MaxValue, ErrorMessage = "Cmon, aint no such thing as no calories fam!")]
        public int Calories {get;set;}

        [Required]
        public string Description {get;set;}

        [Required]
        public int ChefId {get;set;}

        public Chef Creator {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;

        public DateTime UpdatedAt {get;set;} = DateTime.Now;
       
    }
}