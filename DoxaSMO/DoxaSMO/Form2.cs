using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Smo;

namespace DoxaSMO
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Server svr = new Server(".");

        private void btnDatabases_Click(object sender, EventArgs e)
        {
            lstDatabases.Items.Clear();
            foreach (Database item in svr.Databases)
            {
                lstDatabases.Items.Add(item.Name);
            }
        }

        private void btnTables_Click(object sender, EventArgs e)
        {
            lstTables.Items.Clear();

            Database db = svr.Databases[lstDatabases.SelectedItem.ToString()];
            
            foreach (Table item in db.Tables)
            {
                lstTables.Items.Add(item.Name);
            }
        }

        private void btnColumns_Click(object sender, EventArgs e)
        {
            lstColumns.Items.Clear();


            foreach (Column item in svr.Databases[lstDatabases.SelectedItem.ToString()].Tables[lstTables.SelectedItem.ToString()].Columns)
            {
                lstColumns.Items.Add(item.Name);
            }
        }

    }
}
