using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Template.Core.Model.Entities
{
    internal class TemplateContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
