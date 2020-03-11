using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Net;

namespace XMLSON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument xdom = new XmlDocument();
            xdom.Load("http://www.tcmb.gov.tr/kurlar/today.xml");


           //XmlNodeList liste = xdom.SelectNodes("Tarih_Date/Currency");

           XmlNode node = xdom.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']");
           MessageBox.Show(node["ForexBuying"].InnerText);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WebProxy wb = new WebProxy(".", 1);
            wb.Credentials = new NetworkCredential(".", ".");
            HttpWebRequest.DefaultWebProxy = wb;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            XmlDocument xdom = new XmlDocument();
            xdom.Load("http://rss.hurriyet.com.tr/rss.aspx?sectionId=14");

            XmlNodeList liste = xdom.SelectNodes("rss/channel/item");


            foreach (XmlNode node in liste)
            {
                listBox1.Items.Add(node["title"].InnerText);
            }

        }
    }
}
