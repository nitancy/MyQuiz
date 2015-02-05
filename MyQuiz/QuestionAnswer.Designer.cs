namespace MyQuiz
{
    partial class QuestionAnswer
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.grpAnswers = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rdoAnswer4 = new System.Windows.Forms.RadioButton();
            this.rdoAnswer3 = new System.Windows.Forms.RadioButton();
            this.rdoAnswer2 = new System.Windows.Forms.RadioButton();
            this.rdoAnswer1 = new System.Windows.Forms.RadioButton();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnCheckAnswer = new System.Windows.Forms.Button();
            this.grpAnswers.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(12, 9);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(65, 17);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Question";
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(15, 29);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.ReadOnly = true;
            this.txtQuestion.Size = new System.Drawing.Size(700, 72);
            this.txtQuestion.TabIndex = 1;
            this.txtQuestion.Text = "Why is there air?";
            // 
            // grpAnswers
            // 
            this.grpAnswers.Controls.Add(this.tableLayoutPanel1);
            this.grpAnswers.Location = new System.Drawing.Point(15, 121);
            this.grpAnswers.Name = "grpAnswers";
            this.grpAnswers.Size = new System.Drawing.Size(700, 216);
            this.grpAnswers.TabIndex = 2;
            this.grpAnswers.TabStop = false;
            this.grpAnswers.Text = "Answer";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.rdoAnswer4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.rdoAnswer3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.rdoAnswer2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.rdoAnswer1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(693, 188);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // rdoAnswer4
            // 
            this.rdoAnswer4.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rdoAnswer4.Location = new System.Drawing.Point(3, 144);
            this.rdoAnswer4.Name = "rdoAnswer4";
            this.rdoAnswer4.Size = new System.Drawing.Size(687, 24);
            this.rdoAnswer4.TabIndex = 3;
            this.rdoAnswer4.TabStop = true;
            this.rdoAnswer4.Text = "radioButton1";
            this.rdoAnswer4.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rdoAnswer4.UseVisualStyleBackColor = true;
            // 
            // rdoAnswer3
            // 
            this.rdoAnswer3.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rdoAnswer3.Location = new System.Drawing.Point(3, 97);
            this.rdoAnswer3.Name = "rdoAnswer3";
            this.rdoAnswer3.Size = new System.Drawing.Size(687, 24);
            this.rdoAnswer3.TabIndex = 2;
            this.rdoAnswer3.TabStop = true;
            this.rdoAnswer3.Text = "radioButton1";
            this.rdoAnswer3.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rdoAnswer3.UseVisualStyleBackColor = true;
            // 
            // rdoAnswer2
            // 
            this.rdoAnswer2.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rdoAnswer2.Location = new System.Drawing.Point(3, 50);
            this.rdoAnswer2.Name = "rdoAnswer2";
            this.rdoAnswer2.Size = new System.Drawing.Size(687, 24);
            this.rdoAnswer2.TabIndex = 1;
            this.rdoAnswer2.TabStop = true;
            this.rdoAnswer2.Text = "radioButton2";
            this.rdoAnswer2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rdoAnswer2.UseVisualStyleBackColor = true;
            // 
            // rdoAnswer1
            // 
            this.rdoAnswer1.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rdoAnswer1.Location = new System.Drawing.Point(3, 3);
            this.rdoAnswer1.Name = "rdoAnswer1";
            this.rdoAnswer1.Size = new System.Drawing.Size(687, 24);
            this.rdoAnswer1.TabIndex = 0;
            this.rdoAnswer1.TabStop = true;
            this.rdoAnswer1.Text = "radioButton1";
            this.rdoAnswer1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rdoAnswer1.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(525, 346);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnCheckAnswer
            // 
            this.btnCheckAnswer.Location = new System.Drawing.Point(606, 346);
            this.btnCheckAnswer.Name = "btnCheckAnswer";
            this.btnCheckAnswer.Size = new System.Drawing.Size(106, 23);
            this.btnCheckAnswer.TabIndex = 4;
            this.btnCheckAnswer.Text = "Check Answer";
            this.btnCheckAnswer.UseVisualStyleBackColor = true;
            this.btnCheckAnswer.Click += new System.EventHandler(this.btnCheckAnswer_Click);
            // 
            // QuestionAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 388);
            this.Controls.Add(this.btnCheckAnswer);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.grpAnswers);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.lblQuestion);
            this.Name = "QuestionAnswer";
            this.ShowInTaskbar = false;
            this.Text = "QuestionAnswer";
            this.Load += new System.EventHandler(this.QuestionAnswer_Load);
            this.grpAnswers.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.GroupBox grpAnswers;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton rdoAnswer1;
        private System.Windows.Forms.RadioButton rdoAnswer4;
        private System.Windows.Forms.RadioButton rdoAnswer3;
        private System.Windows.Forms.RadioButton rdoAnswer2;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnCheckAnswer;
    }
}