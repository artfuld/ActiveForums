using DotNetNuke.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetNuke.Modules.ActiveForums.DAL2
{
    [TableName("vw_activeforums_DeletedReplies")]
    [PrimaryKey("ContentId")]
    [Scope("ModuleId")]
    public class DeletedReplies
    {
        public int ReplyId { get; set; }
        public int ContentId { get; set; }
        public int ModuleId { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string AuthorName { get; set; }
    }
}
