namespace User_Interface
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.helpProvider1.SetHelpString(this.textBox1, "Enter your Card Number");
            this.textBox1.Location = new System.Drawing.Point(215, 60);
            this.textBox1.MaxLength = 16;
            this.textBox1.Name = "textBox1";
            this.helpProvider1.SetShowHelp(this.textBox1, true);
            this.textBox1.Size = new System.Drawing.Size(232, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.helpProvider1.SetHelpString(this.textBox2, "Enter the three digit number, usually shown on the back of the card");
            this.textBox2.Location = new System.Drawing.Point(378, 159);
            this.textBox2.MaxLength = 3;
            this.textBox2.Name = "textBox2";
            this.helpProvider1.SetShowHelp(this.textBox2, true);
            this.textBox2.Size = new System.Drawing.Size(69, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.helpProvider1.SetHelpString(this.label1, "Enter your Card Number");
            this.label1.Location = new System.Drawing.Point(140, 67);
            this.label1.Name = "label1";
            this.helpProvider1.SetShowHelp(this.label1, true);
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Card Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.helpProvider1.SetHelpString(this.label2, "Enter the card\'s expiration date");
            this.label2.Location = new System.Drawing.Point(130, 165);
            this.label2.Name = "label2";
            this.helpProvider1.SetShowHelp(this.label2, true);
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Expiration Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.helpProvider1.SetHelpString(this.label3, "Enter the three digit number, usually shown on the back of the card");
            this.label3.Location = new System.Drawing.Point(344, 166);
            this.label3.Name = "label3";
            this.helpProvider1.SetShowHelp(this.label3, true);
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "CVC";
            // 
            // textBox4
            // 
            this.helpProvider1.SetHelpString(this.textBox4, "Enter the name of the cardholder as shown on the card");
            this.textBox4.Location = new System.Drawing.Point(215, 105);
            this.textBox4.Name = "textBox4";
            this.helpProvider1.SetShowHelp(this.textBox4, true);
            this.textBox4.Size = new System.Drawing.Size(232, 20);
            this.textBox4.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.helpProvider1.SetHelpString(this.label4, "Enter the name of the cardholder as shown on the card");
            this.label4.Location = new System.Drawing.Point(120, 112);
            this.label4.Name = "label4";
            this.helpProvider1.SetShowHelp(this.label4, true);
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cardholder Name";
            // 
            // numericUpDown1
            // 
            this.helpProvider1.SetHelpString(this.numericUpDown1, "Enter the card\'s expiration date");
            this.numericUpDown1.Location = new System.Drawing.Point(213, 158);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.helpProvider1.SetShowHelp(this.numericUpDown1, true);
            this.numericUpDown1.Size = new System.Drawing.Size(38, 20);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.helpProvider1.SetHelpString(this.numericUpDown2, "Enter the card\'s expiration date");
            this.numericUpDown2.Location = new System.Drawing.Point(257, 158);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            2040,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.helpProvider1.SetShowHelp(this.numericUpDown2, true);
            this.numericUpDown2.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown2.TabIndex = 9;
            this.numericUpDown2.Value = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.helpProvider1.SetHelpString(this.button1, "Press to Complete the transaction");
            this.button1.Location = new System.Drawing.Point(257, 261);
            this.button1.Name = "button1";
            this.helpProvider1.SetShowHelp(this.button1, true);
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Complete Payment";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "D:\\Visual studio\\repos\\User Interface\\bin\\Debug\\new 4.html";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(610, 372);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Πληρωμή";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form4_FormClosed);
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}