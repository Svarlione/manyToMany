


using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp50.Database.Models
{


    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        public string LastName { get; set; }
        public List<Book> Books { get; set; }

    }//todo kompozicija i category

    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public List<BookCategory> BookCategories { get; set; }
    }//todo kompozicija i book

    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<BookCategory> BookCategories { get; set; }
    }

    public class BookCategory//many to many jungiamoji lentele
    {
        public int BookId { get; set; }
        public int CategoryId { get; set; }


        public Book Book { get; set; }

        public Category Category { get; set; }


    }

}
