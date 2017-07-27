using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BestMovies.Models
{
    public class Actor
    {
        [Key]
        public int ActorID { get; set; }
        public string AtorName { get; set; }
        public DateTime DOB { get; set; }
        public string Nationality { get; set; }
        public string Gender { get; set; }


        public virtual ICollection<Movie> Movies { get; set; }
    }
}