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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_openPomo = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.flpanel_calendar = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_debug = new System.Windows.Forms.Label();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_addTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Cursor = System.Windows.Forms.Cursors.Default;
            this.monthCalendar1.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.monthCalendar1.Location = new System.Drawing.Point(90, 507);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
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
            this.btn_openPomo.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(210, 380);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // flpanel_calendar
            // 
            this.flpanel_calendar.AutoScroll = true;
            this.flpanel_calendar.Location = new System.Drawing.Point(322, 12);
            this.flpanel_calendar.Name = "flpanel_calendar";
            this.flpanel_calendar.Size = new System.Drawing.Size(930, 657);
            this.flpanel_calendar.TabIndex = 0;
            this.flpanel_calendar.WrapContents = false;
            // 
            // lbl_debug
            // 
            this.lbl_debug.AutoSize = true;
            this.lbl_debug.Location = new System.Drawing.Point(12, 440);
            this.lbl_debug.Name = "lbl_debug";
            this.lbl_debug.Size = new System.Drawing.Size(52, 12);
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
            // btn_addTask
            // 
            this.btn_addTask.Location = new System.Drawing.Point(14, 12);
            this.btn_addTask.Name = "btn_addTask";
            this.btn_addTask.Size = new System.Drawing.Size(75, 23);
            this.btn_addTask.TabIndex = 5;
            this.btn_addTask.Text = "addTask";
            this.btn_addTask.UseVisualStyleBackColor = true;
            // 
            // Form_mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btn_addTask);
            this.Controls.Add(this.btn_settings);
            this.Controls.Add(this.lbl_debug);
            this.Controls.Add(this.flpanel_calendar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_openPomo);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Form_mainPage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_openPomo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FlowLayoutPanel flpanel_calendar;
        private System.Windows.Forms.Label lbl_debug;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_addTask;
    }
}

