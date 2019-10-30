using REST_API.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST_API.Data.Interfaces
{
    public interface IAutors
    {
        IEnumerable<Autors> AllAutors { get; }
    }
}
