<%@ Page Language="C#" CodeBehind="BackstageManagement.aspx.cs" Inherits="Fitness.Web.BackstageManagement" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Title</title>
    <link rel="stylesheet" href="css/bootstrap.css">
</head>
<body>
<form id="HtmlForm" runat="server">
    <div class="container">
        <div>
            <div class="mb-3 mt-5">
                <div class="row">
                    <div class="col-2">
                        <asp:TextBox ID="TextBox1" runat="server" placeholder="Search" class="form-control"></asp:TextBox>
                    </div>
                    <div class="col-3">

                        <asp:DropDownList ID="DropDownList1" runat="server" class="form-select" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_OnSelectedIndexChanged">
                            <asp:ListItem Value="">请选则城市</asp:ListItem>

                        </asp:DropDownList>
                    </div>
                    <div class="col-3">
                        <asp:DropDownList ID="DropDownList2" runat="server" class="form-select" AutoPostBack="True">
                            <asp:ListItem Value="">请选择俱乐部</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="col-1">
                        <asp:Button ID="Button1" runat="server" Text="查询" class="btn btn-info rounded-pill px-3 text-white" OnClick="Button1_OnClick"/>
                    </div>

                </div>
            </div>
            <div class="mt-5">
                <div class="row">
                    <table class="table table-striped">
                        <asp:Repeater ID="Repeater1" runat="server">
                            <HeaderTemplate>
                                <thead>
                                <tr>
                                    <th>手机号</th>
                                    <th>姓名</th>
                                    <th>预约时间</th>
                                    <th>性别</th>
                                    <th>所在城市</th>
                                    <th>俱乐部名称</th>
                                    <th>教室容纳人数</th>
                                    <th>已报人数</th>
                                    <th>地址</th>
                                    <th>联系电话/活动联系人</th>
                                </tr>
                                </thead>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <tr>
                                    <td><%#Eval("Reservation_User_Phone") %></td>
                                    <td><%#Eval("Reservation_User_Name") %></td>
                                    <td><%#Eval("Reservation_User_Create_Time") %></td>
                                    <td><%#Eval("Reservation_User_Sex").ToString() == "1" ? "男" : "女" %></td>
                                    <td><%#Eval("Fitness_Club_City") %></td>
                                    <td><%#Eval("Fitness_Club_Name") %></td>
                                    <td><%#Eval("Fitness_Club_User") %></td>
                                    <td><%#Eval("Reservation_Activity_Number") %></td>
                                    <td><%#Eval("Fitness_Club_Address") %></td>
                                    <td><%#Eval("Fitness_Club_Phone") %>/<%#Eval("Fitness_Club_Contact") %></td>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                    </table>
                </div>
            </div>
        </div>
    </div>
</form>
<script src="js/bootstrap.js"></script>
</body>
</html>