using project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using AntdUI;

namespace project.Component
{
    public class ToDoTask
    {
        public ToDoTask() { }
        public ToDoTask(String subject, String classification, String task_describe, DateTime deadline, String themeColor)
        {
            this.subject = subject;
            this.classification = classification;
            this.taskDescribe = task_describe;
            this.deadline = deadline;
            this.themeColor = themeColor;

            this.finish = false;
        }

        public void add_to_panel(AntdUI.StackPanel contain_StackPanel)
        {
            PanelTASK current_task = new PanelTASK(contain_StackPanel, this);
            current_task.add_to_panel();
        }

        public String subject { get; set; }
        public String classification { get; set; }
        public String taskDescribe { get; set; }
        public DateTime deadline { get; set; }
        public bool finish { get; set; }
        public String themeColor { get; set; }
    }

    public class PanelTASK : AntdUI.StackPanel
    {
        private AntdUI.StackPanel contain_StackPanel;
        private ToDoTask task;
        public PanelTASK(AntdUI.StackPanel contain_StackPanel, ToDoTask task)
        {
            this.contain_StackPanel = contain_StackPanel;
            this.task = task;
            this.Height = 160;
            this.Margin = new Padding(0, 0, 0, 0);
            //this.Span = "100%; 100%; 100%; 100%";
            this.Vertical = true;
        }
        public void add_to_panel()
        {
            AntdUI.Select SelectSubject = new AntdUI.Select();
            AntdUI.DatePicker deadlineLabel = new AntdUI.DatePicker();
            AntdUI.Select SelectClassification = new AntdUI.Select();
            AntdUI.Input inputTaskDescribe = new AntdUI.Input();

            this.Controls.Add(inputTaskDescribe);
            this.Controls.Add(SelectClassification);
            this.Controls.Add(deadlineLabel);
            this.Controls.Add(SelectSubject);

            SelectSubject.Padding = new Padding(0, 0, 0, 0);
            SelectSubject.Margin = new Padding(0, 0, 0, 0);
            SelectSubject.Text = task.subject;
            SelectSubject.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            SelectSubject.Height = 30;
            SelectSubject.JoinMode = AntdUI.TJoinMode.Top;
            SelectSubject.BackColor = ParseHex(task.themeColor);
            SelectSubject.IconRatio = 0;
            //SelectSubject.

            deadlineLabel.Padding = new Padding(0, 0, 0, 0);
            deadlineLabel.Margin = new Padding(0, 0, 0, 0);
            deadlineLabel.Value = task.deadline;
            deadlineLabel.Text = task.deadline.ToString("yyyy-MM-dd HH:mm");
            deadlineLabel.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            deadlineLabel.Height = 30;
            deadlineLabel.JoinMode = AntdUI.TJoinMode.TB;
            deadlineLabel.BackColor = ParseHex(task.themeColor);

            SelectClassification.Padding = new Padding(0, 0, 0, 0);
            SelectClassification.Margin = new Padding(0, 0, 0, 0);
            SelectClassification.Text = task.classification;
            SelectClassification.Font = new Font("Segoe UI", 10, FontStyle.Italic);
            SelectClassification.Height = 30;
            SelectClassification.JoinMode = AntdUI.TJoinMode.TB;
            SelectClassification.BackColor = ParseHex(task.themeColor);
            SelectClassification.IconRatio = 0;

            inputTaskDescribe.Padding = new Padding(0, 0, 0, 0);
            inputTaskDescribe.Margin = new Padding(0, 0, 0, 0);
            inputTaskDescribe.Text = task.taskDescribe;
            inputTaskDescribe.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            inputTaskDescribe.Height = 70;
            inputTaskDescribe.JoinMode = AntdUI.TJoinMode.Bottom;
            inputTaskDescribe.Multiline = true;
            inputTaskDescribe.AutoScroll = true;
            inputTaskDescribe.BackColor = ParseHex(task.themeColor);

            this.Height = SelectSubject.Height + deadlineLabel.Height + SelectClassification.Height + inputTaskDescribe.Height;
            contain_StackPanel.Controls.Add(this);
        }

        private Color ParseHex(string hex)
        {
            hex = hex.Replace("#", "");

            int r = Convert.ToInt32(hex.Substring(0, 2), 16);
            int g = Convert.ToInt32(hex.Substring(2, 2), 16);
            int b = Convert.ToInt32(hex.Substring(4, 2), 16);

            return Color.FromArgb(r, g, b);
        }
    }
}
