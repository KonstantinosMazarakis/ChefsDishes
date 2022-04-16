using System;
using System.ComponentModel.DataAnnotations;


namespace ChefsDishes.Models
{
    public class Dish
    {
        [Key]
        public int DishId {get;set;}
        [Required]
        public string DishName {get;set;}
        [Required]
        [Range(0,double.PositiveInfinity)]
        public int Calories {get;set;}
        [Required]
        public string Tastiness {get;set;}
        [Required]
        public string Description {get;set;}
        public int ChefId {get;set;}
        public Chef Chef {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}