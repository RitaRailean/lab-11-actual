namespace GestionareAngajati
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            this.gbDate = new System.Windows.Forms.GroupBox();
            this.dgvAngajati = new System.Windows.Forms.DataGridView();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNume = new System.Windows.Forms.Label();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.lblFunctie = new System.Windows.Forms.Label();
            this.lblSalariu = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbPrenume = new System.Windows.Forms.TextBox();
            this.tbFunctie = new System.Windows.Forms.TextBox();
            this.tbSalariu = new System.Windows.Forms.TextBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.btnAfisare = new System.Windows.Forms.Button();
            this.btnInserare = new System.Windows.Forms.Button();
            this.btnActualizare = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();

            // ── FORM ──────────────────────────────────────────────────
            this.Text = "Gestionare Angajati — Companie";
            this.ClientSize = new System.Drawing.Size(860, 580);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MinimumSize = new System.Drawing.Size(860, 580);

            // ── TITLE ─────────────────────────────────────────────────
            this.lblTitle.Text = "Gestionare Angajați";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Size = new System.Drawing.Size(350, 35);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(60, 52, 137);

            // ── GROUPBOX ──────────────────────────────────────────────
            this.gbDate.Text = "Date Angajat";
            this.gbDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gbDate.Location = new System.Drawing.Point(20, 60);
            this.gbDate.Size = new System.Drawing.Size(820, 200);

            // Layout: label on top, textbox below, 6 columns
            // Column X positions
            int col1 = 15, col2 = 155, col3 = 295,
                col4 = 450, col5 = 590, col6 = 730;
            int tbW = 125; // textbox width
            int lbH = 20;  // label height
            int tbH = 24;  // textbox height

            // Row 1 labels  (y=25)
            // Row 1 textboxes (y=47)
            // Row 2 labels  (y=90)
            // Row 2 textboxes (y=112)
            // Buttons row   (y=155)

            // ── ROW 1 ─────────────────────────────────────────────────
            this.lblId.Text = "ID";
            this.lblId.Location = new System.Drawing.Point(col1, 25);
            this.lblId.Size = new System.Drawing.Size(tbW, lbH);
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.tbId.Location = new System.Drawing.Point(col1, 47);
            this.tbId.Size = new System.Drawing.Size(tbW, tbH);
            this.tbId.ReadOnly = true;
            this.tbId.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);

            this.lblNume.Text = "Nume";
            this.lblNume.Location = new System.Drawing.Point(col2, 25);
            this.lblNume.Size = new System.Drawing.Size(tbW, lbH);
            this.lblNume.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.tbNume.Location = new System.Drawing.Point(col2, 47);
            this.tbNume.Size = new System.Drawing.Size(tbW, tbH);

            this.lblPrenume.Text = "Prenume";
            this.lblPrenume.Location = new System.Drawing.Point(col3, 25);
            this.lblPrenume.Size = new System.Drawing.Size(tbW, lbH);
            this.lblPrenume.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.tbPrenume.Location = new System.Drawing.Point(col3, 47);
            this.tbPrenume.Size = new System.Drawing.Size(tbW, tbH);

            this.lblFunctie.Text = "Funcție";
            this.lblFunctie.Location = new System.Drawing.Point(col4, 25);
            this.lblFunctie.Size = new System.Drawing.Size(tbW, lbH);
            this.lblFunctie.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.tbFunctie.Location = new System.Drawing.Point(col4, 47);
            this.tbFunctie.Size = new System.Drawing.Size(tbW, tbH);

            // ── ROW 2 ─────────────────────────────────────────────────
            this.lblSalariu.Text = "Salariu (lei)";
            this.lblSalariu.Location = new System.Drawing.Point(col1, 90);
            this.lblSalariu.Size = new System.Drawing.Size(tbW, lbH);
            this.lblSalariu.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.tbSalariu.Location = new System.Drawing.Point(col1, 112);
            this.tbSalariu.Size = new System.Drawing.Size(tbW, tbH);

            this.lblData.Text = "Data angajare";
            this.lblData.Location = new System.Drawing.Point(col2, 90);
            this.lblData.Size = new System.Drawing.Size(tbW, lbH);
            this.lblData.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.dtp.Location = new System.Drawing.Point(col2, 112);
            this.dtp.Size = new System.Drawing.Size(tbW, tbH);
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            // ── BUTTONS ───────────────────────────────────────────────
            this.btnAfisare.Text = "⟳ Afișare";
            this.btnAfisare.Location = new System.Drawing.Point(col1, 155);
            this.btnAfisare.Size = new System.Drawing.Size(110, 32);
            this.btnAfisare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAfisare.BackColor = System.Drawing.Color.FromArgb(230, 240, 255);
            this.btnAfisare.ForeColor = System.Drawing.Color.FromArgb(12, 68, 124);
            this.btnAfisare.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAfisare.Click += new System.EventHandler(this.btnAfisare_Click);

            this.btnInserare.Text = "+ Inserare";
            this.btnInserare.Location = new System.Drawing.Point(col1 + 120, 155);
            this.btnInserare.Size = new System.Drawing.Size(110, 32);
            this.btnInserare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserare.BackColor = System.Drawing.Color.FromArgb(238, 237, 254);
            this.btnInserare.ForeColor = System.Drawing.Color.FromArgb(60, 52, 137);
            this.btnInserare.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnInserare.Click += new System.EventHandler(this.btnInserare_Click);

            this.btnActualizare.Text = "✎ Actualizare";
            this.btnActualizare.Location = new System.Drawing.Point(col1 + 240, 155);
            this.btnActualizare.Size = new System.Drawing.Size(120, 32);
            this.btnActualizare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizare.BackColor = System.Drawing.Color.FromArgb(225, 245, 238);
            this.btnActualizare.ForeColor = System.Drawing.Color.FromArgb(8, 80, 65);
            this.btnActualizare.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnActualizare.Click += new System.EventHandler(this.btnActualizare_Click);

            this.btnStergere.Text = "✕ Ștergere";
            this.btnStergere.Location = new System.Drawing.Point(col1 + 370, 155);
            this.btnStergere.Size = new System.Drawing.Size(110, 32);
            this.btnStergere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStergere.BackColor = System.Drawing.Color.FromArgb(252, 235, 235);
            this.btnStergere.ForeColor = System.Drawing.Color.FromArgb(121, 31, 31);
            this.btnStergere.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);

            // ── GROUPBOX CONTROLS ─────────────────────────────────────
            this.gbDate.Controls.Add(this.lblId);
            this.gbDate.Controls.Add(this.tbId);
            this.gbDate.Controls.Add(this.lblNume);
            this.gbDate.Controls.Add(this.tbNume);
            this.gbDate.Controls.Add(this.lblPrenume);
            this.gbDate.Controls.Add(this.tbPrenume);
            this.gbDate.Controls.Add(this.lblFunctie);
            this.gbDate.Controls.Add(this.tbFunctie);
            this.gbDate.Controls.Add(this.lblSalariu);
            this.gbDate.Controls.Add(this.tbSalariu);
            this.gbDate.Controls.Add(this.lblData);
            this.gbDate.Controls.Add(this.dtp);
            this.gbDate.Controls.Add(this.btnAfisare);
            this.gbDate.Controls.Add(this.btnInserare);
            this.gbDate.Controls.Add(this.btnActualizare);
            this.gbDate.Controls.Add(this.btnStergere);

            // ── DATAGRIDVIEW ──────────────────────────────────────────
            this.dgvAngajati.Location = new System.Drawing.Point(20, 275);
            this.dgvAngajati.Size = new System.Drawing.Size(820, 285);
            this.dgvAngajati.AllowUserToAddRows = false;
            this.dgvAngajati.ReadOnly = true;
            this.dgvAngajati.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAngajati.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAngajati.BackgroundColor = System.Drawing.Color.White;
            this.dgvAngajati.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvAngajati.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvAngajati.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAngajati_CellClick);

            // ── ADD TO FORM ───────────────────────────────────────────
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.gbDate);
            this.Controls.Add(this.dgvAngajati);

            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox gbDate;
        private System.Windows.Forms.DataGridView dgvAngajati;
        private System.Windows.Forms.Label lblTitle, lblId, lblNume, lblPrenume, lblFunctie, lblSalariu, lblData;
        private System.Windows.Forms.TextBox tbId, tbNume, tbPrenume, tbFunctie, tbSalariu;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Button btnAfisare, btnInserare, btnActualizare, btnStergere;
    }
}