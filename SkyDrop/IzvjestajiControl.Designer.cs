namespace SkyDrop
{
    partial class IzvjestajiControl
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
            this.lblIzvjestaj = new System.Windows.Forms.Label();
            this.cmbIzvjestaji = new System.Windows.Forms.ComboBox();
            this.panelSadrzaj = new System.Windows.Forms.Panel();
            this.dgvIzvjestaj = new System.Windows.Forms.DataGridView();
            this.chartIzvjestaj = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelSadrzaj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzvjestaj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartIzvjestaj)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panelTop, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelSadrzaj, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelBottom, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(950, 600);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lblIzvjestaj);
            this.panelTop.Controls.Add(this.cmbIzvjestaji);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTop.Location = new System.Drawing.Point(3, 3);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(944, 64);
            this.panelTop.TabIndex = 0;
            // 
            // lblIzvjestaj
            // 
            this.lblIzvjestaj.AutoSize = true;
            this.lblIzvjestaj.Location = new System.Drawing.Point(16, 23);
            this.lblIzvjestaj.Name = "lblIzvjestaj";
            this.lblIzvjestaj.Size = new System.Drawing.Size(104, 16);
            this.lblIzvjestaj.TabIndex = 0;
            this.lblIzvjestaj.Text = "Odaberi izvještaj:";
            // 
            // cmbIzvjestaji
            // 
            this.cmbIzvjestaji.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIzvjestaji.FormattingEnabled = true;
            this.cmbIzvjestaji.Location = new System.Drawing.Point(126, 19);
            this.cmbIzvjestaji.Name = "cmbIzvjestaji";
            this.cmbIzvjestaji.Size = new System.Drawing.Size(420, 24);
            this.cmbIzvjestaji.TabIndex = 1;
            this.cmbIzvjestaji.SelectedIndexChanged += new System.EventHandler(this.cmbIzvjestaji_SelectedIndexChanged);
            // 
            // panelSadrzaj
            // 
            this.panelSadrzaj.Controls.Add(this.dgvIzvjestaj);
            this.panelSadrzaj.Controls.Add(this.chartIzvjestaj);
            this.panelSadrzaj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSadrzaj.Location = new System.Drawing.Point(3, 73);
            this.panelSadrzaj.Name = "panelSadrzaj";
            this.panelSadrzaj.Size = new System.Drawing.Size(944, 464);
            this.panelSadrzaj.TabIndex = 1;
            // 
            // dgvIzvjestaj
            // 
            this.dgvIzvjestaj.AllowUserToAddRows = false;
            this.dgvIzvjestaj.AllowUserToDeleteRows = false;
            this.dgvIzvjestaj.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIzvjestaj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIzvjestaj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIzvjestaj.Location = new System.Drawing.Point(0, 0);
            this.dgvIzvjestaj.MultiSelect = false;
            this.dgvIzvjestaj.Name = "dgvIzvjestaj";
            this.dgvIzvjestaj.ReadOnly = true;
            this.dgvIzvjestaj.RowHeadersVisible = false;
            this.dgvIzvjestaj.RowTemplate.Height = 24;
            this.dgvIzvjestaj.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIzvjestaj.Size = new System.Drawing.Size(944, 464);
            this.dgvIzvjestaj.TabIndex = 0;
            // 
            // chartIzvjestaj
            // 
            this.chartIzvjestaj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartIzvjestaj.Location = new System.Drawing.Point(0, 0);
            this.chartIzvjestaj.Name = "chartIzvjestaj";
            this.chartIzvjestaj.Size = new System.Drawing.Size(944, 464);
            this.chartIzvjestaj.TabIndex = 1;
            this.chartIzvjestaj.Text = "chart1";
            this.chartIzvjestaj.Visible = false;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnPovratak);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottom.Location = new System.Drawing.Point(3, 543);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(944, 54);
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
            // IzvjestajiControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "IzvjestajiControl";
            this.Size = new System.Drawing.Size(950, 600);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelSadrzaj.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzvjestaj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartIzvjestaj)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

            this.Load += new System.EventHandler(this.IzvjestajiControl_Load);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblIzvjestaj;
        private System.Windows.Forms.ComboBox cmbIzvjestaji;
        private System.Windows.Forms.Panel panelSadrzaj;
        private System.Windows.Forms.DataGridView dgvIzvjestaj;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartIzvjestaj;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnPovratak;
    }
}
