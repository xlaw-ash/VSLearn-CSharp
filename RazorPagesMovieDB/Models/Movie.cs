using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovieDB.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        
        [Display(Name = "Release")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        [Column(TypeName = "single(2,1)")]
        public float Rating { get; set; }
    }
}
