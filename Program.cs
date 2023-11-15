using ConsoleApp50.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp50
{
    internal class Program
    {
        //    public void Books()
        //    {
        //        var sunrise = new Author { LastName = "Sunrise" };
        //        var some = new Author { LastName = "Some" };
        //        var liberty = new Author { LastName = "Liberty" };
        //        DbContext.Authors.AddRange(sunrise, some, liberty);
        //        DbContext.SaveChanges();

        //        var summerTime = new Book { Title = "Sumerr Time", Year = 2000, Author = sunrise);




        //}
        static void Main(string[] args)
        {
            var dbContext = new BookContext(new DbContextOptionsBuilder<BookContext>().UseSqlServer($"Server=(localdb)\\mssqllocaldb;Database=netau2;Trusted_Connection=True;").Options);
            dbContext.Database.EnsureDeleted();
            dbContext.Database.EnsureCreated();



        }
    }
}