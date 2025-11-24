using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project.Component;

namespace project
{
    public partial class Form_mainPage : Form
    {
        String[] table_suject;
        String[] table_classification;
        String[] table_fl_text;
        public Form_mainPage()
        {
            InitializeComponent();
            init_form();
        }
        

        private void init_form()
        {
            float flpanel_cal_per = 0.8f;
            this.lbl_debug.Text = "";

            this.table_suject = new String[] { "計算機結構", "視窗程式設計" };
            this.table_classification = new String[] { "考試", "報告", "作業" };
            this.table_fl_text = new string[] { "今天", "明天", ""};
            ushort panel_num = 3;

            this.flpanel_calendar.Width = (int)((this.Width - 24) * flpanel_cal_per);
            this.flpanel_calendar.Height = (int)(this.Height - 24);
            this.flpanel_calendar.Location = new System.Drawing.Point((int)((this.Width) * (1-flpanel_cal_per)), 12);
            for (int i = 0; i < panel_num; i++)
            {
                this.lbl_debug.Text += i;
                FL_Panel new_panel = new FL_Panel(flpanel_calendar, $"FL_{i}", $"test_test", panel_num);
                new_panel.add_to_FLPanel();

                this.lbl_debug.Text += new_panel.Name + "\n\r";
                for (UInt16 j = 0; j < 20; j++)
                {
                    String index = $"{j}\r\ntest {j}\r\ntest {j}";
                    int[] task_deadline = new int[3] { 0, 1, 2 };
                    TO_DO_TASK new_task = new TO_DO_TASK((ushort)((UInt16)j % 2), (ushort)((UInt16)j % 3), "test", new int[3] { 0, 1, 2 });
                    new_task.add_to_panel(new_panel, this.table_suject, this.table_classification);
                }
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_pomodoro new_form = new Form_pomodoro();
            new_form.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gb_all_s_Enter(object sender, EventArgs e)
        {

        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            From_settings new_form = new From_settings();
            new_form.ShowDialog();
        }
    }
}
