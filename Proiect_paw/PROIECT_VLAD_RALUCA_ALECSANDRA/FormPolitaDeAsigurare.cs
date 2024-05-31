using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace REST_1058_VLAD_RALUCA_ALECSANDRA
{
    public partial class FormPolitaDeAsigurare : Form
    {
        private List<PolitaDeAsigurare> politeDeAsigurare = new List<PolitaDeAsigurare>();
        private List<Client> clienti;
        private List<Asigurare> asigurari;
        private int nextId = 1;

        public FormPolitaDeAsigurare(List<Client> clienti, List<Asigurare> asigurari)
        {
            InitializeComponent();
            this.clienti = clienti;
            this.asigurari = asigurari;
            InitializeComboBoxes();
            InitializeDataGridView();
        }

        private void InitializeComboBoxes()
        {
            comboBoxClienti.DataSource = clienti;
            comboBoxClienti.DisplayMember = "Nume";
            comboBoxClienti.ValueMember = "Id";

            comboBoxAsigurari.DataSource = asigurari;
            comboBoxAsigurari.DisplayMember = "TipAsigurare";
            comboBoxAsigurari.ValueMember = "Id";
        }

        private void InitializeDataGridView()
        {
            dataGridViewPolite.ColumnCount = 5;
            dataGridViewPolite.Columns[0].Name = "Id";
            dataGridViewPolite.Columns[1].Name = "Client";
            dataGridViewPolite.Columns[2].Name = "Asigurare";
            dataGridViewPolite.Columns[3].Name = "Data Inceput";
            dataGridViewPolite.Columns[4].Name = "Data Sfarsit";

            dataGridViewPolite.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPolite.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPolite.MultiSelect = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxClienti.SelectedItem == null)
            {
                MessageBox.Show("Client field is empty. Please select a client.");
                return;
            }

            if (comboBoxAsigurari.SelectedItem == null)
            {
                MessageBox.Show("Asigurare field is empty. Please select an insurance.");
                return;
            }

            Client client = (Client)comboBoxClienti.SelectedItem;
            Asigurare asigurare = (Asigurare)comboBoxAsigurari.SelectedItem;
            DateTime dataInceput = dateTimePickerInceput.Value;
            DateTime dataSfarsit = dateTimePickerSfarsit.Value;

            PolitaDeAsigurare newPolita = new PolitaDeAsigurare
            {
                Id = nextId++,
                Client = client,
                Asigurare = asigurare,
                DataInceput = dataInceput,
                DataSfarsit = dataSfarsit
            };
            politeDeAsigurare.Add(newPolita);

            PopulateDataGridView();

            comboBoxClienti.SelectedIndex = -1;
            comboBoxAsigurari.SelectedIndex = -1;
            dateTimePickerInceput.Value = DateTime.Now;
            dateTimePickerSfarsit.Value = DateTime.Now;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewPolite.SelectedRows.Count > 0)
            {
                int index = dataGridViewPolite.SelectedRows[0].Index;
                politeDeAsigurare.RemoveAt(index);
                PopulateDataGridView();
            }
        }

        private void FormPolitaDeAsigurare_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            dataGridViewPolite.Rows.Clear();
            foreach (PolitaDeAsigurare polita in politeDeAsigurare)
            {
                if (polita.Client == null || polita.Asigurare == null)
                {
                    MessageBox.Show($"Error: Policy ID {polita.Id} has a null Client or Asigurare.");
                    continue;
                }
                dataGridViewPolite.Rows.Add(polita.Id.ToString(), polita.Client.Nume, polita.Asigurare.TipAsigurare, polita.DataInceput.ToString("d"), polita.DataSfarsit.ToString("d"));
            }
        }
    }
}
