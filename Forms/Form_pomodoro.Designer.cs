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
            this.progress_pomo = new AntdUI.Progress();
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
            this.pageHeader = new AntdUI.PageHeader();
            this.gridPanel_bottomBody = new AntdUI.GridPanel();
            this.gridPanel_set = new AntdUI.GridPanel();
            this.label5 = new AntdUI.Label();
            this.gridPanel_pomoButton = new AntdUI.GridPanel();
            this.gridPanel_bottomBody.SuspendLayout();
            this.gridPanel_set.SuspendLayout();
            this.gridPanel_pomoButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer_count
            // 
            this.timer_count.Interval = 1000;
            this.timer_count.Tick += new System.EventHandler(this.timer_count_Tick);
            // 
            // progress_pomo
            // 
            this.progress_pomo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progress_pomo.Fill = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(175)))), ((int)(((byte)(136)))));
            this.progress_pomo.Font = new System.Drawing.Font("微軟正黑體", 50F);
            this.progress_pomo.IconCircleColor = System.Drawing.SystemColors.ActiveCaption;
            this.progress_pomo.IconCirclePadding = 5;
            this.progress_pomo.IconSvgCircle = "test";
            this.progress_pomo.LoadingFull = true;
            this.progress_pomo.LocalizationText = "";
            this.progress_pomo.Location = new System.Drawing.Point(0, 68);
            this.progress_pomo.Name = "progress_pomo";
            this.progress_pomo.Radius = 30;
            this.progress_pomo.Shape = AntdUI.TShapeProgress.Circle;
            this.progress_pomo.Size = new System.Drawing.Size(730, 637);
            this.progress_pomo.StepGap = 5;
            this.progress_pomo.Steps = 100;
            this.progress_pomo.StepSize = 10;
            this.progress_pomo.TabIndex = 38;
            this.progress_pomo.Text = "00 : 00";
            this.progress_pomo.TextUnit = " tesg";
            this.progress_pomo.UseSystemText = true;
            this.progress_pomo.Value = 1F;
            this.progress_pomo.ValueRatio = 1F;
            // 
            // btn_control
            // 
            this.btn_control.BackColor = System.Drawing.Color.Transparent;
            this.btn_control.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.btn_control.Location = new System.Drawing.Point(3, 3);
            this.btn_control.Name = "btn_control";
            this.btn_control.Size = new System.Drawing.Size(134, 49);
            this.btn_control.TabIndex = 39;
            this.btn_control.Text = "開始";
            this.btn_control.Click += new System.EventHandler(this.btn_control_Click);
            // 
            // lbl_debug
            // 
            this.lbl_debug.BackColor = System.Drawing.Color.Transparent;
            this.lbl_debug.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lbl_debug.Location = new System.Drawing.Point(3, 3);
            this.lbl_debug.Name = "lbl_debug";
            this.lbl_debug.Size = new System.Drawing.Size(286, 164);
            this.lbl_debug.TabIndex = 40;
            this.lbl_debug.Text = "";
            this.lbl_debug.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // btn_stop
            // 
            this.btn_stop.BackColor = System.Drawing.Color.Transparent;
            this.btn_stop.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.btn_stop.Location = new System.Drawing.Point(3, 58);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(134, 49);
            this.btn_stop.TabIndex = 41;
            this.btn_stop.Text = "結束";
            this.btn_stop.Visible = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // inputN_shortBreak
            // 
            this.inputN_shortBreak.BackColor = System.Drawing.Color.Transparent;
            this.inputN_shortBreak.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.inputN_shortBreak.Location = new System.Drawing.Point(141, 44);
            this.inputN_shortBreak.Name = "inputN_shortBreak";
            this.inputN_shortBreak.Size = new System.Drawing.Size(69, 35);
            this.inputN_shortBreak.TabIndex = 42;
            this.inputN_shortBreak.Text = "0";
            this.inputN_shortBreak.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputN_shortBreak.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputN_shortBreak_KeyDown);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F);
            this.label1.Location = new System.Drawing.Point(3, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 35);
            this.label1.TabIndex = 43;
            this.label1.Text = "短休息(m)";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 18F);
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 35);
            this.label2.TabIndex = 45;
            this.label2.Text = "專注時間(m)";
            // 
            // inputN_focus
            // 
            this.inputN_focus.BackColor = System.Drawing.Color.Transparent;
            this.inputN_focus.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.inputN_focus.Location = new System.Drawing.Point(141, 3);
            this.inputN_focus.Name = "inputN_focus";
            this.inputN_focus.Size = new System.Drawing.Size(69, 35);
            this.inputN_focus.TabIndex = 44;
            this.inputN_focus.Text = "0";
            this.inputN_focus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputN_focus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputN_focus_KeyDown);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 18F);
            this.label3.Location = new System.Drawing.Point(3, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 35);
            this.label3.TabIndex = 47;
            this.label3.Text = "長休息(m)";
            // 
            // inputN_longBreak
            // 
            this.inputN_longBreak.BackColor = System.Drawing.Color.Transparent;
            this.inputN_longBreak.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.inputN_longBreak.Location = new System.Drawing.Point(141, 85);
            this.inputN_longBreak.Name = "inputN_longBreak";
            this.inputN_longBreak.Size = new System.Drawing.Size(69, 35);
            this.inputN_longBreak.TabIndex = 46;
            this.inputN_longBreak.Text = "0";
            this.inputN_longBreak.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputN_longBreak.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputN_longBreak_KeyDown);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 18F);
            this.label4.Location = new System.Drawing.Point(3, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 35);
            this.label4.TabIndex = 49;
            this.label4.Text = "長短休息間隔(次)";
            // 
            // inputN_loopTimes
            // 
            this.inputN_loopTimes.BackColor = System.Drawing.Color.Transparent;
            this.inputN_loopTimes.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.inputN_loopTimes.Location = new System.Drawing.Point(141, 126);
            this.inputN_loopTimes.Name = "inputN_loopTimes";
            this.inputN_loopTimes.Size = new System.Drawing.Size(69, 35);
            this.inputN_loopTimes.TabIndex = 48;
            this.inputN_loopTimes.Text = "0";
            this.inputN_loopTimes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputN_loopTimes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputN_loopTimes_KeyDown);
            // 
            // pageHeader
            // 
            this.pageHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pageHeader.Font = new System.Drawing.Font("微軟正黑體", 30F);
            this.pageHeader.Icon = ((System.Drawing.Image)(resources.GetObject("pageHeader.Icon")));
            this.pageHeader.IconRatio = 1.5F;
            this.pageHeader.Location = new System.Drawing.Point(0, 0);
            this.pageHeader.Name = "pageHeader";
            this.pageHeader.ShowButton = true;
            this.pageHeader.Size = new System.Drawing.Size(730, 68);
            this.pageHeader.SubFont = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pageHeader.SubText = "";
            this.pageHeader.TabIndex = 50;
            this.pageHeader.Text = "番茄鐘";
            this.pageHeader.UseLeftMargin = false;
            this.pageHeader.UseTextBold = false;
            // 
            // gridPanel_bottomBody
            // 
            this.gridPanel_bottomBody.Controls.Add(this.gridPanel_set);
            this.gridPanel_bottomBody.Controls.Add(this.label5);
            this.gridPanel_bottomBody.Controls.Add(this.gridPanel_pomoButton);
            this.gridPanel_bottomBody.Controls.Add(this.lbl_debug);
            this.gridPanel_bottomBody.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridPanel_bottomBody.Location = new System.Drawing.Point(0, 705);
            this.gridPanel_bottomBody.Name = "gridPanel_bottomBody";
            this.gridPanel_bottomBody.Size = new System.Drawing.Size(730, 170);
            this.gridPanel_bottomBody.Span = "40% 20% 10% 30%";
            this.gridPanel_bottomBody.TabIndex = 51;
            this.gridPanel_bottomBody.Text = "gridPanel1";
            // 
            // gridPanel_set
            // 
            this.gridPanel_set.Controls.Add(this.inputN_loopTimes);
            this.gridPanel_set.Controls.Add(this.label4);
            this.gridPanel_set.Controls.Add(this.inputN_longBreak);
            this.gridPanel_set.Controls.Add(this.label3);
            this.gridPanel_set.Controls.Add(this.inputN_shortBreak);
            this.gridPanel_set.Controls.Add(this.label1);
            this.gridPanel_set.Controls.Add(this.inputN_focus);
            this.gridPanel_set.Controls.Add(this.label2);
            this.gridPanel_set.Location = new System.Drawing.Point(514, 3);
            this.gridPanel_set.Name = "gridPanel_set";
            this.gridPanel_set.Size = new System.Drawing.Size(213, 164);
            this.gridPanel_set.Span = "65% 35%;\r\n65% 35%;\r\n65% 35%;\r\n65% 35%;";
            this.gridPanel_set.TabIndex = 53;
            this.gridPanel_set.Text = "gridPanel3";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.label5.Location = new System.Drawing.Point(441, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 164);
            this.label5.TabIndex = 53;
            this.label5.Text = "";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // gridPanel_pomoButton
            // 
            this.gridPanel_pomoButton.Controls.Add(this.btn_stop);
            this.gridPanel_pomoButton.Controls.Add(this.btn_control);
            this.gridPanel_pomoButton.Location = new System.Drawing.Point(295, 3);
            this.gridPanel_pomoButton.Name = "gridPanel_pomoButton";
            this.gridPanel_pomoButton.Size = new System.Drawing.Size(140, 164);
            this.gridPanel_pomoButton.Span = "\n100%;\r\n100%; ;";
            this.gridPanel_pomoButton.TabIndex = 52;
            this.gridPanel_pomoButton.Text = "gridPanel2";
            // 
            // Form_pomodoro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 875);
            this.Controls.Add(this.progress_pomo);
            this.Controls.Add(this.gridPanel_bottomBody);
            this.Controls.Add(this.pageHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "Form_pomodoro";
            this.Text = "番茄鐘";
            this.Load += new System.EventHandler(this.Form_pomodoro_Load);
            this.gridPanel_bottomBody.ResumeLayout(false);
            this.gridPanel_set.ResumeLayout(false);
            this.gridPanel_pomoButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer_count;
        private AntdUI.Progress progress_pomo;
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
        private AntdUI.PageHeader pageHeader;
        private AntdUI.GridPanel gridPanel_bottomBody;
        private AntdUI.GridPanel gridPanel_pomoButton;
        private AntdUI.GridPanel gridPanel_set;
        private AntdUI.Label label5;
    }
}

