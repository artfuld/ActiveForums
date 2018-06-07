using DotNetNuke.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetNuke.Modules.ActiveForums.DAL2
{
    public class DeletedPostsController
    {
        IDataContext ctx;
        IRepository<DeletedReplies> rep;

        public DeletedPostsController()
        {
            ctx = DataContext.Instance();
            rep = ctx.GetRepository<DeletedReplies>();
        }

        public IEnumerable<DeletedReplies> Get(int moduleId)
        {
            var deletedPosts = rep.Get(moduleId);
            return deletedPosts;
        }
    }
}