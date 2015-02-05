namespace MyQuiz
{
    partial class Sandbox
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
            this.btnSelectNodeByAttribute = new System.Windows.Forms.Button();
            this.btnSortByAttribute = new System.Windows.Forms.Button();
            this.btnSortByChildDESC = new System.Windows.Forms.Button();
            this.btnbtnSelectNodeByAttributeF = new System.Windows.Forms.Button();
            this.btnWriteXMLtoFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelectNodeByAttribute
            // 
            this.btnSelectNodeByAttribute.Location = new System.Drawing.Point(90, 60);
            this.btnSelectNodeByAttribute.Name = "btnSelectNodeByAttribute";
            this.btnSelectNodeByAttribute.Size = new System.Drawing.Size(195, 23);
            this.btnSelectNodeByAttribute.TabIndex = 0;
            this.btnSelectNodeByAttribute.Text = "Select Node By Attribute";
            this.btnSelectNodeByAttribute.UseVisualStyleBackColor = true;
            this.btnSelectNodeByAttribute.Click += new System.EventHandler(this.btnSelectNodeByAttribute_Click);
            // 
            // btnSortByAttribute
            // 
            this.btnSortByAttribute.Location = new System.Drawing.Point(90, 104);
            this.btnSortByAttribute.Name = "btnSortByAttribute";
            this.btnSortByAttribute.Size = new System.Drawing.Size(195, 23);
            this.btnSortByAttribute.TabIndex = 1;
            this.btnSortByAttribute.Text = "Sort By Attribute";
            this.btnSortByAttribute.UseVisualStyleBackColor = true;
            this.btnSortByAttribute.Click += new System.EventHandler(this.btnSortByAttribute_Click);
            // 
            // btnSortByChildDESC
            // 
            this.btnSortByChildDESC.Location = new System.Drawing.Point(90, 148);
            this.btnSortByChildDESC.Name = "btnSortByChildDESC";
            this.btnSortByChildDESC.Size = new System.Drawing.Size(195, 23);
            this.btnSortByChildDESC.TabIndex = 2;
            this.btnSortByChildDESC.Text = "Sort By Child DESC";
            this.btnSortByChildDESC.UseVisualStyleBackColor = true;
            this.btnSortByChildDESC.Click += new System.EventHandler(this.btnSortByChildDESC_Click);
            // 
            // btnbtnSelectNodeByAttributeF
            // 
            this.btnbtnSelectNodeByAttributeF.Location = new System.Drawing.Point(303, 60);
            this.btnbtnSelectNodeByAttributeF.Name = "btnbtnSelectNodeByAttributeF";
            this.btnbtnSelectNodeByAttributeF.Size = new System.Drawing.Size(195, 23);
            this.btnbtnSelectNodeByAttributeF.TabIndex = 3;
            this.btnbtnSelectNodeByAttributeF.Text = "Select Node By Attribute F";
            this.btnbtnSelectNodeByAttributeF.UseVisualStyleBackColor = true;
            this.btnbtnSelectNodeByAttributeF.Click += new System.EventHandler(this.btnbtnSelectNodeByAttributeF_Click);
            // 
            // btnWriteXMLtoFile
            // 
            this.btnWriteXMLtoFile.Location = new System.Drawing.Point(90, 192);
            this.btnWriteXMLtoFile.Name = "btnWriteXMLtoFile";
            this.btnWriteXMLtoFile.Size = new System.Drawing.Size(195, 23);
            this.btnWriteXMLtoFile.TabIndex = 4;
            this.btnWriteXMLtoFile.Text = "Write XML To File";
            this.btnWriteXMLtoFile.UseVisualStyleBackColor = true;
            this.btnWriteXMLtoFile.Click += new System.EventHandler(this.btnWriteXMLtoFile_Click);
            // 
            // Sandbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 299);
            this.Controls.Add(this.btnWriteXMLtoFile);
            this.Controls.Add(this.btnbtnSelectNodeByAttributeF);
            this.Controls.Add(this.btnSortByChildDESC);
            this.Controls.Add(this.btnSortByAttribute);
            this.Controls.Add(this.btnSelectNodeByAttribute);
            this.Name = "Sandbox";
            this.Text = "Sandbox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelectNodeByAttribute;
        private System.Windows.Forms.Button btnSortByAttribute;
        private System.Windows.Forms.Button btnSortByChildDESC;
        private System.Windows.Forms.Button btnbtnSelectNodeByAttributeF;
        private System.Windows.Forms.Button btnWriteXMLtoFile;
    }
}