using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Template.Web.Model.Entities
{
    public class TemplateContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
