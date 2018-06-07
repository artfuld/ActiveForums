using DotNetNuke.Modules.ActiveForums.DAL2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetNuke.Modules.ActiveForums
{
    public static class RecycleBin
    {
        public static void RestoreReply(int replyId)
        {
            DataProvider.Instance().Reply_Restore(replyId);
        }

        public static void RestoreTopic(int topicId)
        {
            DataProvider.Instance().Topics_Restore(topicId);
        }

        public static void DeleteReply(int replyId)
        {

        }

        public static void DeleteTopic(int topicId)
        {

        }
    }
}
