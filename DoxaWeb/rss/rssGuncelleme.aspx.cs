using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Data.SqlClient;
using System.Web.Configuration;

public partial class rss_rssGuncelleme : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCSharpRSSGuncelle_Click(object sender, EventArgs e)
    {
        XmlDocument xdom = new XmlDocument();
        xdom.Load(Server.MapPath("fydoxaCSHARP.xml"));
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["LocalSqlServer"].ToString());
        SqlCommand com = new SqlCommand("SELECT MakaleId,MakaleAd,EklemeTarihi,Aciklama FROM [Makale] where KonuId=2", con);
        con.Open();
        SqlDataReader dr = com.ExecuteReader();
        while (dr.Read())
        {
            XmlNode nItem = xdom.CreateNode(XmlNodeType.Element, "item", "");

            XmlNode nTitle = xdom.CreateNode(XmlNodeType.Element, "title", "");
            nTitle.InnerText = dr["MakaleAd"].ToString();

            XmlNode nDescription = xdom.CreateNode(XmlNodeType.Element, "description", "");
            nDescription.InnerText = dr["Aciklama"].ToString();

            XmlNode nLink = xdom.CreateNode(XmlNodeType.Element, "link", "");
            nLink.InnerText = "http://www.fatihyildizhan.com/User/MakaleGoster.aspx?id=" + Convert.ToInt32(dr["MakaleId"]);

            XmlNode nPubDate = xdom.CreateNode(XmlNodeType.Element, "pubDate", "");
            nPubDate.InnerText = dr["EklemeTarihi"].ToString();

            nItem.AppendChild(nTitle);
            nItem.AppendChild(nDescription);
            nItem.AppendChild(nLink);
            nItem.AppendChild(nPubDate);

            xdom.ChildNodes[1].ChildNodes[0].AppendChild(nItem);
        }
        dr.Close();
        con.Close();
        xdom.Save(Server.MapPath("fydoxaCSHARP.xml"));
    }
    protected void btnJavaRSSGuncelle_Click(object sender, EventArgs e)
    {
        XmlDocument xdom = new XmlDocument();
        xdom.Load(Server.MapPath("fydoxaJAVA.xml"));
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["LocalSqlServer"].ToString());
        SqlCommand com = new SqlCommand("SELECT MakaleId,MakaleAd,EklemeTarihi,Aciklama FROM [Makale] where KonuId=1", con);
        con.Open();
        SqlDataReader dr = com.ExecuteReader();
        while (dr.Read())
        {
            XmlNode nItem = xdom.CreateNode(XmlNodeType.Element, "item", "");

            XmlNode nTitle = xdom.CreateNode(XmlNodeType.Element, "title", "");
            nTitle.InnerText = dr["MakaleAd"].ToString();

            XmlNode nDescription = xdom.CreateNode(XmlNodeType.Element, "description", "");
            nDescription.InnerText = dr["Aciklama"].ToString();

            XmlNode nLink = xdom.CreateNode(XmlNodeType.Element, "link", "");
            nLink.InnerText = "http://www.fatihyildizhan.com/User/MakaleGoster.aspx?id=" + Convert.ToInt32(dr["MakaleId"]);

            XmlNode nPubDate = xdom.CreateNode(XmlNodeType.Element, "pubDate", "");
            nPubDate.InnerText = dr["EklemeTarihi"].ToString();

            nItem.AppendChild(nTitle);
            nItem.AppendChild(nDescription);
            nItem.AppendChild(nLink);
            nItem.AppendChild(nPubDate);

            xdom.ChildNodes[1].ChildNodes[0].AppendChild(nItem);
        }
        dr.Close();
        con.Close();
        xdom.Save(Server.MapPath("fydoxaJAVA.xml"));
    }
}
