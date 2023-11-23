namespace Reader
{
    partial class Form1
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
            this.ReadSerial = new System.ComponentModel.BackgroundWorker();
            this.richLog = new System.Windows.Forms.RichTextBox();
            this.dtatcp = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtatcp)).BeginInit();
            this.SuspendLayout();
            // 
            // ReadSerial
            // 
            this.ReadSerial.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ReadSerial_DoWork);
            // 
            // richLog
            // 
            this.richLog.Location = new System.Drawing.Point(514, -1);
            this.richLog.Name = "richLog";
            this.richLog.Size = new System.Drawing.Size(270, 640);
            this.richLog.TabIndex = 1;
            this.richLog.Text = "";
            // 
            // dtatcp
            // 
            this.dtatcp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtatcp.Location = new System.Drawing.Point(785, -1);
            this.dtatcp.Name = "dtatcp";
            this.dtatcp.Size = new System.Drawing.Size(707, 640);
            this.dtatcp.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 635);
            this.Controls.Add(this.richLog);
            this.Controls.Add(this.dtatcp);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtatcp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker ReadSerial;
        private System.Windows.Forms.RichTextBox richLog;
        private System.Windows.Forms.DataGridView dtatcp;
    }
}

