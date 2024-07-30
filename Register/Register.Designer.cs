namespace Register
{
    partial class Register
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 50);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "E-Mail:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 90);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 0;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 130);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 0;
            label3.Text = "Confirm Password:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(148, 47);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(148, 87);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 2;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(148, 127);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(100, 23);
            txtConfirmPassword.TabIndex = 3;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(82, 180);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(166, 54);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 328);
            Controls.Add(btnRegister);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Register";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private Button btnRegister;
    }
}