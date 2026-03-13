namespace SkyDrop
{
    partial class PaketiControl
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblRuta = new System.Windows.Forms.Label();
            this.cmbRute = new System.Windows.Forms.ComboBox();
            this.btnDodajPaket = new System.Windows.Forms.Button();
            this.dgvPaketi = new System.Windows.Forms.DataGridView();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaketi)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panelTop, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvPaketi, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelBottom, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(900, 550);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lblRuta);
            this.panelTop.Controls.Add(this.cmbRute);
            this.panelTop.Controls.Add(this.btnDodajPaket);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTop.Location = new System.Drawing.Point(3, 3);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(894, 64);
            this.panelTop.TabIndex = 0;
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Location = new System.Drawing.Point(16, 24);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(92, 16);
            this.lblRuta.TabIndex = 0;
            this.lblRuta.Text = "Odaberi rutu:";
            // 
            // cmbRute
            // 
            this.cmbRute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRute.FormattingEnabled = true;
            this.cmbRute.Location = new System.Drawing.Point(114, 20);
            this.cmbRute.Name = "cmbRute";
            this.cmbRute.Size = new System.Drawing.Size(320, 24);
            this.cmbRute.TabIndex = 1;
            this.cmbRute.SelectedIndexChanged += new System.EventHandler(cmbRute_SelectedIndexChanged);
            // 
            // btnDodajPaket
            // 
            this.btnDodajPaket.Location = new System.Drawing.Point(456, 17);
            this.btnDodajPaket.Name = "btnDodajPaket";
            this.btnDodajPaket.Size = new System.Drawing.Size(170, 30);
            this.btnDodajPaket.TabIndex = 2;
            this.btnDodajPaket.Text = "DODAJ PAKET NA RUTU";
            this.btnDodajPaket.UseVisualStyleBackColor = true;
            this.btnDodajPaket.Click += new System.EventHandler(btnDodajPaket_Click);
            // 
            // dgvPaketi
            // 
            this.dgvPaketi.AllowUserToAddRows = false;
            this.dgvPaketi.AllowUserToDeleteRows = false;
            this.dgvPaketi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPaketi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaketi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPaketi.Location = new System.Drawing.Point(3, 73);
            this.dgvPaketi.MultiSelect = false;
            this.dgvPaketi.Name = "dgvPaketi";
            this.dgvPaketi.ReadOnly = true;
            this.dgvPaketi.RowHeadersVisible = false;
            this.dgvPaketi.RowTemplate.Height = 24;
            this.dgvPaketi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPaketi.Size = new System.Drawing.Size(894, 414);
            this.dgvPaketi.TabIndex = 1;
            
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnPovratak);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottom.Location = new System.Drawing.Point(3, 493);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(894, 54);
            this.panelBottom.TabIndex = 2;
            // 
            // btnPovratak
            // 
            this.btnPovratak.Location = new System.Drawing.Point(16, 12);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(100, 30);
            this.btnPovratak.TabIndex = 0;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // PaketiControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PaketiControl";
            this.Size = new System.Drawing.Size(900, 550);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaketi)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.Load += new System.EventHandler (this.PaketiControl_Load);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.ComboBox cmbRute;
        private System.Windows.Forms.Button btnDodajPaket;
        private System.Windows.Forms.DataGridView dgvPaketi;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnPovratak;
    }
}
