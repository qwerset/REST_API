using REST_API.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST_API.Data.Interfaces
{
    public interface IBooks
    {  
        IEnumerable<Books> AllBooks { get; }
        IEnumerable<Books> AutorBooks{ get; }
        Books getObjectBooks(int booksID);
    }
}
