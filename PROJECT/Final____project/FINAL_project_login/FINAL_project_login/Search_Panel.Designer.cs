namespace FINAL_project_login
{
    partial class Search_Panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search_Panel));
            this.SearchAdmin_button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitAdmin_button1 = new System.Windows.Forms.Button();
            this.Back_button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchAdmin_button1
            // 
            this.SearchAdmin_button1.BackColor = System.Drawing.Color.White;
            this.SearchAdmin_button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchAdmin_button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchAdmin_button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.SearchAdmin_button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SearchAdmin_button1.Location = new System.Drawing.Point(583, 440);
            this.SearchAdmin_button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchAdmin_button1.Name = "SearchAdmin_button1";
            this.SearchAdmin_button1.Size = new System.Drawing.Size(131, 41);
            this.SearchAdmin_button1.TabIndex = 19;
            this.SearchAdmin_button1.Text = "Search";
            this.SearchAdmin_button1.UseVisualStyleBackColor = false;
            this.SearchAdmin_button1.Click += new System.EventHandler(this.SearchAdmin_button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.SearchAdmin_button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(-7, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 556);
            this.panel1.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(101, 442);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(464, 39);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(293, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "Search Panel";
            // 
            // ExitAdmin_button1
            // 
            this.ExitAdmin_button1.BackColor = System.Drawing.Color.Transparent;
            this.ExitAdmin_button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitAdmin_button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ExitAdmin_button1.Image = ((System.Drawing.Image)(resources.GetObject("ExitAdmin_button1.Image")));
            this.ExitAdmin_button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExitAdmin_button1.Location = new System.Drawing.Point(659, 0);
            this.ExitAdmin_button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExitAdmin_button1.Name = "ExitAdmin_button1";
            this.ExitAdmin_button1.Size = new System.Drawing.Size(131, 55);
            this.ExitAdmin_button1.TabIndex = 20;
            this.ExitAdmin_button1.Text = "logout";
            this.ExitAdmin_button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitAdmin_button1.UseVisualStyleBackColor = false;
            this.ExitAdmin_button1.Click += new System.EventHandler(this.ExitAdmin_button1_Click);
            // 
            // Back_button1
            // 
            this.Back_button1.BackColor = System.Drawing.Color.Transparent;
            this.Back_button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Back_button1.Location = new System.Drawing.Point(3, 0);
            this.Back_button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Back_button1.Name = "Back_button1";
            this.Back_button1.Size = new System.Drawing.Size(131, 55);
            this.Back_button1.TabIndex = 22;
            this.Back_button1.Text = "Back";
            this.Back_button1.UseVisualStyleBackColor = false;
            this.Back_button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Search_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(790, 591);
            this.Controls.Add(this.Back_button1);
            this.Controls.Add(this.ExitAdmin_button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Search_Panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Panel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SearchAdmin_button1;
        private Panel panel1;
        private TextBox textBox1;
        private Label label1;
        private Button ExitAdmin_button1;
        private Button Back_button1;
    }
}