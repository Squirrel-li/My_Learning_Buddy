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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_openPomo = new System.Windows.Forms.Button();
            this.flpanel_calendar = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_debug = new System.Windows.Forms.Label();
            this.btn_settings = new System.Windows.Forms.Button();
            this.tb_addToDo = new System.Windows.Forms.TabPage();
            this.btn_addTask = new System.Windows.Forms.Button();
            this.cb_subject = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_classification = new System.Windows.Forms.ComboBox();
            this.tb_taskDescribe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_tabToDoMes = new System.Windows.Forms.Label();
            this.tc_modifySet = new System.Windows.Forms.TabControl();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_addSubj = new System.Windows.Forms.Button();
            this.btn_delSubj = new System.Windows.Forms.Button();
            this.btn_addClass = new System.Windows.Forms.Button();
            this.btn_delClass = new System.Windows.Forms.Button();
            this.lbl_tabModfiyMes = new System.Windows.Forms.Label();
            this.tb_addSubjClass = new System.Windows.Forms.TabPage();
            this.cb_controlSubject = new System.Windows.Forms.ComboBox();
            this.cb_controlClass = new System.Windows.Forms.ComboBox();
            this.mainpageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainpageBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tb_addToDo.SuspendLayout();
            this.tc_modifySet.SuspendLayout();
            this.tb_addSubjClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainpageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainpageBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_openPomo
            // 
            this.btn_openPomo.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_openPomo.Location = new System.Drawing.Point(14, 591);
            this.btn_openPomo.Name = "btn_openPomo";
            this.btn_openPomo.Size = new System.Drawing.Size(143, 36);
            this.btn_openPomo.TabIndex = 2;
            this.btn_openPomo.Text = "開啟番茄鐘";
            this.btn_openPomo.UseVisualStyleBackColor = true;
            this.btn_openPomo.Click += new System.EventHandler(this.btn_openPomo_Click);
            // 
            // flpanel_calendar
            // 
            this.flpanel_calendar.Location = new System.Drawing.Point(344, 9);
            this.flpanel_calendar.Name = "flpanel_calendar";
            this.flpanel_calendar.Size = new System.Drawing.Size(908, 660);
            this.flpanel_calendar.TabIndex = 0;
            this.flpanel_calendar.WrapContents = false;
            // 
            // lbl_debug
            // 
            this.lbl_debug.AutoSize = true;
            this.lbl_debug.Font = new System.Drawing.Font("標楷體", 8F);
            this.lbl_debug.Location = new System.Drawing.Point(13, 399);
            this.lbl_debug.Name = "lbl_debug";
            this.lbl_debug.Size = new System.Drawing.Size(59, 11);
            this.lbl_debug.TabIndex = 3;
            this.lbl_debug.Text = "lbl_debug";
            // 
            // btn_settings
            // 
            this.btn_settings.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_settings.Location = new System.Drawing.Point(12, 633);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(66, 36);
            this.btn_settings.TabIndex = 4;
            this.btn_settings.Text = "設定";
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // tb_addToDo
            // 
            this.tb_addToDo.BackColor = System.Drawing.SystemColors.Control;
            this.tb_addToDo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_addToDo.Controls.Add(this.lbl_tabToDoMes);
            this.tb_addToDo.Controls.Add(this.label4);
            this.tb_addToDo.Controls.Add(this.dateTimePicker1);
            this.tb_addToDo.Controls.Add(this.label3);
            this.tb_addToDo.Controls.Add(this.tb_taskDescribe);
            this.tb_addToDo.Controls.Add(this.cb_classification);
            this.tb_addToDo.Controls.Add(this.label2);
            this.tb_addToDo.Controls.Add(this.label1);
            this.tb_addToDo.Controls.Add(this.cb_subject);
            this.tb_addToDo.Controls.Add(this.btn_addTask);
            this.tb_addToDo.Location = new System.Drawing.Point(4, 26);
            this.tb_addToDo.Name = "tb_addToDo";
            this.tb_addToDo.Padding = new System.Windows.Forms.Padding(3);
            this.tb_addToDo.Size = new System.Drawing.Size(318, 333);
            this.tb_addToDo.TabIndex = 0;
            this.tb_addToDo.Text = "新增代辦事項";
            // 
            // btn_addTask
            // 
            this.btn_addTask.Font = new System.Drawing.Font("標楷體", 15F);
            this.btn_addTask.Location = new System.Drawing.Point(201, 287);
            this.btn_addTask.Name = "btn_addTask";
            this.btn_addTask.Size = new System.Drawing.Size(106, 43);
            this.btn_addTask.TabIndex = 14;
            this.btn_addTask.Text = "新增事項";
            this.btn_addTask.UseVisualStyleBackColor = true;
            this.btn_addTask.Click += new System.EventHandler(this.btn_addTask_Click);
            // 
            // cb_subject
            // 
            this.cb_subject.Font = new System.Drawing.Font("標楷體", 15F);
            this.cb_subject.FormattingEnabled = true;
            this.cb_subject.Location = new System.Drawing.Point(13, 34);
            this.cb_subject.Name = "cb_subject";
            this.cb_subject.Size = new System.Drawing.Size(135, 28);
            this.cb_subject.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 15F);
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "科目";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 15F);
            this.label2.Location = new System.Drawing.Point(168, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "類別";
            // 
            // cb_classification
            // 
            this.cb_classification.Font = new System.Drawing.Font("標楷體", 15F);
            this.cb_classification.FormattingEnabled = true;
            this.cb_classification.Location = new System.Drawing.Point(172, 34);
            this.cb_classification.Name = "cb_classification";
            this.cb_classification.Size = new System.Drawing.Size(135, 28);
            this.cb_classification.TabIndex = 18;
            // 
            // tb_taskDescribe
            // 
            this.tb_taskDescribe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_taskDescribe.Location = new System.Drawing.Point(13, 100);
            this.tb_taskDescribe.Multiline = true;
            this.tb_taskDescribe.Name = "tb_taskDescribe";
            this.tb_taskDescribe.Size = new System.Drawing.Size(294, 120);
            this.tb_taskDescribe.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("標楷體", 15F);
            this.label3.Location = new System.Drawing.Point(9, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "敘述";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(13, 246);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(290, 27);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("標楷體", 15F);
            this.label4.Location = new System.Drawing.Point(13, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "時間";
            // 
            // lbl_tabToDoMes
            // 
            this.lbl_tabToDoMes.AutoSize = true;
            this.lbl_tabToDoMes.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_tabToDoMes.Location = new System.Drawing.Point(14, 301);
            this.lbl_tabToDoMes.Name = "lbl_tabToDoMes";
            this.lbl_tabToDoMes.Size = new System.Drawing.Size(0, 16);
            this.lbl_tabToDoMes.TabIndex = 15;
            // 
            // tc_modifySet
            // 
            this.tc_modifySet.Controls.Add(this.tb_addToDo);
            this.tc_modifySet.Controls.Add(this.tb_addSubjClass);
            this.tc_modifySet.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tc_modifySet.Location = new System.Drawing.Point(12, 9);
            this.tc_modifySet.Name = "tc_modifySet";
            this.tc_modifySet.SelectedIndex = 0;
            this.tc_modifySet.Size = new System.Drawing.Size(326, 363);
            this.tc_modifySet.TabIndex = 14;
            this.tc_modifySet.SelectedIndexChanged += new System.EventHandler(this.tc_modifySet_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("標楷體", 15F);
            this.label8.Location = new System.Drawing.Point(9, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "科目";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("標楷體", 15F);
            this.label7.Location = new System.Drawing.Point(9, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "類別";
            // 
            // btn_addSubj
            // 
            this.btn_addSubj.Font = new System.Drawing.Font("標楷體", 15F);
            this.btn_addSubj.Location = new System.Drawing.Point(140, 45);
            this.btn_addSubj.Name = "btn_addSubj";
            this.btn_addSubj.Size = new System.Drawing.Size(83, 29);
            this.btn_addSubj.TabIndex = 25;
            this.btn_addSubj.Text = "新增";
            this.btn_addSubj.UseVisualStyleBackColor = true;
            this.btn_addSubj.Click += new System.EventHandler(this.btn_addSubj_Click);
            // 
            // btn_delSubj
            // 
            this.btn_delSubj.Font = new System.Drawing.Font("標楷體", 15F);
            this.btn_delSubj.Location = new System.Drawing.Point(229, 45);
            this.btn_delSubj.Name = "btn_delSubj";
            this.btn_delSubj.Size = new System.Drawing.Size(83, 29);
            this.btn_delSubj.TabIndex = 29;
            this.btn_delSubj.Text = "刪除";
            this.btn_delSubj.UseVisualStyleBackColor = true;
            this.btn_delSubj.Click += new System.EventHandler(this.btn_delSubj_Click);
            // 
            // btn_addClass
            // 
            this.btn_addClass.Font = new System.Drawing.Font("標楷體", 15F);
            this.btn_addClass.Location = new System.Drawing.Point(140, 207);
            this.btn_addClass.Name = "btn_addClass";
            this.btn_addClass.Size = new System.Drawing.Size(83, 29);
            this.btn_addClass.TabIndex = 30;
            this.btn_addClass.Text = "新增";
            this.btn_addClass.UseVisualStyleBackColor = true;
            this.btn_addClass.Click += new System.EventHandler(this.btn_addClass_Click);
            // 
            // btn_delClass
            // 
            this.btn_delClass.Font = new System.Drawing.Font("標楷體", 15F);
            this.btn_delClass.Location = new System.Drawing.Point(229, 207);
            this.btn_delClass.Name = "btn_delClass";
            this.btn_delClass.Size = new System.Drawing.Size(83, 29);
            this.btn_delClass.TabIndex = 33;
            this.btn_delClass.Text = "刪除";
            this.btn_delClass.UseVisualStyleBackColor = true;
            this.btn_delClass.Click += new System.EventHandler(this.btn_delClass_Click);
            // 
            // lbl_tabModfiyMes
            // 
            this.lbl_tabModfiyMes.AutoSize = true;
            this.lbl_tabModfiyMes.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_tabModfiyMes.Location = new System.Drawing.Point(14, 301);
            this.lbl_tabModfiyMes.Name = "lbl_tabModfiyMes";
            this.lbl_tabModfiyMes.Size = new System.Drawing.Size(0, 16);
            this.lbl_tabModfiyMes.TabIndex = 34;
            // 
            // tb_addSubjClass
            // 
            this.tb_addSubjClass.Controls.Add(this.cb_controlClass);
            this.tb_addSubjClass.Controls.Add(this.cb_controlSubject);
            this.tb_addSubjClass.Controls.Add(this.lbl_tabModfiyMes);
            this.tb_addSubjClass.Controls.Add(this.btn_delClass);
            this.tb_addSubjClass.Controls.Add(this.btn_addClass);
            this.tb_addSubjClass.Controls.Add(this.btn_delSubj);
            this.tb_addSubjClass.Controls.Add(this.btn_addSubj);
            this.tb_addSubjClass.Controls.Add(this.label7);
            this.tb_addSubjClass.Controls.Add(this.label8);
            this.tb_addSubjClass.Location = new System.Drawing.Point(4, 26);
            this.tb_addSubjClass.Name = "tb_addSubjClass";
            this.tb_addSubjClass.Padding = new System.Windows.Forms.Padding(3);
            this.tb_addSubjClass.Size = new System.Drawing.Size(318, 333);
            this.tb_addSubjClass.TabIndex = 1;
            this.tb_addSubjClass.Text = "更改科目與類別";
            this.tb_addSubjClass.UseVisualStyleBackColor = true;
            // 
            // cb_controlSubject
            // 
            this.cb_controlSubject.Font = new System.Drawing.Font("標楷體", 15F);
            this.cb_controlSubject.FormattingEnabled = true;
            this.cb_controlSubject.Location = new System.Drawing.Point(64, 11);
            this.cb_controlSubject.Name = "cb_controlSubject";
            this.cb_controlSubject.Size = new System.Drawing.Size(248, 28);
            this.cb_controlSubject.TabIndex = 35;
            // 
            // cb_controlClass
            // 
            this.cb_controlClass.Font = new System.Drawing.Font("標楷體", 15F);
            this.cb_controlClass.FormattingEnabled = true;
            this.cb_controlClass.Location = new System.Drawing.Point(64, 172);
            this.cb_controlClass.Name = "cb_controlClass";
            this.cb_controlClass.Size = new System.Drawing.Size(248, 28);
            this.cb_controlClass.TabIndex = 36;
            // 
            // mainpageBindingSource
            // 
            this.mainpageBindingSource.DataSource = typeof(project.Component.main_page);
            // 
            // mainpageBindingSource1
            // 
            this.mainpageBindingSource1.DataSource = typeof(project.Component.main_page);
            // 
            // Form_mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tc_modifySet);
            this.Controls.Add(this.btn_settings);
            this.Controls.Add(this.lbl_debug);
            this.Controls.Add(this.flpanel_calendar);
            this.Controls.Add(this.btn_openPomo);
            this.Name = "Form_mainPage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tb_addToDo.ResumeLayout(false);
            this.tb_addToDo.PerformLayout();
            this.tc_modifySet.ResumeLayout(false);
            this.tb_addSubjClass.ResumeLayout(false);
            this.tb_addSubjClass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainpageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainpageBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_openPomo;
        private System.Windows.Forms.FlowLayoutPanel flpanel_calendar;
        public System.Windows.Forms.Label lbl_debug;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.BindingSource mainpageBindingSource;
        private System.Windows.Forms.BindingSource mainpageBindingSource1;
        private System.Windows.Forms.TabPage tb_addToDo;
        public System.Windows.Forms.Label lbl_tabToDoMes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_taskDescribe;
        private System.Windows.Forms.ComboBox cb_classification;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_subject;
        private System.Windows.Forms.Button btn_addTask;
        private System.Windows.Forms.TabControl tc_modifySet;
        private System.Windows.Forms.TabPage tb_addSubjClass;
        public System.Windows.Forms.Label lbl_tabModfiyMes;
        private System.Windows.Forms.Button btn_delClass;
        private System.Windows.Forms.Button btn_addClass;
        private System.Windows.Forms.Button btn_delSubj;
        private System.Windows.Forms.Button btn_addSubj;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_controlClass;
        private System.Windows.Forms.ComboBox cb_controlSubject;
    }
}

