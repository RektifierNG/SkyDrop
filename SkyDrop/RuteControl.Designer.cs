namespace SkyDrop
{
    partial class RuteControl
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
            this.lblOd = new System.Windows.Forms.Label();
            this.dtpOd = new System.Windows.Forms.DateTimePicker();
            this.lblDo = new System.Windows.Forms.Label();
            this.dtpDo = new System.Windows.Forms.DateTimePicker();
            this.btnFiltriraj = new System.Windows.Forms.Button();
            this.dgvRute = new System.Windows.Forms.DataGridView();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnCsv = new System.Windows.Forms.Button();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRute)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panelTop, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvRute, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelBottom, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Size = new System.Drawing.Size(900, 500);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lblOd);
            this.panelTop.Controls.Add(this.dtpOd);
            this.panelTop.Controls.Add(this.lblDo);
            this.panelTop.Controls.Add(this.dtpDo);
            this.panelTop.Controls.Add(this.btnFiltriraj);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTop.Location = new System.Drawing.Point(3, 3);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(894, 54);
            this.panelTop.TabIndex = 0;
            // 
            // lblOd
            // 
            this.lblOd.AutoSize = true;
            this.lblOd.Location = new System.Drawing.Point(15, 18);
            this.lblOd.Name = "lblOd";
            this.lblOd.Size = new System.Drawing.Size(28, 16);
            this.lblOd.TabIndex = 0;
            this.lblOd.Text = "Od:";
            // 
            // dtpOd
            // 
            this.dtpOd.CustomFormat = "dd.MM.yyyy.";
            this.dtpOd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOd.Location = new System.Drawing.Point(50, 14);
            this.dtpOd.Name = "dtpOd";
            this.dtpOd.Size = new System.Drawing.Size(140, 22);
            this.dtpOd.TabIndex = 1;
            // 
            // lblDo
            // 
            this.lblDo.AutoSize = true;
            this.lblDo.Location = new System.Drawing.Point(210, 18);
            this.lblDo.Name = "lblDo";
            this.lblDo.Size = new System.Drawing.Size(27, 16);
            this.lblDo.TabIndex = 2;
            this.lblDo.Text = "Do:";
            // 
            // dtpDo
            // 
            this.dtpDo.CustomFormat = "dd.MM.yyyy.";
            this.dtpDo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDo.Location = new System.Drawing.Point(245, 14);
            this.dtpDo.Name = "dtpDo";
            this.dtpDo.Size = new System.Drawing.Size(140, 22);
            this.dtpDo.TabIndex = 3;
            // 
            // btnFiltriraj
            // 
            this.btnFiltriraj.Location = new System.Drawing.Point(410, 12);
            this.btnFiltriraj.Name = "btnFiltriraj";
            this.btnFiltriraj.Size = new System.Drawing.Size(100, 28);
            this.btnFiltriraj.TabIndex = 4;
            this.btnFiltriraj.Text = "Filtriraj";
            this.btnFiltriraj.UseVisualStyleBackColor = true;
            this.btnFiltriraj.Click += new System.EventHandler(this.btnFiltriraj_Click);
            // 
            // dgvRute
            // 
            this.dgvRute.AllowUserToAddRows = false;
            this.dgvRute.AllowUserToDeleteRows = false;
            this.dgvRute.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRute.Location = new System.Drawing.Point(3, 63);
            this.dgvRute.MultiSelect = false;
            this.dgvRute.Name = "dgvRute";
            this.dgvRute.ReadOnly = true;
            this.dgvRute.RowHeadersVisible = false;
            this.dgvRute.RowTemplate.Height = 24;
            this.dgvRute.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRute.Size = new System.Drawing.Size(894, 374);
            this.dgvRute.TabIndex = 1;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnCsv);
            this.panelBottom.Controls.Add(this.btnPovratak);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottom.Location = new System.Drawing.Point(3, 443);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(894, 54);
            this.panelBottom.TabIndex = 2;
            // 
            // btnCsv
            // 
            this.btnCsv.Location = new System.Drawing.Point(15, 13);
            this.btnCsv.Name = "btnCsv";
            this.btnCsv.Size = new System.Drawing.Size(130, 30);
            this.btnCsv.TabIndex = 0;
            this.btnCsv.Text = "IZVEZI U CSV";
            this.btnCsv.UseVisualStyleBackColor = true;
            this.btnCsv.Click += new System.EventHandler(this.btnCsv_Click);
            // 
            // btnPovratak
            // 
            this.btnPovratak.Location = new System.Drawing.Point(160, 13);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(100, 30);
            this.btnPovratak.TabIndex = 1;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // RuteControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RuteControl";
            this.Size = new System.Drawing.Size(900, 500);
            this.Load += new System.EventHandler(this.RuteControl_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRute)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblOd;
        private System.Windows.Forms.DateTimePicker dtpOd;
        private System.Windows.Forms.Label lblDo;
        private System.Windows.Forms.DateTimePicker dtpDo;
        private System.Windows.Forms.Button btnFiltriraj;
        private System.Windows.Forms.DataGridView dgvRute;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnCsv;
        private System.Windows.Forms.Button btnPovratak;
    }
}