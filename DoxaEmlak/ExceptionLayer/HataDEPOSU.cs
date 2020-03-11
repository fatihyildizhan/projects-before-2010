using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExceptionLayer
{
    public class HataDEPOSU
    {
        public void HataYakalaTUM(Exception yakalananEX)
        {
            HataEpostaGonder(yakalananEX);
        }
        private void HataEpostaGonder(Exception gelenEX)
        {
            try
            {
                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("mail.yildizhanlar.com", 587);
                System.Net.Mail.MailAddress sndr = new System.Net.Mail.MailAddress("fatih@yildizhanlar.com");
                System.Net.Mail.MailAddress receiver = new System.Net.Mail.MailAddress("fatih@yildizhanlar.com", "fatihyildizhan.com");
                string zaman = DateTime.Now.ToLongTimeString();
                System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage(sndr, receiver);
                mail.Subject = "Application Error: Turan EMLAK OTO ";
                mail.Body = "HATA OLUŞMA ZAMANI : " + zaman + " <br/><br/><br/> YARDIMCI LİNK : " + gelenEX.HelpLink + " <br/><br/><br/> OLUŞAN SON HATA MESAJI : " + gelenEX.Message + " <br/><br/> Inner Exception : " + gelenEX.InnerException + "  <br/><br/><br/> Son Oluşan Hata'nın Data Bilgisi : " + gelenEX.Data.ToString();
                mail.BodyEncoding = Encoding.Default;
                mail.IsBodyHtml = true;
                mail.Priority = System.Net.Mail.MailPriority.Normal;
                smtp.Send(mail);

            }
            catch (Exception ex)
            {


            }
        }
        private void HataXmlYaz(Exception gelenEX)
        {

        }
        private void CepTelefonuMesajAt(Exception gelenEX)
        {

        }
        private void CepTelefonuAra(Exception gelenEX)
        {

        }
    }
}
