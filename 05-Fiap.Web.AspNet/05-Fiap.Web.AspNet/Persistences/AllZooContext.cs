using _05_Fiap.Web.AspNet.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _05_Fiap.Web.AspNet.Persistences
{
    public class AllZooContext : DbContext
    {

        public DbSet<Zoo> Zoos { get; set; }

        public DbSet<Animal> Animals { get; set; }

        //construtor - ctor tab tab
        public AllZooContext(DbContextOptions op) : base (op)
        {

        }
    }
}
