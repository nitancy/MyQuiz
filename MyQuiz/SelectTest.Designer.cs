namespace MyQuiz
{
    partial class SelectTest
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
            this.lblTest = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblNumberOfQuestions = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lstTests = new System.Windows.Forms.ListBox();
            this.updTotalQuestions = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.updTotalQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(185, 43);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(40, 17);
            this.lblTest.TabIndex = 1;
            this.lblTest.Text = "Test:";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(257, 226);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(16, 17);
            this.lblCount.TabIndex = 2;
            this.lblCount.Text = "0";
            // 
            // lblNumberOfQuestions
            // 
            this.lblNumberOfQuestions.AutoSize = true;
            this.lblNumberOfQuestions.Location = new System.Drawing.Point(78, 226);
            this.lblNumberOfQuestions.Name = "lblNumberOfQuestions";
            this.lblNumberOfQuestions.Size = new System.Drawing.Size(127, 17);
            this.lblNumberOfQuestions.TabIndex = 3;
            this.lblNumberOfQuestions.Text = "Questions in Test: ";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(438, 314);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(47, 314);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lstTests
            // 
            this.lstTests.FormattingEnabled = true;
            this.lstTests.ItemHeight = 16;
            this.lstTests.Location = new System.Drawing.Point(247, 43);
            this.lstTests.Name = "lstTests";
            this.lstTests.Size = new System.Drawing.Size(284, 164);
            this.lstTests.TabIndex = 8;
            this.lstTests.SelectedIndexChanged += new System.EventHandler(this.lstTests_SelectedIndexChanged);
            // 
            // updTotalQuestions
            // 
            this.updTotalQuestions.Location = new System.Drawing.Point(254, 260);
            this.updTotalQuestions.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.updTotalQuestions.Name = "updTotalQuestions";
            this.updTotalQuestions.Size = new System.Drawing.Size(120, 22);
            this.updTotalQuestions.TabIndex = 10;
            this.updTotalQuestions.Tag = "";
            this.updTotalQuestions.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Number of Questions:";
            // 
            // SelectTest
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(584, 373);
            this.Controls.Add(this.updTotalQuestions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstTests);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblNumberOfQuestions);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblTest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SelectTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectTest";
            this.Load += new System.EventHandler(this.SelectTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.updTotalQuestions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblNumberOfQuestions;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox lstTests;
        private System.Windows.Forms.NumericUpDown updTotalQuestions;
        private System.Windows.Forms.Label label1;
    }
}