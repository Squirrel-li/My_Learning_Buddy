namespace project
{
    partial class user_control_settings_gen
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

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lbltest = new System.Windows.Forms.Label();
            this.ds_set_xml = new System.Data.DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.ds_set_xml)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltest
            // 
            this.lbltest.AutoSize = true;
            this.lbltest.Location = new System.Drawing.Point(50, 69);
            this.lbltest.Name = "lbltest";
            this.lbltest.Size = new System.Drawing.Size(33, 12);
            this.lbltest.TabIndex = 2;
            this.lbltest.Text = "label1";
            // 
            // ds_set_xml
            // 
            this.ds_set_xml.DataSetName = "ds_set_xml";
            // 
            // user_control_settings_gen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbltest);
            this.Name = "user_control_settings_gen";
            this.Size = new System.Drawing.Size(500, 331);
            this.Load += new System.EventHandler(this.settings_user_control_gen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds_set_xml)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbltest;
        private System.Data.DataSet ds_set_xml;
    }
}
