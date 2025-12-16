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
            this.timer_count = new System.Windows.Forms.Timer(this.components);
            this.progress1 = new AntdUI.Progress();
            this.btn_control = new AntdUI.Button();
            this.lbl_debug = new AntdUI.Label();
            this.btn_stop = new AntdUI.Button();
            this.inputN_shortBreak = new AntdUI.InputNumber();
            this.label1 = new AntdUI.Label();
            this.label2 = new AntdUI.Label();
            this.inputN_focus = new AntdUI.InputNumber();
            this.label3 = new AntdUI.Label();
            this.inputN_longBreak = new AntdUI.InputNumber();
            this.label4 = new AntdUI.Label();
            this.inputN_loopTimes = new AntdUI.InputNumber();
            this.SuspendLayout();
            // 
            // timer_count
            // 
            this.timer_count.Interval = 1000;
            this.timer_count.Tick += new System.EventHandler(this.timer_count_Tick);
            // 
            // progress1
            // 
            this.progress1.Fill = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(113)))), ((int)(((byte)(169)))));
            this.progress1.Font = new System.Drawing.Font("微軟正黑體", 50F);
            this.progress1.IconCircleColor = System.Drawing.SystemColors.ActiveCaption;
            this.progress1.IconCirclePadding = 5;
            this.progress1.IconSvgCircle = "test";
            this.progress1.LoadingFull = true;
            this.progress1.LocalizationText = "";
            this.progress1.Location = new System.Drawing.Point(91, 22);
            this.progress1.Name = "progress1";
            this.progress1.Radius = 30;
            this.progress1.Shape = AntdUI.TShapeProgress.Circle;
            this.progress1.Size = new System.Drawing.Size(400, 400);
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
            // btn_control
            // 
            this.btn_control.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.btn_control.Location = new System.Drawing.Point(235, 428);
            this.btn_control.Name = "btn_control";
            this.btn_control.Size = new System.Drawing.Size(113, 51);
            this.btn_control.TabIndex = 39;
            this.btn_control.Text = "開始";
            this.btn_control.Click += new System.EventHandler(this.btn_control_Click);
            // 
            // lbl_debug
            // 
            this.lbl_debug.BackColor = System.Drawing.Color.Transparent;
            this.lbl_debug.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lbl_debug.Location = new System.Drawing.Point(12, 12);
            this.lbl_debug.Name = "lbl_debug";
            this.lbl_debug.Size = new System.Drawing.Size(197, 537);
            this.lbl_debug.TabIndex = 40;
            this.lbl_debug.Text = "Debug Mode Enable";
            this.lbl_debug.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_debug.Visible = false;
            // 
            // btn_stop
            // 
            this.btn_stop.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.btn_stop.Location = new System.Drawing.Point(235, 485);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(113, 51);
            this.btn_stop.TabIndex = 41;
            this.btn_stop.Text = "結束";
            this.btn_stop.Visible = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // inputN_shortBreak
            // 
            this.inputN_shortBreak.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.inputN_shortBreak.Location = new System.Drawing.Point(497, 438);
            this.inputN_shortBreak.Name = "inputN_shortBreak";
            this.inputN_shortBreak.Size = new System.Drawing.Size(75, 33);
            this.inputN_shortBreak.TabIndex = 42;
            this.inputN_shortBreak.Text = "50";
            this.inputN_shortBreak.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputN_shortBreak.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputN_shortBreak_KeyDown);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.label1.Location = new System.Drawing.Point(399, 438);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 33);
            this.label1.TabIndex = 43;
            this.label1.Text = "短休息(m)";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.label2.Location = new System.Drawing.Point(399, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 33);
            this.label2.TabIndex = 45;
            this.label2.Text = "專注時間(m)";
            // 
            // inputN_focus
            // 
            this.inputN_focus.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.inputN_focus.Location = new System.Drawing.Point(497, 399);
            this.inputN_focus.Name = "inputN_focus";
            this.inputN_focus.Size = new System.Drawing.Size(75, 33);
            this.inputN_focus.TabIndex = 44;
            this.inputN_focus.Text = "0";
            this.inputN_focus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputN_focus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputN_focus_KeyDown);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.label3.Location = new System.Drawing.Point(399, 477);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 33);
            this.label3.TabIndex = 47;
            this.label3.Text = "長休息(m)";
            // 
            // inputN_longBreak
            // 
            this.inputN_longBreak.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.inputN_longBreak.Location = new System.Drawing.Point(497, 477);
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
            this.label4.Location = new System.Drawing.Point(399, 516);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 33);
            this.label4.TabIndex = 49;
            this.label4.Text = "長短休息間隔(次)";
            // 
            // inputN_loopTimes
            // 
            this.inputN_loopTimes.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.inputN_loopTimes.Location = new System.Drawing.Point(497, 516);
            this.inputN_loopTimes.Name = "inputN_loopTimes";
            this.inputN_loopTimes.Size = new System.Drawing.Size(75, 33);
            this.inputN_loopTimes.TabIndex = 48;
            this.inputN_loopTimes.Text = "0";
            this.inputN_loopTimes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputN_loopTimes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputN_loopTimes_KeyDown);
            // 
            // Form_pomodoro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputN_loopTimes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputN_longBreak);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputN_focus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputN_shortBreak);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_control);
            this.Controls.Add(this.progress1);
            this.Controls.Add(this.lbl_debug);
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "Form_pomodoro";
            this.Text = "番茄鐘";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer_count;
        private AntdUI.Progress progress1;
        private AntdUI.Button btn_control;
        private AntdUI.Label lbl_debug;
        private AntdUI.Button btn_stop;
        private AntdUI.InputNumber inputN_shortBreak;
        private AntdUI.Label label1;
        private AntdUI.Label label2;
        private AntdUI.InputNumber inputN_focus;
        private AntdUI.Label label3;
        private AntdUI.InputNumber inputN_longBreak;
        private AntdUI.Label label4;
        private AntdUI.InputNumber inputN_loopTimes;
    }
}

