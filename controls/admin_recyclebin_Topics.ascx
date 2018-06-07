<%@ Control Language="C#" CodeBehind="admin_recyclebin_topics.ascx.cs" Inherits="DotNetNuke.Modules.ActiveForums.admin_recyclebin_topics" %>
<script type="text/javascript">
    function amaf_deleteRecyclebinItem(row) {
        if (confirm('Vill du verkligen ta bort tråden med ämne ' + row.cells[1].firstChild.nodeValue)) {
            var data = {};
            data.action = 14;
            data.TopicId = row.cells[0].firstChild.nodeValue;
            afadmin_callback(JSON.stringify(data));
        }
    }

    function amaf_restoreRecyclebinItem(row) {
        if (confirm('Vill du återställa tråden med ämne ' + row.cells[1].firstChild.nodeValue)) {
            var data = {};
            data.action = 15;
            data.TopicId = row.cells[0].firstChild.nodeValue;
            afadmin_callback(JSON.stringify(data));
        }
    }
</script>

<div class="amcpsubnav"><span onclick="LoadView('recyclebin_replies');" class="amcplnkbtn">Deleted posts</span> <span onclick="LoadView('recyclebin_topics')" class="amcplnkbtn">Deleted topics</span></div>
<div class="amcpbrdnav">[RESX:Recyclebin] [RESX:RecycledTopics]</div>
<div class="amcpcontrols">
    <asp:Repeater ID="rptRecycledTopics" runat="server">
        <HeaderTemplate>
            <table cellpadding="2" cellspacing="0" border="0" class="amGrid" style="width:100%;">
				<tr>
                    <td ColumnName="FilterId" style="display:none;width:0px;"></td>
                    <td class="amcptblhdr" ColumnName="Find" style="width:100px;height:16px;">
                        <div class="amheadingcelltext">[RESX:Subject]</div>
                    </td>
                    <td class="amcptblhdr" ColumnName="Replace" style="height:16px;">
                        <div class="amheadingcelltext">[RESX:Body]</div>
                    </td>
                    <td class="amcptblhdr" ColumnName="FilterType" style="height:16px;white-space:nowrap;width:120px;">
                        <div class="amheadingcelltext">[RESX:AuthorName]</div>
                    </td>
                    <td class="amcptblhdr" style="height:16px;white-space:nowrap;width:30px;">
                        <div class="amheadingcelltext">&nbsp;</div>
                    </td>
				</tr>
        </HeaderTemplate>
		<ItemTemplate>
			<tr class="amdatarow">
				<td style="display:none;"><%# Eval("TopicId") %></td>
				<td class="amcpnormal" onclick="amaf_restoreRecyclebinItem(this.parentNode)"><%# Eval("Subject") %></td>
				<td class="amcpnormal" resize="true" onclick="amaf_restoreRecyclebinItem(this.parentNode)"><%# Eval("Body")%></td>
				<td class="amcpnormal" style="white-space:nowrap;" onclick="amaf_restoreRecyclebinItem(this.parentNode)"><%# Eval("AuthorName") %></td>
<%--                <td><img src="/desktopmodules/activeforums/images/delete16.png" onclick="amaf_deleteRecyclebinItem(<%# Eval("TopicId") %>" /></td>--%>
            </tr>
        </ItemTemplate>
		<FooterTemplate>
            </table>
		</FooterTemplate>
    </asp:Repeater>
</div>