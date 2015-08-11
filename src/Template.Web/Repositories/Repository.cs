using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template.Web.Model.Entities;

namespace Template.Web.Repositories
{
    public abstract class Repository
    {
        public TemplateContext Context { get; set; }

        public Repository(TemplateContext context)
        {
            Context = context;
        }
    }
}
