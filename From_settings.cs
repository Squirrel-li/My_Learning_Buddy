using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class From_settings : Form
    {
        public From_settings()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void From_settings_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.panel_setinput.Controls.Clear();
            user_control_settings_gen user_Control_Settings_Gen = new user_control_settings_gen();
            this.panel_setinput.Controls.Add(user_Control_Settings_Gen);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.panel_setinput.Controls.Clear();
            user_control_settings_task user_Control_Settings_Gen = new user_control_settings_task();
            this.panel_setinput.Controls.Add(user_Control_Settings_Gen);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.panel_setinput.Controls.Clear();
            user_control_settings_pomo user_Control_Settings_Pomo = new user_control_settings_pomo();
            this.panel_setinput.Controls.Add(user_Control_Settings_Pomo);
        }
    }
}
