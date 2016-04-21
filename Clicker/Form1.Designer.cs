namespace Clicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Numeric_Clicks_Delay = new System.Windows.Forms.NumericUpDown();
            this.Numeric_Clicks = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Clicks_Delay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Clicks)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(55, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Q";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Клавиша, по по которой сработает клик:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Задержка между кликами [мс]:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Кликов за нажатие:";
            // 
            // Numeric_Clicks_Delay
            // 
            this.Numeric_Clicks_Delay.Location = new System.Drawing.Point(185, 91);
            this.Numeric_Clicks_Delay.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.Numeric_Clicks_Delay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Numeric_Clicks_Delay.Name = "Numeric_Clicks_Delay";
            this.Numeric_Clicks_Delay.Size = new System.Drawing.Size(51, 20);
            this.Numeric_Clicks_Delay.TabIndex = 3;
            this.Numeric_Clicks_Delay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Numeric_Clicks_Delay.ValueChanged += new System.EventHandler(this.Numeric_Clicks_Delay_ValueChanged);
            // 
            // Numeric_Clicks
            // 
            this.Numeric_Clicks.Location = new System.Drawing.Point(126, 62);
            this.Numeric_Clicks.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Numeric_Clicks.Name = "Numeric_Clicks";
            this.Numeric_Clicks.Size = new System.Drawing.Size(53, 20);
            this.Numeric_Clicks.TabIndex = 3;
            this.Numeric_Clicks.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Numeric_Clicks.ValueChanged += new System.EventHandler(this.Numeric_Clicks_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 120);
            this.Controls.Add(this.Numeric_Clicks);
            this.Controls.Add(this.Numeric_Clicks_Delay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clicker";
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Clicks_Delay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Clicks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Numeric_Clicks_Delay;
        private System.Windows.Forms.NumericUpDown Numeric_Clicks;
    }
}

