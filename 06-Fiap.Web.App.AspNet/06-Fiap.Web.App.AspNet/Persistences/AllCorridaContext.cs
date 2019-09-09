using _06_Fiap.Web.App.AspNet.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_Fiap.Web.App.AspNet.Persistences
{
    public class AllCorridaContext :DbContext
    {
        public DbSet<Corrida> Corridas { get; set; }
        public AllCorridaContext(DbContextOptions options)
        : base(options) { }
    }
}
