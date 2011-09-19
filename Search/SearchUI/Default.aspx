<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    网址：<a href="http://www.jobbaidu.com/Commons/ListPosition!list.shtml" target="_blank">http://www.jobbaidu.com/Commons/ListPosition!list.shtml</a>
    <br /><asp:Button ID="Button1" runat="server" Text="加载富海人才网数据" onclick="Button1_Click" /><br /><br />
    网址：<a href="http://www.jnjobs.cn/Search/JobsList.aspx?key=&keytype=&workarea=&jobpost=&industry=&starteducation=10&endeducation=70&stratworkexperience=01&endworkexperience=13&age=16&sex=&iseducationnull=True&isworkexperiencenull=True&isagenull=True&showno=10" target="_blank">http://www.jnjobs.cn/Search/JobsList.aspx?key=&keytype=&workarea=&jobpost=&industry=&starteducation=10&endeducation=70&stratworkexperience=01&endworkexperience=13&age=16&sex=&iseducationnull=True&isworkexperiencenull=True&isagenull=True&showno=10</a>
    <br /><asp:Button ID="Button2" runat="server" Text="加载聚能人才网数据" 
        onclick="Button2_Click" /><br /><br />
        网址：<a href="http://open.baidu.com/zhaopin/s?wd=%BB%DD%D6%DD%D5%D0%C6%B8&rn=20&p=mini&tn=baiduzhaopin&type=" target="_blank">http://open.baidu.com/zhaopin/s?wd=%BB%DD%D6%DD%D5%D0%C6%B8&rn=20&p=mini&tn=baiduzhaopin&type=</a>
    <br /><asp:Button ID="Button3" runat="server" Text="加载百度惠州招聘数据" 
        onclick="Button3_Click" /><br /><br />
    <asp:Button ID="Button4" runat="server" Text="加载以上3个网站的数据到postion表" 
        onclick="Button4_Click" />
    </form>
</body>
</html>
