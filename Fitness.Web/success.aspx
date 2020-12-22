<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="success.aspx.cs" Inherits="Fitness.Web.success" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="viewport" content="initial-scale=1.0, maximum-scale=1.0, user-scalable=no"/>
    <title>HOLOFIT</title>
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
        <div class="contentbox infbg success">
            <img class="inflogo" src="img/logo.png"/>
            <p>恭喜你，预约成功</p>
            <p>- 时间 -</p>
            <p>11月26日 18:30 - 20:30</p>
            <p>- 活动名称 -</p>
            <p>某某活动</p>
            <p>- 活动地址 -</p>
            <p>南京西路180号</p>
            <p>- 联系方式 -</p>
            <p>021-88888888 吴先生</p>
            <button class="btn success_top">确认</button>
        </div>
    </div>
</form>
</body>
</html>