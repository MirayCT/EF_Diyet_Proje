namespace WindowsForm_UI
{
    partial class UserFoodLog
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
            cmbUserSelectedFood = new ComboBox();
            cmbUserSelectedMealTime = new ComboBox();
            cmbUserSelectedPortionSize = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dtpUserFoodDay = new DateTimePicker();
            dataGridView1 = new DataGridView();
            btnUserAddMeal = new Button();
            btnUserUpdateMeal = new Button();
            btnUserDeleteMeal = new Button();
            btnUserDailyReport = new Button();
            pbFoodPics = new PictureBox();
            btnShowFoodPicture = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFoodPics).BeginInit();
            SuspendLayout();
            // 
            // cmbUserSelectedFood
            // 
            cmbUserSelectedFood.FormattingEnabled = true;
            cmbUserSelectedFood.Location = new Point(23, 41);
            cmbUserSelectedFood.Name = "cmbUserSelectedFood";
            cmbUserSelectedFood.Size = new Size(121, 23);
            cmbUserSelectedFood.TabIndex = 0;
            // 
            // cmbUserSelectedMealTime
            // 
            cmbUserSelectedMealTime.FormattingEnabled = true;
            cmbUserSelectedMealTime.Location = new Point(150, 41);
            cmbUserSelectedMealTime.Name = "cmbUserSelectedMealTime";
            cmbUserSelectedMealTime.Size = new Size(121, 23);
            cmbUserSelectedMealTime.TabIndex = 1;
            // 
            // cmbUserSelectedPortionSize
            // 
            cmbUserSelectedPortionSize.FormattingEnabled = true;
            cmbUserSelectedPortionSize.Location = new Point(277, 41);
            cmbUserSelectedPortionSize.Name = "cmbUserSelectedPortionSize";
            cmbUserSelectedPortionSize.Size = new Size(121, 23);
            cmbUserSelectedPortionSize.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 23);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 3;
            label1.Text = "Select Your Food:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(150, 23);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 4;
            label2.Text = "Select Meal Time:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(277, 23);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 5;
            label3.Text = "Select Portion Size:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(404, 23);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 7;
            label4.Text = "Select The Day:";
            // 
            // dtpUserFoodDay
            // 
            dtpUserFoodDay.Location = new Point(404, 41);
            dtpUserFoodDay.Name = "dtpUserFoodDay";
            dtpUserFoodDay.Size = new Size(200, 23);
            dtpUserFoodDay.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(581, 199);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnUserAddMeal
            // 
            btnUserAddMeal.Location = new Point(622, 41);
            btnUserAddMeal.Name = "btnUserAddMeal";
            btnUserAddMeal.Size = new Size(75, 23);
            btnUserAddMeal.TabIndex = 10;
            btnUserAddMeal.Text = "Add";
            btnUserAddMeal.UseVisualStyleBackColor = true;
            btnUserAddMeal.Click += btnUserAddMeal_Click;
            // 
            // btnUserUpdateMeal
            // 
            btnUserUpdateMeal.Location = new Point(703, 40);
            btnUserUpdateMeal.Name = "btnUserUpdateMeal";
            btnUserUpdateMeal.Size = new Size(75, 23);
            btnUserUpdateMeal.TabIndex = 11;
            btnUserUpdateMeal.Text = "Update";
            btnUserUpdateMeal.UseVisualStyleBackColor = true;
            btnUserUpdateMeal.Click += btnUserUpdateMeal_Click;
            // 
            // btnUserDeleteMeal
            // 
            btnUserDeleteMeal.Location = new Point(784, 40);
            btnUserDeleteMeal.Name = "btnUserDeleteMeal";
            btnUserDeleteMeal.Size = new Size(75, 23);
            btnUserDeleteMeal.TabIndex = 12;
            btnUserDeleteMeal.Text = "Delete";
            btnUserDeleteMeal.UseVisualStyleBackColor = true;
            btnUserDeleteMeal.Click += btnUserDeleteMeal_Click;
            // 
            // btnUserDailyReport
            // 
            btnUserDailyReport.Location = new Point(622, 229);
            btnUserDailyReport.Name = "btnUserDailyReport";
            btnUserDailyReport.Size = new Size(75, 40);
            btnUserDailyReport.TabIndex = 13;
            btnUserDailyReport.Text = "Daily Report";
            btnUserDailyReport.UseVisualStyleBackColor = true;
            btnUserDailyReport.Click += btnUserDailyReport_Click;
            // 
            // pbFoodPics
            // 
            pbFoodPics.Location = new Point(622, 70);
            pbFoodPics.Name = "pbFoodPics";
            pbFoodPics.Size = new Size(237, 153);
            pbFoodPics.TabIndex = 14;
            pbFoodPics.TabStop = false;
            // 
            // btnShowFoodPicture
            // 
            btnShowFoodPicture.Location = new Point(784, 229);
            btnShowFoodPicture.Name = "btnShowFoodPicture";
            btnShowFoodPicture.Size = new Size(75, 40);
            btnShowFoodPicture.TabIndex = 15;
            btnShowFoodPicture.Text = "Food Picture";
            btnShowFoodPicture.UseVisualStyleBackColor = true;
            btnShowFoodPicture.Click += btnShowFoodPicture_Click;
            // 
            // UserFoodLog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 282);
            Controls.Add(btnShowFoodPicture);
            Controls.Add(pbFoodPics);
            Controls.Add(btnUserDailyReport);
            Controls.Add(btnUserDeleteMeal);
            Controls.Add(btnUserUpdateMeal);
            Controls.Add(btnUserAddMeal);
            Controls.Add(dataGridView1);
            Controls.Add(dtpUserFoodDay);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbUserSelectedPortionSize);
            Controls.Add(cmbUserSelectedMealTime);
            Controls.Add(cmbUserSelectedFood);
            Name = "UserFoodLog";
            Text = "FoodLog";
            Load += UserFoodLog_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFoodPics).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbUserSelectedFood;
        private ComboBox cmbUserSelectedMealTime;
        private ComboBox cmbUserSelectedPortionSize;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpUserFoodDay;
        private DataGridView dataGridView1;
        private Button btnUserAddMeal;
        private Button btnUserUpdateMeal;
        private Button btnUserDeleteMeal;
        private Button btnUserDailyReport;
        private PictureBox pbFoodPics;
        private Button btnShowFoodPicture;
    }
}