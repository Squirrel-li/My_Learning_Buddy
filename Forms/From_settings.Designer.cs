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
            this.tb_pomo = new AntdUI.TabPage();
            this.gridPanel1 = new AntdUI.GridPanel();
            this.panel2 = new AntdUI.Panel();
            this.tb_task = new AntdUI.TabPage();
            this.tb_globle = new AntdUI.TabPage();
            this.inputN_focus = new AntdUI.InputNumber();
            this.label7 = new AntdUI.Label();
            this.inputN_shortBreak = new AntdUI.InputNumber();
            this.label8 = new AntdUI.Label();
            this.inputN_longBreak = new AntdUI.InputNumber();
            this.label9 = new AntdUI.Label();
            this.inputN_loopTimes = new AntdUI.InputNumber();
            this.label10 = new AntdUI.Label();
            this.panel1 = new AntdUI.Panel();
            this.label11 = new AntdUI.Label();
            this.switch_autoFocus = new AntdUI.Switch();
            this.label12 = new AntdUI.Label();
            this.switch_autoBreak = new AntdUI.Switch();
            this.tabs1.SuspendLayout();
            this.tb_pomo.SuspendLayout();
            this.gridPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs1
            // 
            this.tabs1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabs1.Controls.Add(this.tb_pomo);
            this.tabs1.Controls.Add(this.tb_task);
            this.tabs1.Controls.Add(this.tb_globle);
            this.tabs1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabs1.Font = new System.Drawing.Font("微軟正黑體", 14.25F);
            this.tabs1.Location = new System.Drawing.Point(12, 12);
            this.tabs1.Name = "tabs1";
            this.tabs1.Pages.Add(this.tb_globle);
            this.tabs1.Pages.Add(this.tb_task);
            this.tabs1.Pages.Add(this.tb_pomo);
            this.tabs1.SelectedIndex = 2;
            this.tabs1.Size = new System.Drawing.Size(776, 426);
            this.tabs1.Style = styleLine1;
            this.tabs1.TabIndex = 6;
            this.tabs1.Text = "全域設定";
            // 
            // tb_pomo
            // 
            this.tb_pomo.Controls.Add(this.gridPanel1);
            this.tb_pomo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_pomo.Font = new System.Drawing.Font("微軟正黑體", 14.25F);
            this.tb_pomo.Location = new System.Drawing.Point(117, 0);
            this.tb_pomo.Name = "tb_pomo";
            this.tb_pomo.Size = new System.Drawing.Size(659, 426);
            this.tb_pomo.TabIndex = 2;
            this.tb_pomo.Text = "番茄鐘設定";
            // 
            // gridPanel1
            // 
            this.gridPanel1.Controls.Add(this.panel1);
            this.gridPanel1.Controls.Add(this.panel2);
            this.gridPanel1.Location = new System.Drawing.Point(3, 3);
            this.gridPanel1.Name = "gridPanel1";
            this.gridPanel1.Size = new System.Drawing.Size(653, 420);
            this.gridPanel1.Span = "50% 50%";
            this.gridPanel1.TabIndex = 0;
            this.gridPanel1.Text = "gridPanel1";
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
            this.panel2.Size = new System.Drawing.Size(320, 414);
            this.panel2.TabIndex = 70;
            this.panel2.Text = "panel2";
            // 
            // tb_task
            // 
            this.tb_task.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_task.Font = new System.Drawing.Font("微軟正黑體", 14.25F);
            this.tb_task.Location = new System.Drawing.Point(117, 0);
            this.tb_task.Name = "tb_task";
            this.tb_task.Size = new System.Drawing.Size(659, 426);
            this.tb_task.TabIndex = 1;
            this.tb_task.Text = "任務設定";
            // 
            // tb_globle
            // 
            this.tb_globle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_globle.Font = new System.Drawing.Font("微軟正黑體", 14.25F);
            this.tb_globle.Location = new System.Drawing.Point(117, 0);
            this.tb_globle.Name = "tb_globle";
            this.tb_globle.Size = new System.Drawing.Size(659, 426);
            this.tb_globle.TabIndex = 0;
            this.tb_globle.Text = "全域設定";
            // 
            // inputN_focus
            // 
            this.inputN_focus.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.inputN_focus.Location = new System.Drawing.Point(164, 101);
            this.inputN_focus.Name = "inputN_focus";
            this.inputN_focus.Size = new System.Drawing.Size(135, 44);
            this.inputN_focus.TabIndex = 72;
            this.inputN_focus.Text = "0";
            this.inputN_focus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.label7.Location = new System.Drawing.Point(23, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 44);
            this.label7.TabIndex = 73;
            this.label7.Text = "專注時間(m)";
            // 
            // inputN_shortBreak
            // 
            this.inputN_shortBreak.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.inputN_shortBreak.Location = new System.Drawing.Point(164, 153);
            this.inputN_shortBreak.Name = "inputN_shortBreak";
            this.inputN_shortBreak.Size = new System.Drawing.Size(135, 44);
            this.inputN_shortBreak.TabIndex = 70;
            this.inputN_shortBreak.Text = "0";
            this.inputN_shortBreak.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.label8.Location = new System.Drawing.Point(23, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 44);
            this.label8.TabIndex = 71;
            this.label8.Text = "短休息(m)";
            // 
            // inputN_longBreak
            // 
            this.inputN_longBreak.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.inputN_longBreak.Location = new System.Drawing.Point(164, 204);
            this.inputN_longBreak.Name = "inputN_longBreak";
            this.inputN_longBreak.Size = new System.Drawing.Size(135, 44);
            this.inputN_longBreak.TabIndex = 74;
            this.inputN_longBreak.Text = "0";
            this.inputN_longBreak.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.label9.Location = new System.Drawing.Point(23, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 44);
            this.label9.TabIndex = 75;
            this.label9.Text = "長休息(m)";
            // 
            // inputN_loopTimes
            // 
            this.inputN_loopTimes.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.inputN_loopTimes.Location = new System.Drawing.Point(164, 256);
            this.inputN_loopTimes.Name = "inputN_loopTimes";
            this.inputN_loopTimes.Size = new System.Drawing.Size(135, 44);
            this.inputN_loopTimes.TabIndex = 76;
            this.inputN_loopTimes.Text = "0";
            this.inputN_loopTimes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.label10.Location = new System.Drawing.Point(23, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 44);
            this.label10.TabIndex = 77;
            this.label10.Text = "長短休息間隔(次)";
            // 
            // panel1
            // 
            this.panel1.Back = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.switch_autoFocus);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.switch_autoBreak);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Location = new System.Drawing.Point(329, 3);
            this.panel1.Name = "panel1";
            this.panel1.Shadow = 10;
            this.panel1.Size = new System.Drawing.Size(320, 414);
            this.panel1.TabIndex = 78;
            this.panel1.Text = "panel1";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.label11.Location = new System.Drawing.Point(65, 161);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 33);
            this.label11.TabIndex = 59;
            this.label11.Text = "自動開始專注";
            // 
            // switch_autoFocus
            // 
            this.switch_autoFocus.Location = new System.Drawing.Point(177, 157);
            this.switch_autoFocus.Name = "switch_autoFocus";
            this.switch_autoFocus.Size = new System.Drawing.Size(80, 40);
            this.switch_autoFocus.TabIndex = 58;
            this.switch_autoFocus.Text = "switch3";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.label12.Location = new System.Drawing.Point(65, 200);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 33);
            this.label12.TabIndex = 61;
            this.label12.Text = "自動開始休息";
            // 
            // switch_autoBreak
            // 
            this.switch_autoBreak.Location = new System.Drawing.Point(177, 196);
            this.switch_autoBreak.Name = "switch_autoBreak";
            this.switch_autoBreak.Size = new System.Drawing.Size(80, 40);
            this.switch_autoBreak.TabIndex = 60;
            this.switch_autoBreak.Text = "switch4";
            // 
            // From_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabs1);
            this.Name = "From_settings";
            this.Text = "settings";
            this.Load += new System.EventHandler(this.From_settings_Load);
            this.tabs1.ResumeLayout(false);
            this.tb_pomo.ResumeLayout(false);
            this.gridPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
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
        private AntdUI.TabPage tb_globle;
        private AntdUI.TabPage tb_task;
        private AntdUI.Panel panel1;
        private AntdUI.Label label11;
        private AntdUI.Switch switch_autoFocus;
        private AntdUI.Label label12;
        private AntdUI.Switch switch_autoBreak;
    }
}