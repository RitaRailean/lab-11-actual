using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace GestionareAngajati
{
    public partial class Form1 : Form
    {
        string connectionString = "Server=localhost\\SQLEXPRESS;Database=Companie;Integrated Security=True;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAngajati();
        }

        // ─────────────────────────────────────────────
        // HELPERS
        // ─────────────────────────────────────────────
        private DataTable ExecuteQuery(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                    adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        private void ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    if (parameters != null) cmd.Parameters.AddRange(parameters);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─────────────────────────────────────────────
        // LOAD
        // ─────────────────────────────────────────────
        private void LoadAngajati()
        {
            dgvAngajati.DataSource = ExecuteQuery("SELECT * FROM Angajati");
        }

        // ─────────────────────────────────────────────
        // AFISARE
        // ─────────────────────────────────────────────
        private void btnAfisare_Click(object sender, EventArgs e)
        {
            LoadAngajati();
            MessageBox.Show("Date afișate cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ─────────────────────────────────────────────
        // INSERARE
        // ─────────────────────────────────────────────
        private void btnInserare_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNume.Text) ||
                string.IsNullOrWhiteSpace(tbPrenume.Text) ||
                string.IsNullOrWhiteSpace(tbFunctie.Text) ||
                string.IsNullOrWhiteSpace(tbSalariu.Text))
            {
                MessageBox.Show("Completați toate câmpurile!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(tbSalariu.Text, out decimal salariu))
            {
                MessageBox.Show("Salariul trebuie să fie un număr!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = @"INSERT INTO Angajati (nume, prenume, functie, salariu, data_angajare) 
                             VALUES (@Nume, @Prenume, @Functie, @Salariu, @Data)";
            SqlParameter[] parameters = {
                new SqlParameter("@Nume", tbNume.Text),
                new SqlParameter("@Prenume", tbPrenume.Text),
                new SqlParameter("@Functie", tbFunctie.Text),
                new SqlParameter("@Salariu", salariu),
                new SqlParameter("@Data", dtp.Value.Date)
            };

            ExecuteNonQuery(query, parameters);
            MessageBox.Show("Angajat adăugat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadAngajati();
            ClearFields();
        }

        // ─────────────────────────────────────────────
        // ACTUALIZARE
        // ─────────────────────────────────────────────
        private void btnActualizare_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbId.Text))
            {
                MessageBox.Show("Selectați un angajat din tabel!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(tbSalariu.Text, out decimal salariu))
            {
                MessageBox.Show("Salariul trebuie să fie un număr!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = @"UPDATE Angajati 
                             SET nume=@Nume, prenume=@Prenume, functie=@Functie, 
                                 salariu=@Salariu, data_angajare=@Data 
                             WHERE id=@Id";
            SqlParameter[] parameters = {
                new SqlParameter("@Id", tbId.Text),
                new SqlParameter("@Nume", tbNume.Text),
                new SqlParameter("@Prenume", tbPrenume.Text),
                new SqlParameter("@Functie", tbFunctie.Text),
                new SqlParameter("@Salariu", salariu),
                new SqlParameter("@Data", dtp.Value.Date)
            };

            ExecuteNonQuery(query, parameters);
            MessageBox.Show("Angajat actualizat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadAngajati();
            ClearFields();
        }

        // ─────────────────────────────────────────────
        // STERGERE
        // ─────────────────────────────────────────────
        private void btnStergere_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbId.Text))
            {
                MessageBox.Show("Selectați un angajat din tabel!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Sigur doriți să ștergeți acest angajat?", "Confirmare",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ExecuteNonQuery("DELETE FROM Angajati WHERE id=@Id",
                    new[] { new SqlParameter("@Id", tbId.Text) });
                MessageBox.Show("Angajat șters cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAngajati();
                ClearFields();
            }
        }

        // ─────────────────────────────────────────────
        // CELL CLICK — auto-fill fields from row
        // ─────────────────────────────────────────────
        private void dgvAngajati_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAngajati.Rows[e.RowIndex];
                tbId.Text = row.Cells["id"].Value.ToString();
                tbNume.Text = row.Cells["nume"].Value.ToString();
                tbPrenume.Text = row.Cells["prenume"].Value.ToString();
                tbFunctie.Text = row.Cells["functie"].Value.ToString();
                tbSalariu.Text = row.Cells["salariu"].Value.ToString();
                dtp.Value = Convert.ToDateTime(row.Cells["data_angajare"].Value);
            }
        }

        // ─────────────────────────────────────────────
        // CLEAR FIELDS
        // ─────────────────────────────────────────────
        private void ClearFields()
        {
            tbId.Text = "";
            tbNume.Text = "";
            tbPrenume.Text = "";
            tbFunctie.Text = "";
            tbSalariu.Text = "";
            dtp.Value = DateTime.Today;
        }
    }
}