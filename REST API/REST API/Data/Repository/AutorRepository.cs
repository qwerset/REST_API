using REST_API.Data.Interfaces;
using REST_API.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST_API.Data.Repository
{
    public class AutorRepository : IAutors
    {

        private readonly AppDBContent appDBContent;

        public AutorRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Autors> AllAutors => appDBContent.Autor;
    }
}
