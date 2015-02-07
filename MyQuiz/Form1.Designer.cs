namespace MyQuiz
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
            this.lblData = new System.Windows.Forms.Label();
            this.txtDataToPass = new System.Windows.Forms.TextBox();
            this.btnPassData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(12, 37);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(102, 17);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "Data To Pass: ";
            // 
            // txtDataToPass
            // 
            this.txtDataToPass.Location = new System.Drawing.Point(120, 38);
            this.txtDataToPass.Name = "txtDataToPass";
            this.txtDataToPass.Size = new System.Drawing.Size(128, 22);
            this.txtDataToPass.TabIndex = 1;
            // 
            // btnPassData
            // 
            this.btnPassData.Location = new System.Drawing.Point(254, 37);
            this.btnPassData.Name = "btnPassData";
            this.btnPassData.Size = new System.Drawing.Size(120, 23);
            this.btnPassData.TabIndex = 2;
            this.btnPassData.Text = "Send to Form2";
            this.btnPassData.UseVisualStyleBackColor = true;
            this.btnPassData.Click += new System.EventHandler(this.btnPassData_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnPassData;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 106);
            this.Controls.Add(this.btnPassData);
            this.Controls.Add(this.txtDataToPass);
            this.Controls.Add(this.lblData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtDataToPass;
        private System.Windows.Forms.Button btnPassData;
    }
}