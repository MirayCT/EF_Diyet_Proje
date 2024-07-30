namespace WindowsForm_UI
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
            btnRegister = new Button();
            txtConfirmPassword = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            cbxCinsiyet = new ComboBox();
            label12 = new Label();
            dateTimePicker1 = new DateTimePicker();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label14 = new Label();
            numKilo = new NumericUpDown();
            numHedefKilo = new NumericUpDown();
            numBoy = new NumericUpDown();
            numYas = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numKilo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHedefKilo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBoy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numYas).BeginInit();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(189, 291);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(166, 26);
            btnRegister.TabIndex = 11;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(351, 117);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(197, 23);
            txtConfirmPassword.TabIndex = 10;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(351, 77);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(197, 23);
            txtPassword.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(351, 37);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(197, 23);
            txtEmail.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(238, 123);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 5;
            label3.Text = "Confirm Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(285, 83);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 6;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(301, 43);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 7;
            label1.Text = "E-Mail:";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(80, 80);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(100, 23);
            txtSoyad.TabIndex = 16;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(80, 40);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(100, 23);
            txtAd.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(263, 170);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 12;
            label4.Text = "Doğum Günü:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 85);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 13;
            label5.Text = "Soyad:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 45);
            label6.Name = "label6";
            label6.Size = new Size(25, 15);
            label6.TabIndex = 14;
            label6.Text = "Ad:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 130);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 18;
            label7.Text = "Kilo:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(45, 207);
            label8.Name = "label8";
            label8.Size = new Size(27, 15);
            label8.TabIndex = 26;
            label8.Text = "Yaş:";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(293, 205);
            label9.Name = "label9";
            label9.Size = new Size(52, 15);
            label9.TabIndex = 23;
            label9.Text = "Cinsiyet:";
            // 
            // cbxCinsiyet
            // 
            cbxCinsiyet.FormattingEnabled = true;
            cbxCinsiyet.Location = new Point(353, 202);
            cbxCinsiyet.Name = "cbxCinsiyet";
            cbxCinsiyet.Size = new Size(195, 23);
            cbxCinsiyet.TabIndex = 27;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(44, 247);
            label12.Name = "label12";
            label12.Size = new Size(30, 15);
            label12.TabIndex = 29;
            label12.Text = "Boy:";
            label12.Click += label12_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(351, 164);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(197, 23);
            dateTimePicker1.TabIndex = 30;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(9, 170);
            label14.Name = "label14";
            label14.Size = new Size(65, 15);
            label14.TabIndex = 34;
            label14.Text = "Hedef Kilo:";
            // 
            // numKilo
            // 
            numKilo.Location = new Point(80, 128);
            numKilo.Name = "numKilo";
            numKilo.Size = new Size(100, 23);
            numKilo.TabIndex = 35;
            // 
            // numHedefKilo
            // 
            numHedefKilo.Location = new Point(80, 168);
            numHedefKilo.Name = "numHedefKilo";
            numHedefKilo.Size = new Size(100, 23);
            numHedefKilo.TabIndex = 36;
            // 
            // numBoy
            // 
            numBoy.Location = new Point(80, 245);
            numBoy.Name = "numBoy";
            numBoy.Size = new Size(100, 23);
            numBoy.TabIndex = 38;
            // 
            // numYas
            // 
            numYas.Location = new Point(80, 205);
            numYas.Name = "numYas";
            numYas.Size = new Size(100, 23);
            numYas.TabIndex = 37;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 357);
            Controls.Add(numBoy);
            Controls.Add(numYas);
            Controls.Add(numHedefKilo);
            Controls.Add(numKilo);
            Controls.Add(label14);
            Controls.Add(dateTimePicker1);
            Controls.Add(label12);
            Controls.Add(cbxCinsiyet);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(btnRegister);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Register";
            Text = "Register";
            Load += Register_Load;
            ((System.ComponentModel.ISupportInitialize)numKilo).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHedefKilo).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBoy).EndInit();
            ((System.ComponentModel.ISupportInitialize)numYas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegister;
        private TextBox txtConfirmPassword;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label10;
        private Label label11;
        private ComboBox cbxCinsiyet;
        private Label label12;
        private DateTimePicker dateTimePicker1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label14;
        private NumericUpDown numKilo;
        private NumericUpDown numHedefKilo;
        private NumericUpDown numBoy;
        private NumericUpDown numYas;
    }
}