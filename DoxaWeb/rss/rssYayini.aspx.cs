using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web.Caching;
using System.Data;

public partial class rssYayini : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ImageButton1_Command(object sender, CommandEventArgs e)
    {
        Response.Redirect("http://www.fatihyildizhan.com/rss/fydoxaJAVA.xml");
    }
    protected void ImageButton2_Command(object sender, CommandEventArgs e)
    {
        Response.Redirect("http://www.fatihyildizhan.com/rss/fydoxaCSHARP.xml");
    }
}
