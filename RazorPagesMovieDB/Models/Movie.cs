using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovieDB.Models
{
    public class Movie
    {
        // Movie ID (Primary Key for Database)
        public int ID { get; set; }
        // Title of the movie
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }
        // Release date of the movie
        [Display(Name = "Release")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        // Genre of the movie
        public string Genre { get; set; }
        // IMdB Rating of the movie
        [Column(TypeName = "decimal(2,1)")]
        [Range(0, 10)]
        public float Rating { get; set; }
        // Run Time of the movie
        [Display(Name = "Run Time")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime RunTime { get; set; }
    }
}
