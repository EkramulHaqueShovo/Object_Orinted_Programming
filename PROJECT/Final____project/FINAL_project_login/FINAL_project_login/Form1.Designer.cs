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
            this.label2 = new System.Windows.Forms.Label();
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
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Exit_button1);
            this.panel1.Controls.Add(this.Login_button);
            this.panel1.Controls.Add(this.UserName_textbox1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.Password_textbox2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 747);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(218, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 40);
            this.label2.TabIndex = 13;
            this.label2.Text = "USER LOGIN";
            // 
            // Exit_button1
            // 
            this.Exit_button1.BackColor = System.Drawing.Color.Transparent;
            this.Exit_button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Exit_button1.Location = new System.Drawing.Point(360, 634);
            this.Exit_button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Exit_button1.Name = "Exit_button1";
            this.Exit_button1.Size = new System.Drawing.Size(116, 55);
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
            this.Login_button.Location = new System.Drawing.Point(160, 634);
            this.Login_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(108, 55);
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
            this.UserName_textbox1.Location = new System.Drawing.Point(139, 444);
            this.UserName_textbox1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.UserName_textbox1.Name = "UserName_textbox1";
            this.UserName_textbox1.Size = new System.Drawing.Size(376, 43);
            this.UserName_textbox1.TabIndex = 6;
            this.UserName_textbox1.TextChanged += new System.EventHandler(this.Login_textbox1_TextChanged_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(79, 444);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(79, 535);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 41);
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
            this.Password_textbox2.Location = new System.Drawing.Point(139, 535);
            this.Password_textbox2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Password_textbox2.Name = "Password_textbox2";
            this.Password_textbox2.PasswordChar = '*';
            this.Password_textbox2.Size = new System.Drawing.Size(376, 43);
            this.Password_textbox2.TabIndex = 7;
            this.Password_textbox2.TextChanged += new System.EventHandler(this.Login_textbox2_TextChanged_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(2, -4);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(611, 287);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(171, 33);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(218, 121);
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
            this.label1.Location = new System.Drawing.Point(49, 199);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Management System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Loginpanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(604, 736);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
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
        private Label label2;
    }
}