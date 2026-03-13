namespace SkyDrop
{
    partial class DronoviControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblOdaberi = new System.Windows.Forms.Label();
            this.cmbDronovi = new System.Windows.Forms.ComboBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblOdaberi, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbDronovi, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNaziv, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtModel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSpremi, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnPovratak, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(500, 87);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblOdaberi
            // 
            this.lblOdaberi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOdaberi.AutoSize = true;
            this.lblOdaberi.Location = new System.Drawing.Point(3, 7);
            this.lblOdaberi.Name = "lblOdaberi";
            this.lblOdaberi.Size = new System.Drawing.Size(89, 16);
            this.lblOdaberi.TabIndex = 0;
            this.lblOdaberi.Text = "Odaberi dron:";
            // 
            // cmbDronovi
            // 
            this.cmbDronovi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDronovi.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbDronovi.Location = new System.Drawing.Point(153, 3);
            this.cmbDronovi.Name = "cmbDronovi";
            this.cmbDronovi.Size = new System.Drawing.Size(250, 24);
            this.cmbDronovi.TabIndex = 1;
            this.cmbDronovi.SelectedIndexChanged += new System.EventHandler(this.cmbDronovi_SelectedIndexChanged);
            // 
            // lblNaziv
            // 
            this.lblNaziv.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(3, 36);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(93, 16);
            this.lblNaziv.TabIndex = 2;
            this.lblNaziv.Text = "Naziv modela:";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(153, 33);
            this.txtModel.MaxLength = 50;
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(250, 22);
            this.txtModel.TabIndex = 3;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(3, 61);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(130, 23);
            this.btnSpremi.TabIndex = 4;
            this.btnSpremi.Text = "Spremi promjene";
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnPovratak
            // 
            this.btnPovratak.Location = new System.Drawing.Point(153, 61);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(130, 23);
            this.btnPovratak.TabIndex = 5;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // DronoviControl
            // 
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DronoviControl";
            this.Size = new System.Drawing.Size(500, 200);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
            this.Load += new System.EventHandler(this.DronoviControl_Load);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblOdaberi;
        private System.Windows.Forms.ComboBox cmbDronovi;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnPovratak;
    }
}