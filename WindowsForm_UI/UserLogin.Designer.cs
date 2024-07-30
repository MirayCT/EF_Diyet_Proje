namespace WindowsForm_UI
{
    partial class UserLogin
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
            btnLoginAsUser.Location = new Point(136, 124);
            btnLoginAsUser.Name = "btnLoginAsUser";
            btnLoginAsUser.Size = new Size(67, 28);
            btnLoginAsUser.TabIndex = 10;
            btnLoginAsUser.Text = "Login";
            btnLoginAsUser.UseVisualStyleBackColor = true;
            btnLoginAsUser.Click += btnLoginAsUser_Click;
            // 
            // txtbUserPassword
            // 
            txtbUserPassword.Location = new Point(81, 83);
            txtbUserPassword.Name = "txtbUserPassword";
            txtbUserPassword.Size = new Size(193, 23);
            txtbUserPassword.TabIndex = 9;
            // 
            // txtbUserEmail
            // 
            txtbUserEmail.Location = new Point(81, 39);
            txtbUserEmail.Name = "txtbUserEmail";
            txtbUserEmail.Size = new Size(193, 23);
            txtbUserEmail.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 86);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 7;
            label2.Text = "Pasword:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 47);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 6;
            label1.Text = "E-Mail:";
            // 
            // UserLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 186);
            Controls.Add(btnLoginAsUser);
            Controls.Add(txtbUserPassword);
            Controls.Add(txtbUserEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserLogin";
            Text = "UserLogin";
            Load += UserLogin_Load;
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