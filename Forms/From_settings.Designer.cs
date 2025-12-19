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
            this.panel1 = new AntdUI.Panel();
            this.label11 = new AntdUI.Label();
            this.switch_autoFocus = new AntdUI.Switch();
            this.label12 = new AntdUI.Label();
            this.switch_autoBreak = new AntdUI.Switch();
            this.panel2 = new AntdUI.Panel();
            this.inputN_focus = new AntdUI.InputNumber();
            this.label7 = new AntdUI.Label();
            this.inputN_shortBreak = new AntdUI.InputNumber();
            this.label8 = new AntdUI.Label();
            this.inputN_longBreak = new AntdUI.InputNumber();
            this.label9 = new AntdUI.Label();
            this.inputN_loopTimes = new AntdUI.InputNumber();
            this.label10 = new AntdUI.Label();
            this.tb_globle = new AntdUI.TabPage();
            this.stackPanel3 = new AntdUI.StackPanel();
            this.stackPanel2 = new AntdUI.StackPanel();
            this.input3 = new AntdUI.Input();
            this.select5 = new AntdUI.Select();
            this.datePicker3 = new AntdUI.DatePicker();
            this.panel5 = new AntdUI.Panel();
            this.checkbox3 = new AntdUI.Checkbox();
            this.select6 = new AntdUI.Select();
            this.stackPanel1 = new AntdUI.StackPanel();
            this.input1 = new AntdUI.Input();
            this.select3 = new AntdUI.Select();
            this.datePicker1 = new AntdUI.DatePicker();
            this.panel3 = new AntdUI.Panel();
            this.checkbox1 = new AntdUI.Checkbox();
            this.select4 = new AntdUI.Select();
            this.stackPanel4 = new AntdUI.StackPanel();
            this.input2 = new AntdUI.Input();
            this.select1 = new AntdUI.Select();
            this.datePicker2 = new AntdUI.DatePicker();
            this.panel4 = new AntdUI.Panel();
            this.checkbox2 = new AntdUI.Checkbox();
            this.select2 = new AntdUI.Select();
            this.tb_task = new AntdUI.TabPage();
            this.btn_save = new AntdUI.Button();
            this.pageHeader1 = new AntdUI.PageHeader();
            this.tabs1.SuspendLayout();
            this.tb_pomo.SuspendLayout();
            this.gridPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tb_globle.SuspendLayout();
            this.stackPanel3.SuspendLayout();
            this.stackPanel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.stackPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.stackPanel4.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs1
            // 
            this.tabs1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabs1.Controls.Add(this.tb_pomo);
            this.tabs1.Controls.Add(this.tb_globle);
            this.tabs1.Controls.Add(this.tb_task);
            this.tabs1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabs1.Font = new System.Drawing.Font("微軟正黑體", 14.25F);
            this.tabs1.Location = new System.Drawing.Point(12, 77);
            this.tabs1.Name = "tabs1";
            this.tabs1.Pages.Add(this.tb_globle);
            this.tabs1.Pages.Add(this.tb_task);
            this.tabs1.Pages.Add(this.tb_pomo);
            this.tabs1.SelectedIndex = 2;
            this.tabs1.Size = new System.Drawing.Size(776, 362);
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
            this.tb_pomo.Size = new System.Drawing.Size(659, 362);
            this.tb_pomo.TabIndex = 2;
            this.tb_pomo.Text = "番茄鐘設定";
            // 
            // gridPanel1
            // 
            this.gridPanel1.Controls.Add(this.panel1);
            this.gridPanel1.Controls.Add(this.panel2);
            this.gridPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPanel1.Location = new System.Drawing.Point(0, 0);
            this.gridPanel1.Name = "gridPanel1";
            this.gridPanel1.Size = new System.Drawing.Size(659, 362);
            this.gridPanel1.Span = "50% 50%";
            this.gridPanel1.TabIndex = 0;
            this.gridPanel1.Text = "gridPanel1";
            // 
            // panel1
            // 
            this.panel1.Back = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.switch_autoFocus);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.switch_autoBreak);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Location = new System.Drawing.Point(333, 3);
            this.panel1.Name = "panel1";
            this.panel1.Shadow = 10;
            this.panel1.Size = new System.Drawing.Size(324, 356);
            this.panel1.TabIndex = 78;
            this.panel1.Text = "panel1";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.label11.Location = new System.Drawing.Point(65, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 33);
            this.label11.TabIndex = 59;
            this.label11.Text = "自動開始專注";
            // 
            // switch_autoFocus
            // 
            this.switch_autoFocus.Location = new System.Drawing.Point(177, 136);
            this.switch_autoFocus.Name = "switch_autoFocus";
            this.switch_autoFocus.Size = new System.Drawing.Size(80, 40);
            this.switch_autoFocus.TabIndex = 58;
            this.switch_autoFocus.Text = "switch3";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.label12.Location = new System.Drawing.Point(65, 179);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 33);
            this.label12.TabIndex = 61;
            this.label12.Text = "自動開始休息";
            // 
            // switch_autoBreak
            // 
            this.switch_autoBreak.Location = new System.Drawing.Point(177, 175);
            this.switch_autoBreak.Name = "switch_autoBreak";
            this.switch_autoBreak.Size = new System.Drawing.Size(80, 40);
            this.switch_autoBreak.TabIndex = 60;
            this.switch_autoBreak.Text = "switch4";
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
            this.panel2.Size = new System.Drawing.Size(324, 356);
            this.panel2.TabIndex = 70;
            this.panel2.Text = "panel2";
            // 
            // inputN_focus
            // 
            this.inputN_focus.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.inputN_focus.Location = new System.Drawing.Point(164, 78);
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
            this.label7.Location = new System.Drawing.Point(23, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 44);
            this.label7.TabIndex = 73;
            this.label7.Text = "專注時間(m)";
            // 
            // inputN_shortBreak
            // 
            this.inputN_shortBreak.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.inputN_shortBreak.Location = new System.Drawing.Point(164, 130);
            this.inputN_shortBreak.Name = "inputN_shortBreak";
            this.inputN_shortBreak.Size = new System.Drawing.Size(135, 44);
            this.inputN_shortBreak.TabIndex = 70;
            this.inputN_shortBreak.Text = "0";
            this.inputN_shortBreak.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.label8.Location = new System.Drawing.Point(23, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 44);
            this.label8.TabIndex = 71;
            this.label8.Text = "短休息(m)";
            // 
            // inputN_longBreak
            // 
            this.inputN_longBreak.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.inputN_longBreak.Location = new System.Drawing.Point(164, 181);
            this.inputN_longBreak.Name = "inputN_longBreak";
            this.inputN_longBreak.Size = new System.Drawing.Size(135, 44);
            this.inputN_longBreak.TabIndex = 74;
            this.inputN_longBreak.Text = "0";
            this.inputN_longBreak.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.label9.Location = new System.Drawing.Point(23, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 44);
            this.label9.TabIndex = 75;
            this.label9.Text = "長休息(m)";
            // 
            // inputN_loopTimes
            // 
            this.inputN_loopTimes.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.inputN_loopTimes.Location = new System.Drawing.Point(164, 233);
            this.inputN_loopTimes.Name = "inputN_loopTimes";
            this.inputN_loopTimes.Size = new System.Drawing.Size(135, 44);
            this.inputN_loopTimes.TabIndex = 76;
            this.inputN_loopTimes.Text = "0";
            this.inputN_loopTimes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.label10.Location = new System.Drawing.Point(23, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 44);
            this.label10.TabIndex = 77;
            this.label10.Text = "長短休息間隔(次)";
            // 
            // tb_globle
            // 
            this.tb_globle.Controls.Add(this.stackPanel3);
            this.tb_globle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_globle.Font = new System.Drawing.Font("微軟正黑體", 14.25F);
            this.tb_globle.Location = new System.Drawing.Point(117, 0);
            this.tb_globle.Name = "tb_globle";
            this.tb_globle.Size = new System.Drawing.Size(659, 362);
            this.tb_globle.TabIndex = 0;
            this.tb_globle.Text = "全域設定";
            // 
            // stackPanel3
            // 
            this.stackPanel3.AutoScroll = true;
            this.stackPanel3.Controls.Add(this.stackPanel2);
            this.stackPanel3.Controls.Add(this.stackPanel1);
            this.stackPanel3.Controls.Add(this.stackPanel4);
            this.stackPanel3.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.stackPanel3.Location = new System.Drawing.Point(170, 86);
            this.stackPanel3.Name = "stackPanel3";
            this.stackPanel3.Size = new System.Drawing.Size(187, 370);
            this.stackPanel3.TabIndex = 28;
            this.stackPanel3.Text = "stackPanel3";
            this.stackPanel3.Vertical = true;
            // 
            // stackPanel2
            // 
            this.stackPanel2.Controls.Add(this.input3);
            this.stackPanel2.Controls.Add(this.select5);
            this.stackPanel2.Controls.Add(this.datePicker3);
            this.stackPanel2.Controls.Add(this.panel5);
            this.stackPanel2.Location = new System.Drawing.Point(3, 399);
            this.stackPanel2.Name = "stackPanel2";
            this.stackPanel2.Size = new System.Drawing.Size(165, 192);
            this.stackPanel2.TabIndex = 27;
            this.stackPanel2.Text = "stackPanel2";
            this.stackPanel2.Vertical = true;
            // 
            // input3
            // 
            this.input3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.input3.JoinMode = AntdUI.TJoinMode.Bottom;
            this.input3.Location = new System.Drawing.Point(0, 98);
            this.input3.Margin = new System.Windows.Forms.Padding(0);
            this.input3.Name = "input3";
            this.input3.Size = new System.Drawing.Size(165, 70);
            this.input3.TabIndex = 32;
            this.input3.Text = "input3";
            // 
            // select5
            // 
            this.select5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.select5.IconRatio = 0F;
            this.select5.JoinMode = AntdUI.TJoinMode.TB;
            this.select5.List = true;
            this.select5.Location = new System.Drawing.Point(0, 68);
            this.select5.Margin = new System.Windows.Forms.Padding(0);
            this.select5.Name = "select5";
            this.select5.Size = new System.Drawing.Size(165, 30);
            this.select5.TabIndex = 31;
            this.select5.Text = "select5";
            // 
            // datePicker3
            // 
            this.datePicker3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datePicker3.JoinMode = AntdUI.TJoinMode.TB;
            this.datePicker3.Location = new System.Drawing.Point(0, 38);
            this.datePicker3.Margin = new System.Windows.Forms.Padding(0);
            this.datePicker3.Name = "datePicker3";
            this.datePicker3.Size = new System.Drawing.Size(165, 30);
            this.datePicker3.TabIndex = 30;
            // 
            // panel5
            // 
            this.panel5.BorderWidth = 1F;
            this.panel5.Controls.Add(this.checkbox3);
            this.panel5.Controls.Add(this.select6);
            this.panel5.Location = new System.Drawing.Point(4, 3);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 0);
            this.panel5.Name = "panel5";
            this.panel5.RadiusAlign = AntdUI.TAlignRound.Top;
            this.panel5.Size = new System.Drawing.Size(157, 35);
            this.panel5.TabIndex = 26;
            this.panel5.Text = "panel5";
            // 
            // checkbox3
            // 
            this.checkbox3.AutoSizeMode = AntdUI.TAutoSize.Height;
            this.checkbox3.BackColor = System.Drawing.Color.White;
            this.checkbox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.checkbox3.Font = new System.Drawing.Font("微軟正黑體", 5F);
            this.checkbox3.Location = new System.Drawing.Point(130, 16);
            this.checkbox3.Name = "checkbox3";
            this.checkbox3.Size = new System.Drawing.Size(26, 18);
            this.checkbox3.TabIndex = 27;
            this.checkbox3.Text = "";
            // 
            // select6
            // 
            this.select6.BorderWidth = 0F;
            this.select6.Dock = System.Windows.Forms.DockStyle.Left;
            this.select6.IconRatio = 0F;
            this.select6.List = true;
            this.select6.Location = new System.Drawing.Point(1, 1);
            this.select6.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.select6.Name = "select6";
            this.select6.PrefixText = "";
            this.select6.ShowIcon = false;
            this.select6.Size = new System.Drawing.Size(129, 33);
            this.select6.SuffixText = "";
            this.select6.TabIndex = 25;
            this.select6.Text = "select6";
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.input1);
            this.stackPanel1.Controls.Add(this.select3);
            this.stackPanel1.Controls.Add(this.datePicker1);
            this.stackPanel1.Controls.Add(this.panel3);
            this.stackPanel1.Location = new System.Drawing.Point(3, 201);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(165, 192);
            this.stackPanel1.TabIndex = 26;
            this.stackPanel1.Text = "stackPanel1";
            this.stackPanel1.Vertical = true;
            // 
            // input1
            // 
            this.input1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.input1.JoinMode = AntdUI.TJoinMode.Bottom;
            this.input1.Location = new System.Drawing.Point(0, 103);
            this.input1.Margin = new System.Windows.Forms.Padding(0);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(165, 70);
            this.input1.TabIndex = 32;
            this.input1.Text = "input1";
            // 
            // select3
            // 
            this.select3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.select3.IconRatio = 0F;
            this.select3.JoinMode = AntdUI.TJoinMode.TB;
            this.select3.List = true;
            this.select3.Location = new System.Drawing.Point(0, 73);
            this.select3.Margin = new System.Windows.Forms.Padding(0);
            this.select3.Name = "select3";
            this.select3.Size = new System.Drawing.Size(165, 30);
            this.select3.TabIndex = 31;
            this.select3.Text = "select3";
            // 
            // datePicker1
            // 
            this.datePicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datePicker1.JoinMode = AntdUI.TJoinMode.TB;
            this.datePicker1.Location = new System.Drawing.Point(0, 43);
            this.datePicker1.Margin = new System.Windows.Forms.Padding(0);
            this.datePicker1.Name = "datePicker1";
            this.datePicker1.Size = new System.Drawing.Size(165, 30);
            this.datePicker1.TabIndex = 30;
            // 
            // panel3
            // 
            this.panel3.BorderWidth = 1F;
            this.panel3.Controls.Add(this.checkbox1);
            this.panel3.Controls.Add(this.select4);
            this.panel3.Location = new System.Drawing.Point(4, 3);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 0);
            this.panel3.Name = "panel3";
            this.panel3.RadiusAlign = AntdUI.TAlignRound.Top;
            this.panel3.Size = new System.Drawing.Size(157, 40);
            this.panel3.TabIndex = 26;
            this.panel3.Text = "panel3";
            // 
            // checkbox1
            // 
            this.checkbox1.AutoSizeMode = AntdUI.TAutoSize.Height;
            this.checkbox1.BackColor = System.Drawing.Color.White;
            this.checkbox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.checkbox1.Font = new System.Drawing.Font("微軟正黑體", 8F);
            this.checkbox1.Location = new System.Drawing.Point(128, 9);
            this.checkbox1.Name = "checkbox1";
            this.checkbox1.Size = new System.Drawing.Size(28, 30);
            this.checkbox1.TabIndex = 27;
            this.checkbox1.Text = "";
            // 
            // select4
            // 
            this.select4.BorderWidth = 0F;
            this.select4.Dock = System.Windows.Forms.DockStyle.Left;
            this.select4.IconRatio = 0F;
            this.select4.List = true;
            this.select4.Location = new System.Drawing.Point(1, 1);
            this.select4.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.select4.Name = "select4";
            this.select4.PrefixText = "";
            this.select4.ShowIcon = false;
            this.select4.Size = new System.Drawing.Size(127, 38);
            this.select4.SuffixText = "";
            this.select4.TabIndex = 25;
            this.select4.Text = "select4";
            // 
            // stackPanel4
            // 
            this.stackPanel4.Controls.Add(this.input2);
            this.stackPanel4.Controls.Add(this.select1);
            this.stackPanel4.Controls.Add(this.datePicker2);
            this.stackPanel4.Controls.Add(this.panel4);
            this.stackPanel4.Location = new System.Drawing.Point(3, 3);
            this.stackPanel4.Name = "stackPanel4";
            this.stackPanel4.Size = new System.Drawing.Size(165, 192);
            this.stackPanel4.TabIndex = 25;
            this.stackPanel4.Text = "stackPanel4";
            this.stackPanel4.Vertical = true;
            // 
            // input2
            // 
            this.input2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.input2.JoinMode = AntdUI.TJoinMode.Bottom;
            this.input2.Location = new System.Drawing.Point(0, 98);
            this.input2.Margin = new System.Windows.Forms.Padding(0);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(165, 70);
            this.input2.TabIndex = 32;
            this.input2.Text = "input2";
            // 
            // select1
            // 
            this.select1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.select1.IconRatio = 0F;
            this.select1.JoinMode = AntdUI.TJoinMode.TB;
            this.select1.List = true;
            this.select1.Location = new System.Drawing.Point(0, 68);
            this.select1.Margin = new System.Windows.Forms.Padding(0);
            this.select1.Name = "select1";
            this.select1.Size = new System.Drawing.Size(165, 30);
            this.select1.TabIndex = 31;
            this.select1.Text = "select1";
            // 
            // datePicker2
            // 
            this.datePicker2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datePicker2.JoinMode = AntdUI.TJoinMode.TB;
            this.datePicker2.Location = new System.Drawing.Point(0, 38);
            this.datePicker2.Margin = new System.Windows.Forms.Padding(0);
            this.datePicker2.Name = "datePicker2";
            this.datePicker2.Size = new System.Drawing.Size(165, 30);
            this.datePicker2.TabIndex = 30;
            // 
            // panel4
            // 
            this.panel4.BorderWidth = 1F;
            this.panel4.Controls.Add(this.checkbox2);
            this.panel4.Controls.Add(this.select2);
            this.panel4.Location = new System.Drawing.Point(4, 3);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 0);
            this.panel4.Name = "panel4";
            this.panel4.RadiusAlign = AntdUI.TAlignRound.Top;
            this.panel4.Size = new System.Drawing.Size(157, 35);
            this.panel4.TabIndex = 26;
            this.panel4.Text = "panel4";
            // 
            // checkbox2
            // 
            this.checkbox2.AutoSizeMode = AntdUI.TAutoSize.Height;
            this.checkbox2.BackColor = System.Drawing.Color.White;
            this.checkbox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.checkbox2.Font = new System.Drawing.Font("微軟正黑體", 5F);
            this.checkbox2.Location = new System.Drawing.Point(130, 16);
            this.checkbox2.Name = "checkbox2";
            this.checkbox2.Size = new System.Drawing.Size(26, 18);
            this.checkbox2.TabIndex = 27;
            this.checkbox2.Text = "";
            // 
            // select2
            // 
            this.select2.BorderWidth = 0F;
            this.select2.Dock = System.Windows.Forms.DockStyle.Left;
            this.select2.IconRatio = 0F;
            this.select2.List = true;
            this.select2.Location = new System.Drawing.Point(1, 1);
            this.select2.Margin = new System.Windows.Forms.Padding(0);
            this.select2.Name = "select2";
            this.select2.PrefixText = "";
            this.select2.ShowIcon = false;
            this.select2.Size = new System.Drawing.Size(129, 33);
            this.select2.SuffixText = "";
            this.select2.TabIndex = 25;
            this.select2.Text = "select2";
            // 
            // tb_task
            // 
            this.tb_task.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_task.Font = new System.Drawing.Font("微軟正黑體", 14.25F);
            this.tb_task.Location = new System.Drawing.Point(117, 0);
            this.tb_task.Name = "tb_task";
            this.tb_task.Size = new System.Drawing.Size(659, 362);
            this.tb_task.TabIndex = 1;
            this.tb_task.Text = "任務設定";
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.btn_save.Location = new System.Drawing.Point(645, 445);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(143, 49);
            this.btn_save.TabIndex = 17;
            this.btn_save.Text = "儲存";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // pageHeader1
            // 
            this.pageHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pageHeader1.Font = new System.Drawing.Font("微軟正黑體", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageHeader1.Location = new System.Drawing.Point(0, 0);
            this.pageHeader1.MaximizeBox = false;
            this.pageHeader1.Name = "pageHeader1";
            this.pageHeader1.ShowButton = true;
            this.pageHeader1.Size = new System.Drawing.Size(800, 71);
            this.pageHeader1.TabIndex = 18;
            this.pageHeader1.Text = "設定";
            // 
            // From_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.pageHeader1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tabs1);
            this.Name = "From_settings";
            this.Text = "settings";
            this.Load += new System.EventHandler(this.From_settings_Load);
            this.tabs1.ResumeLayout(false);
            this.tb_pomo.ResumeLayout(false);
            this.gridPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tb_globle.ResumeLayout(false);
            this.stackPanel3.ResumeLayout(false);
            this.stackPanel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.stackPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.stackPanel4.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
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
        private AntdUI.StackPanel stackPanel3;
        private AntdUI.StackPanel stackPanel2;
        private AntdUI.Input input3;
        private AntdUI.Select select5;
        private AntdUI.DatePicker datePicker3;
        private AntdUI.Panel panel5;
        private AntdUI.Checkbox checkbox3;
        private AntdUI.Select select6;
        private AntdUI.StackPanel stackPanel1;
        private AntdUI.Input input1;
        private AntdUI.Select select3;
        private AntdUI.DatePicker datePicker1;
        private AntdUI.Panel panel3;
        private AntdUI.Checkbox checkbox1;
        private AntdUI.Select select4;
        private AntdUI.StackPanel stackPanel4;
        private AntdUI.Input input2;
        private AntdUI.Select select1;
        private AntdUI.DatePicker datePicker2;
        private AntdUI.Panel panel4;
        private AntdUI.Checkbox checkbox2;
        private AntdUI.Select select2;
        private AntdUI.Button btn_save;
        private AntdUI.PageHeader pageHeader1;
    }
}