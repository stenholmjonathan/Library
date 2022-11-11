using Library.Models;

namespace Library.Utilities
{
    public static class DbContext
    {
        public static bool IsOpen { get; set; }
        public static IEnumerable<Book> Books()
        {
            if (IsOpen)
            {
                IsOpen = false;

                var books = new List<Book>();

                books.Add(new Book()
                {
                    Id = "B1",
                    Author = "Gustav",
                    Title = "Gustav Vasa",
                    Genre = "Historia",
                    Price = 10,
                    PublisheDate = "2010-10-01",
                    Description = "Om Gustav Vasa"
                });

                books.Add(new Book()
                {
                    Id = "B2",
                    Author = "Fredrik",
                    Title = "Fredrik Vasa",
                    Genre = "Historia",
                    Price = 10,
                    PublisheDate = "2010-10-01",
                    Description = "Om Gustavs bror"
                });

                IsOpen = true;

                return books;
            }

            return null;
        }
    }
}
