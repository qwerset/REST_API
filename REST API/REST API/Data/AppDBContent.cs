using Microsoft.EntityFrameworkCore;
using REST_API.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST_API.Data
{
    public class AppDBContent : DbContext 
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {
             
        }

        public DbSet<Autors> Autor { set; get; }
        public DbSet<Books> Book { set; get; }


    }
}
