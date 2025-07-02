using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DevCard.Models;

namespace DevCard.Data
{
    public class DevCardContext : DbContext
    {
        public DevCardContext (DbContextOptions<DevCardContext> options)
            : base(options)
        {
        }

        public DbSet<DevCard.Models.Project> Project { get; set; }
    }
}
