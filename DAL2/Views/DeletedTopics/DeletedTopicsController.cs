using DotNetNuke.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetNuke.Modules.ActiveForums.DAL2
{
    class DeletedTopicsController
    {
        IDataContext ctx;
        IRepository<DeletedTopic> rep;

        public DeletedTopicsController()
        {
            ctx = DataContext.Instance();
            rep = ctx.GetRepository<DeletedTopic>();
        }

        public IEnumerable<DeletedTopic> Get(int moduleId)
        {
            var deletedTopics = rep.Get(moduleId);
            return deletedTopics;
        }
    }
}
