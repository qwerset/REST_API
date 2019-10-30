using Microsoft.EntityFrameworkCore;
using REST_API.Data.Interfaces;
using REST_API.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST_API.Data.Repository
{
    public class BookRepository : IBooks
    {
        private readonly AppDBContent appDBContent;

        public BookRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Books> AllBooks => appDBContent.Book;
        public IEnumerable<Books> AutorBooks => appDBContent.Book.Include(c => c.autor);

        public Books getObjectBooks(int booksID) => appDBContent.Book.FirstOrDefault(p => p.id == booksID);
    }
}
