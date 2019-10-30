using REST_API.Data.Interfaces;
using REST_API.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST_API.Data.Mocks
{
    public class MockBooks : IBooks

    {
        private readonly IAutors _autorname = new MockAutors();
        public IEnumerable<Books> AllBooks {
            get
            {
                return new List<Books> {
                    new Books { name="Доктор Живаго",
                        autor = _autorname.AllAutors.ElementAtOrDefault(1),
                        desc ="Книга затрагивает тайну жизни и смерти",
                        stat =true},
                    new Books { name="Новое откровение",
                        autor = _autorname.AllAutors.ElementAtOrDefault(2),
                        desc ="Автобиографический религиозно-философский трактат",
                        stat =false},
                    new Books { name="Карты на стол",
                        autor = _autorname.AllAutors.ElementAtOrDefault(3),
                        desc ="Расследуют сразу четыре персонажа",
                        stat =false},
                    new Books { name="Слушай песню ветра",
                        autor =_autorname.AllAutors.ElementAtOrDefault(4),
                        desc ="Написан в два приёма",
                        stat =true},
                    new Books { name="Собачье сердце",
                        autor =_autorname.AllAutors.ElementAtOrDefault(1),
                        desc ="Сохранились три редакции текста ",
                        stat =true},

                };
            }
            set { }
        }
        public IEnumerable<Books> AutorBooks { get; set ; }

        public Books getObjectBooks(int booksID)
        {
            throw new NotImplementedException();
        }
    }
}
