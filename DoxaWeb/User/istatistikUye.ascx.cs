using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Web.Security;

public partial class istatistik : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        XmlDocument xdom = new XmlDocument();
        xdom.Load(Server.MapPath("../hit.xml"));
        lblToplamHit.Text = xdom.ChildNodes[1].ChildNodes[0].InnerText;
        lblSonUye.Text = Functions.sonUyeGetir();
        lblKonuSayisi.Text = Functions.ToplamKonuSayisi().ToString();
        lblOnlineMisafir.Text = Application["OnlineMisafir"].ToString();
        lblOnlineUye.Text = Membership.GetNumberOfUsersOnline().ToString();
        lblUyeSayisi.Text = Membership.GetAllUsers().Count.ToString();
    }
}
