namespace project
{
    partial class Form_pomodoro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_pomodoro));
            this.timer_count = new System.Windows.Forms.Timer(this.components);
            this.progress1 = new AntdUI.Progress();
            this.pageHeader1 = new AntdUI.PageHeader();
            this.flowLayoutPanel1 = new AntdUI.In.FlowLayoutPanel();
            this.label2 = new AntdUI.Label();
            this.inputN_focus = new AntdUI.InputNumber();
            this.label1 = new AntdUI.Label();
            this.inputN_shortBreak = new AntdUI.InputNumber();
            this.label3 = new AntdUI.Label();
            this.inputN_longBreak = new AntdUI.InputNumber();
            this.label4 = new AntdUI.Label();
            this.inputN_loopTimes = new AntdUI.InputNumber();
            this.lbl_debug = new AntdUI.Label();
            this.btn_hiddenSet = new AntdUI.Button();
            this.btn_save = new AntdUI.Button();
            this.btn_control = new AntdUI.Button();
            this.btn_stop = new AntdUI.Button();
            this.gridPanel1 = new AntdUI.GridPanel();
            this.gridPanel3 = new AntdUI.GridPanel();
            this.label5 = new AntdUI.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.gridPanel1.SuspendLayout();
            this.gridPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer_count
            // 
            this.timer_count.Interval = 1000;
            this.timer_count.Tick += new System.EventHandler(this.timer_count_Tick);
            // 
            // progress1
            // 
            this.progress1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progress1.Fill = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(113)))), ((int)(((byte)(169)))));
            this.progress1.Font = new System.Drawing.Font("微軟正黑體", 50F);
            this.progress1.IconCircleColor = System.Drawing.SystemColors.ActiveCaption;
            this.progress1.IconCirclePadding = 5;
            this.progress1.IconSvgCircle = "test";
            this.progress1.LoadingFull = true;
            this.progress1.LocalizationText = "";
            this.progress1.Location = new System.Drawing.Point(0, 68);
            this.progress1.Name = "progress1";
            this.progress1.Radius = 30;
            this.progress1.Shape = AntdUI.TShapeProgress.Circle;
            this.progress1.Size = new System.Drawing.Size(782, 489);
            this.progress1.StepGap = 5;
            this.progress1.Steps = 100;
            this.progress1.StepSize = 10;
            this.progress1.TabIndex = 38;
            this.progress1.Text = "00 : 00";
            this.progress1.TextUnit = " tesg";
            this.progress1.UseSystemText = true;
            this.progress1.Value = 1F;
            this.progress1.ValueRatio = 1F;
            // 
            // pageHeader1
            // 
            this.pageHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pageHeader1.Font = new System.Drawing.Font("微軟正黑體", 30F);
            this.pageHeader1.Icon = ((System.Drawing.Image)(resources.GetObject("pageHeader1.Icon")));
            this.pageHeader1.IconRatio = 1.5F;
            this.pageHeader1.Location = new System.Drawing.Point(0, 0);
            this.pageHeader1.Name = "pageHeader1";
            this.pageHeader1.ShowButton = true;
            this.pageHeader1.Size = new System.Drawing.Size(782, 68);
            this.pageHeader1.SubFont = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pageHeader1.SubText = "";
            this.pageHeader1.TabIndex = 50;
            this.pageHeader1.Text = "番茄鐘";
            this.pageHeader1.UseLeftMargin = false;
            this.pageHeader1.UseTextBold = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.inputN_focus);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.inputN_shortBreak);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.inputN_longBreak);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.inputN_loopTimes);
            this.flowLayoutPanel1.Controls.Add(this.btn_save);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(550, 3);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(357, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(229, 260);
            this.flowLayoutPanel1.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 33);
            this.label2.TabIndex = 45;
            this.label2.Text = "專注時間(m)";
            // 
            // inputN_focus
            // 
            this.inputN_focus.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.inputN_focus.Location = new System.Drawing.Point(146, 3);
            this.inputN_focus.Name = "inputN_focus";
            this.inputN_focus.Size = new System.Drawing.Size(75, 33);
            this.inputN_focus.TabIndex = 44;
            this.inputN_focus.Text = "0";
            this.inputN_focus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputN_focus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputN_focus_KeyDown);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.label1.Location = new System.Drawing.Point(3, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 33);
            this.label1.TabIndex = 43;
            this.label1.Text = "短休息(m)";
            // 
            // inputN_shortBreak
            // 
            this.inputN_shortBreak.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.inputN_shortBreak.Location = new System.Drawing.Point(146, 42);
            this.inputN_shortBreak.Name = "inputN_shortBreak";
            this.inputN_shortBreak.Size = new System.Drawing.Size(75, 33);
            this.inputN_shortBreak.TabIndex = 42;
            this.inputN_shortBreak.Text = "0";
            this.inputN_shortBreak.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputN_shortBreak.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputN_shortBreak_KeyDown);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.label3.Location = new System.Drawing.Point(3, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 33);
            this.label3.TabIndex = 47;
            this.label3.Text = "長休息(m)";
            // 
            // inputN_longBreak
            // 
            this.inputN_longBreak.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.inputN_longBreak.Location = new System.Drawing.Point(146, 81);
            this.inputN_longBreak.Name = "inputN_longBreak";
            this.inputN_longBreak.Size = new System.Drawing.Size(75, 33);
            this.inputN_longBreak.TabIndex = 46;
            this.inputN_longBreak.Text = "0";
            this.inputN_longBreak.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputN_longBreak.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputN_longBreak_KeyDown);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.label4.Location = new System.Drawing.Point(3, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 33);
            this.label4.TabIndex = 49;
            this.label4.Text = "長短休息間隔(次)";
            // 
            // inputN_loopTimes
            // 
            this.inputN_loopTimes.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.inputN_loopTimes.Location = new System.Drawing.Point(146, 120);
            this.inputN_loopTimes.Name = "inputN_loopTimes";
            this.inputN_loopTimes.Size = new System.Drawing.Size(75, 33);
            this.inputN_loopTimes.TabIndex = 48;
            this.inputN_loopTimes.Text = "0";
            this.inputN_loopTimes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputN_loopTimes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputN_loopTimes_KeyDown);
            // 
            // lbl_debug
            // 
            this.lbl_debug.Location = new System.Drawing.Point(3, 3);
            this.lbl_debug.Name = "lbl_debug";
            this.lbl_debug.Size = new System.Drawing.Size(307, 260);
            this.lbl_debug.TabIndex = 64;
            this.lbl_debug.Text = "";
            // 
            // btn_hiddenSet
            // 
            this.btn_hiddenSet.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.btn_hiddenSet.Location = new System.Drawing.Point(3, 159);
            this.btn_hiddenSet.Name = "btn_hiddenSet";
            this.btn_hiddenSet.Size = new System.Drawing.Size(144, 46);
            this.btn_hiddenSet.TabIndex = 52;
            this.btn_hiddenSet.Text = "隱藏設定";
            this.btn_hiddenSet.Click += new System.EventHandler(this.btn_hiddenSet_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.btn_save.Location = new System.Drawing.Point(3, 159);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(93, 49);
            this.btn_save.TabIndex = 53;
            this.btn_save.Text = "儲存";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_control
            // 
            this.btn_control.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.btn_control.Location = new System.Drawing.Point(3, 3);
            this.btn_control.Name = "btn_control";
            this.btn_control.Size = new System.Drawing.Size(144, 46);
            this.btn_control.TabIndex = 51;
            this.btn_control.Text = "開始";
            this.btn_control.Click += new System.EventHandler(this.btn_control_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.btn_stop.Location = new System.Drawing.Point(3, 55);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(144, 46);
            this.btn_stop.TabIndex = 52;
            this.btn_stop.Text = "結束";
            this.btn_stop.Visible = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // gridPanel1
            // 
            this.gridPanel1.Controls.Add(this.btn_hiddenSet);
            this.gridPanel1.Controls.Add(this.btn_stop);
            this.gridPanel1.Controls.Add(this.btn_control);
            this.gridPanel1.Location = new System.Drawing.Point(316, 3);
            this.gridPanel1.Name = "gridPanel1";
            this.gridPanel1.Size = new System.Drawing.Size(150, 260);
            this.gridPanel1.Span = "100%; 100%; ; 100%; ;";
            this.gridPanel1.TabIndex = 61;
            this.gridPanel1.Text = "gridPanel1";
            // 
            // gridPanel3
            // 
            this.gridPanel3.Controls.Add(this.flowLayoutPanel1);
            this.gridPanel3.Controls.Add(this.label5);
            this.gridPanel3.Controls.Add(this.gridPanel1);
            this.gridPanel3.Controls.Add(this.lbl_debug);
            this.gridPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridPanel3.Location = new System.Drawing.Point(0, 557);
            this.gridPanel3.Name = "gridPanel3";
            this.gridPanel3.Size = new System.Drawing.Size(782, 266);
            this.gridPanel3.Span = "40% 20% 10% 30%";
            this.gridPanel3.TabIndex = 66;
            this.gridPanel3.Text = "gridPanel3";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(472, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 260);
            this.label5.TabIndex = 66;
            this.label5.Text = "";
            // 
            // Form_pomodoro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 823);
            this.Controls.Add(this.progress1);
            this.Controls.Add(this.pageHeader1);
            this.Controls.Add(this.gridPanel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "Form_pomodoro";
            this.Text = "番茄鐘";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.gridPanel1.ResumeLayout(false);
            this.gridPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer_count;
        private AntdUI.Progress progress1;
        private AntdUI.PageHeader pageHeader1;
        private AntdUI.In.FlowLayoutPanel flowLayoutPanel1;
        private AntdUI.Label label2;
        private AntdUI.InputNumber inputN_focus;
        private AntdUI.Label label1;
        private AntdUI.InputNumber inputN_shortBreak;
        private AntdUI.Label label3;
        private AntdUI.InputNumber inputN_longBreak;
        private AntdUI.Label label4;
        private AntdUI.InputNumber inputN_loopTimes;
        private AntdUI.Label lbl_debug;
        private AntdUI.Button btn_hiddenSet;
        private AntdUI.Button btn_save;
        private AntdUI.Button btn_control;
        private AntdUI.Button btn_stop;
        private AntdUI.GridPanel gridPanel1;
        private AntdUI.GridPanel gridPanel3;
        private AntdUI.Label label5;
    }
}

