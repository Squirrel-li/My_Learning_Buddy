using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project.util;

namespace project
{
    public partial class user_control_settings_gen : UserControl
    {
        private string filePath = "D:\\!universitiy\\3-1\\DevelopWindowsApplications\\project\\XMLFile1.xml";
        public user_control_settings_gen()
        {
            InitializeComponent();
        }

        private void settings_user_control_gen_Load(object sender, EventArgs e)
        {
            xmlManager xmlManager = new xmlManager();
            lbltest.Text = xmlManager.test_connect();


            ds_set_xml.ReadXml(this.filePath);

            dataGridView1.DataSource = ds_set_xml;
            dataGridView1.DataMember = "settings";
        }
    }
}
