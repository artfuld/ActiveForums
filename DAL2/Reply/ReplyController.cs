using DotNetNuke.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetNuke.Modules.ActiveForums.DAL2
{
    class ReplyController
    {
        IDataContext ctx;
        IRepository<Reply> repo;

        public ReplyController()
        {
            ctx = DataContext.Instance();
            repo = ctx.GetRepository<Reply>();
        }

        public Reply Get(int replyId)
        {
            var reply = repo.GetById(replyId);
            return reply;
        }

        public Reply GetFromContentId(int contentId)
        {
            var reply = repo.Find($"WHERE ContentId = {contentId}").FirstOrDefault();
            return reply;
        }

        public void Save(Reply reply)
        {
            if (reply.ReplyId > 0)
            {
                repo.Update(reply);
            }
            else
            {
                repo.Insert(reply);
            }
        }

        public IEnumerable<Reply> GetFromTopicId(int topicId)
        {
            var replies = repo.Find($"WHERE TopicId = {topicId}");
            return replies;
        }
    }
}
