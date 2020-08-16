using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminManageMovieWebApp._00Data
{
    public class Movie
    {

        public int Id { get; set; }
        [Required]

        public string Name { get; set; }
        [Required]

        public DateTime ReleaseDate { get; set; }
        //[Display(Name = "Release Date")]
        [DataType(DataType.Date)]

        public string Director { get; set; }
        [Required]

        public Languages Languages { get; set; }

        public string EmailID { get; set; }
        [Required(ErrorMessage = "Email id is required")]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
                            ErrorMessage = "Please enter a valid email address")]
        [EmailAddress]

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }

    public enum Languages
    { 
        [Display(Name ="English")] English,
        [Display(Name = "Chinese")] Chinese,
        [Display(Name = "Hindi")] Hindi,

    }
    
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }
        [Required]

        public int Code { get; set; }

    }
}


