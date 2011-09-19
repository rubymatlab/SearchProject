using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using ORM;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        FilterFuHai.Load();
        return;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        FilterJuNeng.Load();
        return;
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        FilterBaiduHuiZhou.Load();
        return;
    }
}
