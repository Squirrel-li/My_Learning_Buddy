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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_mainPage));
            this.select_selectColor = new AntdUI.Select();
            this.dateTimeP_select = new AntdUI.DatePicker();
            this.btn_addTask = new AntdUI.Button();
            this.select_classification = new AntdUI.Select();
            this.input_taskDescribe = new AntdUI.Input();
            this.select_subject = new AntdUI.Select();
            this.gridpanel_calendar = new AntdUI.GridPanel();
            this.tabs_modifySet = new AntdUI.Tabs();
            this.tb_addToDo = new AntdUI.TabPage();
            this.panel_side1 = new AntdUI.Panel();
            this.FLPanel_side1 = new AntdUI.In.FlowLayoutPanel();
            this.panel_sideTabSubject = new AntdUI.Panel();
            this.tooltip_class = new AntdUI.Tooltip();
            this.label6 = new AntdUI.Label();
            this.panel_sideTabClass = new AntdUI.Panel();
            this.tooltip_subject = new AntdUI.Tooltip();
            this.label1 = new AntdUI.Label();
            this.panel_sideTabDeadline = new AntdUI.Panel();
            this.label2 = new AntdUI.Label();
            this.panel_sideTabDescript = new AntdUI.Panel();
            this.label3 = new AntdUI.Label();
            this.panel_sideTabColor = new AntdUI.Panel();
            this.label4 = new AntdUI.Label();
            this.panel_sideTabAddTask = new AntdUI.Panel();
            this.tb_addSubjClass = new AntdUI.TabPage();
            this.panel_side2 = new AntdUI.Panel();
            this.FLPanel_side2 = new AntdUI.In.FlowLayoutPanel();
            this.panel_sideTabSubjectLabel = new AntdUI.Panel();
            this.label9 = new AntdUI.Label();
            this.panel_sideTabSubjectControl = new AntdUI.Panel();
            this.select_controlSubject = new AntdUI.SelectMultiple();
            this.btn_addSubj = new AntdUI.Button();
            this.btn_delSubj = new AntdUI.Button();
            this.panel_sideTabClassLabel = new AntdUI.Panel();
            this.Label10 = new AntdUI.Label();
            this.panel_sideTabClassControl = new AntdUI.Panel();
            this.select_controlClass = new AntdUI.SelectMultiple();
            this.btn_delClass = new AntdUI.Button();
            this.btn_addClass = new AntdUI.Button();
            this.lbl_tabModfiyMes = new AntdUI.Label();
            this.timer_toopTipShow = new System.Windows.Forms.Timer(this.components);
            this.pageHeader = new AntdUI.PageHeader();
            this.panel_body = new AntdUI.Panel();
            this.splitter_sideAndCalendar = new AntdUI.Splitter();
            this.splitter_addAndButton = new AntdUI.Splitter();
            this.gridPanel_funButton = new AntdUI.GridPanel();
            this.lbl_debug = new AntdUI.Label();
            this.btn_settings = new AntdUI.Button();
            this.btn_openPomo = new AntdUI.Button();
            this.tabs_modifySet.SuspendLayout();
            this.tb_addToDo.SuspendLayout();
            this.panel_side1.SuspendLayout();
            this.FLPanel_side1.SuspendLayout();
            this.panel_sideTabSubject.SuspendLayout();
            this.panel_sideTabClass.SuspendLayout();
            this.panel_sideTabDeadline.SuspendLayout();
            this.panel_sideTabDescript.SuspendLayout();
            this.panel_sideTabColor.SuspendLayout();
            this.panel_sideTabAddTask.SuspendLayout();
            this.tb_addSubjClass.SuspendLayout();
            this.panel_side2.SuspendLayout();
            this.FLPanel_side2.SuspendLayout();
            this.panel_sideTabSubjectLabel.SuspendLayout();
            this.panel_sideTabSubjectControl.SuspendLayout();
            this.panel_sideTabClassLabel.SuspendLayout();
            this.panel_sideTabClassControl.SuspendLayout();
            this.panel_body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitter_sideAndCalendar)).BeginInit();
            this.splitter_sideAndCalendar.Panel1.SuspendLayout();
            this.splitter_sideAndCalendar.Panel2.SuspendLayout();
            this.splitter_sideAndCalendar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitter_addAndButton)).BeginInit();
            this.splitter_addAndButton.Panel1.SuspendLayout();
            this.splitter_addAndButton.Panel2.SuspendLayout();
            this.splitter_addAndButton.SuspendLayout();
            this.gridPanel_funButton.SuspendLayout();
            this.SuspendLayout();
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
            this.select_selectColor.Location = new System.Drawing.Point(9, 31);
            this.select_selectColor.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.select_selectColor.MaxCount = 5;
            this.select_selectColor.Name = "select_selectColor";
            this.select_selectColor.Size = new System.Drawing.Size(164, 47);
            this.select_selectColor.TabIndex = 26;
            this.select_selectColor.SelectedIndexChanged += new AntdUI.IntEventHandler(this.select_selectColor_SelectedIndexChanged);
            // 
            // dateTimeP_select
            // 
            this.dateTimeP_select.DropDownArrow = true;
            this.dateTimeP_select.Format = "yyyy/MM/dd HH:mm";
            this.dateTimeP_select.Location = new System.Drawing.Point(13, 39);
            this.dateTimeP_select.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.dateTimeP_select.Name = "dateTimeP_select";
            this.dateTimeP_select.ShowIcon = false;
            this.dateTimeP_select.Size = new System.Drawing.Size(274, 44);
            this.dateTimeP_select.TabIndex = 21;
            this.dateTimeP_select.ExpandDropChanged += new AntdUI.BoolEventHandler(this.dateTimeP_select_ExpandDropChanged);
            this.dateTimeP_select.PrefixClick += new System.Windows.Forms.MouseEventHandler(this.dateTimeP_select_PrefixClick);
            // 
            // btn_addTask
            // 
            this.btn_addTask.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addTask.Location = new System.Drawing.Point(3, 26);
            this.btn_addTask.Name = "btn_addTask";
            this.btn_addTask.Size = new System.Drawing.Size(164, 49);
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
            this.select_classification.Location = new System.Drawing.Point(9, 43);
            this.select_classification.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.select_classification.MaxCount = 5;
            this.select_classification.Name = "select_classification";
            this.select_classification.Size = new System.Drawing.Size(164, 47);
            this.select_classification.TabIndex = 25;
            this.select_classification.MouseEnter += new System.EventHandler(this.select_classification_MouseEnter);
            // 
            // input_taskDescribe
            // 
            this.input_taskDescribe.AutoScroll = true;
            this.input_taskDescribe.Font = new System.Drawing.Font("微軟正黑體", 14.25F);
            this.input_taskDescribe.Location = new System.Drawing.Point(13, 35);
            this.input_taskDescribe.Multiline = true;
            this.input_taskDescribe.Name = "input_taskDescribe";
            this.input_taskDescribe.Size = new System.Drawing.Size(274, 136);
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
            this.select_subject.Location = new System.Drawing.Point(9, 43);
            this.select_subject.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.select_subject.MaxCount = 5;
            this.select_subject.Name = "select_subject";
            this.select_subject.Size = new System.Drawing.Size(164, 47);
            this.select_subject.TabIndex = 21;
            this.select_subject.MouseEnter += new System.EventHandler(this.select_subject_MouseEnter);
            // 
            // gridpanel_calendar
            // 
            this.gridpanel_calendar.Back = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridpanel_calendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.gridpanel_calendar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridpanel_calendar.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.gridpanel_calendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridpanel_calendar.Gap = 2;
            this.gridpanel_calendar.Location = new System.Drawing.Point(0, 0);
            this.gridpanel_calendar.Name = "gridpanel_calendar";
            this.gridpanel_calendar.Padding = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.gridpanel_calendar.Radius = 10;
            this.gridpanel_calendar.Size = new System.Drawing.Size(864, 645);
            this.gridpanel_calendar.Span = "14% 14% 14% 14% 14% 14% 14% ";
            this.gridpanel_calendar.TabIndex = 1;
            this.gridpanel_calendar.Text = "gridPanel1";
            // 
            // tabs_modifySet
            // 
            this.tabs_modifySet.Controls.Add(this.tb_addToDo);
            this.tabs_modifySet.Controls.Add(this.tb_addSubjClass);
            this.tabs_modifySet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabs_modifySet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs_modifySet.Fill = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(156)))), ((int)(((byte)(109)))));
            this.tabs_modifySet.FillActive = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(156)))), ((int)(((byte)(109)))));
            this.tabs_modifySet.FillHover = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(130)))), ((int)(((byte)(121)))));
            this.tabs_modifySet.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.tabs_modifySet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(130)))), ((int)(((byte)(121)))));
            this.tabs_modifySet.Location = new System.Drawing.Point(0, 0);
            this.tabs_modifySet.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.tabs_modifySet.Name = "tabs_modifySet";
            this.tabs_modifySet.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.tabs_modifySet.Pages.Add(this.tb_addToDo);
            this.tabs_modifySet.Pages.Add(this.tb_addSubjClass);
            this.tabs_modifySet.Size = new System.Drawing.Size(390, 533);
            this.tabs_modifySet.Style = styleLine2;
            this.tabs_modifySet.TabIndex = 19;
            this.tabs_modifySet.Text = "tabs1";
            this.tabs_modifySet.SelectedIndexChanged += new AntdUI.IntEventHandler(this.tabs_modifySet_SelectedIndexChanged);
            // 
            // tb_addToDo
            // 
            this.tb_addToDo.Controls.Add(this.panel_side1);
            this.tb_addToDo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_addToDo.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.tb_addToDo.Location = new System.Drawing.Point(12, 42);
            this.tb_addToDo.MinimumSize = new System.Drawing.Size(300, 0);
            this.tb_addToDo.Name = "tb_addToDo";
            this.tb_addToDo.Size = new System.Drawing.Size(378, 491);
            this.tb_addToDo.TabIndex = 0;
            this.tb_addToDo.Text = "新增任務";
            // 
            // panel_side1
            // 
            this.panel_side1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.panel_side1.Controls.Add(this.FLPanel_side1);
            this.panel_side1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_side1.Location = new System.Drawing.Point(0, 0);
            this.panel_side1.MinimumSize = new System.Drawing.Size(290, 0);
            this.panel_side1.Name = "panel_side1";
            this.panel_side1.Radius = 10;
            this.panel_side1.Shadow = 5;
            this.panel_side1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(56)))), ((int)(((byte)(50)))));
            this.panel_side1.ShadowOpacity = 0.4F;
            this.panel_side1.ShadowOpacityAnimation = true;
            this.panel_side1.ShadowOpacityHover = 0.5F;
            this.panel_side1.Size = new System.Drawing.Size(378, 491);
            this.panel_side1.TabIndex = 0;
            this.panel_side1.Text = "panel7";
            // 
            // FLPanel_side1
            // 
            this.FLPanel_side1.AutoScroll = true;
            this.FLPanel_side1.BackColor = System.Drawing.Color.Transparent;
            this.FLPanel_side1.Controls.Add(this.panel_sideTabSubject);
            this.FLPanel_side1.Controls.Add(this.panel_sideTabClass);
            this.FLPanel_side1.Controls.Add(this.panel_sideTabDeadline);
            this.FLPanel_side1.Controls.Add(this.panel_sideTabDescript);
            this.FLPanel_side1.Controls.Add(this.panel_sideTabColor);
            this.FLPanel_side1.Controls.Add(this.panel_sideTabAddTask);
            this.FLPanel_side1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPanel_side1.Location = new System.Drawing.Point(5, 5);
            this.FLPanel_side1.MinimumSize = new System.Drawing.Size(290, 0);
            this.FLPanel_side1.Name = "FLPanel_side1";
            this.FLPanel_side1.Size = new System.Drawing.Size(368, 481);
            this.FLPanel_side1.TabIndex = 34;
            // 
            // panel_sideTabSubject
            // 
            this.panel_sideTabSubject.Back = System.Drawing.Color.Transparent;
            this.panel_sideTabSubject.Controls.Add(this.tooltip_class);
            this.panel_sideTabSubject.Controls.Add(this.label6);
            this.panel_sideTabSubject.Controls.Add(this.select_subject);
            this.panel_sideTabSubject.Location = new System.Drawing.Point(3, 3);
            this.panel_sideTabSubject.Name = "panel_sideTabSubject";
            this.panel_sideTabSubject.Size = new System.Drawing.Size(176, 90);
            this.panel_sideTabSubject.TabIndex = 35;
            this.panel_sideTabSubject.Text = "panel3";
            // 
            // tooltip_class
            // 
            this.tooltip_class.ArrowAlign = AntdUI.TAlign.TL;
            this.tooltip_class.Back = System.Drawing.Color.Gray;
            this.tooltip_class.BackColor = System.Drawing.Color.Transparent;
            this.tooltip_class.ColorScheme = AntdUI.TAMode.Dark;
            this.tooltip_class.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.tooltip_class.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tooltip_class.Location = new System.Drawing.Point(84, 3);
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
            // label6
            // 
            this.label6.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(16, 13);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 32);
            this.label6.TabIndex = 27;
            this.label6.Text = "科目";
            // 
            // panel_sideTabClass
            // 
            this.panel_sideTabClass.Back = System.Drawing.Color.Transparent;
            this.panel_sideTabClass.Controls.Add(this.select_classification);
            this.panel_sideTabClass.Controls.Add(this.tooltip_subject);
            this.panel_sideTabClass.Controls.Add(this.label1);
            this.panel_sideTabClass.Location = new System.Drawing.Point(185, 3);
            this.panel_sideTabClass.Name = "panel_sideTabClass";
            this.panel_sideTabClass.Size = new System.Drawing.Size(176, 90);
            this.panel_sideTabClass.TabIndex = 36;
            this.panel_sideTabClass.Text = "panel4";
            // 
            // tooltip_subject
            // 
            this.tooltip_subject.ArrowAlign = AntdUI.TAlign.TL;
            this.tooltip_subject.Back = System.Drawing.Color.Gray;
            this.tooltip_subject.BackColor = System.Drawing.Color.Transparent;
            this.tooltip_subject.ColorScheme = AntdUI.TAMode.Dark;
            this.tooltip_subject.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.tooltip_subject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tooltip_subject.Location = new System.Drawing.Point(84, 3);
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
            // label1
            // 
            this.label1.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 32);
            this.label1.TabIndex = 28;
            this.label1.Text = "類別";
            // 
            // panel_sideTabDeadline
            // 
            this.panel_sideTabDeadline.Back = System.Drawing.Color.Transparent;
            this.panel_sideTabDeadline.BackColor = System.Drawing.Color.Transparent;
            this.panel_sideTabDeadline.Controls.Add(this.label2);
            this.panel_sideTabDeadline.Controls.Add(this.dateTimeP_select);
            this.panel_sideTabDeadline.Location = new System.Drawing.Point(3, 99);
            this.panel_sideTabDeadline.Name = "panel_sideTabDeadline";
            this.panel_sideTabDeadline.Size = new System.Drawing.Size(290, 87);
            this.panel_sideTabDeadline.TabIndex = 37;
            this.panel_sideTabDeadline.Text = "panel6";
            // 
            // label2
            // 
            this.label2.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(14, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 32);
            this.label2.TabIndex = 31;
            this.label2.Text = "時間";
            // 
            // panel_sideTabDescript
            // 
            this.panel_sideTabDescript.Back = System.Drawing.Color.Transparent;
            this.panel_sideTabDescript.Controls.Add(this.input_taskDescribe);
            this.panel_sideTabDescript.Controls.Add(this.label3);
            this.panel_sideTabDescript.Location = new System.Drawing.Point(3, 192);
            this.panel_sideTabDescript.Name = "panel_sideTabDescript";
            this.panel_sideTabDescript.Size = new System.Drawing.Size(290, 173);
            this.panel_sideTabDescript.TabIndex = 38;
            this.panel_sideTabDescript.Text = "panel8";
            // 
            // label3
            // 
            this.label3.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(14, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 32);
            this.label3.TabIndex = 30;
            this.label3.Text = "敘述";
            // 
            // panel_sideTabColor
            // 
            this.panel_sideTabColor.Back = System.Drawing.Color.Transparent;
            this.panel_sideTabColor.Controls.Add(this.label4);
            this.panel_sideTabColor.Controls.Add(this.select_selectColor);
            this.panel_sideTabColor.Location = new System.Drawing.Point(3, 371);
            this.panel_sideTabColor.Name = "panel_sideTabColor";
            this.panel_sideTabColor.Size = new System.Drawing.Size(176, 78);
            this.panel_sideTabColor.TabIndex = 36;
            this.panel_sideTabColor.Text = "panel5";
            // 
            // label4
            // 
            this.label4.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(16, 1);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 32);
            this.label4.TabIndex = 32;
            this.label4.Text = "顏色";
            // 
            // panel_sideTabAddTask
            // 
            this.panel_sideTabAddTask.Back = System.Drawing.Color.Transparent;
            this.panel_sideTabAddTask.Controls.Add(this.btn_addTask);
            this.panel_sideTabAddTask.Location = new System.Drawing.Point(185, 371);
            this.panel_sideTabAddTask.Name = "panel_sideTabAddTask";
            this.panel_sideTabAddTask.Size = new System.Drawing.Size(176, 78);
            this.panel_sideTabAddTask.TabIndex = 39;
            this.panel_sideTabAddTask.Text = "panel9";
            // 
            // tb_addSubjClass
            // 
            this.tb_addSubjClass.Controls.Add(this.panel_side2);
            this.tb_addSubjClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_addSubjClass.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.tb_addSubjClass.Location = new System.Drawing.Point(12, 42);
            this.tb_addSubjClass.Name = "tb_addSubjClass";
            this.tb_addSubjClass.Size = new System.Drawing.Size(378, 491);
            this.tb_addSubjClass.TabIndex = 1;
            this.tb_addSubjClass.Text = "更改科目與類別";
            // 
            // panel_side2
            // 
            this.panel_side2.Controls.Add(this.FLPanel_side2);
            this.panel_side2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_side2.Location = new System.Drawing.Point(0, 0);
            this.panel_side2.Name = "panel_side2";
            this.panel_side2.Radius = 10;
            this.panel_side2.Shadow = 5;
            this.panel_side2.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(56)))), ((int)(((byte)(50)))));
            this.panel_side2.ShadowOpacity = 0.4F;
            this.panel_side2.ShadowOpacityAnimation = true;
            this.panel_side2.ShadowOpacityHover = 0.5F;
            this.panel_side2.Size = new System.Drawing.Size(378, 491);
            this.panel_side2.TabIndex = 50;
            this.panel_side2.Text = "panel10";
            // 
            // FLPanel_side2
            // 
            this.FLPanel_side2.AutoScroll = true;
            this.FLPanel_side2.BackColor = System.Drawing.Color.Transparent;
            this.FLPanel_side2.Controls.Add(this.panel_sideTabSubjectLabel);
            this.FLPanel_side2.Controls.Add(this.panel_sideTabSubjectControl);
            this.FLPanel_side2.Controls.Add(this.panel_sideTabClassLabel);
            this.FLPanel_side2.Controls.Add(this.panel_sideTabClassControl);
            this.FLPanel_side2.Controls.Add(this.lbl_tabModfiyMes);
            this.FLPanel_side2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPanel_side2.Location = new System.Drawing.Point(5, 5);
            this.FLPanel_side2.Name = "FLPanel_side2";
            this.FLPanel_side2.Size = new System.Drawing.Size(368, 481);
            this.FLPanel_side2.TabIndex = 49;
            // 
            // panel_sideTabSubjectLabel
            // 
            this.panel_sideTabSubjectLabel.Back = System.Drawing.Color.Transparent;
            this.panel_sideTabSubjectLabel.Controls.Add(this.label9);
            this.panel_sideTabSubjectLabel.Location = new System.Drawing.Point(3, 3);
            this.panel_sideTabSubjectLabel.Name = "panel_sideTabSubjectLabel";
            this.panel_sideTabSubjectLabel.Size = new System.Drawing.Size(64, 39);
            this.panel_sideTabSubjectLabel.TabIndex = 50;
            this.panel_sideTabSubjectLabel.Text = "panel12";
            // 
            // label9
            // 
            this.label9.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(16, 13);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 32);
            this.label9.TabIndex = 46;
            this.label9.Text = "科目";
            // 
            // panel_sideTabSubjectControl
            // 
            this.panel_sideTabSubjectControl.Back = System.Drawing.Color.Transparent;
            this.panel_sideTabSubjectControl.Controls.Add(this.select_controlSubject);
            this.panel_sideTabSubjectControl.Controls.Add(this.btn_addSubj);
            this.panel_sideTabSubjectControl.Controls.Add(this.btn_delSubj);
            this.panel_sideTabSubjectControl.Location = new System.Drawing.Point(73, 3);
            this.panel_sideTabSubjectControl.Name = "panel_sideTabSubjectControl";
            this.panel_sideTabSubjectControl.Size = new System.Drawing.Size(282, 99);
            this.panel_sideTabSubjectControl.TabIndex = 49;
            this.panel_sideTabSubjectControl.Text = "panel11";
            // 
            // select_controlSubject
            // 
            this.select_controlSubject.Location = new System.Drawing.Point(3, 9);
            this.select_controlSubject.Name = "select_controlSubject";
            this.select_controlSubject.Size = new System.Drawing.Size(276, 37);
            this.select_controlSubject.TabIndex = 44;
            this.select_controlSubject.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_controlSubject_KeyDown);
            // 
            // btn_addSubj
            // 
            this.btn_addSubj.DefaultBack = System.Drawing.SystemColors.AppWorkspace;
            this.btn_addSubj.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.btn_addSubj.Location = new System.Drawing.Point(107, 52);
            this.btn_addSubj.Name = "btn_addSubj";
            this.btn_addSubj.Size = new System.Drawing.Size(83, 43);
            this.btn_addSubj.TabIndex = 39;
            this.btn_addSubj.Text = "新增";
            this.btn_addSubj.Click += new System.EventHandler(this.btn_addSubj_Click);
            // 
            // btn_delSubj
            // 
            this.btn_delSubj.DefaultBack = System.Drawing.SystemColors.AppWorkspace;
            this.btn_delSubj.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.btn_delSubj.Location = new System.Drawing.Point(196, 52);
            this.btn_delSubj.Name = "btn_delSubj";
            this.btn_delSubj.Size = new System.Drawing.Size(83, 43);
            this.btn_delSubj.TabIndex = 38;
            this.btn_delSubj.Text = "刪除";
            this.btn_delSubj.Click += new System.EventHandler(this.btn_delSubj_Click);
            // 
            // panel_sideTabClassLabel
            // 
            this.panel_sideTabClassLabel.Back = System.Drawing.Color.Transparent;
            this.panel_sideTabClassLabel.Controls.Add(this.Label10);
            this.panel_sideTabClassLabel.Location = new System.Drawing.Point(3, 108);
            this.panel_sideTabClassLabel.Name = "panel_sideTabClassLabel";
            this.panel_sideTabClassLabel.Size = new System.Drawing.Size(64, 39);
            this.panel_sideTabClassLabel.TabIndex = 51;
            this.panel_sideTabClassLabel.Text = "panel13";
            // 
            // Label10
            // 
            this.Label10.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.Label10.BackColor = System.Drawing.Color.Transparent;
            this.Label10.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.Label10.Location = new System.Drawing.Point(16, 13);
            this.Label10.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(48, 32);
            this.Label10.TabIndex = 47;
            this.Label10.Text = "類別";
            // 
            // panel_sideTabClassControl
            // 
            this.panel_sideTabClassControl.Back = System.Drawing.Color.Transparent;
            this.panel_sideTabClassControl.Controls.Add(this.select_controlClass);
            this.panel_sideTabClassControl.Controls.Add(this.btn_delClass);
            this.panel_sideTabClassControl.Controls.Add(this.btn_addClass);
            this.panel_sideTabClassControl.Location = new System.Drawing.Point(73, 108);
            this.panel_sideTabClassControl.Name = "panel_sideTabClassControl";
            this.panel_sideTabClassControl.Size = new System.Drawing.Size(282, 99);
            this.panel_sideTabClassControl.TabIndex = 52;
            this.panel_sideTabClassControl.Text = "panel14";
            // 
            // select_controlClass
            // 
            this.select_controlClass.Location = new System.Drawing.Point(3, 9);
            this.select_controlClass.Name = "select_controlClass";
            this.select_controlClass.Size = new System.Drawing.Size(276, 37);
            this.select_controlClass.TabIndex = 43;
            this.select_controlClass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_controlClass_KeyDown);
            // 
            // btn_delClass
            // 
            this.btn_delClass.DefaultBack = System.Drawing.SystemColors.AppWorkspace;
            this.btn_delClass.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.btn_delClass.Location = new System.Drawing.Point(196, 52);
            this.btn_delClass.Name = "btn_delClass";
            this.btn_delClass.Size = new System.Drawing.Size(83, 43);
            this.btn_delClass.TabIndex = 40;
            this.btn_delClass.Text = "刪除";
            this.btn_delClass.Click += new System.EventHandler(this.btn_delClass_Click);
            // 
            // btn_addClass
            // 
            this.btn_addClass.DefaultBack = System.Drawing.SystemColors.AppWorkspace;
            this.btn_addClass.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.btn_addClass.Location = new System.Drawing.Point(107, 54);
            this.btn_addClass.Name = "btn_addClass";
            this.btn_addClass.Size = new System.Drawing.Size(83, 43);
            this.btn_addClass.TabIndex = 41;
            this.btn_addClass.Text = "新增";
            this.btn_addClass.Click += new System.EventHandler(this.btn_addClass_Click);
            // 
            // lbl_tabModfiyMes
            // 
            this.lbl_tabModfiyMes.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.lbl_tabModfiyMes.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tabModfiyMes.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tabModfiyMes.Location = new System.Drawing.Point(3, 213);
            this.lbl_tabModfiyMes.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.lbl_tabModfiyMes.Name = "lbl_tabModfiyMes";
            this.lbl_tabModfiyMes.Size = new System.Drawing.Size(26, 20);
            this.lbl_tabModfiyMes.TabIndex = 48;
            this.lbl_tabModfiyMes.Text = "abc";
            // 
            // timer_toopTipShow
            // 
            this.timer_toopTipShow.Interval = 1000;
            this.timer_toopTipShow.Tick += new System.EventHandler(this.timer_toopTipShow_Tick);
            // 
            // pageHeader
            // 
            this.pageHeader.ColorScheme = AntdUI.TAMode.Dark;
            this.pageHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pageHeader.Font = new System.Drawing.Font("微軟正黑體", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageHeader.ForeColor = System.Drawing.Color.White;
            this.pageHeader.Icon = ((System.Drawing.Image)(resources.GetObject("pageHeader.Icon")));
            this.pageHeader.IconRatio = 1F;
            this.pageHeader.IconSvg = "";
            this.pageHeader.Location = new System.Drawing.Point(0, 0);
            this.pageHeader.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.pageHeader.Mode = AntdUI.TAMode.Dark;
            this.pageHeader.Name = "pageHeader";
            this.pageHeader.ShowButton = true;
            this.pageHeader.ShowIcon = true;
            this.pageHeader.Size = new System.Drawing.Size(1264, 74);
            this.pageHeader.TabIndex = 20;
            this.pageHeader.Text = "My Learning Buddy";
            // 
            // panel_body
            // 
            this.panel_body.Controls.Add(this.splitter_sideAndCalendar);
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(0, 74);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1264, 645);
            this.panel_body.TabIndex = 23;
            this.panel_body.Text = "panel2";
            // 
            // splitter_sideAndCalendar
            // 
            this.splitter_sideAndCalendar.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitter_sideAndCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitter_sideAndCalendar.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitter_sideAndCalendar.Location = new System.Drawing.Point(0, 0);
            this.splitter_sideAndCalendar.Name = "splitter_sideAndCalendar";
            // 
            // splitter_sideAndCalendar.Panel1
            // 
            this.splitter_sideAndCalendar.Panel1.Controls.Add(this.splitter_addAndButton);
            this.splitter_sideAndCalendar.Panel1MinSize = 350;
            // 
            // splitter_sideAndCalendar.Panel2
            // 
            this.splitter_sideAndCalendar.Panel2.Controls.Add(this.gridpanel_calendar);
            this.splitter_sideAndCalendar.Panel2MinSize = 650;
            this.splitter_sideAndCalendar.Size = new System.Drawing.Size(1264, 645);
            this.splitter_sideAndCalendar.SplitterDistance = 390;
            this.splitter_sideAndCalendar.SplitterIncrement = 10;
            this.splitter_sideAndCalendar.SplitterSize = 0;
            this.splitter_sideAndCalendar.SplitterWidth = 10;
            this.splitter_sideAndCalendar.TabIndex = 0;
            // 
            // splitter_addAndButton
            // 
            this.splitter_addAndButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitter_addAndButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitter_addAndButton.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitter_addAndButton.IsSplitterFixed = true;
            this.splitter_addAndButton.Location = new System.Drawing.Point(0, 0);
            this.splitter_addAndButton.Name = "splitter_addAndButton";
            this.splitter_addAndButton.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitter_addAndButton.Panel1
            // 
            this.splitter_addAndButton.Panel1.Controls.Add(this.tabs_modifySet);
            // 
            // splitter_addAndButton.Panel2
            // 
            this.splitter_addAndButton.Panel2.Controls.Add(this.gridPanel_funButton);
            this.splitter_addAndButton.Size = new System.Drawing.Size(390, 645);
            this.splitter_addAndButton.SplitterBack = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.splitter_addAndButton.SplitterDistance = 533;
            this.splitter_addAndButton.SplitterSize = 0;
            this.splitter_addAndButton.SplitterWidth = 1;
            this.splitter_addAndButton.TabIndex = 22;
            // 
            // gridPanel_funButton
            // 
            this.gridPanel_funButton.Controls.Add(this.lbl_debug);
            this.gridPanel_funButton.Controls.Add(this.btn_settings);
            this.gridPanel_funButton.Controls.Add(this.btn_openPomo);
            this.gridPanel_funButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPanel_funButton.Location = new System.Drawing.Point(0, 0);
            this.gridPanel_funButton.Name = "gridPanel_funButton";
            this.gridPanel_funButton.Padding = new System.Windows.Forms.Padding(12, 0, 0, 12);
            this.gridPanel_funButton.Size = new System.Drawing.Size(390, 111);
            this.gridPanel_funButton.Span = "40% ;\r\n40% 50%";
            this.gridPanel_funButton.TabIndex = 0;
            this.gridPanel_funButton.Text = "gridPanel1";
            // 
            // lbl_debug
            // 
            this.lbl_debug.Location = new System.Drawing.Point(166, 53);
            this.lbl_debug.Name = "lbl_debug";
            this.lbl_debug.Size = new System.Drawing.Size(183, 44);
            this.lbl_debug.TabIndex = 25;
            this.lbl_debug.Text = "label5";
            // 
            // btn_settings
            // 
            this.btn_settings.BorderWidth = 2F;
            this.btn_settings.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.btn_settings.Location = new System.Drawing.Point(12, 50);
            this.btn_settings.Margin = new System.Windows.Forms.Padding(0);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(151, 50);
            this.btn_settings.TabIndex = 24;
            this.btn_settings.Text = "設定";
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_openPomo
            // 
            this.btn_openPomo.BorderWidth = 2F;
            this.btn_openPomo.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.btn_openPomo.Location = new System.Drawing.Point(12, 0);
            this.btn_openPomo.Margin = new System.Windows.Forms.Padding(0);
            this.btn_openPomo.Name = "btn_openPomo";
            this.btn_openPomo.Size = new System.Drawing.Size(151, 50);
            this.btn_openPomo.TabIndex = 23;
            this.btn_openPomo.Text = "開啟番茄鐘";
            this.btn_openPomo.Click += new System.EventHandler(this.btn_openPomo_Click);
            // 
            // Form_mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1264, 719);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.pageHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "Form_mainPage";
            this.Text = "My Learning Buddy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabs_modifySet.ResumeLayout(false);
            this.tb_addToDo.ResumeLayout(false);
            this.panel_side1.ResumeLayout(false);
            this.FLPanel_side1.ResumeLayout(false);
            this.panel_sideTabSubject.ResumeLayout(false);
            this.panel_sideTabSubject.PerformLayout();
            this.panel_sideTabClass.ResumeLayout(false);
            this.panel_sideTabClass.PerformLayout();
            this.panel_sideTabDeadline.ResumeLayout(false);
            this.panel_sideTabDeadline.PerformLayout();
            this.panel_sideTabDescript.ResumeLayout(false);
            this.panel_sideTabDescript.PerformLayout();
            this.panel_sideTabColor.ResumeLayout(false);
            this.panel_sideTabColor.PerformLayout();
            this.panel_sideTabAddTask.ResumeLayout(false);
            this.tb_addSubjClass.ResumeLayout(false);
            this.panel_side2.ResumeLayout(false);
            this.FLPanel_side2.ResumeLayout(false);
            this.FLPanel_side2.PerformLayout();
            this.panel_sideTabSubjectLabel.ResumeLayout(false);
            this.panel_sideTabSubjectLabel.PerformLayout();
            this.panel_sideTabSubjectControl.ResumeLayout(false);
            this.panel_sideTabClassLabel.ResumeLayout(false);
            this.panel_sideTabClassLabel.PerformLayout();
            this.panel_sideTabClassControl.ResumeLayout(false);
            this.panel_body.ResumeLayout(false);
            this.splitter_sideAndCalendar.Panel1.ResumeLayout(false);
            this.splitter_sideAndCalendar.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitter_sideAndCalendar)).EndInit();
            this.splitter_sideAndCalendar.ResumeLayout(false);
            this.splitter_addAndButton.Panel1.ResumeLayout(false);
            this.splitter_addAndButton.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitter_addAndButton)).EndInit();
            this.splitter_addAndButton.ResumeLayout(false);
            this.gridPanel_funButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private AntdUI.PageHeader pageHeader;
        private AntdUI.Panel panel_body;

        private AntdUI.Splitter splitter_sideAndCalendar;
        private AntdUI.Splitter splitter_addAndButton;

        private AntdUI.Tabs tabs_modifySet;

        private AntdUI.TabPage tb_addToDo;
        private AntdUI.Panel panel_side1;
        private AntdUI.In.FlowLayoutPanel FLPanel_side1;
        private AntdUI.Input input_taskDescribe;
        private AntdUI.Select select_subject;
        private AntdUI.Select select_classification;
        private AntdUI.Tooltip tooltip_subject;
        private AntdUI.Tooltip tooltip_class;
        private AntdUI.DatePicker dateTimeP_select;
        private AntdUI.Select select_selectColor;
        private AntdUI.Button btn_addTask;
        private AntdUI.Panel panel_sideTabClass;
        private AntdUI.Panel panel_sideTabSubject;
        private AntdUI.Panel panel_sideTabDeadline;
        private AntdUI.Panel panel_sideTabDescript;
        private AntdUI.Panel panel_sideTabColor;
        private AntdUI.Panel panel_sideTabAddTask;

        private AntdUI.TabPage tb_addSubjClass;
        private AntdUI.Panel panel_side2;
        private AntdUI.Panel panel_sideTabSubjectLabel;
        private AntdUI.Panel panel_sideTabClassLabel;
        private AntdUI.Panel panel_sideTabClassControl;
        private AntdUI.Panel panel_sideTabSubjectControl;
        private AntdUI.In.FlowLayoutPanel FLPanel_side2;
        private AntdUI.SelectMultiple select_controlSubject;
        private AntdUI.SelectMultiple select_controlClass;
        private AntdUI.Button btn_addSubj;
        private AntdUI.Button btn_delSubj;
        private AntdUI.Button btn_addClass;
        private AntdUI.Button btn_delClass;

        private AntdUI.GridPanel gridPanel_funButton;
        private AntdUI.Button btn_settings;
        private AntdUI.Button btn_openPomo;

        private AntdUI.GridPanel gridpanel_calendar;

        private System.Windows.Forms.Timer timer_toopTipShow;
        private AntdUI.Label label1;
        private AntdUI.Label label3;
        private AntdUI.Label label2;
        private AntdUI.Label label4;
        private AntdUI.Label label6;
        private AntdUI.Label label9;
        private AntdUI.Label Label10;
        private AntdUI.Label lbl_tabModfiyMes;
        private AntdUI.Label lbl_debug;
    }
}

