using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BestMovies.Models
{
    public class BestMoviesContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public BestMoviesContext() : base("name=BestMoviesContext")
        {
        }

        public System.Data.Entity.DbSet<BestMovies.Models.Movie> Movies { get; set; }

        public System.Data.Entity.DbSet<BestMovies.Models.Genre> Genres { get; set; }

        public System.Data.Entity.DbSet<BestMovies.Models.Actor> Actors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
