namespace WindowsFormsApp3
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
            this.Convert = new System.Windows.Forms.Button();
            this.Send = new System.Windows.Forms.Button();
            this.InDisplay = new System.Windows.Forms.TextBox();
            this.Restart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OutDisplay = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BinDisplay = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Convert
            // 
            this.Convert.AutoSize = true;
            this.Convert.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Convert.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.Convert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Convert.Location = new System.Drawing.Point(426, 122);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(91, 43);
            this.Convert.TabIndex = 0;
            this.Convert.Text = "Convert";
            this.Convert.UseVisualStyleBackColor = false;
            this.Convert.Click += new System.EventHandler(this.ConvertClick);
            // 
            // Send
            // 
            this.Send.AutoSize = true;
            this.Send.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Send.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Send.Location = new System.Drawing.Point(426, 171);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(91, 43);
            this.Send.TabIndex = 3;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = false;
            this.Send.Click += new System.EventHandler(this.SendClick);
            // 
            // InDisplay
            // 
            this.InDisplay.Location = new System.Drawing.Point(47, 72);
            this.InDisplay.MinimumSize = new System.Drawing.Size(300, 100);
            this.InDisplay.Multiline = true;
            this.InDisplay.Name = "InDisplay";
            this.InDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InDisplay.Size = new System.Drawing.Size(300, 141);
            this.InDisplay.TabIndex = 7;
            this.InDisplay.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // Restart
            // 
            this.Restart.AutoSize = true;
            this.Restart.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Restart.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.Restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restart.Location = new System.Drawing.Point(426, 73);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(91, 43);
            this.Restart.TabIndex = 8;
            this.Restart.Text = "Restart";
            this.Restart.UseVisualStyleBackColor = false;
            this.Restart.Click += new System.EventHandler(this.RestartClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Wejście";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(699, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Wyjście";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(412, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "Konwersja";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // OutDisplay
            // 
            this.OutDisplay.BackColor = System.Drawing.SystemColors.Window;
            this.OutDisplay.Location = new System.Drawing.Point(597, 72);
            this.OutDisplay.MinimumSize = new System.Drawing.Size(300, 100);
            this.OutDisplay.Multiline = true;
            this.OutDisplay.Name = "OutDisplay";
            this.OutDisplay.ReadOnly = true;
            this.OutDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OutDisplay.Size = new System.Drawing.Size(300, 141);
            this.OutDisplay.TabIndex = 14;
            this.OutDisplay.TextChanged += new System.EventHandler(this.OutDisplay_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp3.Properties.Resources.strzalka_dol;
            this.pictureBox1.Location = new System.Drawing.Point(141, 219);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp3.Properties.Resources.strzalka_gora;
            this.pictureBox2.Location = new System.Drawing.Point(704, 224);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(104, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // BinDisplay
            // 
            this.BinDisplay.Location = new System.Drawing.Point(47, 311);
            this.BinDisplay.Name = "BinDisplay";
            this.BinDisplay.ReadOnly = true;
            this.BinDisplay.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.BinDisplay.Size = new System.Drawing.Size(850, 166);
            this.BinDisplay.TabIndex = 17;
            this.BinDisplay.Text = "";
            this.BinDisplay.TextChanged += new System.EventHandler(this.BinDisplay_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(941, 516);
            this.Controls.Add(this.BinDisplay);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.OutDisplay);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.InDisplay);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.Convert);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.TextBox InDisplay;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox OutDisplay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox BinDisplay;
    }
}

