namespace mk
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.ah = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ax = new System.Windows.Forms.Label();
            this.dx = new System.Windows.Forms.Label();
            this.cx = new System.Windows.Forms.Label();
            this.bx = new System.Windows.Forms.Label();
            this.rozkaz = new System.Windows.Forms.ComboBox();
            this.register1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.register2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.TextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.instrukcje = new System.Windows.Forms.TextBox();
            this.confirm = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.uwagi = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.holistic_mode = new System.Windows.Forms.Button();
            this.numeracja_linii = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.step_mode = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.bh = new System.Windows.Forms.Label();
            this.ch = new System.Windows.Forms.Label();
            this.dh = new System.Windows.Forms.Label();
            this.dl = new System.Windows.Forms.Label();
            this.cl = new System.Windows.Forms.Label();
            this.bl = new System.Windows.Forms.Label();
            this.al = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.zresetuj = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.aktualna_lin = new System.Windows.Forms.Label();
            this.ToFile = new System.Windows.Forms.Button();
            this.FromFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.FileNameBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.edytuj = new System.Windows.Forms.TextBox();
            this.edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Command";
            // 
            // ah
            // 
            this.ah.AutoSize = true;
            this.ah.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ah.ForeColor = System.Drawing.Color.Black;
            this.ah.Location = new System.Drawing.Point(652, 188);
            this.ah.MaximumSize = new System.Drawing.Size(35, 20);
            this.ah.MinimumSize = new System.Drawing.Size(120, 30);
            this.ah.Name = "ah";
            this.ah.Size = new System.Drawing.Size(120, 30);
            this.ah.TabIndex = 8;
            this.ah.Text = "00000000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(693, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 36);
            this.label4.TabIndex = 68;
            this.label4.Text = "Registers";
            // 
            // ax
            // 
            this.ax.AutoSize = true;
            this.ax.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ax.Location = new System.Drawing.Point(599, 188);
            this.ax.MinimumSize = new System.Drawing.Size(0, 40);
            this.ax.Name = "ax";
            this.ax.Size = new System.Drawing.Size(47, 40);
            this.ax.TabIndex = 69;
            this.ax.Text = "ax";
            // 
            // dx
            // 
            this.dx.AutoSize = true;
            this.dx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dx.Location = new System.Drawing.Point(601, 298);
            this.dx.Name = "dx";
            this.dx.Size = new System.Drawing.Size(47, 32);
            this.dx.TabIndex = 70;
            this.dx.Text = "dx";
            // 
            // cx
            // 
            this.cx.AutoSize = true;
            this.cx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cx.Location = new System.Drawing.Point(601, 261);
            this.cx.Name = "cx";
            this.cx.Size = new System.Drawing.Size(45, 32);
            this.cx.TabIndex = 71;
            this.cx.Text = "cx";
            // 
            // bx
            // 
            this.bx.AutoSize = true;
            this.bx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bx.Location = new System.Drawing.Point(599, 225);
            this.bx.Name = "bx";
            this.bx.Size = new System.Drawing.Size(47, 32);
            this.bx.TabIndex = 72;
            this.bx.Text = "bx";
            // 
            // rozkaz
            // 
            this.rozkaz.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.rozkaz.FormattingEnabled = true;
            this.rozkaz.Items.AddRange(new object[] {
            "mov",
            "add",
            "sub"});
            this.rozkaz.Location = new System.Drawing.Point(79, 104);
            this.rozkaz.Name = "rozkaz";
            this.rozkaz.Size = new System.Drawing.Size(105, 24);
            this.rozkaz.TabIndex = 73;
            this.rozkaz.SelectedIndexChanged += new System.EventHandler(this.rozkaz_SelectedIndexChanged);
            // 
            // register1
            // 
            this.register1.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.register1.FormattingEnabled = true;
            this.register1.Items.AddRange(new object[] {
            "ax",
            "bx",
            "cx",
            "dx"});
            this.register1.Location = new System.Drawing.Point(190, 104);
            this.register1.Name = "register1";
            this.register1.Size = new System.Drawing.Size(108, 24);
            this.register1.TabIndex = 75;
            this.register1.SelectedIndexChanged += new System.EventHandler(this.register1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(202, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 74;
            this.label5.Text = "Register 1";
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(317, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 76;
            this.label6.Text = "Register2";
            // 
            // register2
            // 
            this.register2.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.register2.FormattingEnabled = true;
            this.register2.Items.AddRange(new object[] {
            "ax",
            "bx",
            "cx",
            "dx"});
            this.register2.Location = new System.Drawing.Point(304, 104);
            this.register2.Name = "register2";
            this.register2.Size = new System.Drawing.Size(103, 24);
            this.register2.TabIndex = 78;
            this.register2.SelectedIndexChanged += new System.EventHandler(this.register2_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(460, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 79;
            this.label7.Text = "Number";
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(413, 104);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(95, 22);
            this.number.TabIndex = 80;
            this.number.TextChanged += new System.EventHandler(this.number_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // instrukcje
            // 
            this.instrukcje.Cursor = System.Windows.Forms.Cursors.No;
            this.instrukcje.Location = new System.Drawing.Point(79, 134);
            this.instrukcje.MaximumSize = new System.Drawing.Size(1000, 190);
            this.instrukcje.MinimumSize = new System.Drawing.Size(100, 190);
            this.instrukcje.Multiline = true;
            this.instrukcje.Name = "instrukcje";
            this.instrukcje.ReadOnly = true;
            this.instrukcje.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.instrukcje.Size = new System.Drawing.Size(480, 190);
            this.instrukcje.TabIndex = 82;
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(600, 115);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(77, 23);
            this.confirm.TabIndex = 83;
            this.confirm.Text = "OK";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(601, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 84;
            this.label3.Text = "Confirm";
            // 
            // label8
            // 
            this.label8.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 383);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 20);
            this.label8.TabIndex = 85;
            this.label8.Text = "Uwagi:";
            // 
            // uwagi
            // 
            this.uwagi.AutoSize = true;
            this.uwagi.Location = new System.Drawing.Point(96, 386);
            this.uwagi.Name = "uwagi";
            this.uwagi.Size = new System.Drawing.Size(20, 17);
            this.uwagi.TabIndex = 87;
            this.uwagi.Text = "...";
            // 
            // label9
            // 
            this.label9.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(682, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 20);
            this.label9.TabIndex = 89;
            this.label9.Text = "Holistic mode";
            // 
            // holistic_mode
            // 
            this.holistic_mode.Location = new System.Drawing.Point(710, 114);
            this.holistic_mode.Name = "holistic_mode";
            this.holistic_mode.Size = new System.Drawing.Size(73, 23);
            this.holistic_mode.TabIndex = 88;
            this.holistic_mode.Text = "OK";
            this.holistic_mode.UseVisualStyleBackColor = true;
            this.holistic_mode.Click += new System.EventHandler(this.holistic_mode_Click);
            // 
            // numeracja_linii
            // 
            this.numeracja_linii.Location = new System.Drawing.Point(27, 134);
            this.numeracja_linii.MaximumSize = new System.Drawing.Size(1000, 190);
            this.numeracja_linii.MinimumSize = new System.Drawing.Size(30, 190);
            this.numeracja_linii.Multiline = true;
            this.numeracja_linii.Name = "numeracja_linii";
            this.numeracja_linii.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.numeracja_linii.Size = new System.Drawing.Size(46, 190);
            this.numeracja_linii.TabIndex = 90;
            // 
            // label10
            // 
            this.label10.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(813, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 20);
            this.label10.TabIndex = 92;
            this.label10.Text = "Step mode";
            // 
            // step_mode
            // 
            this.step_mode.Location = new System.Drawing.Point(820, 114);
            this.step_mode.Name = "step_mode";
            this.step_mode.Size = new System.Drawing.Size(78, 23);
            this.step_mode.TabIndex = 91;
            this.step_mode.Text = "OK";
            this.step_mode.UseVisualStyleBackColor = true;
            this.step_mode.Click += new System.EventHandler(this.step_mode_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(514, 103);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(45, 23);
            this.button4.TabIndex = 93;
            this.button4.Text = "OK";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // bh
            // 
            this.bh.AutoSize = true;
            this.bh.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bh.ForeColor = System.Drawing.Color.Black;
            this.bh.Location = new System.Drawing.Point(652, 227);
            this.bh.MaximumSize = new System.Drawing.Size(35, 20);
            this.bh.MinimumSize = new System.Drawing.Size(120, 30);
            this.bh.Name = "bh";
            this.bh.Size = new System.Drawing.Size(120, 30);
            this.bh.TabIndex = 94;
            this.bh.Text = "00000000";
            // 
            // ch
            // 
            this.ch.AutoSize = true;
            this.ch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch.ForeColor = System.Drawing.Color.Black;
            this.ch.Location = new System.Drawing.Point(652, 263);
            this.ch.MaximumSize = new System.Drawing.Size(35, 20);
            this.ch.MinimumSize = new System.Drawing.Size(120, 30);
            this.ch.Name = "ch";
            this.ch.Size = new System.Drawing.Size(120, 30);
            this.ch.TabIndex = 95;
            this.ch.Text = "00000000";
            // 
            // dh
            // 
            this.dh.AutoSize = true;
            this.dh.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dh.ForeColor = System.Drawing.Color.Black;
            this.dh.Location = new System.Drawing.Point(652, 300);
            this.dh.MaximumSize = new System.Drawing.Size(35, 20);
            this.dh.MinimumSize = new System.Drawing.Size(120, 30);
            this.dh.Name = "dh";
            this.dh.Size = new System.Drawing.Size(120, 30);
            this.dh.TabIndex = 96;
            this.dh.Text = "00000000";
            // 
            // dl
            // 
            this.dl.AutoSize = true;
            this.dl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dl.ForeColor = System.Drawing.Color.Black;
            this.dl.Location = new System.Drawing.Point(778, 300);
            this.dl.MaximumSize = new System.Drawing.Size(35, 20);
            this.dl.MinimumSize = new System.Drawing.Size(120, 30);
            this.dl.Name = "dl";
            this.dl.Size = new System.Drawing.Size(120, 30);
            this.dl.TabIndex = 100;
            this.dl.Text = "00000000";
            // 
            // cl
            // 
            this.cl.AutoSize = true;
            this.cl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cl.ForeColor = System.Drawing.Color.Black;
            this.cl.Location = new System.Drawing.Point(778, 263);
            this.cl.MaximumSize = new System.Drawing.Size(35, 20);
            this.cl.MinimumSize = new System.Drawing.Size(120, 30);
            this.cl.Name = "cl";
            this.cl.Size = new System.Drawing.Size(120, 30);
            this.cl.TabIndex = 99;
            this.cl.Text = "00000000";
            // 
            // bl
            // 
            this.bl.AutoSize = true;
            this.bl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bl.ForeColor = System.Drawing.Color.Black;
            this.bl.Location = new System.Drawing.Point(778, 227);
            this.bl.MaximumSize = new System.Drawing.Size(35, 20);
            this.bl.MinimumSize = new System.Drawing.Size(120, 30);
            this.bl.Name = "bl";
            this.bl.Size = new System.Drawing.Size(120, 30);
            this.bl.TabIndex = 98;
            this.bl.Text = "00000000";
            // 
            // al
            // 
            this.al.AutoSize = true;
            this.al.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.al.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.al.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.al.ForeColor = System.Drawing.Color.Black;
            this.al.Location = new System.Drawing.Point(778, 188);
            this.al.MaximumSize = new System.Drawing.Size(35, 20);
            this.al.MinimumSize = new System.Drawing.Size(120, 30);
            this.al.Name = "al";
            this.al.Size = new System.Drawing.Size(120, 30);
            this.al.TabIndex = 97;
            this.al.Text = "00000000";
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 102;
            this.label2.Text = "Reset";
            // 
            // zresetuj
            // 
            this.zresetuj.Location = new System.Drawing.Point(28, 104);
            this.zresetuj.Name = "zresetuj";
            this.zresetuj.Size = new System.Drawing.Size(46, 23);
            this.zresetuj.TabIndex = 101;
            this.zresetuj.Text = "OK";
            this.zresetuj.UseVisualStyleBackColor = true;
            this.zresetuj.Click += new System.EventHandler(this.zresetuj_Click);
            // 
            // label11
            // 
            this.label11.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(24, 342);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(425, 18);
            this.label11.TabIndex = 103;
            this.label11.Text = "Aktualnie wykonywana instrukcja w trybie STEP MODE:";
            // 
            // aktualna_lin
            // 
            this.aktualna_lin.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.aktualna_lin.AutoSize = true;
            this.aktualna_lin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aktualna_lin.ForeColor = System.Drawing.Color.Crimson;
            this.aktualna_lin.Location = new System.Drawing.Point(499, 334);
            this.aktualna_lin.Name = "aktualna_lin";
            this.aktualna_lin.Size = new System.Drawing.Size(25, 29);
            this.aktualna_lin.TabIndex = 104;
            this.aktualna_lin.Text = "x";
            // 
            // ToFile
            // 
            this.ToFile.Location = new System.Drawing.Point(602, 393);
            this.ToFile.Name = "ToFile";
            this.ToFile.Size = new System.Drawing.Size(241, 23);
            this.ToFile.TabIndex = 105;
            this.ToFile.Text = "Upload code to file";
            this.ToFile.UseVisualStyleBackColor = true;
            this.ToFile.Click += new System.EventHandler(this.ToFile_Click);
            // 
            // FromFile
            // 
            this.FromFile.Location = new System.Drawing.Point(602, 422);
            this.FromFile.Name = "FromFile";
            this.FromFile.Size = new System.Drawing.Size(241, 23);
            this.FromFile.TabIndex = 106;
            this.FromFile.Text = "Download code from file";
            this.FromFile.UseVisualStyleBackColor = true;
            this.FromFile.Click += new System.EventHandler(this.FromFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FileNameBox
            // 
            this.FileNameBox.Location = new System.Drawing.Point(699, 365);
            this.FileNameBox.Name = "FileNameBox";
            this.FileNameBox.Size = new System.Drawing.Size(144, 22);
            this.FileNameBox.TabIndex = 107;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(584, 368);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 17);
            this.label12.TabIndex = 108;
            this.label12.Text = "Upload file name";
            // 
            // label13
            // 
            this.label13.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(24, 425);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 20);
            this.label13.TabIndex = 109;
            this.label13.Text = "Edytuj linijkę:";
            // 
            // edytuj
            // 
            this.edytuj.Location = new System.Drawing.Point(163, 425);
            this.edytuj.Name = "edytuj";
            this.edytuj.Size = new System.Drawing.Size(32, 22);
            this.edytuj.TabIndex = 110;
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(201, 425);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(46, 23);
            this.edit.TabIndex = 111;
            this.edit.Text = "OK";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 469);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.edytuj);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.FileNameBox);
            this.Controls.Add(this.FromFile);
            this.Controls.Add(this.ToFile);
            this.Controls.Add(this.aktualna_lin);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.zresetuj);
            this.Controls.Add(this.dl);
            this.Controls.Add(this.cl);
            this.Controls.Add(this.bl);
            this.Controls.Add(this.al);
            this.Controls.Add(this.dh);
            this.Controls.Add(this.ch);
            this.Controls.Add(this.bh);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.step_mode);
            this.Controls.Add(this.numeracja_linii);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.holistic_mode);
            this.Controls.Add(this.uwagi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.instrukcje);
            this.Controls.Add(this.number);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.register2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.register1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rozkaz);
            this.Controls.Add(this.bx);
            this.Controls.Add(this.cx);
            this.Controls.Add(this.dx);
            this.Controls.Add(this.ax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ah);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ah;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ax;
        private System.Windows.Forms.Label dx;
        private System.Windows.Forms.Label cx;
        private System.Windows.Forms.Label bx;
        private System.Windows.Forms.ComboBox rozkaz;
        private System.Windows.Forms.ComboBox register1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox register2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox instrukcje;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label uwagi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button holistic_mode;
        private System.Windows.Forms.TextBox numeracja_linii;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button step_mode;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label bh;
        private System.Windows.Forms.Label ch;
        private System.Windows.Forms.Label dh;
        private System.Windows.Forms.Label dl;
        private System.Windows.Forms.Label cl;
        private System.Windows.Forms.Label bl;
        private System.Windows.Forms.Label al;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button zresetuj;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label aktualna_lin;
        private System.Windows.Forms.Button ToFile;
        private System.Windows.Forms.Button FromFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox FileNameBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox edytuj;
        private System.Windows.Forms.Button edit;
    }
}

