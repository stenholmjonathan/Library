using System.Diagnostics.CodeAnalysis;
using Library.Models;
using Library.Utilities;

namespace Library.Repositories
{
    public class LibraryRepository
    {
        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return DbContext.Books();
        }
    }
}
