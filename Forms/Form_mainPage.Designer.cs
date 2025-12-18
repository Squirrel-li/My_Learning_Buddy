namespace project
{
    partial class Form_mainPage
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            AntdUI.Tabs.StyleLine styleLine2 = new AntdUI.Tabs.StyleLine();
            this.lbl_debug = new System.Windows.Forms.Label();
            this.select_selectColor = new AntdUI.Select();
            this.dateTimeP_select = new AntdUI.DatePicker();
            this.btn_addTask = new AntdUI.Button();
            this.select_classification = new AntdUI.Select();
            this.input_taskDescribe = new AntdUI.Input();
            this.select_subject = new AntdUI.Select();
            this.btn_openPomo = new AntdUI.Button();
            this.btn_settings = new AntdUI.Button();
            this.gridpanel_calendar = new AntdUI.GridPanel();
            this.tabs_modifySet = new AntdUI.Tabs();
            this.tb_addToDo = new AntdUI.TabPage();
            this.panel_Task = new AntdUI.Panel();
            this.tooltip_class = new AntdUI.Tooltip();
            this.tooltip_subject = new AntdUI.Tooltip();
            this.label4 = new AntdUI.Label();
            this.label2 = new AntdUI.Label();
            this.label3 = new AntdUI.Label();
            this.label1 = new AntdUI.Label();
            this.label6 = new AntdUI.Label();
            this.tb_addSubjClass = new AntdUI.TabPage();
            this.panel_modeify = new AntdUI.Panel();
            this.lbl_tabModfiyMes = new System.Windows.Forms.Label();
            this.select_controlClass = new AntdUI.SelectMultiple();
            this.btn_addClass = new AntdUI.Button();
            this.select_controlSubject = new AntdUI.SelectMultiple();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_addSubj = new AntdUI.Button();
            this.btn_delClass = new AntdUI.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_delSubj = new AntdUI.Button();
            this.timer_toopTipShow = new System.Windows.Forms.Timer(this.components);
            this.lbl_tabToDoMes = new AntdUI.Label();
            this.tabs_modifySet.SuspendLayout();
            this.tb_addToDo.SuspendLayout();
            this.panel_Task.SuspendLayout();
            this.tb_addSubjClass.SuspendLayout();
            this.panel_modeify.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_debug
            // 
            this.lbl_debug.AutoSize = true;
            this.lbl_debug.Font = new System.Drawing.Font("更紗黑體 Mono TC Nerd", 8F);
            this.lbl_debug.Location = new System.Drawing.Point(177, 547);
            this.lbl_debug.Name = "lbl_debug";
            this.lbl_debug.Size = new System.Drawing.Size(109, 14);
            this.lbl_debug.TabIndex = 3;
            this.lbl_debug.Text = "Debug Mode Enable";
            this.lbl_debug.Visible = false;
            // 
            // select_selectColor
            // 
            this.select_selectColor.Font = new System.Drawing.Font("微軟正黑體", 14.25F);
            this.select_selectColor.Items.AddRange(new object[] {
            "test1",
            "test2",
            "test3",
            "test4"});
            this.select_selectColor.List = true;
            this.select_selectColor.Location = new System.Drawing.Point(18, 361);
            this.select_selectColor.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.select_selectColor.MaxCount = 5;
            this.select_selectColor.Name = "select_selectColor";
            this.select_selectColor.Size = new System.Drawing.Size(138, 48);
            this.select_selectColor.TabIndex = 26;
            this.select_selectColor.SelectedIndexChanged += new AntdUI.IntEventHandler(this.select_selectColor_SelectedIndexChanged);
            // 
            // dateTimeP_select
            // 
            this.dateTimeP_select.DropDownArrow = true;
            this.dateTimeP_select.Format = "yyyy/MM/dd HH:mm";
            this.dateTimeP_select.Location = new System.Drawing.Point(18, 281);
            this.dateTimeP_select.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.dateTimeP_select.Name = "dateTimeP_select";
            this.dateTimeP_select.ShowIcon = false;
            this.dateTimeP_select.Size = new System.Drawing.Size(294, 44);
            this.dateTimeP_select.TabIndex = 21;
            this.dateTimeP_select.ExpandDropChanged += new AntdUI.BoolEventHandler(this.dateTimeP_select_ExpandDropChanged);
            this.dateTimeP_select.PrefixClick += new System.Windows.Forms.MouseEventHandler(this.dateTimeP_select_PrefixClick);
            // 
            // btn_addTask
            // 
            this.btn_addTask.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.btn_addTask.Location = new System.Drawing.Point(169, 409);
            this.btn_addTask.Name = "btn_addTask";
            this.btn_addTask.Size = new System.Drawing.Size(143, 49);
            this.btn_addTask.TabIndex = 20;
            this.btn_addTask.Text = "新增活動";
            this.btn_addTask.Click += new System.EventHandler(this.btn_addTask_Click);
            // 
            // select_classification
            // 
            this.select_classification.Font = new System.Drawing.Font("微軟正黑體", 14.25F);
            this.select_classification.Items.AddRange(new object[] {
            "test1",
            "test2",
            "test3",
            "test4"});
            this.select_classification.List = true;
            this.select_classification.Location = new System.Drawing.Point(168, 48);
            this.select_classification.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.select_classification.MaxCount = 5;
            this.select_classification.Name = "select_classification";
            this.select_classification.Size = new System.Drawing.Size(144, 38);
            this.select_classification.TabIndex = 25;
            this.select_classification.MouseEnter += new System.EventHandler(this.select_classification_MouseEnter);
            // 
            // input_taskDescribe
            // 
            this.input_taskDescribe.AutoScroll = true;
            this.input_taskDescribe.Font = new System.Drawing.Font("微軟正黑體", 14.25F);
            this.input_taskDescribe.Location = new System.Drawing.Point(18, 124);
            this.input_taskDescribe.Multiline = true;
            this.input_taskDescribe.Name = "input_taskDescribe";
            this.input_taskDescribe.Size = new System.Drawing.Size(294, 121);
            this.input_taskDescribe.TabIndex = 17;
            // 
            // select_subject
            // 
            this.select_subject.Font = new System.Drawing.Font("微軟正黑體", 14.25F);
            this.select_subject.Items.AddRange(new object[] {
            "test1",
            "test2",
            "test3",
            "test4"});
            this.select_subject.List = true;
            this.select_subject.Location = new System.Drawing.Point(18, 48);
            this.select_subject.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.select_subject.MaxCount = 5;
            this.select_subject.Name = "select_subject";
            this.select_subject.Size = new System.Drawing.Size(144, 38);
            this.select_subject.TabIndex = 21;
            this.select_subject.MouseEnter += new System.EventHandler(this.select_subject_MouseEnter);
            // 
            // btn_openPomo
            // 
            this.btn_openPomo.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.btn_openPomo.Location = new System.Drawing.Point(17, 568);
            this.btn_openPomo.Name = "btn_openPomo";
            this.btn_openPomo.Size = new System.Drawing.Size(143, 49);
            this.btn_openPomo.TabIndex = 15;
            this.btn_openPomo.Text = "開啟番茄鐘";
            this.btn_openPomo.Click += new System.EventHandler(this.btn_openPomo_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.btn_settings.Location = new System.Drawing.Point(17, 620);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(143, 49);
            this.btn_settings.TabIndex = 16;
            this.btn_settings.Text = "設定";
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // gridpanel_calendar
            // 
            this.gridpanel_calendar.Location = new System.Drawing.Point(344, 12);
            this.gridpanel_calendar.Name = "gridpanel_calendar";
            this.gridpanel_calendar.Size = new System.Drawing.Size(908, 660);
            this.gridpanel_calendar.Span = "";
            this.gridpanel_calendar.TabIndex = 1;
            this.gridpanel_calendar.Text = "gridPanel1";
            // 
            // tabs_modifySet
            // 
            this.tabs_modifySet.Controls.Add(this.tb_addToDo);
            this.tabs_modifySet.Controls.Add(this.tb_addSubjClass);
            this.tabs_modifySet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabs_modifySet.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.tabs_modifySet.Location = new System.Drawing.Point(12, 11);
            this.tabs_modifySet.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.tabs_modifySet.Name = "tabs_modifySet";
            this.tabs_modifySet.Pages.Add(this.tb_addToDo);
            this.tabs_modifySet.Pages.Add(this.tb_addSubjClass);
            this.tabs_modifySet.Size = new System.Drawing.Size(328, 518);
            this.tabs_modifySet.Style = styleLine2;
            this.tabs_modifySet.TabIndex = 19;
            this.tabs_modifySet.Text = "tabs1";
            this.tabs_modifySet.SelectedIndexChanged += new AntdUI.IntEventHandler(this.tabs_modifySet_SelectedIndexChanged);
            // 
            // tb_addToDo
            // 
            this.tb_addToDo.Controls.Add(this.panel_Task);
            this.tb_addToDo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_addToDo.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.tb_addToDo.Location = new System.Drawing.Point(0, 42);
            this.tb_addToDo.Name = "tb_addToDo";
            this.tb_addToDo.Size = new System.Drawing.Size(328, 476);
            this.tb_addToDo.TabIndex = 0;
            this.tb_addToDo.Text = "新增任務";
            // 
            // panel_Task
            // 
            this.panel_Task.Controls.Add(this.lbl_tabToDoMes);
            this.panel_Task.Controls.Add(this.tooltip_class);
            this.panel_Task.Controls.Add(this.tooltip_subject);
            this.panel_Task.Controls.Add(this.label4);
            this.panel_Task.Controls.Add(this.label2);
            this.panel_Task.Controls.Add(this.label3);
            this.panel_Task.Controls.Add(this.label1);
            this.panel_Task.Controls.Add(this.label6);
            this.panel_Task.Controls.Add(this.select_selectColor);
            this.panel_Task.Controls.Add(this.dateTimeP_select);
            this.panel_Task.Controls.Add(this.btn_addTask);
            this.panel_Task.Controls.Add(this.select_classification);
            this.panel_Task.Controls.Add(this.input_taskDescribe);
            this.panel_Task.Controls.Add(this.select_subject);
            this.panel_Task.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel_Task.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Task.Location = new System.Drawing.Point(0, 0);
            this.panel_Task.Margin = new System.Windows.Forms.Padding(0);
            this.panel_Task.Name = "panel_Task";
            this.panel_Task.Radius = 10;
            this.panel_Task.Shadow = 5;
            this.panel_Task.Size = new System.Drawing.Size(328, 476);
            this.panel_Task.TabIndex = 0;
            this.panel_Task.Text = "panel1";
            // 
            // tooltip_class
            // 
            this.tooltip_class.ArrowAlign = AntdUI.TAlign.BL;
            this.tooltip_class.Back = System.Drawing.Color.Gray;
            this.tooltip_class.BackColor = System.Drawing.Color.White;
            this.tooltip_class.ColorScheme = AntdUI.TAMode.Dark;
            this.tooltip_class.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.tooltip_class.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tooltip_class.Location = new System.Drawing.Point(223, 83);
            this.tooltip_class.MaximumSize = new System.Drawing.Size(89, 41);
            this.tooltip_class.MinimumSize = new System.Drawing.Size(89, 41);
            this.tooltip_class.Name = "tooltip_class";
            this.tooltip_class.Radius = 20;
            this.tooltip_class.Size = new System.Drawing.Size(89, 41);
            this.tooltip_class.TabIndex = 34;
            this.tooltip_class.TabStop = false;
            this.tooltip_class.Text = "請選擇類別";
            this.tooltip_class.Visible = false;
            // 
            // tooltip_subject
            // 
            this.tooltip_subject.ArrowAlign = AntdUI.TAlign.BL;
            this.tooltip_subject.Back = System.Drawing.Color.Gray;
            this.tooltip_subject.BackColor = System.Drawing.Color.White;
            this.tooltip_subject.ColorScheme = AntdUI.TAMode.Dark;
            this.tooltip_subject.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.tooltip_subject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tooltip_subject.Location = new System.Drawing.Point(73, 83);
            this.tooltip_subject.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tooltip_subject.MaximumSize = new System.Drawing.Size(89, 41);
            this.tooltip_subject.MinimumSize = new System.Drawing.Size(89, 41);
            this.tooltip_subject.Name = "tooltip_subject";
            this.tooltip_subject.Radius = 20;
            this.tooltip_subject.Size = new System.Drawing.Size(89, 41);
            this.tooltip_subject.TabIndex = 33;
            this.tooltip_subject.TabStop = false;
            this.tooltip_subject.Text = "請選擇科目";
            this.tooltip_subject.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(24, 331);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 28);
            this.label4.TabIndex = 32;
            this.label4.Text = "顏色";
            // 
            // label2
            // 
            this.label2.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 251);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 28);
            this.label2.TabIndex = 31;
            this.label2.Text = "時間";
            // 
            // label3
            // 
            this.label3.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 28);
            this.label3.TabIndex = 30;
            this.label3.Text = "敘述";
            // 
            // label1
            // 
            this.label1.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(181, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 28);
            this.label1.TabIndex = 28;
            this.label1.Text = "類別";
            // 
            // label6
            // 
            this.label6.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(24, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 28);
            this.label6.TabIndex = 27;
            this.label6.Text = "科目";
            // 
            // tb_addSubjClass
            // 
            this.tb_addSubjClass.Controls.Add(this.panel_modeify);
            this.tb_addSubjClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_addSubjClass.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.tb_addSubjClass.Location = new System.Drawing.Point(0, 42);
            this.tb_addSubjClass.Name = "tb_addSubjClass";
            this.tb_addSubjClass.Size = new System.Drawing.Size(328, 476);
            this.tb_addSubjClass.TabIndex = 1;
            this.tb_addSubjClass.Text = "更改科目與類別";
            // 
            // panel_modeify
            // 
            this.panel_modeify.Controls.Add(this.lbl_tabModfiyMes);
            this.panel_modeify.Controls.Add(this.select_controlClass);
            this.panel_modeify.Controls.Add(this.btn_addClass);
            this.panel_modeify.Controls.Add(this.select_controlSubject);
            this.panel_modeify.Controls.Add(this.label7);
            this.panel_modeify.Controls.Add(this.btn_addSubj);
            this.panel_modeify.Controls.Add(this.btn_delClass);
            this.panel_modeify.Controls.Add(this.label8);
            this.panel_modeify.Controls.Add(this.btn_delSubj);
            this.panel_modeify.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_modeify.Location = new System.Drawing.Point(0, 0);
            this.panel_modeify.Margin = new System.Windows.Forms.Padding(0);
            this.panel_modeify.Name = "panel_modeify";
            this.panel_modeify.Radius = 10;
            this.panel_modeify.Shadow = 5;
            this.panel_modeify.Size = new System.Drawing.Size(328, 476);
            this.panel_modeify.TabIndex = 28;
            this.panel_modeify.Text = "panel4";
            // 
            // lbl_tabModfiyMes
            // 
            this.lbl_tabModfiyMes.AutoSize = true;
            this.lbl_tabModfiyMes.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_tabModfiyMes.Location = new System.Drawing.Point(18, 400);
            this.lbl_tabModfiyMes.Name = "lbl_tabModfiyMes";
            this.lbl_tabModfiyMes.Size = new System.Drawing.Size(36, 20);
            this.lbl_tabModfiyMes.TabIndex = 45;
            this.lbl_tabModfiyMes.Text = "123";
            // 
            // select_controlClass
            // 
            this.select_controlClass.Location = new System.Drawing.Point(68, 112);
            this.select_controlClass.Name = "select_controlClass";
            this.select_controlClass.Size = new System.Drawing.Size(248, 37);
            this.select_controlClass.TabIndex = 43;
            this.select_controlClass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_controlClass_KeyDown);
            // 
            // btn_addClass
            // 
            this.btn_addClass.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.btn_addClass.Location = new System.Drawing.Point(144, 153);
            this.btn_addClass.Name = "btn_addClass";
            this.btn_addClass.Size = new System.Drawing.Size(83, 43);
            this.btn_addClass.TabIndex = 41;
            this.btn_addClass.Text = "新增";
            this.btn_addClass.Click += new System.EventHandler(this.btn_addClass_Click);
            // 
            // select_controlSubject
            // 
            this.select_controlSubject.Location = new System.Drawing.Point(68, 12);
            this.select_controlSubject.Name = "select_controlSubject";
            this.select_controlSubject.Size = new System.Drawing.Size(248, 37);
            this.select_controlSubject.TabIndex = 44;
            this.select_controlSubject.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_controlSubject_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 15F);
            this.label7.Location = new System.Drawing.Point(13, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "類別";
            // 
            // btn_addSubj
            // 
            this.btn_addSubj.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.btn_addSubj.Location = new System.Drawing.Point(144, 55);
            this.btn_addSubj.Name = "btn_addSubj";
            this.btn_addSubj.Size = new System.Drawing.Size(83, 43);
            this.btn_addSubj.TabIndex = 39;
            this.btn_addSubj.Text = "新增";
            this.btn_addSubj.Click += new System.EventHandler(this.btn_addSubj_Click);
            // 
            // btn_delClass
            // 
            this.btn_delClass.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.btn_delClass.Location = new System.Drawing.Point(233, 153);
            this.btn_delClass.Name = "btn_delClass";
            this.btn_delClass.Size = new System.Drawing.Size(83, 43);
            this.btn_delClass.TabIndex = 40;
            this.btn_delClass.Text = "刪除";
            this.btn_delClass.Click += new System.EventHandler(this.btn_delClass_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 14.25F);
            this.label8.Location = new System.Drawing.Point(14, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "科目";
            // 
            // btn_delSubj
            // 
            this.btn_delSubj.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.btn_delSubj.Location = new System.Drawing.Point(233, 55);
            this.btn_delSubj.Name = "btn_delSubj";
            this.btn_delSubj.Size = new System.Drawing.Size(83, 43);
            this.btn_delSubj.TabIndex = 38;
            this.btn_delSubj.Text = "刪除";
            this.btn_delSubj.Click += new System.EventHandler(this.btn_delSubj_Click);
            // 
            // timer_toopTipShow
            // 
            this.timer_toopTipShow.Interval = 1000;
            this.timer_toopTipShow.Tick += new System.EventHandler(this.timer_toopTipShow_Tick);
            // 
            // lbl_tabToDoMes
            // 
            this.lbl_tabToDoMes.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.lbl_tabToDoMes.BackColor = System.Drawing.Color.White;
            this.lbl_tabToDoMes.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tabToDoMes.Location = new System.Drawing.Point(24, 438);
            this.lbl_tabToDoMes.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.lbl_tabToDoMes.Name = "lbl_tabToDoMes";
            this.lbl_tabToDoMes.Size = new System.Drawing.Size(26, 20);
            this.lbl_tabToDoMes.TabIndex = 35;
            this.lbl_tabToDoMes.Text = "abc";
            // 
            // Form_mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.lbl_debug);
            this.Controls.Add(this.gridpanel_calendar);
            this.Controls.Add(this.btn_settings);
            this.Controls.Add(this.btn_openPomo);
            this.Controls.Add(this.tabs_modifySet);
            this.Name = "Form_mainPage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabs_modifySet.ResumeLayout(false);
            this.tb_addToDo.ResumeLayout(false);
            this.panel_Task.ResumeLayout(false);
            this.panel_Task.PerformLayout();
            this.tb_addSubjClass.ResumeLayout(false);
            this.panel_modeify.ResumeLayout(false);
            this.panel_modeify.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lbl_debug;
        private AntdUI.Button btn_openPomo;
        private AntdUI.Button btn_settings;
        private AntdUI.Input input_taskDescribe;
        private AntdUI.Select select_subject;
        private AntdUI.Select select_classification;
        private AntdUI.Button btn_addTask;
        private AntdUI.DatePicker dateTimeP_select;
        private AntdUI.Select select_selectColor;
        private AntdUI.GridPanel gridpanel_calendar;
        private AntdUI.Tabs tabs_modifySet;
        private AntdUI.TabPage tb_addSubjClass;
        private AntdUI.TabPage tb_addToDo;
        private AntdUI.Panel panel_Task;
        private AntdUI.Panel panel_modeify;
        public System.Windows.Forms.Label lbl_tabModfiyMes;
        private AntdUI.SelectMultiple select_controlClass;
        private AntdUI.Button btn_addClass;
        private AntdUI.SelectMultiple select_controlSubject;
        private System.Windows.Forms.Label label7;
        private AntdUI.Button btn_addSubj;
        private AntdUI.Button btn_delClass;
        private System.Windows.Forms.Label label8;
        private AntdUI.Button btn_delSubj;
        private AntdUI.Label label1;
        private AntdUI.Label label6;
        private AntdUI.Label label3;
        private AntdUI.Label label2;
        private AntdUI.Label label4;
        private AntdUI.Tooltip tooltip_subject;
        private AntdUI.Tooltip tooltip_class;
        private System.Windows.Forms.Timer timer_toopTipShow;
        private AntdUI.Label lbl_tabToDoMes;
    }
}

