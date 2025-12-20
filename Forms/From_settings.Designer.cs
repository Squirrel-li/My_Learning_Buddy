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
            this.tabs1 = new AntdUI.Tabs();
            this.tb_task = new AntdUI.TabPage();
            this.gridPanel2 = new AntdUI.GridPanel();
            this.panel3 = new AntdUI.Panel();
            this.btn_clearAllTask = new AntdUI.Button();
            this.panel4 = new AntdUI.Panel();
            this.btn_clearAllSubject = new AntdUI.Button();
            this.label1 = new AntdUI.Label();
            this.btn_clearAllClass = new AntdUI.Button();
            this.btn_addClass = new AntdUI.Button();
            this.btn_delClass = new AntdUI.Button();
            this.label2 = new AntdUI.Label();
            this.select_controlClass = new AntdUI.SelectMultiple();
            this.select_controlSubject = new AntdUI.SelectMultiple();
            this.btn_addSubj = new AntdUI.Button();
            this.btn_delSubj = new AntdUI.Button();
            this.tb_display = new AntdUI.TabPage();
            this.gridPanel3 = new AntdUI.GridPanel();
            this.panel5 = new AntdUI.Panel();
            this.panel6 = new AntdUI.Panel();
            this.select1 = new AntdUI.Select();
            this.select_panelNum = new AntdUI.Select();
            this.label15 = new AntdUI.Label();
            this.label16 = new AntdUI.Label();
            this.tb_pomo = new AntdUI.TabPage();
            this.gridPanel1 = new AntdUI.GridPanel();
            this.panel1 = new AntdUI.Panel();
            this.label11 = new AntdUI.Label();
            this.switch_autoFocus = new AntdUI.Switch();
            this.label12 = new AntdUI.Label();
            this.switch_autoBreak = new AntdUI.Switch();
            this.panel2 = new AntdUI.Panel();
            this.inputN_focus = new AntdUI.InputNumber();
            this.label7 = new AntdUI.Label();
            this.inputN_shortBreak = new AntdUI.InputNumber();
            this.label8 = new AntdUI.Label();
            this.inputN_longBreak = new AntdUI.InputNumber();
            this.label9 = new AntdUI.Label();
            this.inputN_loopTimes = new AntdUI.InputNumber();
            this.label10 = new AntdUI.Label();
            this.btn_save = new AntdUI.Button();
            this.pageHeader1 = new AntdUI.PageHeader();
            this.tabs1.SuspendLayout();
            this.tb_task.SuspendLayout();
            this.gridPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tb_display.SuspendLayout();
            this.gridPanel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tb_pomo.SuspendLayout();
            this.gridPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs1
            // 
            this.tabs1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabs1.Controls.Add(this.tb_pomo);
            this.tabs1.Controls.Add(this.tb_task);
            this.tabs1.Controls.Add(this.tb_display);
            this.tabs1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabs1.Font = new System.Drawing.Font("微軟正黑體", 14.25F);
            this.tabs1.Location = new System.Drawing.Point(12, 77);
            this.tabs1.Name = "tabs1";
            this.tabs1.Pages.Add(this.tb_display);
            this.tabs1.Pages.Add(this.tb_task);
            this.tabs1.Pages.Add(this.tb_pomo);
            this.tabs1.SelectedIndex = 2;
            this.tabs1.Size = new System.Drawing.Size(776, 362);
            this.tabs1.Style = styleLine1;
            this.tabs1.TabIndex = 6;
            this.tabs1.Text = "全域設定";
            // 
            // tb_task
            // 
            this.tb_task.Controls.Add(this.gridPanel2);
            this.tb_task.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_task.Font = new System.Drawing.Font("微軟正黑體", 14.25F);
            this.tb_task.Location = new System.Drawing.Point(117, 0);
            this.tb_task.Name = "tb_task";
            this.tb_task.Size = new System.Drawing.Size(659, 362);
            this.tb_task.TabIndex = 1;
            this.tb_task.Text = "任務設定";
            // 
            // gridPanel2
            // 
            this.gridPanel2.Controls.Add(this.panel3);
            this.gridPanel2.Controls.Add(this.panel4);
            this.gridPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPanel2.Location = new System.Drawing.Point(0, 0);
            this.gridPanel2.Name = "gridPanel2";
            this.gridPanel2.Size = new System.Drawing.Size(659, 362);
            this.gridPanel2.Span = "50% 50%";
            this.gridPanel2.TabIndex = 1;
            this.gridPanel2.Text = "gridPanel2";
            // 
            // panel3
            // 
            this.panel3.Back = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel3.Controls.Add(this.btn_clearAllTask);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel3.Location = new System.Drawing.Point(333, 3);
            this.panel3.Name = "panel3";
            this.panel3.Shadow = 10;
            this.panel3.Size = new System.Drawing.Size(324, 356);
            this.panel3.TabIndex = 78;
            this.panel3.Text = "panel3";
            // 
            // btn_clearAllTask
            // 
            this.btn_clearAllTask.BackColor = System.Drawing.Color.Transparent;
            this.btn_clearAllTask.DefaultBack = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.btn_clearAllTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_clearAllTask.Font = new System.Drawing.Font("微軟正黑體", 60F);
            this.btn_clearAllTask.Location = new System.Drawing.Point(10, 10);
            this.btn_clearAllTask.Name = "btn_clearAllTask";
            this.btn_clearAllTask.Size = new System.Drawing.Size(304, 336);
            this.btn_clearAllTask.TabIndex = 65;
            this.btn_clearAllTask.Text = "清除所有任務";
            this.btn_clearAllTask.TextMultiLine = true;
            this.btn_clearAllTask.Click += new System.EventHandler(this.btn_clearAllTask_Click);
            // 
            // panel4
            // 
            this.panel4.Back = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel4.Controls.Add(this.btn_clearAllSubject);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btn_clearAllClass);
            this.panel4.Controls.Add(this.btn_addClass);
            this.panel4.Controls.Add(this.btn_delClass);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.select_controlClass);
            this.panel4.Controls.Add(this.select_controlSubject);
            this.panel4.Controls.Add(this.btn_addSubj);
            this.panel4.Controls.Add(this.btn_delSubj);
            this.panel4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Shadow = 10;
            this.panel4.Size = new System.Drawing.Size(324, 356);
            this.panel4.TabIndex = 70;
            this.panel4.Text = "panel4";
            // 
            // btn_clearAllSubject
            // 
            this.btn_clearAllSubject.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.btn_clearAllSubject.Location = new System.Drawing.Point(13, 76);
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
            this.label1.Location = new System.Drawing.Point(16, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 26);
            this.label1.TabIndex = 63;
            this.label1.Text = "類別";
            // 
            // btn_clearAllClass
            // 
            this.btn_clearAllClass.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.btn_clearAllClass.Location = new System.Drawing.Point(16, 176);
            this.btn_clearAllClass.Name = "btn_clearAllClass";
            this.btn_clearAllClass.Size = new System.Drawing.Size(114, 43);
            this.btn_clearAllClass.TabIndex = 64;
            this.btn_clearAllClass.Text = "清除全部";
            this.btn_clearAllClass.Click += new System.EventHandler(this.btn_clearAllClass_Click);
            // 
            // btn_addClass
            // 
            this.btn_addClass.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.btn_addClass.Location = new System.Drawing.Point(136, 176);
            this.btn_addClass.Name = "btn_addClass";
            this.btn_addClass.Size = new System.Drawing.Size(83, 43);
            this.btn_addClass.TabIndex = 59;
            this.btn_addClass.Text = "新增";
            this.btn_addClass.Click += new System.EventHandler(this.btn_addClass_Click);
            // 
            // btn_delClass
            // 
            this.btn_delClass.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.btn_delClass.Location = new System.Drawing.Point(225, 176);
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
            this.label2.Location = new System.Drawing.Point(16, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 26);
            this.label2.TabIndex = 62;
            this.label2.Text = "科目";
            // 
            // select_controlClass
            // 
            this.select_controlClass.Location = new System.Drawing.Point(60, 133);
            this.select_controlClass.Name = "select_controlClass";
            this.select_controlClass.Size = new System.Drawing.Size(248, 37);
            this.select_controlClass.TabIndex = 60;
            // 
            // select_controlSubject
            // 
            this.select_controlSubject.Location = new System.Drawing.Point(60, 33);
            this.select_controlSubject.Name = "select_controlSubject";
            this.select_controlSubject.Size = new System.Drawing.Size(248, 37);
            this.select_controlSubject.TabIndex = 61;
            // 
            // btn_addSubj
            // 
            this.btn_addSubj.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.btn_addSubj.Location = new System.Drawing.Point(136, 76);
            this.btn_addSubj.Name = "btn_addSubj";
            this.btn_addSubj.Size = new System.Drawing.Size(83, 43);
            this.btn_addSubj.TabIndex = 57;
            this.btn_addSubj.Text = "新增";
            this.btn_addSubj.Click += new System.EventHandler(this.btn_addSubj_Click);
            // 
            // btn_delSubj
            // 
            this.btn_delSubj.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.btn_delSubj.Location = new System.Drawing.Point(225, 76);
            this.btn_delSubj.Name = "btn_delSubj";
            this.btn_delSubj.Size = new System.Drawing.Size(83, 43);
            this.btn_delSubj.TabIndex = 56;
            this.btn_delSubj.Text = "刪除";
            this.btn_delSubj.Click += new System.EventHandler(this.btn_delSubj_Click);
            // 
            // tb_display
            // 
            this.tb_display.Controls.Add(this.gridPanel3);
            this.tb_display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_display.Font = new System.Drawing.Font("微軟正黑體", 14.25F);
            this.tb_display.Location = new System.Drawing.Point(117, 0);
            this.tb_display.Name = "tb_display";
            this.tb_display.Size = new System.Drawing.Size(659, 362);
            this.tb_display.TabIndex = 0;
            this.tb_display.Text = "顯示設定";
            // 
            // gridPanel3
            // 
            this.gridPanel3.Controls.Add(this.panel5);
            this.gridPanel3.Controls.Add(this.panel6);
            this.gridPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPanel3.Location = new System.Drawing.Point(0, 0);
            this.gridPanel3.Name = "gridPanel3";
            this.gridPanel3.Size = new System.Drawing.Size(659, 362);
            this.gridPanel3.Span = "50% 50%";
            this.gridPanel3.TabIndex = 1;
            this.gridPanel3.Text = "gridPanel3";
            // 
            // panel5
            // 
            this.panel5.Back = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel5.Location = new System.Drawing.Point(333, 3);
            this.panel5.Name = "panel5";
            this.panel5.Shadow = 10;
            this.panel5.Size = new System.Drawing.Size(324, 356);
            this.panel5.TabIndex = 78;
            this.panel5.Text = "panel5";
            // 
            // panel6
            // 
            this.panel6.Back = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel6.Controls.Add(this.select1);
            this.panel6.Controls.Add(this.select_panelNum);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.label16);
            this.panel6.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Shadow = 10;
            this.panel6.Size = new System.Drawing.Size(324, 356);
            this.panel6.TabIndex = 70;
            this.panel6.Text = "panel6";
            // 
            // select1
            // 
            this.select1.Location = new System.Drawing.Point(164, 130);
            this.select1.Name = "select1";
            this.select1.Size = new System.Drawing.Size(135, 44);
            this.select1.TabIndex = 79;
            // 
            // select_panelNum
            // 
            this.select_panelNum.Location = new System.Drawing.Point(164, 78);
            this.select_panelNum.Name = "select_panelNum";
            this.select_panelNum.Size = new System.Drawing.Size(135, 44);
            this.select_panelNum.TabIndex = 78;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.label15.Location = new System.Drawing.Point(23, 78);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(135, 44);
            this.label15.TabIndex = 73;
            this.label15.Text = "任務顯示天數";
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.label16.Location = new System.Drawing.Point(23, 130);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(135, 44);
            this.label16.TabIndex = 71;
            this.label16.Text = "未來任務顯示範圍";
            // 
            // tb_pomo
            // 
            this.tb_pomo.Controls.Add(this.gridPanel1);
            this.tb_pomo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_pomo.Font = new System.Drawing.Font("微軟正黑體", 14.25F);
            this.tb_pomo.Location = new System.Drawing.Point(117, 0);
            this.tb_pomo.Name = "tb_pomo";
            this.tb_pomo.Size = new System.Drawing.Size(659, 362);
            this.tb_pomo.TabIndex = 2;
            this.tb_pomo.Text = "番茄鐘設定";
            // 
            // gridPanel1
            // 
            this.gridPanel1.Controls.Add(this.panel1);
            this.gridPanel1.Controls.Add(this.panel2);
            this.gridPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPanel1.Location = new System.Drawing.Point(0, 0);
            this.gridPanel1.Name = "gridPanel1";
            this.gridPanel1.Size = new System.Drawing.Size(659, 362);
            this.gridPanel1.Span = "50% 50%";
            this.gridPanel1.TabIndex = 0;
            this.gridPanel1.Text = "gridPanel1";
            // 
            // panel1
            // 
            this.panel1.Back = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.switch_autoFocus);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.switch_autoBreak);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Location = new System.Drawing.Point(333, 3);
            this.panel1.Name = "panel1";
            this.panel1.Shadow = 10;
            this.panel1.Size = new System.Drawing.Size(324, 356);
            this.panel1.TabIndex = 78;
            this.panel1.Text = "panel1";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.label11.Location = new System.Drawing.Point(65, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 33);
            this.label11.TabIndex = 59;
            this.label11.Text = "自動開始專注";
            // 
            // switch_autoFocus
            // 
            this.switch_autoFocus.Location = new System.Drawing.Point(177, 136);
            this.switch_autoFocus.Name = "switch_autoFocus";
            this.switch_autoFocus.Size = new System.Drawing.Size(80, 40);
            this.switch_autoFocus.TabIndex = 58;
            this.switch_autoFocus.Text = "switch3";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.label12.Location = new System.Drawing.Point(65, 179);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 33);
            this.label12.TabIndex = 61;
            this.label12.Text = "自動開始休息";
            // 
            // switch_autoBreak
            // 
            this.switch_autoBreak.Location = new System.Drawing.Point(177, 175);
            this.switch_autoBreak.Name = "switch_autoBreak";
            this.switch_autoBreak.Size = new System.Drawing.Size(80, 40);
            this.switch_autoBreak.TabIndex = 60;
            this.switch_autoBreak.Text = "switch4";
            // 
            // panel2
            // 
            this.panel2.Back = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel2.Controls.Add(this.inputN_focus);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.inputN_shortBreak);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.inputN_longBreak);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.inputN_loopTimes);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Shadow = 10;
            this.panel2.Size = new System.Drawing.Size(324, 356);
            this.panel2.TabIndex = 70;
            this.panel2.Text = "panel2";
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
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F);
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
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 12F);
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
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 12F);
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
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.label10.Location = new System.Drawing.Point(23, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 44);
            this.label10.TabIndex = 77;
            this.label10.Text = "長短休息間隔(次)";
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.btn_save.Location = new System.Drawing.Point(645, 445);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(143, 49);
            this.btn_save.TabIndex = 17;
            this.btn_save.Text = "全部儲存";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // pageHeader1
            // 
            this.pageHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pageHeader1.Font = new System.Drawing.Font("微軟正黑體", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageHeader1.Location = new System.Drawing.Point(0, 0);
            this.pageHeader1.MaximizeBox = false;
            this.pageHeader1.Name = "pageHeader1";
            this.pageHeader1.ShowButton = true;
            this.pageHeader1.Size = new System.Drawing.Size(800, 71);
            this.pageHeader1.TabIndex = 18;
            this.pageHeader1.Text = "設定";
            // 
            // From_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.pageHeader1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tabs1);
            this.Name = "From_settings";
            this.Resizable = false;
            this.Text = "settings";
            this.Load += new System.EventHandler(this.From_settings_Load);
            this.tabs1.ResumeLayout(false);
            this.tb_task.ResumeLayout(false);
            this.gridPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tb_display.ResumeLayout(false);
            this.gridPanel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.tb_pomo.ResumeLayout(false);
            this.gridPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Tabs tabs1;
        private AntdUI.TabPage tb_pomo;
        private AntdUI.GridPanel gridPanel1;
        private AntdUI.Panel panel2;
        private AntdUI.InputNumber inputN_focus;
        private AntdUI.Label label7;
        private AntdUI.InputNumber inputN_shortBreak;
        private AntdUI.Label label8;
        private AntdUI.InputNumber inputN_longBreak;
        private AntdUI.Label label9;
        private AntdUI.InputNumber inputN_loopTimes;
        private AntdUI.Label label10;
        private AntdUI.TabPage tb_display;
        private AntdUI.TabPage tb_task;
        private AntdUI.Panel panel1;
        private AntdUI.Label label11;
        private AntdUI.Switch switch_autoFocus;
        private AntdUI.Label label12;
        private AntdUI.Switch switch_autoBreak;
        private AntdUI.Button btn_save;
        private AntdUI.PageHeader pageHeader1;
        private AntdUI.GridPanel gridPanel3;
        private AntdUI.Panel panel5;
        private AntdUI.Panel panel6;
        private AntdUI.Label label15;
        private AntdUI.Label label16;
        private AntdUI.GridPanel gridPanel2;
        private AntdUI.Panel panel3;
        private AntdUI.Panel panel4;
        private AntdUI.Select select_panelNum;
        private AntdUI.Button btn_clearAllTask;
        private AntdUI.Select select1;
        private AntdUI.Button btn_clearAllSubject;
        private AntdUI.Label label1;
        private AntdUI.Button btn_clearAllClass;
        private AntdUI.Button btn_addClass;
        private AntdUI.Button btn_delClass;
        private AntdUI.Label label2;
        private AntdUI.SelectMultiple select_controlClass;
        private AntdUI.SelectMultiple select_controlSubject;
        private AntdUI.Button btn_addSubj;
        private AntdUI.Button btn_delSubj;
    }
}