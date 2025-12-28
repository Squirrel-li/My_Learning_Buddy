namespace project
{
    partial class From_settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AntdUI.Tabs.StyleLine styleLine1 = new AntdUI.Tabs.StyleLine();
            this.tabs = new AntdUI.Tabs();
            this.tb_task = new AntdUI.TabPage();
            this.gridPanel_setTask = new AntdUI.GridPanel();
            this.panel_setTaskFinish = new AntdUI.Panel();
            this.stackPanel_FinishTask = new AntdUI.StackPanel();
            this.gridPanell_setTaskFinishButton = new AntdUI.GridPanel();
            this.btn_saveToDoTask = new AntdUI.Button();
            this.btn_clearAllTask = new AntdUI.Button();
            this.btn_clearFinish = new AntdUI.Button();
            this.label4 = new AntdUI.Label();
            this.panel_setTaskSelect = new AntdUI.Panel();
            this.btn_clearAllClass = new AntdUI.Button();
            this.select_range = new AntdUI.Select();
            this.btn_clearAllSubject = new AntdUI.Button();
            this.label1 = new AntdUI.Label();
            this.label15 = new AntdUI.Label();
            this.label16 = new AntdUI.Label();
            this.btn_addClass = new AntdUI.Button();
            this.select_panelNum = new AntdUI.Select();
            this.btn_delClass = new AntdUI.Button();
            this.label2 = new AntdUI.Label();
            this.select_controlClass = new AntdUI.SelectMultiple();
            this.select_controlSubject = new AntdUI.SelectMultiple();
            this.btn_addSubj = new AntdUI.Button();
            this.btn_delSubj = new AntdUI.Button();
            this.tb_pomo = new AntdUI.TabPage();
            this.gridPanel_setPomo = new AntdUI.GridPanel();
            this.panel_setPomoAuto = new AntdUI.Panel();
            this.btn_saveAutoBegin = new AntdUI.Button();
            this.label11 = new AntdUI.Label();
            this.switch_autoFocus = new AntdUI.Switch();
            this.label12 = new AntdUI.Label();
            this.switch_autoBreak = new AntdUI.Switch();
            this.panel_setPomoTime = new AntdUI.Panel();
            this.inputN_focus = new AntdUI.InputNumber();
            this.btn_saveTime = new AntdUI.Button();
            this.label7 = new AntdUI.Label();
            this.inputN_shortBreak = new AntdUI.InputNumber();
            this.label8 = new AntdUI.Label();
            this.inputN_longBreak = new AntdUI.InputNumber();
            this.label9 = new AntdUI.Label();
            this.inputN_loopTimes = new AntdUI.InputNumber();
            this.label10 = new AntdUI.Label();
            this.tb_display = new AntdUI.TabPage();
            this.panel_show = new AntdUI.Panel();
            this.lbl_total = new AntdUI.Label();
            this.pageHeader = new AntdUI.PageHeader();
            this.tabs.SuspendLayout();
            this.tb_task.SuspendLayout();
            this.gridPanel_setTask.SuspendLayout();
            this.panel_setTaskFinish.SuspendLayout();
            this.gridPanell_setTaskFinishButton.SuspendLayout();
            this.panel_setTaskSelect.SuspendLayout();
            this.tb_pomo.SuspendLayout();
            this.gridPanel_setPomo.SuspendLayout();
            this.panel_setPomoAuto.SuspendLayout();
            this.panel_setPomoTime.SuspendLayout();
            this.tb_display.SuspendLayout();
            this.panel_show.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabs.Controls.Add(this.tb_display);
            this.tabs.Controls.Add(this.tb_task);
            this.tabs.Controls.Add(this.tb_pomo);
            this.tabs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Fill = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(156)))), ((int)(((byte)(109)))));
            this.tabs.FillActive = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(156)))), ((int)(((byte)(109)))));
            this.tabs.FillHover = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(130)))), ((int)(((byte)(121)))));
            this.tabs.Font = new System.Drawing.Font("微軟正黑體", 18F);
            this.tabs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(130)))), ((int)(((byte)(121)))));
            this.tabs.Location = new System.Drawing.Point(0, 54);
            this.tabs.Name = "tabs";
            this.tabs.Pages.Add(this.tb_display);
            this.tabs.Pages.Add(this.tb_task);
            this.tabs.Pages.Add(this.tb_pomo);
            this.tabs.Size = new System.Drawing.Size(800, 452);
            this.tabs.Style = styleLine1;
            this.tabs.TabIndex = 6;
            this.tabs.Text = "全域設定";
            this.tabs.TypExceed = AntdUI.TabTypExceed.None;
            this.tabs.SelectedIndexChanged += new AntdUI.IntEventHandler(this.tabs1_SelectedIndexChanged);
            // 
            // tb_task
            // 
            this.tb_task.Controls.Add(this.gridPanel_setTask);
            this.tb_task.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_task.Font = new System.Drawing.Font("微軟正黑體", 14.25F);
            this.tb_task.Location = new System.Drawing.Point(142, 0);
            this.tb_task.Name = "tb_task";
            this.tb_task.Size = new System.Drawing.Size(658, 452);
            this.tb_task.TabIndex = 1;
            this.tb_task.Text = "任務設定";
            // 
            // gridPanel_setTask
            // 
            this.gridPanel_setTask.Controls.Add(this.panel_setTaskFinish);
            this.gridPanel_setTask.Controls.Add(this.panel_setTaskSelect);
            this.gridPanel_setTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPanel_setTask.Location = new System.Drawing.Point(0, 0);
            this.gridPanel_setTask.Name = "gridPanel_setTask";
            this.gridPanel_setTask.Size = new System.Drawing.Size(658, 452);
            this.gridPanel_setTask.Span = "60% 40%";
            this.gridPanel_setTask.TabIndex = 1;
            this.gridPanel_setTask.Text = "gridPanel2";
            // 
            // panel_setTaskFinish
            // 
            this.panel_setTaskFinish.Back = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel_setTaskFinish.Controls.Add(this.stackPanel_FinishTask);
            this.panel_setTaskFinish.Controls.Add(this.gridPanell_setTaskFinishButton);
            this.panel_setTaskFinish.Controls.Add(this.label4);
            this.panel_setTaskFinish.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel_setTaskFinish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_setTaskFinish.Location = new System.Drawing.Point(398, 3);
            this.panel_setTaskFinish.Name = "panel_setTaskFinish";
            this.panel_setTaskFinish.Shadow = 10;
            this.panel_setTaskFinish.Size = new System.Drawing.Size(257, 446);
            this.panel_setTaskFinish.TabIndex = 78;
            this.panel_setTaskFinish.Text = "panel3";
            // 
            // stackPanel_FinishTask
            // 
            this.stackPanel_FinishTask.AutoScroll = true;
            this.stackPanel_FinishTask.BackColor = System.Drawing.Color.Transparent;
            this.stackPanel_FinishTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel_FinishTask.Location = new System.Drawing.Point(10, 40);
            this.stackPanel_FinishTask.Name = "stackPanel_FinishTask";
            this.stackPanel_FinishTask.Size = new System.Drawing.Size(237, 315);
            this.stackPanel_FinishTask.TabIndex = 0;
            this.stackPanel_FinishTask.Text = "stackPanel1";
            this.stackPanel_FinishTask.Vertical = true;
            // 
            // gridPanell_setTaskFinishButton
            // 
            this.gridPanell_setTaskFinishButton.Controls.Add(this.btn_saveToDoTask);
            this.gridPanell_setTaskFinishButton.Controls.Add(this.btn_clearAllTask);
            this.gridPanell_setTaskFinishButton.Controls.Add(this.btn_clearFinish);
            this.gridPanell_setTaskFinishButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridPanell_setTaskFinishButton.Location = new System.Drawing.Point(10, 355);
            this.gridPanell_setTaskFinishButton.Name = "gridPanell_setTaskFinishButton";
            this.gridPanell_setTaskFinishButton.Size = new System.Drawing.Size(237, 81);
            this.gridPanell_setTaskFinishButton.Span = "33% 33% 34%";
            this.gridPanell_setTaskFinishButton.TabIndex = 84;
            this.gridPanell_setTaskFinishButton.Text = "gridPanel3";
            // 
            // btn_saveToDoTask
            // 
            this.btn_saveToDoTask.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.btn_saveToDoTask.Location = new System.Drawing.Point(157, 1);
            this.btn_saveToDoTask.Margin = new System.Windows.Forms.Padding(1);
            this.btn_saveToDoTask.Name = "btn_saveToDoTask";
            this.btn_saveToDoTask.Size = new System.Drawing.Size(79, 79);
            this.btn_saveToDoTask.TabIndex = 65;
            this.btn_saveToDoTask.Text = "儲存";
            this.btn_saveToDoTask.Click += new System.EventHandler(this.btn_saveToDoTask_Click);
            // 
            // btn_clearAllTask
            // 
            this.btn_clearAllTask.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.btn_clearAllTask.Location = new System.Drawing.Point(79, 1);
            this.btn_clearAllTask.Margin = new System.Windows.Forms.Padding(1);
            this.btn_clearAllTask.Name = "btn_clearAllTask";
            this.btn_clearAllTask.Size = new System.Drawing.Size(76, 79);
            this.btn_clearAllTask.TabIndex = 65;
            this.btn_clearAllTask.Text = "清除\r\n全部";
            this.btn_clearAllTask.Click += new System.EventHandler(this.btn_clearAllTask_Click);
            // 
            // btn_clearFinish
            // 
            this.btn_clearFinish.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.btn_clearFinish.Location = new System.Drawing.Point(1, 1);
            this.btn_clearFinish.Margin = new System.Windows.Forms.Padding(1);
            this.btn_clearFinish.Name = "btn_clearFinish";
            this.btn_clearFinish.Size = new System.Drawing.Size(76, 79);
            this.btn_clearFinish.TabIndex = 66;
            this.btn_clearFinish.Text = "清除\r\n完成";
            this.btn_clearFinish.Click += new System.EventHandler(this.btn_clearFinish_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(10, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 30);
            this.label4.TabIndex = 1;
            this.label4.Text = "已完成的 To-Do List";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_setTaskSelect
            // 
            this.panel_setTaskSelect.Back = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel_setTaskSelect.Controls.Add(this.btn_clearAllClass);
            this.panel_setTaskSelect.Controls.Add(this.select_range);
            this.panel_setTaskSelect.Controls.Add(this.btn_clearAllSubject);
            this.panel_setTaskSelect.Controls.Add(this.label1);
            this.panel_setTaskSelect.Controls.Add(this.label15);
            this.panel_setTaskSelect.Controls.Add(this.label16);
            this.panel_setTaskSelect.Controls.Add(this.btn_addClass);
            this.panel_setTaskSelect.Controls.Add(this.select_panelNum);
            this.panel_setTaskSelect.Controls.Add(this.btn_delClass);
            this.panel_setTaskSelect.Controls.Add(this.label2);
            this.panel_setTaskSelect.Controls.Add(this.select_controlClass);
            this.panel_setTaskSelect.Controls.Add(this.select_controlSubject);
            this.panel_setTaskSelect.Controls.Add(this.btn_addSubj);
            this.panel_setTaskSelect.Controls.Add(this.btn_delSubj);
            this.panel_setTaskSelect.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel_setTaskSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_setTaskSelect.Location = new System.Drawing.Point(3, 3);
            this.panel_setTaskSelect.Name = "panel_setTaskSelect";
            this.panel_setTaskSelect.Shadow = 10;
            this.panel_setTaskSelect.Size = new System.Drawing.Size(389, 446);
            this.panel_setTaskSelect.TabIndex = 70;
            this.panel_setTaskSelect.Text = "panel4";
            // 
            // btn_clearAllClass
            // 
            this.btn_clearAllClass.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.btn_clearAllClass.Location = new System.Drawing.Point(277, 286);
            this.btn_clearAllClass.Name = "btn_clearAllClass";
            this.btn_clearAllClass.Size = new System.Drawing.Size(114, 43);
            this.btn_clearAllClass.TabIndex = 64;
            this.btn_clearAllClass.Text = "清除全部";
            this.btn_clearAllClass.Click += new System.EventHandler(this.btn_clearAllClass_Click);
            // 
            // select_range
            // 
            this.select_range.Font = new System.Drawing.Font("微軟正黑體", 18F);
            this.select_range.List = true;
            this.select_range.Location = new System.Drawing.Point(125, 63);
            this.select_range.Name = "select_range";
            this.select_range.Size = new System.Drawing.Size(143, 47);
            this.select_range.TabIndex = 83;
            this.select_range.SelectedIndexChanged += new AntdUI.IntEventHandler(this.select_range_SelectedIndexChanged);
            // 
            // btn_clearAllSubject
            // 
            this.btn_clearAllSubject.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.btn_clearAllSubject.Location = new System.Drawing.Point(277, 177);
            this.btn_clearAllSubject.Name = "btn_clearAllSubject";
            this.btn_clearAllSubject.Size = new System.Drawing.Size(114, 43);
            this.btn_clearAllSubject.TabIndex = 65;
            this.btn_clearAllSubject.Text = "清除全部";
            this.btn_clearAllSubject.Click += new System.EventHandler(this.btn_clearAllSubject_Click);
            // 
            // label1
            // 
            this.label1.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F);
            this.label1.Location = new System.Drawing.Point(16, 241);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 32);
            this.label1.TabIndex = 63;
            this.label1.Text = "類別";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("微軟正黑體", 18F);
            this.label15.Location = new System.Drawing.Point(16, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 44);
            this.label15.TabIndex = 81;
            this.label15.Text = "顯示天數";
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("微軟正黑體", 18F);
            this.label16.Location = new System.Drawing.Point(17, 63);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(102, 44);
            this.label16.TabIndex = 80;
            this.label16.Text = "顯示範圍";
            // 
            // btn_addClass
            // 
            this.btn_addClass.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.btn_addClass.Location = new System.Drawing.Point(219, 237);
            this.btn_addClass.Name = "btn_addClass";
            this.btn_addClass.Size = new System.Drawing.Size(83, 43);
            this.btn_addClass.TabIndex = 59;
            this.btn_addClass.Text = "新增";
            this.btn_addClass.Click += new System.EventHandler(this.btn_addClass_Click);
            // 
            // select_panelNum
            // 
            this.select_panelNum.Font = new System.Drawing.Font("微軟正黑體", 18F);
            this.select_panelNum.List = true;
            this.select_panelNum.Location = new System.Drawing.Point(125, 13);
            this.select_panelNum.Name = "select_panelNum";
            this.select_panelNum.Size = new System.Drawing.Size(143, 47);
            this.select_panelNum.TabIndex = 82;
            this.select_panelNum.SelectedIndexChanged += new AntdUI.IntEventHandler(this.select_panelNum_SelectedIndexChanged);
            // 
            // btn_delClass
            // 
            this.btn_delClass.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.btn_delClass.Location = new System.Drawing.Point(308, 237);
            this.btn_delClass.Name = "btn_delClass";
            this.btn_delClass.Size = new System.Drawing.Size(83, 43);
            this.btn_delClass.TabIndex = 58;
            this.btn_delClass.Text = "刪除";
            this.btn_delClass.Click += new System.EventHandler(this.btn_delClass_Click);
            // 
            // label2
            // 
            this.label2.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 18F);
            this.label2.Location = new System.Drawing.Point(17, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 32);
            this.label2.TabIndex = 62;
            this.label2.Text = "科目";
            // 
            // select_controlClass
            // 
            this.select_controlClass.Font = new System.Drawing.Font("微軟正黑體", 18F);
            this.select_controlClass.Location = new System.Drawing.Point(70, 233);
            this.select_controlClass.Name = "select_controlClass";
            this.select_controlClass.Size = new System.Drawing.Size(143, 47);
            this.select_controlClass.TabIndex = 60;
            // 
            // select_controlSubject
            // 
            this.select_controlSubject.Font = new System.Drawing.Font("微軟正黑體", 18F);
            this.select_controlSubject.Location = new System.Drawing.Point(71, 128);
            this.select_controlSubject.Name = "select_controlSubject";
            this.select_controlSubject.Size = new System.Drawing.Size(143, 47);
            this.select_controlSubject.TabIndex = 61;
            // 
            // btn_addSubj
            // 
            this.btn_addSubj.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.btn_addSubj.Location = new System.Drawing.Point(219, 128);
            this.btn_addSubj.Name = "btn_addSubj";
            this.btn_addSubj.Size = new System.Drawing.Size(83, 43);
            this.btn_addSubj.TabIndex = 57;
            this.btn_addSubj.Text = "新增";
            this.btn_addSubj.Click += new System.EventHandler(this.btn_addSubj_Click);
            // 
            // btn_delSubj
            // 
            this.btn_delSubj.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.btn_delSubj.Location = new System.Drawing.Point(308, 128);
            this.btn_delSubj.Name = "btn_delSubj";
            this.btn_delSubj.Size = new System.Drawing.Size(83, 43);
            this.btn_delSubj.TabIndex = 56;
            this.btn_delSubj.Text = "刪除";
            this.btn_delSubj.Click += new System.EventHandler(this.btn_delSubj_Click);
            // 
            // tb_pomo
            // 
            this.tb_pomo.Controls.Add(this.gridPanel_setPomo);
            this.tb_pomo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_pomo.Font = new System.Drawing.Font("微軟正黑體", 14.25F);
            this.tb_pomo.Location = new System.Drawing.Point(142, 0);
            this.tb_pomo.Name = "tb_pomo";
            this.tb_pomo.Size = new System.Drawing.Size(658, 452);
            this.tb_pomo.TabIndex = 2;
            this.tb_pomo.Text = "番茄鐘設定";
            // 
            // gridPanel_setPomo
            // 
            this.gridPanel_setPomo.Controls.Add(this.panel_setPomoAuto);
            this.gridPanel_setPomo.Controls.Add(this.panel_setPomoTime);
            this.gridPanel_setPomo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPanel_setPomo.Location = new System.Drawing.Point(0, 0);
            this.gridPanel_setPomo.Name = "gridPanel_setPomo";
            this.gridPanel_setPomo.Size = new System.Drawing.Size(658, 452);
            this.gridPanel_setPomo.Span = "50% 50%";
            this.gridPanel_setPomo.TabIndex = 0;
            this.gridPanel_setPomo.Text = "gridPanel1";
            // 
            // panel_setPomoAuto
            // 
            this.panel_setPomoAuto.Back = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel_setPomoAuto.Controls.Add(this.btn_saveAutoBegin);
            this.panel_setPomoAuto.Controls.Add(this.label11);
            this.panel_setPomoAuto.Controls.Add(this.switch_autoFocus);
            this.panel_setPomoAuto.Controls.Add(this.label12);
            this.panel_setPomoAuto.Controls.Add(this.switch_autoBreak);
            this.panel_setPomoAuto.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel_setPomoAuto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_setPomoAuto.Location = new System.Drawing.Point(332, 3);
            this.panel_setPomoAuto.Name = "panel_setPomoAuto";
            this.panel_setPomoAuto.Shadow = 10;
            this.panel_setPomoAuto.Size = new System.Drawing.Size(323, 446);
            this.panel_setPomoAuto.TabIndex = 78;
            this.panel_setPomoAuto.Text = "panel1";
            // 
            // btn_saveAutoBegin
            // 
            this.btn_saveAutoBegin.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.btn_saveAutoBegin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_saveAutoBegin.Location = new System.Drawing.Point(218, 294);
            this.btn_saveAutoBegin.Name = "btn_saveAutoBegin";
            this.btn_saveAutoBegin.Size = new System.Drawing.Size(92, 49);
            this.btn_saveAutoBegin.TabIndex = 78;
            this.btn_saveAutoBegin.Text = "儲存";
            this.btn_saveAutoBegin.Click += new System.EventHandler(this.btn_saveAutoBegin_Click);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 18F);
            this.label11.Location = new System.Drawing.Point(65, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 33);
            this.label11.TabIndex = 59;
            this.label11.Text = "自動開始專注";
            // 
            // switch_autoFocus
            // 
            this.switch_autoFocus.Fill = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(141)))), ((int)(((byte)(69)))));
            this.switch_autoFocus.FillHover = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(131)))), ((int)(((byte)(59)))));
            this.switch_autoFocus.Location = new System.Drawing.Point(177, 136);
            this.switch_autoFocus.Name = "switch_autoFocus";
            this.switch_autoFocus.Size = new System.Drawing.Size(80, 40);
            this.switch_autoFocus.TabIndex = 58;
            this.switch_autoFocus.Text = "switch3";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 18F);
            this.label12.Location = new System.Drawing.Point(65, 179);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 33);
            this.label12.TabIndex = 61;
            this.label12.Text = "自動開始休息";
            // 
            // switch_autoBreak
            // 
            this.switch_autoBreak.BackColor = System.Drawing.Color.Transparent;
            this.switch_autoBreak.Location = new System.Drawing.Point(177, 175);
            this.switch_autoBreak.Name = "switch_autoBreak";
            this.switch_autoBreak.Size = new System.Drawing.Size(80, 40);
            this.switch_autoBreak.TabIndex = 60;
            this.switch_autoBreak.Text = "switch4";
            // 
            // panel_setPomoTime
            // 
            this.panel_setPomoTime.Back = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel_setPomoTime.Controls.Add(this.inputN_focus);
            this.panel_setPomoTime.Controls.Add(this.btn_saveTime);
            this.panel_setPomoTime.Controls.Add(this.label7);
            this.panel_setPomoTime.Controls.Add(this.inputN_shortBreak);
            this.panel_setPomoTime.Controls.Add(this.label8);
            this.panel_setPomoTime.Controls.Add(this.inputN_longBreak);
            this.panel_setPomoTime.Controls.Add(this.label9);
            this.panel_setPomoTime.Controls.Add(this.inputN_loopTimes);
            this.panel_setPomoTime.Controls.Add(this.label10);
            this.panel_setPomoTime.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel_setPomoTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_setPomoTime.Location = new System.Drawing.Point(3, 3);
            this.panel_setPomoTime.Name = "panel_setPomoTime";
            this.panel_setPomoTime.Shadow = 10;
            this.panel_setPomoTime.Size = new System.Drawing.Size(323, 446);
            this.panel_setPomoTime.TabIndex = 70;
            this.panel_setPomoTime.Text = "panel2";
            // 
            // inputN_focus
            // 
            this.inputN_focus.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.inputN_focus.Location = new System.Drawing.Point(164, 78);
            this.inputN_focus.Name = "inputN_focus";
            this.inputN_focus.Size = new System.Drawing.Size(135, 44);
            this.inputN_focus.TabIndex = 72;
            this.inputN_focus.Text = "0";
            this.inputN_focus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_saveTime
            // 
            this.btn_saveTime.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.btn_saveTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_saveTime.Location = new System.Drawing.Point(219, 294);
            this.btn_saveTime.Name = "btn_saveTime";
            this.btn_saveTime.Size = new System.Drawing.Size(92, 49);
            this.btn_saveTime.TabIndex = 17;
            this.btn_saveTime.Text = "儲存";
            this.btn_saveTime.Click += new System.EventHandler(this.btn_saveTime_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 18F);
            this.label7.Location = new System.Drawing.Point(23, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 44);
            this.label7.TabIndex = 73;
            this.label7.Text = "專注時間(m)";
            // 
            // inputN_shortBreak
            // 
            this.inputN_shortBreak.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.inputN_shortBreak.Location = new System.Drawing.Point(164, 130);
            this.inputN_shortBreak.Name = "inputN_shortBreak";
            this.inputN_shortBreak.Size = new System.Drawing.Size(135, 44);
            this.inputN_shortBreak.TabIndex = 70;
            this.inputN_shortBreak.Text = "0";
            this.inputN_shortBreak.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 18F);
            this.label8.Location = new System.Drawing.Point(23, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 44);
            this.label8.TabIndex = 71;
            this.label8.Text = "短休息(m)";
            // 
            // inputN_longBreak
            // 
            this.inputN_longBreak.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.inputN_longBreak.Location = new System.Drawing.Point(164, 181);
            this.inputN_longBreak.Name = "inputN_longBreak";
            this.inputN_longBreak.Size = new System.Drawing.Size(135, 44);
            this.inputN_longBreak.TabIndex = 74;
            this.inputN_longBreak.Text = "0";
            this.inputN_longBreak.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 18F);
            this.label9.Location = new System.Drawing.Point(23, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 44);
            this.label9.TabIndex = 75;
            this.label9.Text = "長休息(m)";
            // 
            // inputN_loopTimes
            // 
            this.inputN_loopTimes.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.inputN_loopTimes.Location = new System.Drawing.Point(164, 233);
            this.inputN_loopTimes.Name = "inputN_loopTimes";
            this.inputN_loopTimes.Size = new System.Drawing.Size(135, 44);
            this.inputN_loopTimes.TabIndex = 76;
            this.inputN_loopTimes.Text = "0";
            this.inputN_loopTimes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 18F);
            this.label10.Location = new System.Drawing.Point(23, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 44);
            this.label10.TabIndex = 77;
            this.label10.Text = "長短休息間隔(次)";
            // 
            // tb_display
            // 
            this.tb_display.Controls.Add(this.panel_show);
            this.tb_display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_display.Font = new System.Drawing.Font("微軟正黑體", 14.25F);
            this.tb_display.Location = new System.Drawing.Point(142, 0);
            this.tb_display.Name = "tb_display";
            this.tb_display.Size = new System.Drawing.Size(658, 452);
            this.tb_display.TabIndex = 0;
            this.tb_display.Text = "統計";
            // 
            // panel_show
            // 
            this.panel_show.Back = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel_show.Controls.Add(this.lbl_total);
            this.panel_show.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel_show.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_show.Location = new System.Drawing.Point(0, 0);
            this.panel_show.Name = "panel_show";
            this.panel_show.Shadow = 10;
            this.panel_show.Size = new System.Drawing.Size(658, 452);
            this.panel_show.TabIndex = 78;
            this.panel_show.Text = "panel5";
            // 
            // lbl_total
            // 
            this.lbl_total.BackColor = System.Drawing.Color.Transparent;
            this.lbl_total.Font = new System.Drawing.Font("微軟正黑體", 20F);
            this.lbl_total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(56)))), ((int)(((byte)(50)))));
            this.lbl_total.Location = new System.Drawing.Point(20, 20);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(372, 323);
            this.lbl_total.TabIndex = 0;
            this.lbl_total.Text = "今日已完成 N 項任務，\r\n本週已完成 N 項任務。\r\n\r\n今日已完成 N 個番茄鐘循環，\r\n本週已完成 N 個番茄鐘循環。\r\n";
            // 
            // pageHeader
            // 
            this.pageHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pageHeader.Font = new System.Drawing.Font("微軟正黑體", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageHeader.Location = new System.Drawing.Point(0, 0);
            this.pageHeader.MaximizeBox = false;
            this.pageHeader.Name = "pageHeader";
            this.pageHeader.ShowButton = true;
            this.pageHeader.Size = new System.Drawing.Size(800, 54);
            this.pageHeader.TabIndex = 18;
            this.pageHeader.Text = "設定";
            // 
            // From_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.pageHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "From_settings";
            this.Text = "settings";
            this.Load += new System.EventHandler(this.From_settings_Load);
            this.tabs.ResumeLayout(false);
            this.tb_task.ResumeLayout(false);
            this.gridPanel_setTask.ResumeLayout(false);
            this.panel_setTaskFinish.ResumeLayout(false);
            this.gridPanell_setTaskFinishButton.ResumeLayout(false);
            this.panel_setTaskSelect.ResumeLayout(false);
            this.panel_setTaskSelect.PerformLayout();
            this.tb_pomo.ResumeLayout(false);
            this.gridPanel_setPomo.ResumeLayout(false);
            this.panel_setPomoAuto.ResumeLayout(false);
            this.panel_setPomoTime.ResumeLayout(false);
            this.tb_display.ResumeLayout(false);
            this.panel_show.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.PageHeader pageHeader;
        private AntdUI.Tabs tabs;
        private AntdUI.TabPage tb_pomo;
        private AntdUI.TabPage tb_display;
        private AntdUI.TabPage tb_task;
        private AntdUI.GridPanel gridPanel_setPomo;
        private AntdUI.GridPanel gridPanell_setTaskFinishButton;
        private AntdUI.GridPanel gridPanel_setTask;
        private AntdUI.StackPanel stackPanel_FinishTask;
        private AntdUI.Panel panel_setPomoTime;
        private AntdUI.Panel panel_setPomoAuto;
        private AntdUI.Panel panel_show;
        private AntdUI.Panel panel_setTaskFinish;
        private AntdUI.Panel panel_setTaskSelect;
        private AntdUI.InputNumber inputN_focus;
        private AntdUI.InputNumber inputN_shortBreak;
        private AntdUI.InputNumber inputN_longBreak;
        private AntdUI.InputNumber inputN_loopTimes;
        private AntdUI.Switch switch_autoFocus;
        private AntdUI.Switch switch_autoBreak;
        private AntdUI.Select select_range;
        private AntdUI.Select select_panelNum;
        private AntdUI.SelectMultiple select_controlClass;
        private AntdUI.SelectMultiple select_controlSubject;
        private AntdUI.Button btn_saveTime;
        private AntdUI.Button btn_clearAllTask;
        private AntdUI.Button btn_clearAllSubject;
        private AntdUI.Button btn_clearAllClass;
        private AntdUI.Button btn_addClass;
        private AntdUI.Button btn_delClass;
        private AntdUI.Button btn_addSubj;
        private AntdUI.Button btn_delSubj;
        private AntdUI.Button btn_saveToDoTask;
        private AntdUI.Button btn_saveAutoBegin;
        private AntdUI.Button btn_clearFinish;
        private AntdUI.Label label4;
        private AntdUI.Label label7;
        private AntdUI.Label label8;
        private AntdUI.Label label9;
        private AntdUI.Label label10;
        private AntdUI.Label label11;
        private AntdUI.Label label12;
        private AntdUI.Label label1;
        private AntdUI.Label label2;
        private AntdUI.Label label15;
        private AntdUI.Label label16;
        private AntdUI.Label lbl_total;
    }
}