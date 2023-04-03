namespace FINAL_project_login
{
    partial class Loginpanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loginpanel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox_showpassword = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Exit_button1 = new System.Windows.Forms.Button();
            this.Login_button = new System.Windows.Forms.Button();
            this.UserName_textbox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Password_textbox2 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.checkBox_showpassword);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Exit_button1);
            this.panel1.Controls.Add(this.Login_button);
            this.panel1.Controls.Add(this.UserName_textbox1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.Password_textbox2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 483);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // checkBox_showpassword
            // 
            this.checkBox_showpassword.AutoSize = true;
            this.checkBox_showpassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_showpassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_showpassword.Location = new System.Drawing.Point(234, 371);
            this.checkBox_showpassword.Name = "checkBox_showpassword";
            this.checkBox_showpassword.Size = new System.Drawing.Size(105, 19);
            this.checkBox_showpassword.TabIndex = 16;
            this.checkBox_showpassword.Text = "Show Password";
            this.checkBox_showpassword.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(79, 298);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(79, 217);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "User Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Exit_button1
            // 
            this.Exit_button1.BackColor = System.Drawing.Color.Transparent;
            this.Exit_button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Exit_button1.Location = new System.Drawing.Point(238, 409);
            this.Exit_button1.Name = "Exit_button1";
            this.Exit_button1.Size = new System.Drawing.Size(81, 33);
            this.Exit_button1.TabIndex = 12;
            this.Exit_button1.Text = "Exit";
            this.Exit_button1.UseVisualStyleBackColor = false;
            this.Exit_button1.Click += new System.EventHandler(this.Exit_button1_Click);
            // 
            // Login_button
            // 
            this.Login_button.BackColor = System.Drawing.Color.Transparent;
            this.Login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_button.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Login_button.Location = new System.Drawing.Point(79, 409);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(76, 33);
            this.Login_button.TabIndex = 10;
            this.Login_button.Text = "Login";
            this.Login_button.UseVisualStyleBackColor = false;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // UserName_textbox1
            // 
            this.UserName_textbox1.BackColor = System.Drawing.Color.Silver;
            this.UserName_textbox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserName_textbox1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserName_textbox1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.UserName_textbox1.Location = new System.Drawing.Point(79, 251);
            this.UserName_textbox1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.UserName_textbox1.Name = "UserName_textbox1";
            this.UserName_textbox1.Size = new System.Drawing.Size(263, 29);
            this.UserName_textbox1.TabIndex = 6;
            this.UserName_textbox1.TextChanged += new System.EventHandler(this.Login_textbox1_TextChanged_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 251);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(37, 328);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // Password_textbox2
            // 
            this.Password_textbox2.BackColor = System.Drawing.Color.Silver;
            this.Password_textbox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password_textbox2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Password_textbox2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.Password_textbox2.Location = new System.Drawing.Point(79, 328);
            this.Password_textbox2.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Password_textbox2.Name = "Password_textbox2";
            this.Password_textbox2.PasswordChar = '*';
            this.Password_textbox2.Size = new System.Drawing.Size(263, 29);
            this.Password_textbox2.TabIndex = 7;
            this.Password_textbox2.TextChanged += new System.EventHandler(this.Login_textbox2_TextChanged_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, -2);
            this.panel2.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(431, 172);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(120, 20);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(153, 73);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Miriam Fixed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Management System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Loginpanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(401, 474);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "Loginpanel";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Panel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox UserName_textbox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox Password_textbox2;
        private Panel panel2;
        private PictureBox pictureBox3;
        private Label label1;
        private Button Login_button;
        private Button Exit_button1;
        private Label label4;
        private Label label3;
        private CheckBox checkBox_showpassword;
    }
}