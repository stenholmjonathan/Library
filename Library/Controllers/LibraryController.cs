using Library.Services;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LibraryController : ControllerBase
    {
        private readonly ILogger<LibraryController> _logger;
        private LibraryService _libraryService;

        public LibraryController(ILogger<LibraryController> logger)
        {
            _libraryService = new LibraryService();
            _logger = logger;
        }

        [HttpGet(Name = "GetBooks")]
        public async Task<ActionResult> GetBooks()
        {
            var result = _libraryService.GetAllBooks();

            return Ok(result);
        }
    }
}