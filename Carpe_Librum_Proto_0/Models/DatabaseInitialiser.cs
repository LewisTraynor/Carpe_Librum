using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace Carpe_Librum_Proto_0.Models
{
    public class DatabaseInitialiser : DropCreateDatabaseIfModelChanges<BookSugestionDbContext>
    {
        protected override void Seed(BookSugestionDbContext context)
        {

            BookSugestion b1 = new BookSugestion
            {
                Title = "ASP.NET Core In Action",
                Authour = "Andrew Lock",
                Publisher = "Manning Publications",
                PublicationDate = "30/05/2018",
                GetDateTime = DateTime.Now


            };

            BookSugestion b2 = new BookSugestion
            {
                Title = "The Lord of the Rings",
                Authour = "J. R. R. Tolkien",
                Publisher = "Allen & Unwin",
                PublicationDate = "29/07/1954",
                GetDateTime = DateTime.Now


            };


            BookSugestion b3 = new BookSugestion
            {
                Title = "The Wind in the Willows",
                Authour = "Kenneth Grahame",
                Publisher = "Methuen",
                PublicationDate = "01/04/1908",
                GetDateTime = DateTime.Now


            };


            BookSugestion b4 = new BookSugestion
            {
                Title = "Stuart Little",
                Authour = "E. B. White",
                Publisher = "Harper & Brothers",
                PublicationDate = "10/03/1945",
                GetDateTime = DateTime.Now


            };

            BookSugestion b5 = new BookSugestion
            {
                Title = "The Great Gatsby",
                Authour = "F. Scott Fitzgerald",
                Publisher = "Charles Scribner's Sons",
                PublicationDate = "10/04/1925",
                GetDateTime = DateTime.Now


            };


            context.BookSugestionSet.Add(b1);
            context.BookSugestionSet.Add(b2);
            context.BookSugestionSet.Add(b3);
            context.BookSugestionSet.Add(b4);
            context.BookSugestionSet.Add(b5);
            context.SaveChanges();


            base.Seed(context);

        }

    }
    
}