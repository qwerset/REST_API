using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST_API.Data.Models
{
    public class Books
{
    public int id { set; get; }

    public string name { set; get; }

    public virtual Autors autor { set; get; }

    public string desc { set; get; }

    public bool stat { set; get; }
}
}
