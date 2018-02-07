using System;

namespace Fisher.Bookstore.Models
{

    public class Book
    {

        public int BookId { get; set; }

        public string Title { get; set; }

        public Author Author { get; set; }

        public void SellBook()
        {
            //code to sell book goes here
        }
        
    }
}