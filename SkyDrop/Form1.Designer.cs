namespace SkyDrop
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelSadrzaj = new System.Windows.Forms.Panel();
            this.btnDronovi = new System.Windows.Forms.Button();
            this.btnRute = new System.Windows.Forms.Button();
            this.btnPaketi = new System.Windows.Forms.Button();
            this.btnIzvjestaji = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelSadrzaj, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.menuStrip1, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(76, 24);
            this.toolStripMenuItem1.Text = "Dronovi";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(53, 24);
            this.toolStripMenuItem2.Text = "Rute";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(62, 24);
            this.toolStripMenuItem3.Text = "Paketi";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(80, 24);
            this.toolStripMenuItem4.Text = "Izvještaji";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnDronovi);
            this.flowLayoutPanel1.Controls.Add(this.btnRute);
            this.flowLayoutPanel1.Controls.Add(this.btnPaketi);
            this.flowLayoutPanel1.Controls.Add(this.btnIzvjestaji);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 43);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(174, 404);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // panelSadrzaj
            // 
            this.panelSadrzaj.BackColor = System.Drawing.Color.White;
            this.panelSadrzaj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSadrzaj.Location = new System.Drawing.Point(183, 43);
            this.panelSadrzaj.Name = "panelSadrzaj";
            this.panelSadrzaj.Size = new System.Drawing.Size(614, 404);
            this.panelSadrzaj.TabIndex = 2;
            this.panelSadrzaj.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSadrzaj_Paint);
            // 
            // btnDronovi
            // 
            this.btnDronovi.Image = global::SkyDrop.Properties.Resources.ikona_dronovi3;
            this.btnDronovi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDronovi.Location = new System.Drawing.Point(3, 3);
            this.btnDronovi.Name = "btnDronovi";
            this.btnDronovi.Size = new System.Drawing.Size(160, 60);
            this.btnDronovi.TabIndex = 0;
            this.btnDronovi.Text = "Dronovi";
            this.btnDronovi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDronovi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDronovi.UseVisualStyleBackColor = true;
            this.btnDronovi.Click += new System.EventHandler(this.btnDronovi_Click);
            // 
            // btnRute
            // 
            this.btnRute.Image = global::SkyDrop.Properties.Resources.ikona_rute3;
            this.btnRute.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRute.Location = new System.Drawing.Point(3, 69);
            this.btnRute.Name = "btnRute";
            this.btnRute.Size = new System.Drawing.Size(160, 60);
            this.btnRute.TabIndex = 1;
            this.btnRute.Text = "Rute";
            this.btnRute.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRute.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRute.UseVisualStyleBackColor = true;
            this.btnRute.Click += new System.EventHandler(this.btnRute_Click);
            // 
            // btnPaketi
            // 
            this.btnPaketi.Image = global::SkyDrop.Properties.Resources.ikona_paketi3;
            this.btnPaketi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaketi.Location = new System.Drawing.Point(3, 135);
            this.btnPaketi.Name = "btnPaketi";
            this.btnPaketi.Size = new System.Drawing.Size(160, 60);
            this.btnPaketi.TabIndex = 2;
            this.btnPaketi.Text = "Paketi";
            this.btnPaketi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPaketi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPaketi.UseVisualStyleBackColor = true;
            this.btnPaketi.Click += new System.EventHandler(this.btnPaketi_Click);
            // 
            // btnIzvjestaji
            // 
            this.btnIzvjestaji.Image = global::SkyDrop.Properties.Resources.ikona_izvjestaji3;
            this.btnIzvjestaji.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIzvjestaji.Location = new System.Drawing.Point(3, 201);
            this.btnIzvjestaji.Name = "btnIzvjestaji";
            this.btnIzvjestaji.Size = new System.Drawing.Size(160, 60);
            this.btnIzvjestaji.TabIndex = 3;
            this.btnIzvjestaji.Text = "Izvjestaji";
            this.btnIzvjestaji.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIzvjestaji.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIzvjestaji.UseVisualStyleBackColor = true;
            this.btnIzvjestaji.Click += new System.EventHandler(this.btnIzvjestaji_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnDronovi;
        private System.Windows.Forms.Button btnRute;
        private System.Windows.Forms.Button btnPaketi;
        private System.Windows.Forms.Button btnIzvjestaji;
        private System.Windows.Forms.Panel panelSadrzaj;
    }
}

