namespace WindowsForm_UI
{
    partial class AdminLogin
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
            btnLoginAsUser = new Button();
            txtbUserPassword = new TextBox();
            txtbUserEmail = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnLoginAsUser
            // 
            btnLoginAsUser.Location = new Point(137, 128);
            btnLoginAsUser.Name = "btnLoginAsUser";
            btnLoginAsUser.Size = new Size(67, 28);
            btnLoginAsUser.TabIndex = 15;
            btnLoginAsUser.Text = "Login";
            btnLoginAsUser.UseVisualStyleBackColor = true;
            btnLoginAsUser.Click += btnLoginAsUser_Click;
            // 
            // txtbUserPassword
            // 
            txtbUserPassword.Location = new Point(82, 87);
            txtbUserPassword.Name = "txtbUserPassword";
            txtbUserPassword.Size = new Size(193, 23);
            txtbUserPassword.TabIndex = 14;
            // 
            // txtbUserEmail
            // 
            txtbUserEmail.Location = new Point(82, 43);
            txtbUserEmail.Name = "txtbUserEmail";
            txtbUserEmail.Size = new Size(193, 23);
            txtbUserEmail.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 90);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 12;
            label2.Text = "Pasword:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 51);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 11;
            label1.Text = "E-Mail:";
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 200);
            Controls.Add(btnLoginAsUser);
            Controls.Add(txtbUserPassword);
            Controls.Add(txtbUserEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdminLogin";
            Text = "AdminLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoginAsUser;
        private TextBox txtbUserPassword;
        private TextBox txtbUserEmail;
        private Label label2;
        private Label label1;
    }
}