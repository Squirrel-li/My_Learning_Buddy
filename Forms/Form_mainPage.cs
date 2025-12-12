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
                    titel = $"{i}天後";
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
            if (cb_subject.Text == String.Empty || cb_classification.Text == String.Empty)
            {
                lbl_tabToDoMes.Text = "請填入要新增的內容";
            }
            else
            {
                if (!cb_subject.Items.Contains(cb_subject.Text))
                {
                    cb_subject.Items.Add(cb_subject.Text);
                    table_suject.Add(cb_subject.Text);
                    lbl_debug.Text += "cb_subject：\n";
                    foreach (var item in cb_subject.Items)
                    {
                        lbl_debug.Text += item.ToString() + "\n";
                    }
                }
                if (!cb_classification.Items.Contains(cb_classification.Text))
                {
                    cb_classification.Items.Add(cb_classification.Text);
                    table_suject.Add(cb_classification.Text);
                    lbl_debug.Text += "cb_classification：\n";
                    foreach (var item in cb_classification.Items)
                    {
                        lbl_debug.Text += item.ToString() + "\n";
                    }
                }

                String subject = cb_subject.Text;
                String classification = cb_classification.Text;
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
                cb_subject.Items.Clear();
                cb_classification.Items.Clear();
                foreach (var item in table_suject)
                {
                    cb_subject.Items.Add(item);
                }
                foreach (var item in table_classification)
                {
                    cb_classification.Items.Add(item);
                }
            }
            else if (tc_modifySet.SelectedIndex == 1)
            {
                cb_controlSubject.Items.Clear();
                cb_controlClass.Items.Clear();
                foreach (var item in table_suject)
                {
                    cb_controlSubject.Items.Add(item);
                }
                foreach (var item in table_classification)
                {
                    cb_controlClass.Items.Add(item);
                }
            }
        }

        private void btn_addSubj_Click(object sender, EventArgs e)
        {
            if (cb_controlSubject.Text == string.Empty)
            {
                lbl_tabModfiyMes.Text = "請填入要新增的內容";
            }
            if (!cb_controlSubject.Items.Contains(cb_controlSubject.Text))
            {
                cb_controlSubject.Items.Add(cb_controlSubject.Text);
                table_suject.Add(cb_controlSubject.Text);
            }
        }

        private void btn_delSubj_Click(object sender, EventArgs e)
        {
            if (cb_controlSubject.Text == string.Empty)
            {
                lbl_tabModfiyMes.Text = "請選擇要刪除的內容";
            }
            if (cb_controlSubject.Items.Contains(cb_controlSubject.Text))
            {
                table_suject.Remove(cb_controlSubject.Text);
                cb_controlSubject.Items.Remove(cb_controlSubject.Text);
            }
        }

        private void btn_addClass_Click(object sender, EventArgs e)
        {
            if (cb_controlClass.Text == string.Empty)
            {
                lbl_tabModfiyMes.Text = "請填入要新增的內容";
            }
            if (!cb_controlClass.Items.Contains(cb_controlClass.Text))
            {
                cb_controlClass.Items.Add(cb_controlClass.Text);
                table_suject.Add(cb_controlClass.Text);
            }
        }

        private void btn_delClass_Click(object sender, EventArgs e)
        {
            if (cb_controlClass.Text == string.Empty)
            {
                lbl_tabModfiyMes.Text = "請選擇要刪除的內容";
            }
            if (cb_controlClass.Items.Contains(cb_controlClass.Text))
            {
                table_classification.Remove(cb_controlClass.Text);
                cb_controlClass.Items.Remove(cb_controlClass.Text);
            }
        }
    }
}
