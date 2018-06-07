using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using System.Web.DynamicData;
using DotNetNuke.Modules.ActiveForums.DAL2;
using System.Collections.Generic;

namespace DotNetNuke.Modules.ActiveForums
{
    public partial class admin_recyclebin_replies : ActiveAdminBase
    {
        IEnumerable<DeletedReplies> deletedPosts;
        
        protected override void OnLoad(EventArgs e)
        {

            var deletedPostsManager = new DeletedPostsController();
            deletedPosts = deletedPostsManager.Get(ModuleId);

            rptRecycledPosts.DataSource = deletedPosts;
            rptRecycledPosts.DataBind();
            base.OnLoad(e);
        }
    }
}
