using REST_API.Data.Interfaces;
using REST_API.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST_API.Data.Mocks
{
    public class MockAutors : IAutors
    {
        public IEnumerable<Autors> AllAutors {
            get {
                return new List<Autors> {
                    new Autors { autor="Булгаков Михаил"},
                    new Autors { autor="Конан Дойл"},
                    new Autors { autor="Агата Кристи"},
                    new Autors { autor="Харуки Мураками"},
                    new Autors { autor="Булгаков Михаил"},
                    new Autors { autor="Тургенев Иван"},
                    new Autors { autor="Пастернак Борис"},
                };
            }
            set { }
        }
    }
}
