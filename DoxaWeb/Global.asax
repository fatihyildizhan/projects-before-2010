<%@ Application Language="C#" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e) 
    {
        Application["OnlineMisafir"] = 0;
    }
    
    void Application_End(object sender, EventArgs e) 
    {
        
    }

     void Application_BeginRequest(object sender, EventArgs e)
     {
         //if (Context.Request.RawUrl.Contains("MakaleGoster"))
         //{
         //    string id = Context.Request.RawUrl.Split('/')[4];
         //    Context.RewritePath("https://www.fatihyildizhan.com/User/MakaleGoster.aspx?id="+id);
         //}
         
        //try
        //{
        //    string q = this.Context.Request.QueryString.ToString();
        //    if (q.Contains("delete") || q.Contains("update") || q.Contains("drop") || q.Contains("exec"))
        //        Response.Redirect("hata.aspx");
        //}
        //catch
        //{
        //}
     }
 
        
    void Application_Error(object sender, EventArgs e) 
    {
        try
        {
            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient();
            System.Net.Mail.MailAddress sndr = new System.Net.Mail.MailAddress("");
            System.Net.Mail.MailAddress receiver = new System.Net.Mail.MailAddress("", "");
            string ip = Request.ServerVariables["REMOTE_ADDR"].ToString();
            string zaman = DateTime.Now.ToLongTimeString();
            string hata="Inner Exception";
            if(Server.GetLastError().InnerException!=null){hata=Server.GetLastError().InnerException.Message;}
                        
            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage(sndr, receiver);
            mail.Subject = "Application Error";
            mail.Body = "Hata Oluşma Zamanı : "+zaman+" <br/> Ip Adresi : " + ip + " <br/> Yardımcı Link : " + Server.GetLastError().HelpLink + " <br/> Oluşan Son Hata : " + Server.GetLastError().ToString() + " <br/> Inner Exception : " +  hata+ "  <br/> Son Oluşan Hata'nın Data Bilgisi : " + Server.GetLastError().Data.ToString();
            mail.BodyEncoding = Encoding.Default;
            mail.IsBodyHtml = true;
            mail.Priority = System.Net.Mail.MailPriority.Normal;
            smtp.Send(mail);
        }
        catch (Exception)
        {
        }
    }

    void Session_Start(object sender, EventArgs e) 
    {
            Application["OnlineMisafir"] = Convert.ToInt32(Application["OnlineMisafir"]) + 1;
            System.Xml.XmlDocument xdom = new System.Xml.XmlDocument();
            xdom.Load(Server.MapPath("hit.xml"));
            int toplamHit = Convert.ToInt32(xdom.ChildNodes[1].ChildNodes[0].InnerText) + 1;
            xdom.ChildNodes[1].ChildNodes[0].InnerText = toplamHit.ToString();
            xdom.Save(Server.MapPath("hit.xml"));
    }

    void Session_End(object sender, EventArgs e) 
    {
        Application["OnlineMisafir"] = Convert.ToInt32(Application["OnlineMisafir"]) - 1;

    }
    
       
</script>
