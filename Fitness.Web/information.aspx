<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="information.aspx.cs" Inherits="Fitness.Web.information" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>HOLOFIT</title>
    <meta name="viewport" content="initial-scale=1.0, maximum-scale=1.0, user-scalable=no"/>
    <link rel="stylesheet" type="text/css" href="css/style.css"/>
    <script type="text/javascript">
        			(function(doc, win) {
        				var docEl = doc.documentElement,
        					resizeEvt = 'orientationchange' in window ? 'orientationchange' : 'resize',
        					recalc = function() {
        						var clientWidth = docEl.clientWidth;
        						if(!clientWidth) return;
        						docEl.style.fontSize = 16 * (clientWidth / 375) + 'px'; 
        					};
        
        				if(!doc.addEventListener) return;
        				win.addEventListener(resizeEvt, recalc, false);
        				doc.addEventListener('DOMContentLoaded', recalc, false);
        			})(document, window);
        		</script>
</head>
<body>
<form id="form1" runat="server">
    <div>
        <div class="contentbox infbg">
            <img class="inflogo" src="img/logo.png"/>
            <div>
                <%--<select>
                    <option value="城市">城市</option>
                </select>--%>
                <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_OnSelectedIndexChanged" AutoPostBack="True">
                    <asp:ListItem Value="">城市名称</asp:ListItem>
                </asp:DropDownList>

            </div>
            <div>
                <%--<select>
                        <option value="俱乐部名称">俱乐部名称</option>
                    </select>--%>
                <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True">
                    <asp:ListItem Value="">俱乐部名称</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div>
                <%-- <input type="text" placeholder="姓名"/> --%>
                <asp:TextBox ID="TextBox1" runat="server" placeholder="姓名"></asp:TextBox>
            </div>
            <div>
                <%-- <input type="text" placeholder="手机号码"/> --%>
                <asp:TextBox ID="TextBox2" runat="server" placeholder="手机号码"></asp:TextBox>

            </div>
            <div>
                <%--<select>
                    <option value="俱乐部名称">请选择性别</option>
                </select>--%>
                <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True">
                    <asp:ListItem Value="">请选择性别</asp:ListItem>
                    <asp:ListItem Value="1">男</asp:ListItem>
                    <asp:ListItem Value="0">女</asp:ListItem>

                </asp:DropDownList>
            </div>
            <%-- <button id="Button1" class="btn btn_top" >确认预约</button> --%>
            <asp:Button ID="Button1" CssClass="btn btn_top confirmBtn" runat="server" OnClick="Button1_OnClick" Text="确认预约"/>
        </div>
    </div>
</form>
</body>
</html>