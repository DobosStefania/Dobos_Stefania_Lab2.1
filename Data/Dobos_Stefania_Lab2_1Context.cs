using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Dobos_Stefania_Lab2._1.Models;

namespace Dobos_Stefania_Lab2._1.Data
{
    public class Dobos_Stefania_Lab2_1Context : DbContext
    {
        public Dobos_Stefania_Lab2_1Context (DbContextOptions<Dobos_Stefania_Lab2_1Context> options)
            : base(options)
        {
        }

        public DbSet<Dobos_Stefania_Lab2._1.Models.Book> Book { get; set; } = default!;

        public DbSet<Dobos_Stefania_Lab2._1.Models.Publisher> Publisher { get; set; }

        public DbSet<Dobos_Stefania_Lab2._1.Models.Category> Category { get; set; }
    }
}
