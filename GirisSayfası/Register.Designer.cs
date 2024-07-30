namespace LoginPage
{
    partial class Register
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtEmail = new TextBox();
            txtConfirmPassword = new TextBox();
            txtPassword = new TextBox();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 47);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "E-Mail:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 87);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 0;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 126);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 0;
            label3.Text = "Confirm Password:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(152, 44);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(152, 123);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(100, 23);
            txtConfirmPassword.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(152, 84);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 1;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(102, 169);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(137, 39);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 334);
            Controls.Add(btnRegister);
            Controls.Add(txtPassword);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtEmail;
        private TextBox txtConfirmPassword;
        private TextBox txtPassword;
        private Button btnRegister;
    }
}