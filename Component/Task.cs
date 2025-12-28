using AntdUI;
using project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using AntdUI;

namespace project.Component
{
    public class ToDoTask
    {
        public ToDoTask()
        {
            this.subject = "subject";
            this.classification = "classification";
            this.taskDescribe = "taskDescribe";
            this.deadline = DateTime.Now;
            this.themeColor = "#FDFFB6";

            this.finish = false;
        }
        public ToDoTask(String subject, String classification, String taskDescribe, DateTime deadline, String themeColor)
        {
            this.subject = subject;
            this.classification = classification;
            this.taskDescribe = taskDescribe;
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
        JsonManager jsonManager = new JsonManager();
        private AntdUI.StackPanel contain_StackPanel;
        public ToDoTask task;
        public PanelTASK(AntdUI.StackPanel contain_StackPanel, ToDoTask task)
        {
            this.contain_StackPanel = contain_StackPanel;
            this.task = task;
            this.Height = 165;
            this.Margin = new Padding(2, 2, 2, 2);
            //this.Span = "100%; 100%; 100%; 100%";
            this.Vertical = true;
        }
        public PanelTASK()
        {
            this.Vertical = true;
            this.Size = new Size(210, 170);
            this.Margin = new Padding(2, 2, 2, 2);
            this.task = new ToDoTask();
            this.contain_StackPanel = null;
            add_to_panel();
        }
        public void add_to_panel()
        {
            AntdUI.Panel PanelContainerSubject = new AntdUI.Panel();
            AntdUI.Panel PanelC1 = new AntdUI.Panel();
            AntdUI.Panel PanelC2 = new AntdUI.Panel();
            AntdUI.Splitter SplitterPanelContainer = new AntdUI.Splitter();
            AntdUI.Select SelectSubject = new AntdUI.Select();
            AntdUI.Checkbox checkboxFinish = new AntdUI.Checkbox();
            AntdUI.DatePicker deadlineLabel = new AntdUI.DatePicker();
            AntdUI.Select SelectClassification = new AntdUI.Select();
            AntdUI.Input inputTaskDescribe = new AntdUI.Input();

            this.Controls.Add(inputTaskDescribe);
            this.Controls.Add(SelectClassification);
            this.Controls.Add(deadlineLabel);
            this.Controls.Add(PanelContainerSubject);
            this.Back = ThemeColor.BackPrimary;
            this.BackColor = ThemeColor.BackPrimary;

            PanelContainerSubject.Padding = new Padding(0, 0, 0, 0);
            PanelContainerSubject.Margin = new Padding(5, 3, 5, 0);
            PanelContainerSubject.Height = 35;
            //PanelContainerSubject.Radius = 6;
            //PanelContainerSubject.RadiusAlign = TAlignRound.Top;
            //PanelContainerSubject.Back = ParseHex(task.themeColor);
            PanelContainerSubject.BorderWidth = 0;

            SplitterPanelContainer.Dock = DockStyle.Fill;
            SplitterPanelContainer.Width = 1;
            SplitterPanelContainer.SplitterSize = 0;
            SplitterPanelContainer.SplitterBack = ParseHex(task.themeColor);
            SplitterPanelContainer.FixedPanel = FixedPanel.Panel2;
            SplitterPanelContainer.IsSplitterFixed = true;

            PanelContainerSubject.Controls.Add(SplitterPanelContainer);


            PanelC1.Radius = 6;
            PanelC1.RadiusAlign = TAlignRound.TL;
            PanelC1.Back = ParseHex(task.themeColor);
            PanelC1.Controls.Add(SelectSubject);
            PanelC1.Dock = DockStyle.Fill;

            PanelC2.Radius = 6;
            PanelC2.RadiusAlign = TAlignRound.TR;
            PanelC2.Back = ParseHex(task.themeColor);
            PanelC2.Controls.Add(checkboxFinish);
            PanelC2.Dock = DockStyle.Fill;

            SplitterPanelContainer.Panel1.Controls.Add(PanelC1);
            SplitterPanelContainer.Panel2.Controls.Add(PanelC2);

            SelectSubject.Margin = new Padding(0, 0, 0, 0);
            SelectSubject.Text = task.subject;
            SelectSubject.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            SelectSubject.BackColor = ParseHex(task.themeColor);
            SelectSubject.ShowIcon = false;
            SelectSubject.List = true;
            SelectSubject.WheelModifyEnabled = false;
            SelectSubject.BorderWidth = 0;
            if (contain_StackPanel != null)
            {
                SelectSubject.Size = new Size(contain_StackPanel.Width - 8 - 45, PanelContainerSubject.Height - 2);
            }
            else
            {
                SelectSubject.Size = new Size(190 - 8 - 45, PanelContainerSubject.Height - 2);
            }
            SelectSubject.Dock = DockStyle.Fill;
            SelectSubject.Location = new Point(0, 0);
            foreach (var item in jsonManager.Get_table_subject())
            {
                SelectSubject.Items.Add(item);
            }
            SelectSubject.SelectedIndexChanged += (s, e) =>
            {
                JsonManager jsonManager = new JsonManager();
                int id = jsonManager.Find_ToDoTask_Id(task);
                this.task.subject = SelectSubject.Text;
                jsonManager.Update_tableToDoTask(id, task);
            };

            checkboxFinish.Margin = new Padding(0, 0, 0, 0);
            checkboxFinish.Text = "";
            checkboxFinish.Font = new Font("Segoe UI", 8, FontStyle.Regular);
            checkboxFinish.Height = 30;
            checkboxFinish.Width = 30;
            checkboxFinish.Dock = DockStyle.Bottom;
            checkboxFinish.BackColor = ParseHex(task.themeColor);
            checkboxFinish.Checked = task.finish;
            checkboxFinish.CheckedChanged += (s, e) =>
            {
                JsonManager jsonManager = new JsonManager();
                int id = jsonManager.Find_ToDoTask_Id(task);
                List<ToDoTask> table = jsonManager.Get_tableToDoTask();
                if (checkboxFinish.Checked)
                {
                    task.finish = true;
                    PanelC1.Back = Color.LightGreen;
                    PanelC2.Back = Color.LightGreen;
                    SelectSubject.BackColor = Color.LightGreen;
                    checkboxFinish.BackColor = Color.LightGreen;
                    deadlineLabel.BackColor = Color.LightGreen;
                    SelectClassification.BackColor = Color.LightGreen;
                    inputTaskDescribe.BackColor = Color.LightGreen;
                    SplitterPanelContainer.SplitterBack = Color.LightGreen;
                }
                else
                {
                    task.finish = false;
                    PanelC1.Back = ParseHex(task.themeColor);
                    PanelC2.Back = ParseHex(task.themeColor);
                    SelectSubject.BackColor = ParseHex(task.themeColor);
                    checkboxFinish.BackColor = ParseHex(task.themeColor);
                    deadlineLabel.BackColor = ParseHex(task.themeColor);
                    SelectClassification.BackColor = ParseHex(task.themeColor);
                    inputTaskDescribe.BackColor = ParseHex(task.themeColor);
                    SplitterPanelContainer.SplitterBack = ParseHex(task.themeColor);
                }
                jsonManager.Update_tableToDoTask(id, task);
            };



            deadlineLabel.Margin = new Padding(0, 0, 0, 0);
            deadlineLabel.Value = task.deadline;
            deadlineLabel.Text = task.deadline.ToString("yyyy-MM-dd HH:mm");
            deadlineLabel.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            deadlineLabel.Height = 30;
            deadlineLabel.JoinMode = AntdUI.TJoinMode.TB;
            deadlineLabel.BackColor = ParseHex(task.themeColor);
            deadlineLabel.ShowIcon = false;
            deadlineLabel.Format = "yyyy/MM/dd HH:mm";
            deadlineLabel.ValueChanged += (s, e) =>
            {
                JsonManager jsonManager = new JsonManager();
                int id = jsonManager.Find_ToDoTask_Id(task);
                this.task.deadline = deadlineLabel.Value?? throw new Exception("dateTimeP_select.Value is null");
                jsonManager.Update_tableToDoTask(id, task);
            };

            SelectClassification.Margin = new Padding(0, 0, 0, 0);
            SelectClassification.Text = task.classification;
            SelectClassification.Font = new Font("Segoe UI", 10, FontStyle.Italic);
            SelectClassification.Height = 30;
            SelectClassification.JoinMode = AntdUI.TJoinMode.TB;
            SelectClassification.BackColor = ParseHex(task.themeColor);
            SelectClassification.ShowIcon = false;
            SelectClassification.List = true;
            SelectClassification.WheelModifyEnabled = false;
            foreach (var item in jsonManager.Get_tableClassification())
            {
                SelectClassification.Items.Add(item);
            }
            SelectClassification.SelectedIndexChanged += (s, e) =>
            {
                JsonManager jsonManager = new JsonManager();
                int id = jsonManager.Find_ToDoTask_Id(task);
                this.task.classification = SelectClassification.Text;
                jsonManager.Update_tableToDoTask(id, task);
            };

            inputTaskDescribe.Margin = new Padding(0, 0, 0, 0);
            inputTaskDescribe.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            inputTaskDescribe.Height = 70;
            inputTaskDescribe.JoinMode = AntdUI.TJoinMode.Bottom;
            inputTaskDescribe.Multiline = true;
            inputTaskDescribe.AutoScroll = true;
            inputTaskDescribe.BackColor = ParseHex(task.themeColor);
            inputTaskDescribe.TextChanged += (s, e) =>
            {
                JsonManager jsonManager = new JsonManager();
                int id = jsonManager.Find_ToDoTask_Id(task);
                this.task.taskDescribe = inputTaskDescribe.Text;
                jsonManager.Update_tableToDoTask(id, task);
            };

            if (task.taskDescribe == "")
                inputTaskDescribe.Text = "(無描述)";
            else
                inputTaskDescribe.Text = task.taskDescribe;

            if (task.finish)
            {
                PanelC1.Back = Color.LightGreen;
                PanelC2.Back = Color.LightGreen;
                SelectSubject.BackColor = Color.LightGreen;
                checkboxFinish.BackColor = Color.LightGreen;
                deadlineLabel.BackColor = Color.LightGreen;
                SelectClassification.BackColor = Color.LightGreen;
                inputTaskDescribe.BackColor = Color.LightGreen;
                SplitterPanelContainer.SplitterBack = Color.LightGreen;
            }
            if (contain_StackPanel != null)
            {
                contain_StackPanel.Controls.Add(this);
            }
            this.BringToFront();
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
