using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using REST_API.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST_API.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
    
            if (!content.Autor.Any()) content.Autor.AddRange(AutorB.Select(c => c.Value));

            if (!content.Book.Any()) { content.AddRange(
                    new Books
                    {
                        name = "Доктор Живаго",
                        autor = AutorB["Булгаков Михаил"],
                        desc = "Книга затрагивает тайну жизни и смерти",
                        stat = true
                    },
                    new Books
                    {
                        name = "Новое откровение",
                        autor = AutorB["Конан Дойл"],
                        desc = "Автобиографический религиозно-философский трактат",
                        stat = false
                    },
                    new Books
                    {
                        name = "Карты на стол",
                        autor = AutorB["Агата Кристи"],
                        desc = "Расследуют сразу четыре персонажа",
                        stat = false
                    },
                    new Books
                    {
                        name = "Слушай песню ветра",
                        autor = AutorB["Харуки Мураками"],
                        desc = "Написан в два приёма",
                        stat = true
                    },
                    new Books
                    {
                        name = "Собачье сердце",
                        autor = AutorB["Булгаков Михаил"],
                        desc = "Сохранились три редакции текста ",
                        stat = true
                    }

               );}

            content.SaveChanges();

        }

        private static Dictionary<string, Autors> autor;
        public static Dictionary<string, Autors> AutorB
        {
            get
            {
                if (autor == null)
                {
                    var list = new Autors[]
                    {
                        new Autors { autor="Булгаков Михаил"},
                        new Autors { autor="Конан Дойл"},
                        new Autors { autor="Агата Кристи"},
                        new Autors { autor="Харуки Мураками"},
                        new Autors { autor="Булгаков Михаил"},
                        new Autors { autor="Тургенев Иван"},
                        new Autors { autor="Пастернак Борис"},
                    };
                    autor = new Dictionary<string, Autors>();
                    foreach (Autors element in list) autor.Add(element.autor, element);
                }

                return autor;
            }
        }
    }
}
