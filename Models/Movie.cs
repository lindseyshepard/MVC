using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Please enter First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Specify Employee Pay Grade")]
        public float Pay { get; set; }
        [Required(ErrorMessage = "Labor Hours")]
        public float Hours { get; set; }
        [Required(ErrorMessage = "Specify Pay Week")]

        [DataType(DataType.Date)]
        public DateTime PayWeek { get; set; }
        //public int ID { get; set; }
        //public string Title { get; set; }

        //[DataType(DataType.Date)]
        //public DateTime ReleaseDate { get; set; }
        //public string Genre { get; set; }
        //public decimal Price { get; set; }
    }
}