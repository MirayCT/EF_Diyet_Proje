namespace WindowsForm_UI
{
    partial class UserInformation
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
            button1 = new Button();
            txtbUserAge = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtbUserHeight = new TextBox();
            label3 = new Label();
            txtbUserWeight = new TextBox();
            label4 = new Label();
            txtbUserGoalWeight = new TextBox();
            cmbUserGender = new ComboBox();
            label5 = new Label();
            btnUserStartLoginFood = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 185);
            button1.Name = "button1";
            button1.Size = new Size(181, 23);
            button1.TabIndex = 0;
            button1.Text = "Add Info";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtbUserAge
            // 
            txtbUserAge.Location = new Point(93, 37);
            txtbUserAge.Name = "txtbUserAge";
            txtbUserAge.Size = new Size(100, 23);
            txtbUserAge.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 37);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 2;
            label1.Text = "Age:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 66);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 4;
            label2.Text = "Height:";
            // 
            // txtbUserHeight
            // 
            txtbUserHeight.Location = new Point(93, 63);
            txtbUserHeight.Name = "txtbUserHeight";
            txtbUserHeight.Size = new Size(100, 23);
            txtbUserHeight.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 95);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 6;
            label3.Text = "Weight:";
            // 
            // txtbUserWeight
            // 
            txtbUserWeight.Location = new Point(93, 92);
            txtbUserWeight.Name = "txtbUserWeight";
            txtbUserWeight.Size = new Size(100, 23);
            txtbUserWeight.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 124);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 8;
            label4.Text = "Goal Weight:";
            // 
            // txtbUserGoalWeight
            // 
            txtbUserGoalWeight.Location = new Point(93, 121);
            txtbUserGoalWeight.Name = "txtbUserGoalWeight";
            txtbUserGoalWeight.Size = new Size(100, 23);
            txtbUserGoalWeight.TabIndex = 7;
            // 
            // cmbUserGender
            // 
            cmbUserGender.FormattingEnabled = true;
            cmbUserGender.Items.AddRange(new object[] { "Male", "Female", "Not Specified" });
            cmbUserGender.Location = new Point(93, 148);
            cmbUserGender.Name = "cmbUserGender";
            cmbUserGender.Size = new Size(100, 23);
            cmbUserGender.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 151);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 10;
            label5.Text = "Gender:";
            // 
            // btnUserStartLoginFood
            // 
            btnUserStartLoginFood.Location = new Point(12, 214);
            btnUserStartLoginFood.Name = "btnUserStartLoginFood";
            btnUserStartLoginFood.Size = new Size(181, 23);
            btnUserStartLoginFood.TabIndex = 11;
            btnUserStartLoginFood.Text = "Start Logging Your Food!";
            btnUserStartLoginFood.UseVisualStyleBackColor = true;
            btnUserStartLoginFood.Click += btnUserStartLoginFood_Click;
            // 
            // UserInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(220, 291);
            Controls.Add(btnUserStartLoginFood);
            Controls.Add(label5);
            Controls.Add(cmbUserGender);
            Controls.Add(label4);
            Controls.Add(txtbUserGoalWeight);
            Controls.Add(label3);
            Controls.Add(txtbUserWeight);
            Controls.Add(label2);
            Controls.Add(txtbUserHeight);
            Controls.Add(label1);
            Controls.Add(txtbUserAge);
            Controls.Add(button1);
            Name = "UserInformation";
            Text = "UserInformation";
            Load += UserInformation_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtbUserAge;
        private Label label1;
        private Label label2;
        private TextBox txtbUserHeight;
        private Label label3;
        private TextBox txtbUserWeight;
        private Label label4;
        private TextBox txtbUserGoalWeight;
        private ComboBox cmbUserGender;
        private Label label5;
        private Button btnUserStartLoginFood;
    }
}