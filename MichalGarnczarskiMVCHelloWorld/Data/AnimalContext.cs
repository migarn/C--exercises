using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MichalGarnczarskiMVCHelloWorld.Models;

namespace MichalGarnczarskiMVCHelloWorld.Data
{
    public class AnimalContext : DbContext
    {
        public AnimalContext (DbContextOptions<AnimalContext> options)
            : base(options)
        {
        }

        public DbSet<MichalGarnczarskiMVCHelloWorld.Models.Animal> Animal { get; set; }
    }
}
