using System.Linq;
using Template.Web.Model.Entities;

namespace Template.Web.Repositories
{
    public class UsersRepository : Repository
    {
        public UsersRepository(TemplateContext context) : base(context) { }

        public User[] ToList()
        {
            return Context.Users.ToArray();
        }
    }
}
