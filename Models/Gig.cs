using System;
using System.ComponentModel.DataAnnotations;

namespace GigHub2.Models
{
    public class Gig
    {
        public int Id { get; set; }

        [Required]
        public ApplicationUser Artist { get; set; }//who

        public DateTime DateTime { get; set; }//when

        [Required]
        [StringLength(255)]
        public string Venue { get; set; }//where

        [Required]
        public Genre Genre { get; set; }//genre

    }
}