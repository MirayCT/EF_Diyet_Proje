namespace WindowsForm_UI
{
    partial class Admin
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbAdminPortionSize = new ComboBox();
            cmbAdminMealTime = new ComboBox();
            cmbAdminFood = new ComboBox();
            txtbNewFood = new TextBox();
            txtbNewPortionSize = new TextBox();
            txtbNewMealTime = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnAdminFoodAdd = new Button();
            btnAdmindMealTimeAdd = new Button();
            btnAdminPortionSizeAdd = new Button();
            btnAdminFoodDelete = new Button();
            btnAdminFoodUpdate = new Button();
            btnAdminMealTimeDelete = new Button();
            btnAdminMealTimeUpdate = new Button();
            btnAdminPortionSizeDelete = new Button();
            btnAdminPortionSizeUpdate = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btnAdminWeeklyReport = new Button();
            btnAdminMonthlyReport = new Button();
            btnAdminTopFoods = new Button();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            txtFats = new TextBox();
            label13 = new Label();
            txtProtein = new TextBox();
            label14 = new Label();
            txtCarbs = new TextBox();
            label15 = new Label();
            txtDescription = new TextBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            btnAddImage = new Button();
            txtCalorie = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(504, 22);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 11;
            label3.Text = "Select Portion Size:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(346, 22);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 10;
            label2.Text = "Select Meal Time:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 22);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 9;
            label1.Text = "Select Your Food:";
            // 
            // cmbAdminPortionSize
            // 
            cmbAdminPortionSize.FormattingEnabled = true;
            cmbAdminPortionSize.Location = new Point(504, 40);
            cmbAdminPortionSize.Name = "cmbAdminPortionSize";
            cmbAdminPortionSize.Size = new Size(121, 23);
            cmbAdminPortionSize.TabIndex = 8;
            cmbAdminPortionSize.SelectedIndexChanged += cmbAdminPortionSize_SelectedIndexChanged;
            // 
            // cmbAdminMealTime
            // 
            cmbAdminMealTime.FormattingEnabled = true;
            cmbAdminMealTime.Location = new Point(346, 40);
            cmbAdminMealTime.Name = "cmbAdminMealTime";
            cmbAdminMealTime.Size = new Size(121, 23);
            cmbAdminMealTime.TabIndex = 7;
            cmbAdminMealTime.SelectedIndexChanged += cmbAdminMealTime_SelectedIndexChanged;
            // 
            // cmbAdminFood
            // 
            cmbAdminFood.FormattingEnabled = true;
            cmbAdminFood.Location = new Point(23, 40);
            cmbAdminFood.Name = "cmbAdminFood";
            cmbAdminFood.Size = new Size(121, 23);
            cmbAdminFood.TabIndex = 6;
            cmbAdminFood.SelectedIndexChanged += cmbAdminFood_SelectedIndexChanged;
            // 
            // txtbNewFood
            // 
            txtbNewFood.Location = new Point(23, 129);
            txtbNewFood.Name = "txtbNewFood";
            txtbNewFood.Size = new Size(121, 23);
            txtbNewFood.TabIndex = 12;
            // 
            // txtbNewPortionSize
            // 
            txtbNewPortionSize.Location = new Point(504, 129);
            txtbNewPortionSize.Name = "txtbNewPortionSize";
            txtbNewPortionSize.Size = new Size(121, 23);
            txtbNewPortionSize.TabIndex = 13;
            // 
            // txtbNewMealTime
            // 
            txtbNewMealTime.Location = new Point(345, 129);
            txtbNewMealTime.Name = "txtbNewMealTime";
            txtbNewMealTime.Size = new Size(122, 23);
            txtbNewMealTime.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(504, 111);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 15;
            label4.Text = "Portion Size:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(345, 111);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 16;
            label5.Text = "Meal Time:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 111);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 17;
            label6.Text = "Food Name:";
            // 
            // btnAdminFoodAdd
            // 
            btnAdminFoodAdd.Location = new Point(60, 304);
            btnAdminFoodAdd.Name = "btnAdminFoodAdd";
            btnAdminFoodAdd.Size = new Size(190, 23);
            btnAdminFoodAdd.TabIndex = 18;
            btnAdminFoodAdd.Text = "Add";
            btnAdminFoodAdd.UseVisualStyleBackColor = true;
            btnAdminFoodAdd.Click += btnAdminFoodAdd_Click;
            // 
            // btnAdmindMealTimeAdd
            // 
            btnAdmindMealTimeAdd.Location = new Point(345, 158);
            btnAdmindMealTimeAdd.Name = "btnAdmindMealTimeAdd";
            btnAdmindMealTimeAdd.Size = new Size(122, 23);
            btnAdmindMealTimeAdd.TabIndex = 19;
            btnAdmindMealTimeAdd.Text = "Add";
            btnAdmindMealTimeAdd.UseVisualStyleBackColor = true;
            btnAdmindMealTimeAdd.Click += btnAdmindMealTimeAdd_Click;
            // 
            // btnAdminPortionSizeAdd
            // 
            btnAdminPortionSizeAdd.Location = new Point(504, 158);
            btnAdminPortionSizeAdd.Name = "btnAdminPortionSizeAdd";
            btnAdminPortionSizeAdd.Size = new Size(121, 23);
            btnAdminPortionSizeAdd.TabIndex = 20;
            btnAdminPortionSizeAdd.Text = "Add";
            btnAdminPortionSizeAdd.UseVisualStyleBackColor = true;
            btnAdminPortionSizeAdd.Click += btnAdminPortionSizeAdd_Click;
            // 
            // btnAdminFoodDelete
            // 
            btnAdminFoodDelete.Location = new Point(20, 69);
            btnAdminFoodDelete.Name = "btnAdminFoodDelete";
            btnAdminFoodDelete.Size = new Size(124, 23);
            btnAdminFoodDelete.TabIndex = 21;
            btnAdminFoodDelete.Text = "Delete";
            btnAdminFoodDelete.UseVisualStyleBackColor = true;
            btnAdminFoodDelete.Click += btnAdminFoodDelete_Click;
            // 
            // btnAdminFoodUpdate
            // 
            btnAdminFoodUpdate.Location = new Point(60, 333);
            btnAdminFoodUpdate.Name = "btnAdminFoodUpdate";
            btnAdminFoodUpdate.Size = new Size(190, 23);
            btnAdminFoodUpdate.TabIndex = 22;
            btnAdminFoodUpdate.Text = "Update";
            btnAdminFoodUpdate.UseVisualStyleBackColor = true;
            btnAdminFoodUpdate.Click += btnAdminFoodUpdate_Click;
            // 
            // btnAdminMealTimeDelete
            // 
            btnAdminMealTimeDelete.Location = new Point(346, 69);
            btnAdminMealTimeDelete.Name = "btnAdminMealTimeDelete";
            btnAdminMealTimeDelete.Size = new Size(121, 23);
            btnAdminMealTimeDelete.TabIndex = 23;
            btnAdminMealTimeDelete.Text = "Delete";
            btnAdminMealTimeDelete.UseVisualStyleBackColor = true;
            btnAdminMealTimeDelete.Click += btnAdminMealTimeDelete_Click;
            // 
            // btnAdminMealTimeUpdate
            // 
            btnAdminMealTimeUpdate.Location = new Point(346, 187);
            btnAdminMealTimeUpdate.Name = "btnAdminMealTimeUpdate";
            btnAdminMealTimeUpdate.Size = new Size(121, 23);
            btnAdminMealTimeUpdate.TabIndex = 24;
            btnAdminMealTimeUpdate.Text = "Update";
            btnAdminMealTimeUpdate.UseVisualStyleBackColor = true;
            btnAdminMealTimeUpdate.Click += btnAdminMealTimeUpdate_Click;
            // 
            // btnAdminPortionSizeDelete
            // 
            btnAdminPortionSizeDelete.Location = new Point(504, 69);
            btnAdminPortionSizeDelete.Name = "btnAdminPortionSizeDelete";
            btnAdminPortionSizeDelete.Size = new Size(121, 23);
            btnAdminPortionSizeDelete.TabIndex = 25;
            btnAdminPortionSizeDelete.Text = "Delete";
            btnAdminPortionSizeDelete.UseVisualStyleBackColor = true;
            btnAdminPortionSizeDelete.Click += btnAdminPortionSizeDelete_Click;
            // 
            // btnAdminPortionSizeUpdate
            // 
            btnAdminPortionSizeUpdate.Location = new Point(504, 187);
            btnAdminPortionSizeUpdate.Name = "btnAdminPortionSizeUpdate";
            btnAdminPortionSizeUpdate.Size = new Size(121, 23);
            btnAdminPortionSizeUpdate.TabIndex = 26;
            btnAdminPortionSizeUpdate.Text = "Update";
            btnAdminPortionSizeUpdate.UseVisualStyleBackColor = true;
            btnAdminPortionSizeUpdate.Click += btnAdminPortionSizeUpdate_Click;
            // 
            // label7
            // 
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Location = new Point(13, 9);
            label7.Name = "label7";
            label7.Size = new Size(292, 358);
            label7.TabIndex = 27;
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Location = new Point(336, 9);
            label8.Name = "label8";
            label8.Size = new Size(141, 213);
            label8.TabIndex = 28;
            // 
            // label9
            // 
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Location = new Point(494, 9);
            label9.Name = "label9";
            label9.Size = new Size(141, 213);
            label9.TabIndex = 29;
            // 
            // btnAdminWeeklyReport
            // 
            btnAdminWeeklyReport.Location = new Point(110, 407);
            btnAdminWeeklyReport.Name = "btnAdminWeeklyReport";
            btnAdminWeeklyReport.Size = new Size(75, 52);
            btnAdminWeeklyReport.TabIndex = 30;
            btnAdminWeeklyReport.Text = "Weekly Report";
            btnAdminWeeklyReport.UseVisualStyleBackColor = true;
            btnAdminWeeklyReport.Click += btnAdminWeeklyReport_Click;
            // 
            // btnAdminMonthlyReport
            // 
            btnAdminMonthlyReport.Location = new Point(199, 407);
            btnAdminMonthlyReport.Name = "btnAdminMonthlyReport";
            btnAdminMonthlyReport.Size = new Size(75, 52);
            btnAdminMonthlyReport.TabIndex = 31;
            btnAdminMonthlyReport.Text = "Monthly Report";
            btnAdminMonthlyReport.UseVisualStyleBackColor = true;
            btnAdminMonthlyReport.Click += btnAdminMonthlyReport_Click;
            // 
            // btnAdminTopFoods
            // 
            btnAdminTopFoods.Location = new Point(290, 407);
            btnAdminTopFoods.Name = "btnAdminTopFoods";
            btnAdminTopFoods.Size = new Size(75, 52);
            btnAdminTopFoods.TabIndex = 32;
            btnAdminTopFoods.Text = "Top \r\nFoods";
            btnAdminTopFoods.UseVisualStyleBackColor = true;
            btnAdminTopFoods.Click += btnAdminTopFoods_Click;
            // 
            // label10
            // 
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Location = new Point(9, 382);
            label10.Name = "label10";
            label10.Size = new Size(454, 22);
            label10.TabIndex = 33;
            label10.Text = "Reports";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(23, 158);
            label11.Name = "label11";
            label11.Size = new Size(47, 15);
            label11.TabIndex = 35;
            label11.Text = "Calorie:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(23, 206);
            label12.Name = "label12";
            label12.Size = new Size(31, 15);
            label12.TabIndex = 37;
            label12.Text = "Fats:";
            // 
            // txtFats
            // 
            txtFats.Location = new Point(23, 224);
            txtFats.Name = "txtFats";
            txtFats.Size = new Size(121, 23);
            txtFats.TabIndex = 36;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(164, 206);
            label13.Name = "label13";
            label13.Size = new Size(48, 15);
            label13.TabIndex = 43;
            label13.Text = "Protein:";
            // 
            // txtProtein
            // 
            txtProtein.Location = new Point(164, 224);
            txtProtein.Name = "txtProtein";
            txtProtein.Size = new Size(121, 23);
            txtProtein.TabIndex = 42;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(164, 158);
            label14.Name = "label14";
            label14.Size = new Size(40, 15);
            label14.TabIndex = 41;
            label14.Text = "Carbs:";
            // 
            // txtCarbs
            // 
            txtCarbs.Location = new Point(164, 176);
            txtCarbs.Name = "txtCarbs";
            txtCarbs.Size = new Size(121, 23);
            txtCarbs.TabIndex = 40;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(164, 111);
            label15.Name = "label15";
            label15.Size = new Size(70, 15);
            label15.TabIndex = 39;
            label15.Text = "Description:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(164, 129);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(121, 23);
            txtDescription.TabIndex = 38;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // btnAddImage
            // 
            btnAddImage.Location = new Point(24, 256);
            btnAddImage.Name = "btnAddImage";
            btnAddImage.Size = new Size(119, 25);
            btnAddImage.TabIndex = 44;
            btnAddImage.Text = "Add Picture...";
            btnAddImage.UseVisualStyleBackColor = true;
            btnAddImage.Click += btnAddImage_Click;
            // 
            // txtCalorie
            // 
            txtCalorie.Location = new Point(20, 176);
            txtCalorie.Name = "txtCalorie";
            txtCalorie.Size = new Size(121, 23);
            txtCalorie.TabIndex = 45;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 476);
            Controls.Add(txtCalorie);
            Controls.Add(btnAddImage);
            Controls.Add(label13);
            Controls.Add(txtProtein);
            Controls.Add(label14);
            Controls.Add(txtCarbs);
            Controls.Add(label15);
            Controls.Add(txtDescription);
            Controls.Add(label12);
            Controls.Add(txtFats);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(btnAdminTopFoods);
            Controls.Add(btnAdminMonthlyReport);
            Controls.Add(btnAdminWeeklyReport);
            Controls.Add(btnAdminPortionSizeUpdate);
            Controls.Add(btnAdminPortionSizeDelete);
            Controls.Add(btnAdminMealTimeUpdate);
            Controls.Add(btnAdminMealTimeDelete);
            Controls.Add(btnAdminFoodUpdate);
            Controls.Add(btnAdminFoodDelete);
            Controls.Add(btnAdminPortionSizeAdd);
            Controls.Add(btnAdmindMealTimeAdd);
            Controls.Add(btnAdminFoodAdd);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtbNewMealTime);
            Controls.Add(txtbNewPortionSize);
            Controls.Add(txtbNewFood);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbAdminPortionSize);
            Controls.Add(cmbAdminMealTime);
            Controls.Add(cmbAdminFood);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Name = "Admin";
            Text = "Admin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbAdminPortionSize;
        private ComboBox cmbAdminMealTime;
        private ComboBox cmbAdminFood;
        private TextBox txtbNewFood;
        private TextBox txtbNewPortionSize;
        private TextBox txtbNewMealTime;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnAdminFoodAdd;
        private Button btnAdmindMealTimeAdd;
        private Button btnAdminPortionSizeAdd;
        private Button btnAdminFoodDelete;
        private Button btnAdminFoodUpdate;
        private Button btnAdminMealTimeDelete;
        private Button btnAdminMealTimeUpdate;
        private Button btnAdminPortionSizeDelete;
        private Button btnAdminPortionSizeUpdate;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnAdminWeeklyReport;
        private Button btnAdminMonthlyReport;
        private Button btnAdminTopFoods;
        private Label label10;
        private Label label11;
        private TextBox textBox1;
        private Label label12;
        private TextBox txtFats;
        private Label label13;
        private TextBox txtProtein;
        private Label label14;
        private TextBox txtCarbs;
        private Label label15;
        private TextBox txtDescription;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button btnAddImage;
        private TextBox txtCalorie;
    }
}