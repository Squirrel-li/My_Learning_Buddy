using AntdUI;
using project.Component;
using project.util;
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
    public partial class From_settings : AntdUI.Window
    {
        private String[] setName = new string[] {"全域設定", "待辦事項設定", "番茄鐘設定" };
        private JsonManager jsonManager = new JsonManager();

        private int[] modeSet = { 0, 20 * 60, 5 * 60, 10 * 60 }; // work, short break, long break
        private int loopTimes = 2;
        private bool[] autoStart;

        private List<string> tableSubject = new List<string>();
        private List<string> tableClassification = new List<string>();
        private List<ToDoTask> tableToDoTask = new List<ToDoTask>();

        private ushort showPanel;
        private ushort showRangeMode;
        private ushort[] tableShowPanel = new ushort[] { 3, 5, 7 };
        String[] showRangeLabel = new String[] { "一周", "一個月", "兩個月", "不限制" };

        public From_settings()
        {
            InitializeComponent();
        }

        private void From_settings_Load(object sender, EventArgs e)
        {
            initBackColor();
            backColorSet.SetPanelBackItemColor(panel_setPomoAuto);
            backColorSet.SetPanelBackItemColor(panel_setPomoTime);
            initPara();


            select_controlSubject.Items.Clear();
            select_controlClass.Items.Clear();
            foreach (var item in tableSubject)
            {
                select_controlSubject.Items.Add(item);
            }
            foreach (var item in tableClassification)
            {
                select_controlClass.Items.Add(item);
            }

            foreach (ushort item in tableShowPanel)
            {
                select_panelNum.BeginInvoke((MethodInvoker)delegate
                {
                    select_panelNum.Items.Add(item);
                });
            }
            foreach (String item in showRangeLabel)
            {
                select_range.BeginInvoke((MethodInvoker)delegate
                {
                    select_range.Items.Add(item);
                });
            }

            select_panelNum.Text = jsonManager.Get_showPanel().ToString();
            select_range.Text = showRangeLabel[(int)jsonManager.Get_showRangeMode()];

            initLabel();
        }
        void initBackColor()
        {
            pageHeader.ColorScheme = TAMode.Light;
            pageHeader.BackColor = ThemeColor.BackPrimary;
            pageHeader.ForeColor = ThemeColor.TextPrimary;

            tabs.BackColor = ThemeColor.BackPrimary;

            tb_display.BackColor = ThemeColor.BackPrimary;
            panel_show.Back = ThemeColor.BackSurface;
            //lbl_total;

            tb_task.BackColor = ThemeColor.BackPrimary;
            gridPanel_setTask.Back = ThemeColor.BackPrimary;

            panel_setTaskSelect.Back = ThemeColor.BackSurface;
            select_range.BackColor = ThemeColor.BackInput;
            select_panelNum.BackColor = ThemeColor.BackInput;
            select_controlClass.BackColor = ThemeColor.BackInput;
            select_controlSubject.BackColor = ThemeColor.BackInput;
            btn_addSubj.DefaultBack = ThemeColor.BackButtonAccent;
            btn_addSubj.ForeColor = ThemeColor.BackInput;
            btn_delSubj.DefaultBack = ThemeColor.BackSurface;
            btn_delSubj.BorderWidth = 2;
            btn_delSubj.DefaultBorderColor = ThemeColor.BackBorder;
            btn_delSubj.ForeColor = ThemeColor.TextSecondary;
            btn_clearAllSubject.DefaultBack = ThemeColor.BackSurface;
            btn_clearAllSubject.BorderWidth = 2;
            btn_clearAllSubject.DefaultBorderColor = ThemeColor.BackBorder;
            btn_clearAllSubject.ForeColor = ThemeColor.TextSecondary;
            btn_addClass.DefaultBack = ThemeColor.BackButtonAccent;
            btn_addClass.ForeColor = ThemeColor.BackInput;
            btn_delClass.DefaultBack = ThemeColor.BackSurface;
            btn_delClass.BorderWidth = 2;
            btn_delClass.DefaultBorderColor = ThemeColor.BackBorder;
            btn_delClass.ForeColor = ThemeColor.TextSecondary;
            btn_clearAllClass.DefaultBack = ThemeColor.BackSurface;
            btn_clearAllClass.BorderWidth = 2;
            btn_clearAllClass.DefaultBorderColor = ThemeColor.BackBorder;
            btn_clearAllClass.ForeColor = ThemeColor.TextSecondary;

            panel_setTaskFinish.Back = ThemeColor.BackSurface;
            stackPanel_FinishTask.BackColor = ThemeColor.BackSurface; ;
            gridPanell_setTaskFinishButton.BackColor = ThemeColor.BackSurface;
            btn_clearFinish.DefaultBack = ThemeColor.BackSurface;
            btn_clearFinish.BorderWidth = 2;
            btn_clearFinish.DefaultBorderColor = ThemeColor.BackBorder;
            btn_clearFinish.ForeColor = ThemeColor.TextSecondary;
            btn_clearAllTask.DefaultBack = ThemeColor.BackSurface;
            btn_clearAllTask.BorderWidth = 2;
            btn_clearAllTask.DefaultBorderColor = ThemeColor.BackBorder;
            btn_clearAllTask.ForeColor = ThemeColor.TextSecondary;
            btn_saveToDoTask.DefaultBack = ThemeColor.BackButtonAccent;
            btn_saveToDoTask.ForeColor = ThemeColor.BackInput;


            tb_pomo.BackColor = ThemeColor.BackPrimary;
            gridPanel_setPomo.Back = ThemeColor.BackPrimary;

            panel_setPomoTime.Back = ThemeColor.BackSurface;
            inputN_focus.BackColor = ThemeColor.BackInput;
            inputN_shortBreak.BackColor = ThemeColor.BackInput;
            inputN_longBreak.BackColor = ThemeColor.BackInput;
            inputN_loopTimes.BackColor = ThemeColor.BackInput;
            btn_saveTime.DefaultBack = ThemeColor.BackButtonAccent;

            panel_setPomoAuto.Back = ThemeColor.BackSurface;
            switch_autoFocus.BackColor = ThemeColor.BackSurface;
            switch_autoFocus.Fill = ThemeColor.BackBorder;
            switch_autoFocus.FillHover = ColorTranslator.FromHtml("#AF7931");
            switch_autoBreak.BackColor = ThemeColor.BackSurface;
            switch_autoBreak.Fill = ThemeColor.BackBorder;
            switch_autoBreak.FillHover = ColorTranslator.FromHtml("#AF7931");
            btn_saveAutoBegin.DefaultBack = ThemeColor.BackButtonAccent;
            
            label1.ForeColor = ThemeColor.TextPrimary;
            label2.ForeColor = ThemeColor.TextPrimary;
            label4.ForeColor = ThemeColor.TextPrimary;
            label7.ForeColor = ThemeColor.TextPrimary;
            label8.ForeColor = ThemeColor.TextPrimary;
            label9.ForeColor = ThemeColor.TextPrimary;
            label10.ForeColor = ThemeColor.TextPrimary;
            label11.ForeColor = ThemeColor.TextPrimary;
            label12.ForeColor = ThemeColor.TextPrimary;
            label15.ForeColor = ThemeColor.TextPrimary;
            label16.ForeColor = ThemeColor.TextPrimary; 
            
        }


        private void initLabel()
        {
            lbl_total.Text = "";
            String index = "";
            int todayFinishTask = 0;
            int weekFinishTask = 0;
            List<DateTime> tableFinish = jsonManager.Get_tableFinish();
            int todayPomo = 0;
            int weekyPomo = 0;
            foreach (ToDoTask task in tableToDoTask)
            {
                if (task.deadline.Date == DateTime.Today) todayFinishTask++;
                if ((task.deadline.Date - DateTime.Today).Days < 7) weekFinishTask++;
            }
            foreach (DateTime finishTime in tableFinish)
            {
                if (finishTime.Date == DateTime.Today) todayPomo++;
                if ((finishTime.Date - DateTime.Today).Days < 7) weekyPomo++;
            }

            index = $"今日已完成 {todayFinishTask} 項任務，\n\r"
                + $"本週已完成 {weekFinishTask} 項任務。\n\r\n\r"
                + $"今日已完成 {todayPomo} 個番茄鐘循環，\n\r"
                + $"本週已完成 {weekyPomo} 個番茄鐘循環。\n\r";

            lbl_total.Text = index;
        }

        private void initPara()
        {
            this.modeSet = jsonManager.Get_modeSet();
            this.loopTimes = jsonManager.Get_loopTime();

            // init display settings

            // set task settings
            tableSubject = jsonManager.Get_table_subject();
            tableClassification = jsonManager.Get_tableClassification();
            tableToDoTask = jsonManager.Get_tableToDoTask();

            foreach (var toDoTask in this.tableToDoTask)
            {
                //int dayDiff = (toDoTask.deadline.Date - DateTime.Today).Days;
                if (toDoTask.finish)
                {
                    toDoTask.add_to_panel(stackPanel_FinishTask);
                }
            }

            // init pomodoro settings
            inputN_focus.Value = modeSet[1] / 60;
            inputN_shortBreak.Value = modeSet[2] / 60;
            inputN_longBreak.Value = modeSet[3] / 60; 
            inputN_loopTimes.Value = loopTimes;
            autoStart = jsonManager.Get_autoStart();
            switch_autoFocus.Checked = autoStart[0];
            switch_autoBreak.Checked = autoStart[1];
        }

        private void tabs1_SelectedIndexChanged(object sender, IntEventArgs e)
        {
            if (tabs.SelectedIndex == 0)
            {
                tb_display.Font = new Font("微軟正黑體", 14.25f, FontStyle.Bold);
            }
            if (tabs.SelectedIndex == 1)
            {
                this.tableToDoTask = jsonManager.Get_tableToDoTask();

                foreach (var toDoTask in this.tableToDoTask)
                {
                    int dayDiff = (toDoTask.deadline.Date - DateTime.Today).Days;
                    if (toDoTask.finish)
                    {
                        toDoTask.add_to_panel(stackPanel_FinishTask);
                    }
                }
            }
        }

        private void btn_saveTime_Click(object sender, EventArgs e)
        {
            jsonManager.Save_modeSet(new int[] { 0, (int)inputN_focus.Value * 60, (int)inputN_shortBreak.Value * 60, (int)inputN_longBreak.Value * 60 });
            jsonManager.Save_loopTime((int)inputN_loopTimes.Value);
        }

        private void btn_saveAutoBegin_Click(object sender, EventArgs e)
        {
            autoStart = new bool[] { switch_autoFocus.Checked, switch_autoBreak.Checked };
            jsonManager.Save_autoStart(autoStart);
        }

        private void btn_addSubj_Click(object sender, EventArgs e)
        {
            if (select_controlSubject.Text == String.Empty)
            {
                //lbl_tabModfiyMes.Text = "請填入要新增的內容";
                return;
            }
            if (!select_controlSubject.Items.Contains(select_controlSubject.Text))
            {
                select_controlSubject.Items.Add(select_controlSubject.Text);
                tableSubject.Add(select_controlSubject.Text);
                this.jsonManager.Save_table_subject(tableSubject);
            }
        }

        private void btn_delSubj_Click(object sender, EventArgs e)
        {
            if (select_controlSubject.SelectedValue == null)
            {
                //lbl_tabModfiyMes.Text = "請選擇要刪除的內容";
                return;
            }
            else
            {
                foreach (var Item in select_controlSubject.SelectedValue)
                {
                    tableSubject.Remove(Item.ToString());
                    select_controlSubject.ClearSelect();
                    select_controlSubject.Items.Remove(Item);
                    this.jsonManager.Save_table_subject(tableSubject);
                }
            }
        }

        private void btn_clearAllSubject_Click(object sender, EventArgs e)
        {
            tableSubject.Clear();
            select_controlSubject.ClearSelect();
            select_controlSubject.Items.Clear();
            this.jsonManager.Save_table_subject(tableSubject);
        }

        private void btn_addClass_Click(object sender, EventArgs e)
        {
            if (select_controlClass.Text == String.Empty)
            {
                //lbl_tabModfiyMes.Text = "請填入要新增的內容";
                return;
            }
            if (!select_controlClass.Items.Contains(select_controlClass.Text))
            {
                select_controlClass.Items.Add(select_controlClass.Text);
                tableClassification.Add(select_controlClass.Text);
                this.jsonManager.Save_tableClassification(tableClassification);
            }
        }

        private void btn_delClass_Click(object sender, EventArgs e)
        {
            if (select_controlClass.SelectedValue == null)
            {
                //lbl_tabModfiyMes.Text = "請選擇要刪除的內容";
                return;
            }
            else
            {
                foreach (var Item in select_controlClass.SelectedValue)
                {
                    tableClassification.Remove(Item.ToString());
                    select_controlClass.ClearSelect();
                    select_controlClass.Items.Remove(Item);
                    this.jsonManager.Save_tableClassification(tableClassification);
                }
            }
        }

        private void btn_clearAllClass_Click(object sender, EventArgs e)
        {
            tableClassification.Clear();
            select_controlClass.ClearSelect();
            select_controlClass.Items.Clear();
            this.jsonManager.Save_tableClassification(tableClassification);
        }

        private void btn_clearFinish_Click(object sender, EventArgs e)
        {
            ToDoTask[] tmp_table = new ToDoTask[tableToDoTask.Count];
            stackPanel_FinishTask.Controls.Clear();
            tableToDoTask.CopyTo(tmp_table);
            foreach (ToDoTask task in tmp_table)
            {
                if (task.finish == true)
                {
                    tableToDoTask.Remove(task);
                }
            }
        }

        private void btn_clearAllTask_Click(object sender, EventArgs e)
        {
            stackPanel_FinishTask.Controls.Clear();
            tableToDoTask.Clear();
        }

        private void btn_saveToDoTask_Click(object sender, EventArgs e)
        {
            jsonManager.Save_tableToDoTask(tableToDoTask);
            stackPanel_FinishTask.Controls.Clear();
            foreach (var toDoTask in tableToDoTask)
            {
                int dayDiff = (toDoTask.deadline.Date - DateTime.Today).Days;
                if (toDoTask.finish)
                {
                    toDoTask.add_to_panel(stackPanel_FinishTask);
                }
            }
        }

        private void select_panelNum_SelectedIndexChanged(object sender, IntEventArgs e)
        {
            if (select_panelNum.SelectedValue is null)
            {
                return;
            }
            showPanel = Convert.ToUInt16(select_panelNum.SelectedValue);
            jsonManager.Save_showPanel(showPanel);
        }

        private void select_range_SelectedIndexChanged(object sender, IntEventArgs e)
        {
            if (select_range.SelectedIndex == -1)
            {
                return;
            }
            showRangeMode = Convert.ToUInt16(select_range.SelectedIndex);
            jsonManager.Save_showRangeMode(showRangeMode);
        }
    }
}
