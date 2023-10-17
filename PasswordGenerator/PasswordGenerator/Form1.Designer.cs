namespace PasswordGenerator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNewPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtPasswordLength = new TextBox();
            chkIncludeUppercase = new CheckBox();
            chkIncludeLowerCase = new CheckBox();
            chkIncludeSymbols = new CheckBox();
            chkIncludeNumbers = new CheckBox();
            btnGeneratorPassword = new Button();
            SuspendLayout();
            // 
            // txtNewPassword
            // 
            txtNewPassword.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtNewPassword.Location = new Point(164, 85);
            txtNewPassword.Multiline = true;
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(489, 65);
            txtNewPassword.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(289, 33);
            label1.Name = "label1";
            label1.Size = new Size(254, 37);
            label1.TabIndex = 1;
            label1.Text = "Password Generator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(271, 185);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 2;
            label2.Text = "Password Length";
            // 
            // txtPasswordLength
            // 
            txtPasswordLength.Location = new Point(416, 182);
            txtPasswordLength.Name = "txtPasswordLength";
            txtPasswordLength.Size = new Size(172, 23);
            txtPasswordLength.TabIndex = 3;
            txtPasswordLength.KeyPress += txtPasswordLength_KeyPress;
            // 
            // chkIncludeUppercase
            // 
            chkIncludeUppercase.AutoSize = true;
            chkIncludeUppercase.CheckAlign = ContentAlignment.MiddleRight;
            chkIncludeUppercase.Location = new Point(272, 223);
            chkIncludeUppercase.Name = "chkIncludeUppercase";
            chkIncludeUppercase.Size = new Size(156, 19);
            chkIncludeUppercase.TabIndex = 4;
            chkIncludeUppercase.Text = "Include Uppercase           ";
            chkIncludeUppercase.UseVisualStyleBackColor = true;
            // 
            // chkIncludeLowerCase
            // 
            chkIncludeLowerCase.AutoSize = true;
            chkIncludeLowerCase.CheckAlign = ContentAlignment.MiddleRight;
            chkIncludeLowerCase.Location = new Point(272, 267);
            chkIncludeLowerCase.Name = "chkIncludeLowerCase";
            chkIncludeLowerCase.Size = new Size(156, 19);
            chkIncludeLowerCase.TabIndex = 5;
            chkIncludeLowerCase.Text = "Include Lowercase           ";
            chkIncludeLowerCase.UseVisualStyleBackColor = true;
            // 
            // chkIncludeSymbols
            // 
            chkIncludeSymbols.AutoSize = true;
            chkIncludeSymbols.CheckAlign = ContentAlignment.MiddleRight;
            chkIncludeSymbols.Location = new Point(274, 340);
            chkIncludeSymbols.Name = "chkIncludeSymbols";
            chkIncludeSymbols.Size = new Size(155, 19);
            chkIncludeSymbols.TabIndex = 7;
            chkIncludeSymbols.Text = "Include Symbols              ";
            chkIncludeSymbols.UseVisualStyleBackColor = true;
            // 
            // chkIncludeNumbers
            // 
            chkIncludeNumbers.AutoSize = true;
            chkIncludeNumbers.CheckAlign = ContentAlignment.MiddleRight;
            chkIncludeNumbers.Location = new Point(272, 303);
            chkIncludeNumbers.Name = "chkIncludeNumbers";
            chkIncludeNumbers.Size = new Size(157, 19);
            chkIncludeNumbers.TabIndex = 6;
            chkIncludeNumbers.Text = "Include numbers              ";
            chkIncludeNumbers.UseVisualStyleBackColor = true;
            // 
            // btnGeneratorPassword
            // 
            btnGeneratorPassword.BackColor = SystemColors.ActiveCaptionText;
            btnGeneratorPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGeneratorPassword.ForeColor = SystemColors.ButtonHighlight;
            btnGeneratorPassword.Location = new Point(321, 386);
            btnGeneratorPassword.Name = "btnGeneratorPassword";
            btnGeneratorPassword.Size = new Size(202, 52);
            btnGeneratorPassword.TabIndex = 8;
            btnGeneratorPassword.Text = "Generate";
            btnGeneratorPassword.UseVisualStyleBackColor = false;
            btnGeneratorPassword.Click += btnGeneratorPassword_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGeneratorPassword);
            Controls.Add(chkIncludeSymbols);
            Controls.Add(chkIncludeNumbers);
            Controls.Add(chkIncludeLowerCase);
            Controls.Add(chkIncludeUppercase);
            Controls.Add(txtPasswordLength);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNewPassword);
            Name = "Form1";
            Text = "PasswordGenerator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNewPassword;
        private Label label1;
        private Label label2;
        private TextBox txtPasswordLength;
        private CheckBox chkIncludeUppercase;
        private CheckBox chkIncludeLowerCase;
        private CheckBox chkIncludeSymbols;
        private CheckBox chkIncludeNumbers;
        private Button btnGeneratorPassword;
    }
}