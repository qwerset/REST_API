using Microsoft.AspNetCore.Mvc;
using REST_API.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST_API.Data.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBooks _allBooks;
        private readonly IAutors _allAutors;

        [HttpGet]
        [Route("/[Controller]")]

        public ActionResult<IEnumerable<string>> List()
        {
            var books = _allBooks.AllBooks;
            return View(books);
        }

        public BooksController(IBooks iAllBooks, IAutors iAllAutors)
        {
            _allBooks = iAllBooks;
            _allAutors = iAllAutors;
        }
          
       
    }
}
