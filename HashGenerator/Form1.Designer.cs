
namespace HashGenerator
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
            this.generateHashBtn = new System.Windows.Forms.Button();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.copyToClipboardCheckBox = new System.Windows.Forms.CheckBox();
            this.hashTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // generateHashBtn
            // 
            this.generateHashBtn.Enabled = false;
            this.generateHashBtn.Location = new System.Drawing.Point(236, 23);
            this.generateHashBtn.Name = "generateHashBtn";
            this.generateHashBtn.Size = new System.Drawing.Size(148, 51);
            this.generateHashBtn.TabIndex = 0;
            this.generateHashBtn.Text = "Give Me Hash";
            this.generateHashBtn.UseVisualStyleBackColor = true;
            this.generateHashBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(101, 19);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(100, 22);
            this.loginTextBox.TabIndex = 1;
            this.loginTextBox.TextChanged += new System.EventHandler(this.loginTextBox_TextChanged);
            // 
            // passTextBox
            // 
            this.passTextBox.Location = new System.Drawing.Point(101, 52);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(100, 22);
            this.passTextBox.TabIndex = 2;
            this.passTextBox.TextChanged += new System.EventHandler(this.passTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "pass";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "hash";
            // 
            // copyToClipboardCheckBox
            // 
            this.copyToClipboardCheckBox.AutoSize = true;
            this.copyToClipboardCheckBox.Checked = true;
            this.copyToClipboardCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.copyToClipboardCheckBox.Location = new System.Drawing.Point(236, 104);
            this.copyToClipboardCheckBox.Name = "copyToClipboardCheckBox";
            this.copyToClipboardCheckBox.Size = new System.Drawing.Size(138, 21);
            this.copyToClipboardCheckBox.TabIndex = 7;
            this.copyToClipboardCheckBox.Text = "copy to clipboard";
            this.copyToClipboardCheckBox.UseVisualStyleBackColor = true;
            // 
            // hashTextBox
            // 
            this.hashTextBox.Location = new System.Drawing.Point(29, 131);
            this.hashTextBox.Multiline = true;
            this.hashTextBox.Name = "hashTextBox";
            this.hashTextBox.Size = new System.Drawing.Size(355, 99);
            this.hashTextBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(426, 242);
            this.Controls.Add(this.hashTextBox);
            this.Controls.Add(this.copyToClipboardCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.generateHashBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateHashBtn;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox copyToClipboardCheckBox;
        private System.Windows.Forms.TextBox hashTextBox;
    }
}

