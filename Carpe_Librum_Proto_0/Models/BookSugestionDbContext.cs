using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace Carpe_Librum_Proto_0.Models
{
    public class BookSugestionDbContext:DbContext
    {
        public DbSet<BookSugestion> BookSugestionSet { get; set; }
        public BookSugestionDbContext():base("CarpeLibrum_22")
        {
            Database.SetInitializer(new DatabaseInitialiser());
        }
    }
}