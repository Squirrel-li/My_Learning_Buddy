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
            this.btn_genset = new System.Windows.Forms.Button();
            this.btn_taskset = new System.Windows.Forms.Button();
            this.btn_pomoset = new System.Windows.Forms.Button();
            this.panel_setinput = new System.Windows.Forms.Panel();
            this.lbl_set_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_genset
            // 
            this.btn_genset.Location = new System.Drawing.Point(12, 12);
            this.btn_genset.Name = "btn_genset";
            this.btn_genset.Size = new System.Drawing.Size(75, 23);
            this.btn_genset.TabIndex = 0;
            this.btn_genset.Text = "button1";
            this.btn_genset.UseVisualStyleBackColor = true;
            this.btn_genset.Click += new System.EventHandler(this.btn_genset_Click);
            // 
            // btn_taskset
            // 
            this.btn_taskset.Location = new System.Drawing.Point(12, 41);
            this.btn_taskset.Name = "btn_taskset";
            this.btn_taskset.Size = new System.Drawing.Size(75, 23);
            this.btn_taskset.TabIndex = 1;
            this.btn_taskset.Text = "button2";
            this.btn_taskset.UseVisualStyleBackColor = true;
            this.btn_taskset.Click += new System.EventHandler(this.btn_taskset_Click);
            // 
            // btn_pomoset
            // 
            this.btn_pomoset.Location = new System.Drawing.Point(12, 70);
            this.btn_pomoset.Name = "btn_pomoset";
            this.btn_pomoset.Size = new System.Drawing.Size(75, 23);
            this.btn_pomoset.TabIndex = 2;
            this.btn_pomoset.Text = "button3";
            this.btn_pomoset.UseVisualStyleBackColor = true;
            this.btn_pomoset.Click += new System.EventHandler(this.btn_pomoset_Click);
            // 
            // panel_setinput
            // 
            this.panel_setinput.Location = new System.Drawing.Point(93, 36);
            this.panel_setinput.Name = "panel_setinput";
            this.panel_setinput.Size = new System.Drawing.Size(695, 402);
            this.panel_setinput.TabIndex = 3;
            // 
            // lbl_set_name
            // 
            this.lbl_set_name.AutoSize = true;
            this.lbl_set_name.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_set_name.Location = new System.Drawing.Point(93, 14);
            this.lbl_set_name.Name = "lbl_set_name";
            this.lbl_set_name.Size = new System.Drawing.Size(69, 19);
            this.lbl_set_name.TabIndex = 0;
            this.lbl_set_name.Text = "label1";
            // 
            // From_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_set_name);
            this.Controls.Add(this.panel_setinput);
            this.Controls.Add(this.btn_pomoset);
            this.Controls.Add(this.btn_taskset);
            this.Controls.Add(this.btn_genset);
            this.Name = "From_settings";
            this.Text = "settings";
            this.Load += new System.EventHandler(this.From_settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_genset;
        private System.Windows.Forms.Button btn_taskset;
        private System.Windows.Forms.Button btn_pomoset;
        private System.Windows.Forms.Panel panel_setinput;
        private System.Windows.Forms.Label lbl_set_name;
    }
}