using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AzureOps_SampleApp.Models;

namespace AzureOps_SampleApp.Data
{
    public class AzureOps_SampleAppContext : DbContext
    {
        public AzureOps_SampleAppContext (DbContextOptions<AzureOps_SampleAppContext> options)
            : base(options)
        {
        }

        public DbSet<AzureOps_SampleApp.Models.Person> Person { get; set; } = default!;
    }
}
