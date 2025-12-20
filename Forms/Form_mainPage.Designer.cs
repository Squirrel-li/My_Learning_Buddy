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
            AntdUI.Tabs.StyleLine styleLine1 = new AntdUI.Tabs.StyleLine();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_mainPage));
            this.select_selectColor = new AntdUI.Select();
            this.dateTimeP_select = new AntdUI.DatePicker();
            this.btn_addTask = new AntdUI.Button();
            this.select_classification = new AntdUI.Select();
            this.input_taskDescribe = new AntdUI.Input();
            this.select_subject = new AntdUI.Select();
            this.gridpanel_calendar = new AntdUI.GridPanel();
            this.tabs_modifySet = new AntdUI.Tabs();
            this.tb_addSubjClass = new AntdUI.TabPage();
            this.panel10 = new AntdUI.Panel();
            this.flowLayoutPanel2 = new AntdUI.In.FlowLayoutPanel();
            this.panel12 = new AntdUI.Panel();
            this.label9 = new AntdUI.Label();
            this.panel11 = new AntdUI.Panel();
            this.select_controlSubject = new AntdUI.SelectMultiple();
            this.btn_addSubj = new AntdUI.Button();
            this.btn_delSubj = new AntdUI.Button();
            this.panel13 = new AntdUI.Panel();
            this.label10 = new AntdUI.Label();
            this.panel14 = new AntdUI.Panel();
            this.select_controlClass = new AntdUI.SelectMultiple();
            this.btn_delClass = new AntdUI.Button();
            this.btn_addClass = new AntdUI.Button();
            this.lbl_tabModfiyMes = new AntdUI.Label();
            this.tb_addToDo = new AntdUI.TabPage();
            this.panel7 = new AntdUI.Panel();
            this.flowLayoutPanel1 = new AntdUI.In.FlowLayoutPanel();
            this.panel3 = new AntdUI.Panel();
            this.tooltip_class = new AntdUI.Tooltip();
            this.label6 = new AntdUI.Label();
            this.panel4 = new AntdUI.Panel();
            this.tooltip_subject = new AntdUI.Tooltip();
            this.label1 = new AntdUI.Label();
            this.panel6 = new AntdUI.Panel();
            this.label2 = new AntdUI.Label();
            this.panel8 = new AntdUI.Panel();
            this.label3 = new AntdUI.Label();
            this.panel5 = new AntdUI.Panel();
            this.label4 = new AntdUI.Label();
            this.panel9 = new AntdUI.Panel();
            this.timer_toopTipShow = new System.Windows.Forms.Timer(this.components);
            this.pageHeader1 = new AntdUI.PageHeader();
            this.panel2 = new AntdUI.Panel();
            this.splitter1 = new AntdUI.Splitter();
            this.splitter2 = new AntdUI.Splitter();
            this.gridPanel1 = new AntdUI.GridPanel();
            this.lbl_debug = new System.Windows.Forms.Label();
            this.btn_settings = new AntdUI.Button();
            this.btn_openPomo = new AntdUI.Button();
            this.tabs_modifySet.SuspendLayout();
            this.tb_addSubjClass.SuspendLayout();
            this.panel10.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            this.tb_addToDo.SuspendLayout();
            this.panel7.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitter1)).BeginInit();
            this.splitter1.Panel1.SuspendLayout();
            this.splitter1.Panel2.SuspendLayout();
            this.splitter1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitter2)).BeginInit();
            this.splitter2.Panel1.SuspendLayout();
            this.splitter2.Panel2.SuspendLayout();
            this.splitter2.SuspendLayout();
            this.gridPanel1.SuspendLayout();
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
            this.btn_addTask.DefaultBack = System.Drawing.SystemColors.AppWorkspace;
            this.btn_addTask.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
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
            this.tabs_modifySet.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.tabs_modifySet.Location = new System.Drawing.Point(0, 0);
            this.tabs_modifySet.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.tabs_modifySet.Name = "tabs_modifySet";
            this.tabs_modifySet.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.tabs_modifySet.Pages.Add(this.tb_addToDo);
            this.tabs_modifySet.Pages.Add(this.tb_addSubjClass);
            this.tabs_modifySet.Size = new System.Drawing.Size(390, 520);
            this.tabs_modifySet.Style = styleLine1;
            this.tabs_modifySet.TabIndex = 19;
            this.tabs_modifySet.Text = "tabs1";
            this.tabs_modifySet.SelectedIndexChanged += new AntdUI.IntEventHandler(this.tabs_modifySet_SelectedIndexChanged);
            // 
            // tb_addSubjClass
            // 
            this.tb_addSubjClass.Controls.Add(this.panel10);
            this.tb_addSubjClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_addSubjClass.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.tb_addSubjClass.Location = new System.Drawing.Point(12, 42);
            this.tb_addSubjClass.Name = "tb_addSubjClass";
            this.tb_addSubjClass.Size = new System.Drawing.Size(378, 478);
            this.tb_addSubjClass.TabIndex = 1;
            this.tb_addSubjClass.Text = "更改科目與類別";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.flowLayoutPanel2);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Radius = 10;
            this.panel10.Shadow = 5;
            this.panel10.Size = new System.Drawing.Size(378, 478);
            this.panel10.TabIndex = 50;
            this.panel10.Text = "panel10";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Controls.Add(this.panel12);
            this.flowLayoutPanel2.Controls.Add(this.panel11);
            this.flowLayoutPanel2.Controls.Add(this.panel13);
            this.flowLayoutPanel2.Controls.Add(this.panel14);
            this.flowLayoutPanel2.Controls.Add(this.lbl_tabModfiyMes);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(5, 5);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(368, 468);
            this.flowLayoutPanel2.TabIndex = 49;
            // 
            // panel12
            // 
            this.panel12.Back = System.Drawing.Color.Transparent;
            this.panel12.Controls.Add(this.label9);
            this.panel12.Location = new System.Drawing.Point(3, 3);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(64, 39);
            this.panel12.TabIndex = 50;
            this.panel12.Text = "panel12";
            // 
            // label9
            // 
            this.label9.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(16, 13);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 28);
            this.label9.TabIndex = 46;
            this.label9.Text = "科目";
            // 
            // panel11
            // 
            this.panel11.Back = System.Drawing.Color.Transparent;
            this.panel11.Controls.Add(this.select_controlSubject);
            this.panel11.Controls.Add(this.btn_addSubj);
            this.panel11.Controls.Add(this.btn_delSubj);
            this.panel11.Location = new System.Drawing.Point(73, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(282, 99);
            this.panel11.TabIndex = 49;
            this.panel11.Text = "panel11";
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
            this.btn_addSubj.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
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
            this.btn_delSubj.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.btn_delSubj.Location = new System.Drawing.Point(196, 52);
            this.btn_delSubj.Name = "btn_delSubj";
            this.btn_delSubj.Size = new System.Drawing.Size(83, 43);
            this.btn_delSubj.TabIndex = 38;
            this.btn_delSubj.Text = "刪除";
            this.btn_delSubj.Click += new System.EventHandler(this.btn_delSubj_Click);
            // 
            // panel13
            // 
            this.panel13.Back = System.Drawing.Color.Transparent;
            this.panel13.Controls.Add(this.label10);
            this.panel13.Location = new System.Drawing.Point(3, 108);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(64, 39);
            this.panel13.TabIndex = 51;
            this.panel13.Text = "panel13";
            // 
            // label10
            // 
            this.label10.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(16, 13);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 28);
            this.label10.TabIndex = 47;
            this.label10.Text = "類別";
            // 
            // panel14
            // 
            this.panel14.Back = System.Drawing.Color.Transparent;
            this.panel14.Controls.Add(this.select_controlClass);
            this.panel14.Controls.Add(this.btn_delClass);
            this.panel14.Controls.Add(this.btn_addClass);
            this.panel14.Location = new System.Drawing.Point(73, 108);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(282, 99);
            this.panel14.TabIndex = 52;
            this.panel14.Text = "panel14";
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
            this.btn_delClass.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
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
            this.btn_addClass.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
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
            this.lbl_tabModfiyMes.BackColor = System.Drawing.Color.White;
            this.lbl_tabModfiyMes.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tabModfiyMes.Location = new System.Drawing.Point(3, 213);
            this.lbl_tabModfiyMes.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.lbl_tabModfiyMes.Name = "lbl_tabModfiyMes";
            this.lbl_tabModfiyMes.Size = new System.Drawing.Size(26, 20);
            this.lbl_tabModfiyMes.TabIndex = 48;
            this.lbl_tabModfiyMes.Text = "abc";
            // 
            // tb_addToDo
            // 
            this.tb_addToDo.Controls.Add(this.panel7);
            this.tb_addToDo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_addToDo.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.tb_addToDo.Location = new System.Drawing.Point(12, 42);
            this.tb_addToDo.MinimumSize = new System.Drawing.Size(300, 0);
            this.tb_addToDo.Name = "tb_addToDo";
            this.tb_addToDo.Size = new System.Drawing.Size(378, 478);
            this.tb_addToDo.TabIndex = 0;
            this.tb_addToDo.Text = "新增任務";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.panel7.Controls.Add(this.flowLayoutPanel1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.MinimumSize = new System.Drawing.Size(290, 0);
            this.panel7.Name = "panel7";
            this.panel7.Radius = 10;
            this.panel7.Shadow = 5;
            this.panel7.Size = new System.Drawing.Size(378, 478);
            this.panel7.TabIndex = 0;
            this.panel7.Text = "panel7";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.Controls.Add(this.panel8);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.panel9);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(290, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(368, 468);
            this.flowLayoutPanel1.TabIndex = 34;
            // 
            // panel3
            // 
            this.panel3.Back = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.tooltip_class);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.select_subject);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(176, 90);
            this.panel3.TabIndex = 35;
            this.panel3.Text = "panel3";
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
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(16, 13);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 28);
            this.label6.TabIndex = 27;
            this.label6.Text = "科目";
            // 
            // panel4
            // 
            this.panel4.Back = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.select_classification);
            this.panel4.Controls.Add(this.tooltip_subject);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(185, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(176, 90);
            this.panel4.TabIndex = 36;
            this.panel4.Text = "panel4";
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
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 28);
            this.label1.TabIndex = 28;
            this.label1.Text = "類別";
            // 
            // panel6
            // 
            this.panel6.Back = System.Drawing.Color.Transparent;
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.dateTimeP_select);
            this.panel6.Location = new System.Drawing.Point(3, 99);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(290, 87);
            this.panel6.TabIndex = 37;
            this.panel6.Text = "panel6";
            // 
            // label2
            // 
            this.label2.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 28);
            this.label2.TabIndex = 31;
            this.label2.Text = "時間";
            // 
            // panel8
            // 
            this.panel8.Back = System.Drawing.Color.Transparent;
            this.panel8.Controls.Add(this.input_taskDescribe);
            this.panel8.Controls.Add(this.label3);
            this.panel8.Location = new System.Drawing.Point(3, 192);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(290, 173);
            this.panel8.TabIndex = 38;
            this.panel8.Text = "panel8";
            // 
            // label3
            // 
            this.label3.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(14, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 28);
            this.label3.TabIndex = 30;
            this.label3.Text = "敘述";
            // 
            // panel5
            // 
            this.panel5.Back = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.select_selectColor);
            this.panel5.Location = new System.Drawing.Point(3, 371);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(176, 78);
            this.panel5.TabIndex = 36;
            this.panel5.Text = "panel5";
            // 
            // label4
            // 
            this.label4.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(16, 1);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 28);
            this.label4.TabIndex = 32;
            this.label4.Text = "顏色";
            // 
            // panel9
            // 
            this.panel9.Back = System.Drawing.Color.Transparent;
            this.panel9.Controls.Add(this.btn_addTask);
            this.panel9.Location = new System.Drawing.Point(185, 371);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(176, 78);
            this.panel9.TabIndex = 39;
            this.panel9.Text = "panel9";
            // 
            // timer_toopTipShow
            // 
            this.timer_toopTipShow.Interval = 1000;
            this.timer_toopTipShow.Tick += new System.EventHandler(this.timer_toopTipShow_Tick);
            // 
            // pageHeader1
            // 
            this.pageHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pageHeader1.Font = new System.Drawing.Font("微軟正黑體", 30F);
            this.pageHeader1.Icon = ((System.Drawing.Image)(resources.GetObject("pageHeader1.Icon")));
            this.pageHeader1.IconRatio = 1F;
            this.pageHeader1.IconSvg = "";
            this.pageHeader1.Location = new System.Drawing.Point(0, 0);
            this.pageHeader1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.pageHeader1.Name = "pageHeader1";
            this.pageHeader1.ShowButton = true;
            this.pageHeader1.ShowIcon = true;
            this.pageHeader1.Size = new System.Drawing.Size(1264, 74);
            this.pageHeader1.TabIndex = 20;
            this.pageHeader1.Text = "My Learning Buddy";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitter1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1264, 645);
            this.panel2.TabIndex = 23;
            this.panel2.Text = "panel2";
            // 
            // splitter1
            // 
            this.splitter1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitter1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            // 
            // splitter1.Panel1
            // 
            this.splitter1.Panel1.Controls.Add(this.splitter2);
            this.splitter1.Panel1MinSize = 350;
            // 
            // splitter1.Panel2
            // 
            this.splitter1.Panel2.Controls.Add(this.gridpanel_calendar);
            this.splitter1.Panel2MinSize = 650;
            this.splitter1.Size = new System.Drawing.Size(1264, 645);
            this.splitter1.SplitterDistance = 390;
            this.splitter1.SplitterIncrement = 10;
            this.splitter1.SplitterSize = 0;
            this.splitter1.SplitterWidth = 10;
            this.splitter1.TabIndex = 0;
            // 
            // splitter2
            // 
            this.splitter2.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitter2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitter2.IsSplitterFixed = true;
            this.splitter2.Location = new System.Drawing.Point(0, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitter2.Panel1
            // 
            this.splitter2.Panel1.Controls.Add(this.tabs_modifySet);
            // 
            // splitter2.Panel2
            // 
            this.splitter2.Panel2.Controls.Add(this.gridPanel1);
            this.splitter2.Size = new System.Drawing.Size(390, 645);
            this.splitter2.SplitterBack = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.splitter2.SplitterDistance = 520;
            this.splitter2.SplitterSize = 0;
            this.splitter2.SplitterWidth = 1;
            this.splitter2.TabIndex = 22;
            // 
            // gridPanel1
            // 
            this.gridPanel1.Controls.Add(this.lbl_debug);
            this.gridPanel1.Controls.Add(this.btn_settings);
            this.gridPanel1.Controls.Add(this.btn_openPomo);
            this.gridPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPanel1.Location = new System.Drawing.Point(0, 0);
            this.gridPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.gridPanel1.Name = "gridPanel1";
            this.gridPanel1.Padding = new System.Windows.Forms.Padding(12, 0, 0, 12);
            this.gridPanel1.Size = new System.Drawing.Size(390, 124);
            this.gridPanel1.Span = "40% ;\r\n40% 50%";
            this.gridPanel1.TabIndex = 0;
            this.gridPanel1.Text = "gridPanel1";
            // 
            // lbl_debug
            // 
            this.lbl_debug.AutoSize = true;
            this.lbl_debug.Font = new System.Drawing.Font("更紗黑體 Mono TC Nerd", 8F);
            this.lbl_debug.Location = new System.Drawing.Point(166, 56);
            this.lbl_debug.Name = "lbl_debug";
            this.lbl_debug.Size = new System.Drawing.Size(183, 56);
            this.lbl_debug.TabIndex = 22;
            this.lbl_debug.Text = "Debug Mode Enable";
            this.lbl_debug.Visible = false;
            // 
            // btn_settings
            // 
            this.btn_settings.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.btn_settings.Location = new System.Drawing.Point(15, 59);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(145, 50);
            this.btn_settings.TabIndex = 24;
            this.btn_settings.Text = "設定";
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_openPomo
            // 
            this.btn_openPomo.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.btn_openPomo.Location = new System.Drawing.Point(15, 3);
            this.btn_openPomo.Name = "btn_openPomo";
            this.btn_openPomo.Size = new System.Drawing.Size(145, 50);
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
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pageHeader1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "Form_mainPage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabs_modifySet.ResumeLayout(false);
            this.tb_addSubjClass.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.tb_addToDo.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.splitter1.Panel1.ResumeLayout(false);
            this.splitter1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitter1)).EndInit();
            this.splitter1.ResumeLayout(false);
            this.splitter2.Panel1.ResumeLayout(false);
            this.splitter2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitter2)).EndInit();
            this.splitter2.ResumeLayout(false);
            this.gridPanel1.ResumeLayout(false);
            this.gridPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
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
        private AntdUI.SelectMultiple select_controlClass;
        private AntdUI.Button btn_addClass;
        private AntdUI.SelectMultiple select_controlSubject;
        private AntdUI.Button btn_addSubj;
        private AntdUI.Button btn_delClass;
        private AntdUI.Button btn_delSubj;
        private AntdUI.Label label1;
        private AntdUI.Label label6;
        private AntdUI.Label label3;
        private AntdUI.Label label2;
        private AntdUI.Label label4;
        private AntdUI.Tooltip tooltip_subject;
        private AntdUI.Tooltip tooltip_class;
        private System.Windows.Forms.Timer timer_toopTipShow;
        private AntdUI.PageHeader pageHeader1;
        private AntdUI.Label label9;
        private AntdUI.Label label10;
        private AntdUI.Label lbl_tabModfiyMes;
        private AntdUI.Panel panel2;
        private AntdUI.Splitter splitter1;
        private AntdUI.Splitter splitter2;
        private AntdUI.GridPanel gridPanel1;
        private AntdUI.Button btn_settings;
        private AntdUI.Button btn_openPomo;
        public System.Windows.Forms.Label lbl_debug;
        private AntdUI.Panel panel4;
        private AntdUI.Panel panel3;
        private AntdUI.Panel panel6;
        private AntdUI.Panel panel7;
        private AntdUI.In.FlowLayoutPanel flowLayoutPanel1;
        private AntdUI.Panel panel8;
        private AntdUI.Panel panel5;
        private AntdUI.Panel panel9;
        private AntdUI.Panel panel10;
        private AntdUI.In.FlowLayoutPanel flowLayoutPanel2;
        private AntdUI.Panel panel12;
        private AntdUI.Panel panel11;
        private AntdUI.Panel panel13;
        private AntdUI.Panel panel14;
    }
}

