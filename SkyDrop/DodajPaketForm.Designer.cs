namespace SkyDrop
{
    partial class DodajPaketForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblPaket;
        private System.Windows.Forms.ComboBox cmbPaketi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnOdustani;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblPaket = new System.Windows.Forms.Label();
            this.cmbPaketi = new System.Windows.Forms.ComboBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPaket
            // 
            this.lblPaket.AutoSize = true;
            this.lblPaket.Location = new System.Drawing.Point(20, 20);
            this.lblPaket.Name = "lblPaket";
            this.lblPaket.Size = new System.Drawing.Size(92, 16);
            this.lblPaket.Text = "Odaberi paket:";
            // 
            // cmbPaketi
            // 
            this.cmbPaketi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaketi.FormattingEnabled = true;
            this.cmbPaketi.Location = new System.Drawing.Point(23, 45);
            this.cmbPaketi.Name = "cmbPaketi";
            this.cmbPaketi.Size = new System.Drawing.Size(340, 24);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(23, 90);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(100, 30);
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(135, 90);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(100, 30);
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // DodajPaketForm
            // 
            this.ClientSize = new System.Drawing.Size(390, 145);
            this.Controls.Add(this.lblPaket);
            this.Controls.Add(this.cmbPaketi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnOdustani);
            this.Name = "DodajPaketForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodaj paket na rutu";
            this.Load += new System.EventHandler(this.DodajPaketForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}