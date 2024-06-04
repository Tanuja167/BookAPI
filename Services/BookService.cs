using BookAPI.Models;
using BookAPI.Repository;

namespace BookAPI.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepo repo;  //This field will hold an instance of a class that implements the IBookRepo interface.

        public BookService(IBookRepo repo)  //This allows the BookService class to use the functionalities provided by any class that implements IBookRepo.
        {
            this.repo = repo;
        }
        public int AddBook(Book book)
        {
            return repo.AddBook(book);
        }

        public int DeleteBook(int id)
        {
            return repo.DeleteBook(id);
        }

        public Book GetBookById(int id)
        {
            return repo.GetBookById(id);
        }

        public IEnumerable<Book> GetBooks()
        {
            return repo.GetBooks();
        }

        public int UpdateBook(Book book)
        {
            return repo.UpdateBook(book);
        }
    }
}