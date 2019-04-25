namespace IntroToWindforms
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
            this.SomethingButton = new System.Windows.Forms.Button();
            this.checkBox_failsafe = new System.Windows.Forms.CheckBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SomethingButton
            // 
            this.SomethingButton.Location = new System.Drawing.Point(327, 96);
            this.SomethingButton.Name = "SomethingButton";
            this.SomethingButton.Size = new System.Drawing.Size(384, 208);
            this.SomethingButton.TabIndex = 0;
            this.SomethingButton.Text = "Do Something Buttom";
            this.SomethingButton.UseVisualStyleBackColor = true;
            this.SomethingButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox_failsafe
            // 
            this.checkBox_failsafe.AutoSize = true;
            this.checkBox_failsafe.Location = new System.Drawing.Point(66, 96);
            this.checkBox_failsafe.Name = "checkBox_failsafe";
            this.checkBox_failsafe.Size = new System.Drawing.Size(59, 17);
            this.checkBox_failsafe.TabIndex = 1;
            this.checkBox_failsafe.Text = "failsafe";
            this.checkBox_failsafe.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(66, 174);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 2;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(54, 288);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(212, 92);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(54, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.checkBox_failsafe);
            this.Controls.Add(this.SomethingButton);
            this.Name = "Form1";
            this.Text = "Do Something";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SomethingButton;
        private System.Windows.Forms.CheckBox checkBox_failsafe;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox textBox1;
    }
}

