using DotNetNuke.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetNuke.Modules.ActiveForums.DAL2
{
    class ContentController
    {
        IDataContext ctx;
        IRepository<Content> repo;

        public ContentController()
        {
            ctx = DataContext.Instance();
            repo = ctx.GetRepository<Content>();
        }

        public Content Get(int contentId)
        {
            var content = repo.GetById(contentId);
            return content;
        }

        public IEnumerable<Content> Get(string ids)
        {
            var contents = repo.Find($"WHERE ContentId in ({ids})");
            return contents;
        }

        public void Save(Content content)
        {
            if (content.ContentId > 0)
            {
                repo.Update(content);
            }
            else
            {
                repo.Insert(content);
            }
        }
    }
}
