using EFCoreTutorial.Models.Domain;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreTutorial.Controllers
{
    public class BookController : Controller
    {
        private readonly DatabaseContext _ctx;

        public BookController(DatabaseContext ctx)
        {
            _ctx = ctx;
        }
        public IActionResult Index()
        {
            var booksWithGenres = (from book in _ctx.Book
                                  join bookGenre in _ctx.BookGenre on book.Id equals bookGenre.BookId
                                  join genre in _ctx.Genre on bookGenre.GenreId equals genre.Id
                                   select new
                                   {
                                       BookId = book.Id,
                                       Title = book.Title,
                                       GenreId = genre.Id,
                                       GenreName = genre.Name
                                   }).ToList();

            return Json(booksWithGenres);
        }
 
    }
}
