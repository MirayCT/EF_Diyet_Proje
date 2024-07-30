namespace WindowsForm_UI
{
    partial class WelcomePage
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
            lblWelcome = new Label();
            btnForUserLoginPage = new Button();
            btnForAdminLoginPage = new Button();
            btnForRegisterPage = new Button();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.BorderStyle = BorderStyle.FixedSingle;
            lblWelcome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblWelcome.Location = new Point(23, 9);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(268, 127);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome to our Diet Program. In this program you can choose the meal, food and the portion size to calculate how much calories you have consimed in a day!";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnForUserLoginPage
            // 
            btnForUserLoginPage.Location = new Point(194, 139);
            btnForUserLoginPage.Name = "btnForUserLoginPage";
            btnForUserLoginPage.Size = new Size(97, 30);
            btnForUserLoginPage.TabIndex = 1;
            btnForUserLoginPage.Text = "User Login";
            btnForUserLoginPage.UseVisualStyleBackColor = true;
            btnForUserLoginPage.Click += btnForUserLoginPage_Click;
            // 
            // btnForAdminLoginPage
            // 
            btnForAdminLoginPage.Location = new Point(23, 139);
            btnForAdminLoginPage.Name = "btnForAdminLoginPage";
            btnForAdminLoginPage.Size = new Size(97, 30);
            btnForAdminLoginPage.TabIndex = 2;
            btnForAdminLoginPage.Text = "Admin Login";
            btnForAdminLoginPage.UseVisualStyleBackColor = true;
            btnForAdminLoginPage.Click += btnForAdminLoginPage_Click;
            // 
            // btnForRegisterPage
            // 
            btnForRegisterPage.Location = new Point(110, 175);
            btnForRegisterPage.Name = "btnForRegisterPage";
            btnForRegisterPage.Size = new Size(97, 30);
            btnForRegisterPage.TabIndex = 3;
            btnForRegisterPage.Text = "Register";
            btnForRegisterPage.UseVisualStyleBackColor = true;
            btnForRegisterPage.Click += btnForRegisterPage_Click;
            // 
            // WelcomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 229);
            Controls.Add(btnForRegisterPage);
            Controls.Add(btnForAdminLoginPage);
            Controls.Add(btnForUserLoginPage);
            Controls.Add(lblWelcome);
            Name = "WelcomePage";
            Text = "Welcome User";
            ResumeLayout(false);
        }

        #endregion

        private Label lblWelcome;
        private Button btnForUserLoginPage;
        private Button btnForAdminLoginPage;
        private Button btnForRegisterPage;
    }
}
