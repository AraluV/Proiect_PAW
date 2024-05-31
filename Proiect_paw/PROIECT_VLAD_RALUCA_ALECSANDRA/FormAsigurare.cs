using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace REST_1058_VLAD_RALUCA_ALECSANDRA
{
    public partial class FormAsigurare : Form
    {
        private List<Asigurare> asigurari = new List<Asigurare>();
        private int nextId = 1;

        public FormAsigurare()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        public List<Asigurare> GetAsigurari()
        {
            return asigurari;
        }

        private void InitializeDataGridView()
        {
            dataGridViewAsigurari.ColumnCount = 3;
            dataGridViewAsigurari.Columns[0].Name = "Id";
            dataGridViewAsigurari.Columns[1].Name = "Tip Asigurare";
            dataGridViewAsigurari.Columns[2].Name = "Pret";

            dataGridViewAsigurari.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAsigurari.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAsigurari.MultiSelect = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTipAsigurare.Text))
            {
                MessageBox.Show("Tip Asigurare field is empty. Please fill it.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPret.Text))
            {
                MessageBox.Show("Pret field is empty. Please fill it.");
                return;
            }

            string tipAsigurare = txtTipAsigurare.Text;
            if (!double.TryParse(txtPret.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double pret))
            {
                MessageBox.Show("Please enter a valid price in the format 123.45");
                return;
            }
            Asigurare newAsigurare = new Asigurare { Id = nextId++, TipAsigurare = tipAsigurare, Pret = pret };
            asigurari.Add(newAsigurare);

            PopulateDataGridView();

            txtTipAsigurare.Clear();
            txtPret.Clear();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewAsigurari.SelectedRows.Count > 0)
            {

                int index = dataGridViewAsigurari.SelectedRows[0].Index;
                Asigurare asigurare = asigurari[index];

                asigurare.TipAsigurare = txtTipAsigurare.Text;

                if (!double.TryParse(txtPret.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double pret))
                {
                    MessageBox.Show("Please enter a valid price in the format 123.45");
                    return;
                }
                asigurare.Pret = pret;

                PopulateDataGridView();

                txtTipAsigurare.Clear();
                txtPret.Clear();
            }
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewAsigurari.SelectedRows.Count > 0)
            {
                int index = dataGridViewAsigurari.SelectedRows[0].Index;
                asigurari.RemoveAt(index);
                PopulateDataGridView();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            asigurari.Clear();
            foreach (DataGridViewRow row in dataGridViewAsigurari.Rows)
            {
                if (row.IsNewRow) continue;
                Asigurare asigurare = new Asigurare
                {
                    Id = int.Parse(row.Cells[0].Value.ToString()),
                    TipAsigurare = row.Cells[1].Value.ToString(),
                    Pret = double.Parse(row.Cells[2].Value.ToString(), CultureInfo.InvariantCulture)
                };
                asigurari.Add(asigurare);
            }
            MessageBox.Show("Data saved successfully!");
        }

        private void FormAsigurare_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            dataGridViewAsigurari.Rows.Clear();
            foreach (Asigurare asigurare in asigurari)
            {
                dataGridViewAsigurari.Rows.Add(asigurare.Id.ToString(), asigurare.TipAsigurare, asigurare.Pret.ToString(CultureInfo.InvariantCulture));
            }
        }
    }
}
