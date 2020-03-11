using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Web.UI.WebControls.WebParts;

public partial class MasterPageSayfalar : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("http://www.fatihyildizhan.com/rss/rssYayini.aspx");
    }
}
