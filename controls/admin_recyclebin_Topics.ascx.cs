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
    public partial class admin_recyclebin_topics : ActiveAdminBase
    {
        IEnumerable<DeletedTopic> deletedTopics;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            var deletedTopicsManager = new DeletedTopicsController();
            deletedTopics = deletedTopicsManager.Get(ModuleId);

            rptRecycledTopics.DataSource = deletedTopics;
            rptRecycledTopics.DataBind();
        }
    }
}
