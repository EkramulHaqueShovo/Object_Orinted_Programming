namespace CurrencyExchange
{
    partial class Form1
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
            this.textBox_Input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.USD_label = new System.Windows.Forms.Label();
            this.EUR_label = new System.Windows.Forms.Label();
            this.GBP_label = new System.Windows.Forms.Label();
            this.indi_label2 = new System.Windows.Forms.Label();
            this.Nepal_label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Pakistani_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Input
            // 
            this.textBox_Input.Location = new System.Drawing.Point(136, 124);
            this.textBox_Input.Multiline = true;
            this.textBox_Input.Name = "textBox_Input";
            this.textBox_Input.Size = new System.Drawing.Size(507, 42);
            this.textBox_Input.TabIndex = 0;
            this.textBox_Input.TextChanged += new System.EventHandler(this.textBox_Input_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter The Amount(BDT) :";
            // 
            // USD_label
            // 
            this.USD_label.AutoSize = true;
            this.USD_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USD_label.Location = new System.Drawing.Point(399, 219);
            this.USD_label.Name = "USD_label";
            this.USD_label.Size = new System.Drawing.Size(0, 29);
            this.USD_label.TabIndex = 2;
            // 
            // EUR_label
            // 
            this.EUR_label.AutoSize = true;
            this.EUR_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EUR_label.Location = new System.Drawing.Point(399, 267);
            this.EUR_label.Name = "EUR_label";
            this.EUR_label.Size = new System.Drawing.Size(0, 29);
            this.EUR_label.TabIndex = 3;
            this.EUR_label.Click += new System.EventHandler(this.EUR_label_Click);
            // 
            // GBP_label
            // 
            this.GBP_label.AutoSize = true;
            this.GBP_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBP_label.Location = new System.Drawing.Point(399, 315);
            this.GBP_label.Name = "GBP_label";
            this.GBP_label.Size = new System.Drawing.Size(0, 29);
            this.GBP_label.TabIndex = 4;
            // 
            // indi_label2
            // 
            this.indi_label2.AutoSize = true;
            this.indi_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indi_label2.Location = new System.Drawing.Point(399, 369);
            this.indi_label2.Name = "indi_label2";
            this.indi_label2.Size = new System.Drawing.Size(0, 29);
            this.indi_label2.TabIndex = 5;
            // 
            // Nepal_label3
            // 
            this.Nepal_label3.AutoSize = true;
            this.Nepal_label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nepal_label3.Location = new System.Drawing.Point(399, 421);
            this.Nepal_label3.Name = "Nepal_label3";
            this.Nepal_label3.Size = new System.Drawing.Size(0, 29);
            this.Nepal_label3.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(222, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "USD Rate :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(207, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nepal Rate :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(231, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "IND Rate :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(222, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "GBP Rate :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(222, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "EUR Rate :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(207, 478);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "Pakistani Rate :";
            // 
            // Pakistani_label
            // 
            this.Pakistani_label.AutoSize = true;
            this.Pakistani_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pakistani_label.Location = new System.Drawing.Point(399, 478);
            this.Pakistani_label.Name = "Pakistani_label";
            this.Pakistani_label.Size = new System.Drawing.Size(0, 29);
            this.Pakistani_label.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 588);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Pakistani_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nepal_label3);
            this.Controls.Add(this.indi_label2);
            this.Controls.Add(this.GBP_label);
            this.Controls.Add(this.EUR_label);
            this.Controls.Add(this.USD_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CurrencyExchange";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label USD_label;
        private System.Windows.Forms.Label EUR_label;
        private System.Windows.Forms.Label GBP_label;
        private System.Windows.Forms.Label indi_label2;
        private System.Windows.Forms.Label Nepal_label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Pakistani_label;
    }
}

