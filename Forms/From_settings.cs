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
        private String[] setName = new string[] {"全域設定", "待辦事項設定", "番茄鐘設定" };
        public From_settings()
        {
            InitializeComponent();
        }

        private void From_settings_Load(object sender, EventArgs e)
        {
            lbl_set_name.Text = setName[0];
            this.panel_setinput.Controls.Clear();
            user_control_settings_gen user_Control_Settings_Gen = new user_control_settings_gen();
            this.panel_setinput.Controls.Add(user_Control_Settings_Gen);
        }

        private void btn_genset_Click(object sender, EventArgs e)
        {
            lbl_set_name.Text = setName[0];
            this.panel_setinput.Controls.Clear();
            user_control_settings_gen user_Control_Settings_Gen = new user_control_settings_gen();
            this.panel_setinput.Controls.Add(user_Control_Settings_Gen);
        }

        private void btn_taskset_Click(object sender, EventArgs e)
        {
            lbl_set_name.Text = setName[1];
            this.panel_setinput.Controls.Clear();
            user_control_settings_task user_Control_Settings_Gen = new user_control_settings_task();
            this.panel_setinput.Controls.Add(user_Control_Settings_Gen);
        }

        private void btn_pomoset_Click(object sender, EventArgs e)
        {
            lbl_set_name.Text = setName[2];
            this.panel_setinput.Controls.Clear();
            user_control_settings_pomo user_Control_Settings_Pomo = new user_control_settings_pomo();
            this.panel_setinput.Controls.Add(user_Control_Settings_Pomo);
        }
    }
}
