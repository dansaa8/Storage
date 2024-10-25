using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Storage.Models;

namespace Storage.Data
{
    // En klass som använder sig av EntityFramework(ORM mappar mellan databasen och vår C# kod).
    public class StorageContext : DbContext
    {
        public StorageContext (DbContextOptions<StorageContext> options)
            : base(options)
        {   
        }

        // Denna property använder vi oss av för att hämta data från databasen
        public DbSet<Storage.Models.Product> Product { get; set; } = default!;
    // En klass som använder sig av EntityFramework(ORM mappar mellan databasen och vår C# kod).
    }
}
