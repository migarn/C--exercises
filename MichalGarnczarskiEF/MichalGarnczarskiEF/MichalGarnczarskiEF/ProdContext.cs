using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace MichalGarnczarskiEF
{
    class ProdContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
