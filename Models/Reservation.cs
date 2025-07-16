using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CofeeShopWebAPI.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        [Required] //This is Data Annotations
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage ="Email is not valid")] //This is Data Annotations
        public string Email { get; set; }
        [Required]
        [RegularExpression("^[0-9]*$", ErrorMessage ="Phone number is not valid")] //This is Data Annotations
        public string Phone { get; set; }
        [Required]
        public int TotalPeople { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        [DataType(DataType.Time)]
        public string Time { get; set; }
    }
}