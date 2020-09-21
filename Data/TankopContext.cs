using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tankop.Models;


namespace Tankop.Data
{
    public class TankopContext :DbContext
    {
        public TankopContext(DbContextOptions<TankopContext> options) : base(options)
        {

        }
        public DbSet<Tanks> Tanks { get; set; }
    }
}
