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
using System.Collections.Generic;

namespace project
{
    public partial class Form_mainPage : Form
    {
        List<string> table_suject = new List<string>();
        List<string> table_classification = new List<string>();
        List<string> table_fl_text = new List<string>();
        List<TO_DO_TASK> toDoTask = new List<TO_DO_TASK>();
        public Form_mainPage()
        {
            InitializeComponent();
            init_form();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void init_form()
        {
            this.lbl_debug.Text = "";

            this.table_suject = new List<string> { "計算機結構", "視窗程式設計" };
            this.table_classification = new List<string> { "考試", "報告", "作業" };
            this.table_fl_text = new List<string> { "今日待辦事項", "明日待辦事項" };
            ushort panel_num = 5;
            //this.flpanel_calendar.BorderStyle = BorderStyle.FixedSingle;


            for (int i = 0; i < panel_num; i++)
            {
                String titel = "";
                if (i < table_fl_text.Count)
                {
                    titel = table_fl_text[i];
                }
                else
                {
                    titel = $"{i} 天後待辦";
                }
                FL_Panel new_panel = new FL_Panel(this.flpanel_calendar, $"FL_{i}", $"{titel}", panel_num);
                new_panel.add_to_FLPanel();
                this.lbl_debug.Text += new_panel.Tag + "\n\r";
            }

            init_cb_index(cb_subject, table_suject);
            init_cb_index(cb_classification, table_classification);
        }

        public void add_cb_index(ComboBox cb_input, String index)
        {
            cb_input.BeginUpdate();
            cb_input.Items.Add(index);
            cb_input.EndUpdate();
        }

        private void init_cb_index(ComboBox cb_input, List<string> table)
        {
            cb_input.Items.Clear();
            foreach (String classification in table) 
            {
                add_cb_index(cb_input, classification);
            }
        }

        private void btn_openPomo_Click(object sender, EventArgs e)
        {
            Form_pomodoro new_form = new Form_pomodoro();
            new_form.ShowDialog();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            From_settings new_form = new From_settings();
            new_form.ShowDialog();
        }

        private void btn_addTask_Click(object sender, EventArgs e)
        {
            if (cb_subject.SelectedIndex == -1 && cb_classification.SelectedIndex == -1)
            {
                lbl_tabToDoMes.Text = "請選擇科目、類別";
                return;
            }
            if (cb_subject.SelectedIndex == -1)
            {
                lbl_tabToDoMes.Text = "請選擇科目";
                return;
            }
            if (cb_classification.SelectedIndex == -1)
            {
                lbl_tabToDoMes.Text = "請選擇類別";
                return;
            }

            String subject = this.table_suject[cb_subject.SelectedIndex];
            String classification = this.table_classification[cb_classification.SelectedIndex];
            String task_describe = tb_taskDescribe.Text;
            DateTime dateTime = DateTime.Now;

            TO_DO_TASK new_task = new TO_DO_TASK(subject, classification, task_describe, dateTime);

            FL_Panel targetPanel = find_pnaelinlanel(this.flpanel_calendar, "FL_0");
            if (targetPanel == null)
            {
                throw new Exception("cant find panel");
            }
            new_task.add_to_panel(targetPanel);

        }

        private FL_Panel find_pnaelinlanel(FlowLayoutPanel sourcePanel, String tag)
        {
            FL_Panel targetPanel = null;
            foreach (Control control in sourcePanel.Controls)
            {
                if (control is FL_Panel fl && control.Tag?.ToString() == tag)
                {
                    targetPanel = fl;
                    break; // 找到就跳出
                }
            }
            if (targetPanel == null)
            {
                MessageBox.Show("找不到標記為 FL_0 的 FL_Panel");
                return null;
            }
            return targetPanel;
        }

        private void tc_modifySet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tc_modifySet.SelectedIndex == 0)
            {
                if (cb_subject.SelectedIndex == -1)
                {
                    cb_subject.SelectedIndex = 0;
                }
                if (cb_classification.SelectedIndex == -1)
                {
                    cb_classification.SelectedIndex = 0;
                }
                tb_taskDescribe.Text = "無敘述";
            }
            if (tc_modifySet.SelectedIndex == 1)
            {
                lb_SubjShow.Items.Clear();
                lb_classShow.Items.Clear();
                foreach (String subject in table_suject)
                {
                    lb_SubjShow.Items.Add(subject);
                }
                foreach (String classification in table_classification)
                {
                    lb_classShow.Items.Add(classification);
                }
            }
        }

        private void btn_addSubj_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_addSubj.Text))
            {

                foreach (String subject in table_suject)
                {
                    if (tb_addSubj.Text == subject)
                    {
                        lbl_tabModfiyMes.Text = "內容已存在";
                        return;
                    }
                }

                this.table_suject.Add(tb_addSubj.Text);
                lb_SubjShow.Items.Clear();
                foreach (String subject in table_suject)
                {
                    lb_SubjShow.Items.Add(subject);
                }
            }
            else
            {
                lbl_tabModfiyMes.Text = "請填入要新增的內容";
            }
        }

        private void btn_delSubj_Click(object sender, EventArgs e)
        {

        }

        private void btn_addClass_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_addClass.Text))
            {
                this.table_classification.Add(tb_addClass.Text);
                lb_classShow.Items.Clear();
                foreach (String classification in table_classification)
                {
                    lb_classShow.Items.Add(classification);
                }
            }
        }

        private void btn_delClass_Click(object sender, EventArgs e)
        {

        }
    }
}
