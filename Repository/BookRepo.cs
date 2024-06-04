using BookAPI.Data;
using BookAPI.Models;

namespace BookAPI.Repository
{
    public class BookRepo : IBookRepo
    {
        private readonly ApplicationDbContext db;   //holds the instance of database context and allowing access to the database

        public BookRepo(ApplicationDbContext db)  //allow bookrepo class to interact with the DB
        {
            this.db = db;
        }
        public int AddBook(Book book)
        {

            db.Books.Add(book);
            int result = db.SaveChanges();            //savechanges into DB
            return result;
        }

        public int DeleteBook(int id)
        {
            int res = 0;
            var result = db.Books.Where(x => x.Id == id).FirstOrDefault();
            if (result != null)
            {
                db.Books.Remove(result); // remove from DbSet
                res = db.SaveChanges();
            }

            return res;
        }

        public Book GetBookById(int id)
        {
            var result = db.Books.Where(x => x.Id == id).SingleOrDefault();
            return result;
        }

        public IEnumerable<Book> GetBooks()
        {
            var result = from b in db.Books
                         select b;

            return result;
        }

        public int UpdateBook(Book book)
        {
            int res = 0;
            var result = db.Books.Where(x => x.Id == book.Id).FirstOrDefault();

            if (result != null)
            {
                result.Name = book.Name;
                result.Author = book.Author;
                result.Price = book.Price;

                res = db.SaveChanges();
            }

            return res;
        }
    }
}