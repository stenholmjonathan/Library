using Library.Models;
using Library.Repositories;

namespace Library.Services;

public class LibraryService
{
    private LibraryRepository _libraryRepository;

    public LibraryService()
    {
        _libraryRepository = new LibraryRepository();
    }

    public async Task<IEnumerable<Book>> GetAllBooks()
    {
        return await _libraryRepository.GetAllBooks();
    }
}

