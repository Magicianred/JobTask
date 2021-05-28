using JobTask.ServiceLayer;
using JobTask.ServiceLayer.Pension;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTask.DataLayer
{
    public class PensionDbContext : DbContext
    {
        public PensionDbContext(DbContextOptions<PensionDbContext> options)
            :base(options)
        {
        }

        /// <summary>
        /// all of tables
        /// </summary>
        public DbSet<PensionItemModel> PensionItems { get; set; }
    }
}
