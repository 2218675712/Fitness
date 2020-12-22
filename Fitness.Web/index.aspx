<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Fitness.Web.index" %>

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
        <div class="contentbox boxbg3">
            <img class="inflogo" src="img/logo.png"/>
            <img class="title" src="img/slogn.png"/>
            <p class="ptop">时间:12月22日&nbsp;10:30 - 20:30</p>
            <p>全国家俱乐部同步启动课程</p>
            <img class="rule" src="img/rule.png"/>
            <%-- <button class="btn rule_top">立即预约</button> --%>
            <asp:Button class="btn rule_top" ID="Button1" runat="server" Text="立即预约" OnClick="Button1_OnClick"/>
        </div>
    </div>
</form>
</body>
</html>