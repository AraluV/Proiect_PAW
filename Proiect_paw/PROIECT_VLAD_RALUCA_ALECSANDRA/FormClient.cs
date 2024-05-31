using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REST_1058_VLAD_RALUCA_ALECSANDRA
{
    public partial class FormClient : Form
    {
        private List<Client> clients = new List<Client>();
        private int nextId = 1;

        public FormClient()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        public List<Client> GetClienti()
        {
            return clients;
        }

        private void InitializeDataGridView()
        {
            dataGridViewClient.ColumnCount = 4;
            dataGridViewClient.Columns[0].Name = "Id";
            dataGridViewClient.Columns[1].Name = "Nume";
            dataGridViewClient.Columns[2].Name = "Adresa";
            dataGridViewClient.Columns[3].Name = "Telefon";

            dataGridViewClient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewClient.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewClient.MultiSelect = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNume.Text))
            {
                MessageBox.Show("Nume field is empty. Please fill it.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAdresa.Text))
            {
                MessageBox.Show("Adresa field is empty. Please fill it.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTelefon.Text))
            {
                MessageBox.Show("Telefon field is empty. Please fill it.");
                return;
            }

            if (!Regex.IsMatch(txtTelefon.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Telefon field must contain exactly 10 digits.");
                return;
            }

            string nume = txtNume.Text;
            string adresa = txtAdresa.Text;
            string telefon = txtTelefon.Text;

            Client newClient = new Client { Id = nextId++, Nume = nume, Adresa = adresa, Telefon = telefon };
            clients.Add(newClient);

            PopulateDataGridView();

            txtNume.Clear();
            txtAdresa.Clear();
            txtTelefon.Clear();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewClient.SelectedRows.Count > 0)
            {
                if (string.IsNullOrWhiteSpace(txtNume.Text))
                {
                    MessageBox.Show("Nume field is empty. Please fill it.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtAdresa.Text))
                {
                    MessageBox.Show("Adresa field is empty. Please fill it.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtTelefon.Text))
                {
                    MessageBox.Show("Telefon field is empty. Please fill it.");
                    return;
                }

                if (!Regex.IsMatch(txtTelefon.Text, @"^\d{10}$"))
                {
                    MessageBox.Show("Telefon field must contain exactly 10 digits.");
                    return;
                }

                int index = dataGridViewClient.SelectedRows[0].Index;
                Client client = clients[index];

                client.Nume = txtNume.Text;
                client.Adresa = txtAdresa.Text;
                client.Telefon = txtTelefon.Text;

                PopulateDataGridView();

                txtNume.Clear();
                txtAdresa.Clear();
                txtTelefon.Clear();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewClient.SelectedRows.Count > 0)
            {
                int index = dataGridViewClient.SelectedRows[0].Index;
                clients.RemoveAt(index);
                PopulateDataGridView();
            }
        }

        private void PopulateDataGridView()
        {
            dataGridViewClient.Rows.Clear();
            foreach (Client client in clients)
            {
                dataGridViewClient.Rows.Add(client.Id.ToString(), client.Nume, client.Adresa, client.Telefon);
            }
        }

        private void FormClient_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            clients.Clear();
            foreach (DataGridViewRow row in dataGridViewClient.Rows)
            {
                if (row.IsNewRow) continue;
                Client client = new Client
                {
                    Id = int.Parse(row.Cells[0].Value.ToString()),
                    Nume = row.Cells[1].Value.ToString(),
                    Adresa = row.Cells[2].Value.ToString(),
                    Telefon = row.Cells[3].Value.ToString()
                };
                clients.Add(client);
            }
            MessageBox.Show("Data saved successfully!");
        }

        private void FormClient_Load_1(object sender, EventArgs e)
        {

        }
    }
}
