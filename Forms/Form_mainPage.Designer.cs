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
            this.lbl_debug = new System.Windows.Forms.Label();
            this.tb_addToDo = new System.Windows.Forms.TabPage();
            this.select_selectColor = new AntdUI.Select();
            this.dateTimeP_select = new AntdUI.DatePicker();
            this.btn_addTask = new AntdUI.Button();
            this.select_classification = new AntdUI.Select();
            this.input_taskDescribe = new AntdUI.Input();
            this.select_subject = new AntdUI.Select();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_tabToDoMes = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tc_modifySet = new System.Windows.Forms.TabControl();
            this.tb_addSubjClass = new System.Windows.Forms.TabPage();
            this.select_controlSubject = new AntdUI.SelectMultiple();
            this.select_controlClass = new AntdUI.SelectMultiple();
            this.btn_addClass = new AntdUI.Button();
            this.btn_delClass = new AntdUI.Button();
            this.btn_addSubj = new AntdUI.Button();
            this.btn_delSubj = new AntdUI.Button();
            this.lbl_tabModfiyMes = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_openPomo = new AntdUI.Button();
            this.btn_settings = new AntdUI.Button();
            this.stackPanel1 = new AntdUI.StackPanel();
            this.stackPanel4 = new AntdUI.StackPanel();
            this.input7 = new AntdUI.Input();
            this.input8 = new AntdUI.Input();
            this.datePicker3 = new AntdUI.DatePicker();
            this.input9 = new AntdUI.Input();
            this.stackPanel3 = new AntdUI.StackPanel();
            this.input4 = new AntdUI.Input();
            this.input5 = new AntdUI.Input();
            this.datePicker2 = new AntdUI.DatePicker();
            this.input6 = new AntdUI.Input();
            this.stackPanel2 = new AntdUI.StackPanel();
            this.input2 = new AntdUI.Input();
            this.input3 = new AntdUI.Input();
            this.datePicker1 = new AntdUI.DatePicker();
            this.input1 = new AntdUI.Input();
            this.gridpanel_calendar = new AntdUI.GridPanel();
            this.tb_addToDo.SuspendLayout();
            this.tc_modifySet.SuspendLayout();
            this.tb_addSubjClass.SuspendLayout();
            this.stackPanel1.SuspendLayout();
            this.stackPanel4.SuspendLayout();
            this.stackPanel3.SuspendLayout();
            this.stackPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_debug
            // 
            this.lbl_debug.AutoSize = true;
            this.lbl_debug.Font = new System.Drawing.Font("更紗黑體 Mono TC Nerd", 8F);
            this.lbl_debug.Location = new System.Drawing.Point(14, 444);
            this.lbl_debug.Name = "lbl_debug";
            this.lbl_debug.Size = new System.Drawing.Size(109, 14);
            this.lbl_debug.TabIndex = 3;
            this.lbl_debug.Text = "Debug Mode Enable";
            this.lbl_debug.Visible = false;
            // 
            // tb_addToDo
            // 
            this.tb_addToDo.BackColor = System.Drawing.SystemColors.Control;
            this.tb_addToDo.Controls.Add(this.select_selectColor);
            this.tb_addToDo.Controls.Add(this.dateTimeP_select);
            this.tb_addToDo.Controls.Add(this.btn_addTask);
            this.tb_addToDo.Controls.Add(this.select_classification);
            this.tb_addToDo.Controls.Add(this.input_taskDescribe);
            this.tb_addToDo.Controls.Add(this.select_subject);
            this.tb_addToDo.Controls.Add(this.label5);
            this.tb_addToDo.Controls.Add(this.lbl_tabToDoMes);
            this.tb_addToDo.Controls.Add(this.label4);
            this.tb_addToDo.Controls.Add(this.label3);
            this.tb_addToDo.Controls.Add(this.label2);
            this.tb_addToDo.Controls.Add(this.label1);
            this.tb_addToDo.Location = new System.Drawing.Point(4, 29);
            this.tb_addToDo.Name = "tb_addToDo";
            this.tb_addToDo.Padding = new System.Windows.Forms.Padding(3);
            this.tb_addToDo.Size = new System.Drawing.Size(318, 399);
            this.tb_addToDo.TabIndex = 0;
            this.tb_addToDo.Text = "新增代辦事項";
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
            this.select_selectColor.Location = new System.Drawing.Point(9, 325);
            this.select_selectColor.MaxCount = 5;
            this.select_selectColor.Name = "select_selectColor";
            this.select_selectColor.Size = new System.Drawing.Size(144, 48);
            this.select_selectColor.TabIndex = 26;
            this.select_selectColor.SelectedIndexChanged += new AntdUI.IntEventHandler(this.select_selectColor_SelectedIndexChanged);
            // 
            // dateTimeP_select
            // 
            this.dateTimeP_select.DropDownArrow = true;
            this.dateTimeP_select.Format = "yyyy/MM/dd HH:mm";
            this.dateTimeP_select.Location = new System.Drawing.Point(9, 250);
            this.dateTimeP_select.Name = "dateTimeP_select";
            this.dateTimeP_select.ShowIcon = false;
            this.dateTimeP_select.Size = new System.Drawing.Size(302, 44);
            this.dateTimeP_select.TabIndex = 21;
            this.dateTimeP_select.ExpandDropChanged += new AntdUI.BoolEventHandler(this.dateTimeP_select_ExpandDropChanged);
            this.dateTimeP_select.PrefixClick += new System.Windows.Forms.MouseEventHandler(this.dateTimeP_select_PrefixClick);
            // 
            // btn_addTask
            // 
            this.btn_addTask.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.btn_addTask.Location = new System.Drawing.Point(168, 324);
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
            this.select_classification.Location = new System.Drawing.Point(168, 33);
            this.select_classification.MaxCount = 5;
            this.select_classification.Name = "select_classification";
            this.select_classification.Size = new System.Drawing.Size(144, 38);
            this.select_classification.TabIndex = 25;
            // 
            // input_taskDescribe
            // 
            this.input_taskDescribe.AutoScroll = true;
            this.input_taskDescribe.Font = new System.Drawing.Font("微軟正黑體", 14.25F);
            this.input_taskDescribe.Location = new System.Drawing.Point(9, 99);
            this.input_taskDescribe.Multiline = true;
            this.input_taskDescribe.Name = "input_taskDescribe";
            this.input_taskDescribe.Size = new System.Drawing.Size(303, 121);
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
            this.select_subject.Location = new System.Drawing.Point(9, 33);
            this.select_subject.MaxCount = 5;
            this.select_subject.Name = "select_subject";
            this.select_subject.Size = new System.Drawing.Size(144, 38);
            this.select_subject.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "顏色";
            // 
            // lbl_tabToDoMes
            // 
            this.lbl_tabToDoMes.AutoSize = true;
            this.lbl_tabToDoMes.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_tabToDoMes.Location = new System.Drawing.Point(9, 376);
            this.lbl_tabToDoMes.Name = "lbl_tabToDoMes";
            this.lbl_tabToDoMes.Size = new System.Drawing.Size(36, 20);
            this.lbl_tabToDoMes.TabIndex = 15;
            this.lbl_tabToDoMes.Text = "123";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "時間";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "敘述";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "類別";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "科目";
            // 
            // tc_modifySet
            // 
            this.tc_modifySet.Controls.Add(this.tb_addToDo);
            this.tc_modifySet.Controls.Add(this.tb_addSubjClass);
            this.tc_modifySet.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tc_modifySet.Location = new System.Drawing.Point(12, 9);
            this.tc_modifySet.Name = "tc_modifySet";
            this.tc_modifySet.SelectedIndex = 0;
            this.tc_modifySet.Size = new System.Drawing.Size(326, 432);
            this.tc_modifySet.TabIndex = 14;
            this.tc_modifySet.SelectedIndexChanged += new System.EventHandler(this.tc_modifySet_SelectedIndexChanged);
            // 
            // tb_addSubjClass
            // 
            this.tb_addSubjClass.BackColor = System.Drawing.SystemColors.Control;
            this.tb_addSubjClass.Controls.Add(this.select_controlSubject);
            this.tb_addSubjClass.Controls.Add(this.select_controlClass);
            this.tb_addSubjClass.Controls.Add(this.btn_addClass);
            this.tb_addSubjClass.Controls.Add(this.btn_delClass);
            this.tb_addSubjClass.Controls.Add(this.btn_addSubj);
            this.tb_addSubjClass.Controls.Add(this.btn_delSubj);
            this.tb_addSubjClass.Controls.Add(this.lbl_tabModfiyMes);
            this.tb_addSubjClass.Controls.Add(this.label7);
            this.tb_addSubjClass.Controls.Add(this.label8);
            this.tb_addSubjClass.Location = new System.Drawing.Point(4, 29);
            this.tb_addSubjClass.Name = "tb_addSubjClass";
            this.tb_addSubjClass.Padding = new System.Windows.Forms.Padding(3);
            this.tb_addSubjClass.Size = new System.Drawing.Size(318, 399);
            this.tb_addSubjClass.TabIndex = 1;
            this.tb_addSubjClass.Text = "更改科目與類別";
            // 
            // select_controlSubject
            // 
            this.select_controlSubject.Location = new System.Drawing.Point(64, 7);
            this.select_controlSubject.Name = "select_controlSubject";
            this.select_controlSubject.Size = new System.Drawing.Size(248, 37);
            this.select_controlSubject.TabIndex = 44;
            this.select_controlSubject.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_controlSubject_KeyDown);
            // 
            // select_controlClass
            // 
            this.select_controlClass.Location = new System.Drawing.Point(64, 168);
            this.select_controlClass.Name = "select_controlClass";
            this.select_controlClass.Size = new System.Drawing.Size(248, 37);
            this.select_controlClass.TabIndex = 43;
            this.select_controlClass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_controlClass_KeyDown);
            // 
            // btn_addClass
            // 
            this.btn_addClass.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.btn_addClass.Location = new System.Drawing.Point(140, 211);
            this.btn_addClass.Name = "btn_addClass";
            this.btn_addClass.Size = new System.Drawing.Size(83, 43);
            this.btn_addClass.TabIndex = 41;
            this.btn_addClass.Text = "新增";
            this.btn_addClass.Click += new System.EventHandler(this.btn_addClass_Click);
            // 
            // btn_delClass
            // 
            this.btn_delClass.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.btn_delClass.Location = new System.Drawing.Point(229, 211);
            this.btn_delClass.Name = "btn_delClass";
            this.btn_delClass.Size = new System.Drawing.Size(83, 43);
            this.btn_delClass.TabIndex = 40;
            this.btn_delClass.Text = "刪除";
            this.btn_delClass.Click += new System.EventHandler(this.btn_delClass_Click);
            // 
            // btn_addSubj
            // 
            this.btn_addSubj.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.btn_addSubj.Location = new System.Drawing.Point(140, 50);
            this.btn_addSubj.Name = "btn_addSubj";
            this.btn_addSubj.Size = new System.Drawing.Size(83, 43);
            this.btn_addSubj.TabIndex = 39;
            this.btn_addSubj.Text = "新增";
            this.btn_addSubj.Click += new System.EventHandler(this.btn_addSubj_Click);
            // 
            // btn_delSubj
            // 
            this.btn_delSubj.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.btn_delSubj.Location = new System.Drawing.Point(229, 50);
            this.btn_delSubj.Name = "btn_delSubj";
            this.btn_delSubj.Size = new System.Drawing.Size(83, 43);
            this.btn_delSubj.TabIndex = 38;
            this.btn_delSubj.Text = "刪除";
            this.btn_delSubj.Click += new System.EventHandler(this.btn_delSubj_Click);
            // 
            // lbl_tabModfiyMes
            // 
            this.lbl_tabModfiyMes.AutoSize = true;
            this.lbl_tabModfiyMes.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_tabModfiyMes.Location = new System.Drawing.Point(14, 301);
            this.lbl_tabModfiyMes.Name = "lbl_tabModfiyMes";
            this.lbl_tabModfiyMes.Size = new System.Drawing.Size(0, 20);
            this.lbl_tabModfiyMes.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 15F);
            this.label7.Location = new System.Drawing.Point(9, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "類別";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 15F);
            this.label8.Location = new System.Drawing.Point(9, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "科目";
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
            // stackPanel1
            // 
            this.stackPanel1.AutoScroll = true;
            this.stackPanel1.Controls.Add(this.stackPanel4);
            this.stackPanel1.Controls.Add(this.stackPanel3);
            this.stackPanel1.Controls.Add(this.stackPanel2);
            this.stackPanel1.Location = new System.Drawing.Point(175, 447);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(159, 222);
            this.stackPanel1.TabIndex = 17;
            this.stackPanel1.Text = "stackPanel1";
            this.stackPanel1.Vertical = true;
            this.stackPanel1.Visible = false;
            // 
            // stackPanel4
            // 
            this.stackPanel4.AutoScroll = true;
            this.stackPanel4.Controls.Add(this.input7);
            this.stackPanel4.Controls.Add(this.input8);
            this.stackPanel4.Controls.Add(this.datePicker3);
            this.stackPanel4.Controls.Add(this.input9);
            this.stackPanel4.Location = new System.Drawing.Point(3, 367);
            this.stackPanel4.Name = "stackPanel4";
            this.stackPanel4.Size = new System.Drawing.Size(137, 176);
            this.stackPanel4.TabIndex = 5;
            this.stackPanel4.Text = "stackPanel4";
            this.stackPanel4.Vertical = true;
            // 
            // input7
            // 
            this.input7.JoinMode = AntdUI.TJoinMode.Bottom;
            this.input7.Location = new System.Drawing.Point(0, 90);
            this.input7.Margin = new System.Windows.Forms.Padding(0);
            this.input7.Name = "input7";
            this.input7.Size = new System.Drawing.Size(137, 64);
            this.input7.TabIndex = 5;
            this.input7.Text = "input7";
            // 
            // input8
            // 
            this.input8.JoinMode = AntdUI.TJoinMode.TB;
            this.input8.Location = new System.Drawing.Point(0, 60);
            this.input8.Margin = new System.Windows.Forms.Padding(0);
            this.input8.Name = "input8";
            this.input8.Size = new System.Drawing.Size(137, 30);
            this.input8.TabIndex = 4;
            this.input8.Text = "input8";
            // 
            // datePicker3
            // 
            this.datePicker3.JoinMode = AntdUI.TJoinMode.TB;
            this.datePicker3.Location = new System.Drawing.Point(0, 30);
            this.datePicker3.Margin = new System.Windows.Forms.Padding(0);
            this.datePicker3.Name = "datePicker3";
            this.datePicker3.Size = new System.Drawing.Size(137, 30);
            this.datePicker3.TabIndex = 3;
            // 
            // input9
            // 
            this.input9.JoinMode = AntdUI.TJoinMode.Top;
            this.input9.Location = new System.Drawing.Point(0, 0);
            this.input9.Margin = new System.Windows.Forms.Padding(0);
            this.input9.Name = "input9";
            this.input9.Size = new System.Drawing.Size(137, 30);
            this.input9.TabIndex = 0;
            this.input9.Text = "input9";
            // 
            // stackPanel3
            // 
            this.stackPanel3.AutoScroll = true;
            this.stackPanel3.Controls.Add(this.input4);
            this.stackPanel3.Controls.Add(this.input5);
            this.stackPanel3.Controls.Add(this.datePicker2);
            this.stackPanel3.Controls.Add(this.input6);
            this.stackPanel3.Location = new System.Drawing.Point(3, 185);
            this.stackPanel3.Name = "stackPanel3";
            this.stackPanel3.Size = new System.Drawing.Size(137, 176);
            this.stackPanel3.TabIndex = 4;
            this.stackPanel3.Text = "stackPanel3";
            this.stackPanel3.Vertical = true;
            // 
            // input4
            // 
            this.input4.JoinMode = AntdUI.TJoinMode.Bottom;
            this.input4.Location = new System.Drawing.Point(0, 90);
            this.input4.Margin = new System.Windows.Forms.Padding(0);
            this.input4.Name = "input4";
            this.input4.Size = new System.Drawing.Size(137, 64);
            this.input4.TabIndex = 5;
            this.input4.Text = "input4";
            // 
            // input5
            // 
            this.input5.JoinMode = AntdUI.TJoinMode.TB;
            this.input5.Location = new System.Drawing.Point(0, 60);
            this.input5.Margin = new System.Windows.Forms.Padding(0);
            this.input5.Name = "input5";
            this.input5.Size = new System.Drawing.Size(137, 30);
            this.input5.TabIndex = 4;
            this.input5.Text = "input5";
            // 
            // datePicker2
            // 
            this.datePicker2.JoinMode = AntdUI.TJoinMode.TB;
            this.datePicker2.Location = new System.Drawing.Point(0, 30);
            this.datePicker2.Margin = new System.Windows.Forms.Padding(0);
            this.datePicker2.Name = "datePicker2";
            this.datePicker2.Size = new System.Drawing.Size(137, 30);
            this.datePicker2.TabIndex = 3;
            // 
            // input6
            // 
            this.input6.JoinMode = AntdUI.TJoinMode.Top;
            this.input6.Location = new System.Drawing.Point(0, 0);
            this.input6.Margin = new System.Windows.Forms.Padding(0);
            this.input6.Name = "input6";
            this.input6.Size = new System.Drawing.Size(137, 30);
            this.input6.TabIndex = 0;
            this.input6.Text = "input6";
            // 
            // stackPanel2
            // 
            this.stackPanel2.AutoScroll = true;
            this.stackPanel2.Controls.Add(this.input2);
            this.stackPanel2.Controls.Add(this.input3);
            this.stackPanel2.Controls.Add(this.datePicker1);
            this.stackPanel2.Controls.Add(this.input1);
            this.stackPanel2.Location = new System.Drawing.Point(3, 3);
            this.stackPanel2.Name = "stackPanel2";
            this.stackPanel2.Size = new System.Drawing.Size(137, 176);
            this.stackPanel2.TabIndex = 3;
            this.stackPanel2.Text = "stackPanel2";
            this.stackPanel2.Vertical = true;
            // 
            // input2
            // 
            this.input2.JoinMode = AntdUI.TJoinMode.Bottom;
            this.input2.Location = new System.Drawing.Point(0, 90);
            this.input2.Margin = new System.Windows.Forms.Padding(0);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(137, 64);
            this.input2.TabIndex = 5;
            this.input2.Text = "input2";
            // 
            // input3
            // 
            this.input3.JoinMode = AntdUI.TJoinMode.TB;
            this.input3.Location = new System.Drawing.Point(0, 60);
            this.input3.Margin = new System.Windows.Forms.Padding(0);
            this.input3.Name = "input3";
            this.input3.Size = new System.Drawing.Size(137, 30);
            this.input3.TabIndex = 4;
            this.input3.Text = "input3";
            // 
            // datePicker1
            // 
            this.datePicker1.JoinMode = AntdUI.TJoinMode.TB;
            this.datePicker1.Location = new System.Drawing.Point(0, 30);
            this.datePicker1.Margin = new System.Windows.Forms.Padding(0);
            this.datePicker1.Name = "datePicker1";
            this.datePicker1.Size = new System.Drawing.Size(137, 30);
            this.datePicker1.TabIndex = 3;
            // 
            // input1
            // 
            this.input1.JoinMode = AntdUI.TJoinMode.Top;
            this.input1.Location = new System.Drawing.Point(0, 0);
            this.input1.Margin = new System.Windows.Forms.Padding(0);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(137, 30);
            this.input1.TabIndex = 0;
            this.input1.Text = "input1";
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
            // Form_mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.lbl_debug);
            this.Controls.Add(this.gridpanel_calendar);
            this.Controls.Add(this.stackPanel1);
            this.Controls.Add(this.btn_settings);
            this.Controls.Add(this.btn_openPomo);
            this.Controls.Add(this.tc_modifySet);
            this.Name = "Form_mainPage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tb_addToDo.ResumeLayout(false);
            this.tb_addToDo.PerformLayout();
            this.tc_modifySet.ResumeLayout(false);
            this.tb_addSubjClass.ResumeLayout(false);
            this.tb_addSubjClass.PerformLayout();
            this.stackPanel1.ResumeLayout(false);
            this.stackPanel4.ResumeLayout(false);
            this.stackPanel3.ResumeLayout(false);
            this.stackPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lbl_debug;
        private System.Windows.Forms.TabPage tb_addToDo;
        public System.Windows.Forms.Label lbl_tabToDoMes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tc_modifySet;
        private System.Windows.Forms.TabPage tb_addSubjClass;
        public System.Windows.Forms.Label lbl_tabModfiyMes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private AntdUI.Button btn_openPomo;
        private AntdUI.Button btn_settings;
        private AntdUI.Input input_taskDescribe;
        private AntdUI.Select select_subject;
        private AntdUI.Select select_classification;
        private AntdUI.Button btn_addTask;
        private AntdUI.DatePicker dateTimeP_select;
        private AntdUI.Select select_selectColor;
        private AntdUI.Button btn_addClass;
        private AntdUI.Button btn_delClass;
        private AntdUI.Button btn_addSubj;
        private AntdUI.Button btn_delSubj;
        private AntdUI.SelectMultiple select_controlClass;
        private AntdUI.SelectMultiple select_controlSubject;
        private AntdUI.StackPanel stackPanel1;
        private AntdUI.StackPanel stackPanel4;
        private AntdUI.Input input7;
        private AntdUI.Input input8;
        private AntdUI.DatePicker datePicker3;
        private AntdUI.Input input9;
        private AntdUI.StackPanel stackPanel3;
        private AntdUI.Input input4;
        private AntdUI.Input input5;
        private AntdUI.DatePicker datePicker2;
        private AntdUI.Input input6;
        private AntdUI.StackPanel stackPanel2;
        private AntdUI.Input input2;
        private AntdUI.Input input3;
        private AntdUI.DatePicker datePicker1;
        private AntdUI.Input input1;
        private AntdUI.GridPanel gridpanel_calendar;
    }
}

