namespace FileMover
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaKonumlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konumlarıKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konumlarıYükleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelSource = new System.Windows.Forms.Label();
            this.labelPathSource = new System.Windows.Forms.Label();
            this.buttonPathSource = new System.Windows.Forms.Button();
            this.buttonPathTarget1 = new System.Windows.Forms.Button();
            this.labelPathTarget1 = new System.Windows.Forms.Label();
            this.labelTarget1 = new System.Windows.Forms.Label();
            this.buttonPathTarget2 = new System.Windows.Forms.Button();
            this.labelPathTarget2 = new System.Windows.Forms.Label();
            this.labelTarget2 = new System.Windows.Forms.Label();
            this.buttonMove = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.checkBoxTarget2 = new System.Windows.Forms.CheckBox();
            this.groupBoxTarget2 = new System.Windows.Forms.GroupBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBoxTarget2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaKonumlarıToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MinimumSize = new System.Drawing.Size(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(737, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaKonumlarıToolStripMenuItem
            // 
            this.dosyaKonumlarıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.konumlarıKaydetToolStripMenuItem,
            this.konumlarıYükleToolStripMenuItem});
            this.dosyaKonumlarıToolStripMenuItem.Name = "dosyaKonumlarıToolStripMenuItem";
            this.dosyaKonumlarıToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.dosyaKonumlarıToolStripMenuItem.Text = "Dosya Konumları";
            // 
            // konumlarıKaydetToolStripMenuItem
            // 
            this.konumlarıKaydetToolStripMenuItem.Name = "konumlarıKaydetToolStripMenuItem";
            this.konumlarıKaydetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.konumlarıKaydetToolStripMenuItem.Text = "Konumları kaydet";
            this.konumlarıKaydetToolStripMenuItem.Click += new System.EventHandler(this.konumlarıKaydetToolStripMenuItem_Click);
            // 
            // konumlarıYükleToolStripMenuItem
            // 
            this.konumlarıYükleToolStripMenuItem.Name = "konumlarıYükleToolStripMenuItem";
            this.konumlarıYükleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.konumlarıYükleToolStripMenuItem.Text = "Konumları yükle";
            this.konumlarıYükleToolStripMenuItem.Click += new System.EventHandler(this.konumlarıYükleToolStripMenuItem_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hakkındaToolStripMenuItem});
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.hakkındaToolStripMenuItem_Click);
            // 
            // labelSource
            // 
            this.labelSource.AutoSize = true;
            this.labelSource.Location = new System.Drawing.Point(12, 81);
            this.labelSource.Name = "labelSource";
            this.labelSource.Size = new System.Drawing.Size(150, 13);
            this.labelSource.TabIndex = 1;
            this.labelSource.Text = "Taranmış Dosyaların Konumu: ";
            // 
            // labelPathSource
            // 
            this.labelPathSource.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPathSource.Location = new System.Drawing.Point(168, 81);
            this.labelPathSource.Name = "labelPathSource";
            this.labelPathSource.Size = new System.Drawing.Size(300, 13);
            this.labelPathSource.TabIndex = 2;
            this.labelPathSource.Text = "C:\\Users\\";
            // 
            // buttonPathSource
            // 
            this.buttonPathSource.Location = new System.Drawing.Point(674, 76);
            this.buttonPathSource.Name = "buttonPathSource";
            this.buttonPathSource.Size = new System.Drawing.Size(42, 23);
            this.buttonPathSource.TabIndex = 3;
            this.buttonPathSource.Text = "Seç";
            this.buttonPathSource.UseVisualStyleBackColor = true;
            this.buttonPathSource.Click += new System.EventHandler(this.buttonPathSource_Click);
            // 
            // buttonPathTarget1
            // 
            this.buttonPathTarget1.Location = new System.Drawing.Point(674, 105);
            this.buttonPathTarget1.Name = "buttonPathTarget1";
            this.buttonPathTarget1.Size = new System.Drawing.Size(42, 23);
            this.buttonPathTarget1.TabIndex = 6;
            this.buttonPathTarget1.Text = "Seç";
            this.buttonPathTarget1.UseVisualStyleBackColor = true;
            this.buttonPathTarget1.Click += new System.EventHandler(this.buttonPathTarget1_Click);
            // 
            // labelPathTarget1
            // 
            this.labelPathTarget1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPathTarget1.Location = new System.Drawing.Point(168, 110);
            this.labelPathTarget1.Name = "labelPathTarget1";
            this.labelPathTarget1.Size = new System.Drawing.Size(300, 13);
            this.labelPathTarget1.TabIndex = 5;
            this.labelPathTarget1.Text = "C:\\Users\\";
            // 
            // labelTarget1
            // 
            this.labelTarget1.AutoSize = true;
            this.labelTarget1.Location = new System.Drawing.Point(12, 110);
            this.labelTarget1.Name = "labelTarget1";
            this.labelTarget1.Size = new System.Drawing.Size(78, 13);
            this.labelTarget1.TabIndex = 4;
            this.labelTarget1.Text = "Hedef Konum: ";
            // 
            // buttonPathTarget2
            // 
            this.buttonPathTarget2.Location = new System.Drawing.Point(668, 17);
            this.buttonPathTarget2.Name = "buttonPathTarget2";
            this.buttonPathTarget2.Size = new System.Drawing.Size(42, 23);
            this.buttonPathTarget2.TabIndex = 9;
            this.buttonPathTarget2.Text = "Seç";
            this.buttonPathTarget2.UseVisualStyleBackColor = true;
            this.buttonPathTarget2.Click += new System.EventHandler(this.buttonPathTarget2_Click);
            // 
            // labelPathTarget2
            // 
            this.labelPathTarget2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPathTarget2.Location = new System.Drawing.Point(162, 22);
            this.labelPathTarget2.Name = "labelPathTarget2";
            this.labelPathTarget2.Size = new System.Drawing.Size(300, 13);
            this.labelPathTarget2.TabIndex = 8;
            this.labelPathTarget2.Text = "C:\\Users\\";
            // 
            // labelTarget2
            // 
            this.labelTarget2.AutoSize = true;
            this.labelTarget2.Location = new System.Drawing.Point(6, 22);
            this.labelTarget2.Name = "labelTarget2";
            this.labelTarget2.Size = new System.Drawing.Size(84, 13);
            this.labelTarget2.TabIndex = 7;
            this.labelTarget2.Text = "2. Hedef Konum";
            // 
            // buttonMove
            // 
            this.buttonMove.Location = new System.Drawing.Point(388, 264);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(80, 56);
            this.buttonMove.TabIndex = 10;
            this.buttonMove.Text = "TAŞI";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(266, 264);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(80, 56);
            this.buttonCopy.TabIndex = 11;
            this.buttonCopy.Text = "KOPYALA";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // checkBoxTarget2
            // 
            this.checkBoxTarget2.AutoSize = true;
            this.checkBoxTarget2.Checked = true;
            this.checkBoxTarget2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTarget2.Location = new System.Drawing.Point(15, 217);
            this.checkBoxTarget2.Name = "checkBoxTarget2";
            this.checkBoxTarget2.Size = new System.Drawing.Size(71, 17);
            this.checkBoxTarget2.TabIndex = 12;
            this.checkBoxTarget2.Text = "2. Konum";
            this.checkBoxTarget2.UseVisualStyleBackColor = true;
            this.checkBoxTarget2.CheckedChanged += new System.EventHandler(this.checkBoxTarget2_CheckedChanged);
            // 
            // groupBoxTarget2
            // 
            this.groupBoxTarget2.Controls.Add(this.labelTarget2);
            this.groupBoxTarget2.Controls.Add(this.labelPathTarget2);
            this.groupBoxTarget2.Controls.Add(this.buttonPathTarget2);
            this.groupBoxTarget2.Location = new System.Drawing.Point(6, 147);
            this.groupBoxTarget2.Name = "groupBoxTarget2";
            this.groupBoxTarget2.Size = new System.Drawing.Size(719, 54);
            this.groupBoxTarget2.TabIndex = 13;
            this.groupBoxTarget2.TabStop = false;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(12, 350);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(0, 13);
            this.labelInfo.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 381);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.checkBoxTarget2);
            this.Controls.Add(this.groupBoxTarget2);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.buttonPathTarget1);
            this.Controls.Add(this.labelPathTarget1);
            this.Controls.Add(this.labelTarget1);
            this.Controls.Add(this.buttonPathSource);
            this.Controls.Add(this.labelPathSource);
            this.Controls.Add(this.labelSource);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Dosya Taşıyıcı";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxTarget2.ResumeLayout(false);
            this.groupBoxTarget2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaKonumlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konumlarıKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konumlarıYükleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.Label labelSource;
        private System.Windows.Forms.Label labelPathSource;
        private System.Windows.Forms.Button buttonPathSource;
        private System.Windows.Forms.Button buttonPathTarget1;
        private System.Windows.Forms.Label labelPathTarget1;
        private System.Windows.Forms.Label labelTarget1;
        private System.Windows.Forms.Button buttonPathTarget2;
        private System.Windows.Forms.Label labelPathTarget2;
        private System.Windows.Forms.Label labelTarget2;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.CheckBox checkBoxTarget2;
        private System.Windows.Forms.GroupBox groupBoxTarget2;
        private System.Windows.Forms.Label labelInfo;
    }
}

