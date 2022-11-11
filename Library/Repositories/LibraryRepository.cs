using System.Diagnostics.CodeAnalysis;
using Library.Models;
using Library.Utilities;

namespace Library.Repositories
{
    public class LibraryRepository
    {
        //private DbContext _dbContext;

        public LibraryRepository()
        {
            //_dbContext = new DbContext();
        }

        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return DbContext.Books();
        }
    }
}
