using Template.Web.Model.Entities;

namespace Template.Web.Repositories
{
    public class PersistentRepository : Repository
    {
        public PersistentRepository(TemplateContext context) : base(context) { }

        public void Persist()
        {
            Context.SaveChanges();
        }
    }
}
