using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace REST_1058_VLAD_RALUCA_ALECSANDRA
{
    public partial class Form1 : Form
    {
        private List<Client> clienti = new List<Client>();
        private List<Asigurare> asigurari = new List<Asigurare>();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            using (var formClient = new FormClient())
            {
                formClient.ShowDialog();
                clienti.AddRange(formClient.GetClienti());
            }
        }

        private void buttonAsigurare_Click(object sender, EventArgs e)
        {
            using (var formAsigurare = new FormAsigurare())
            {
                formAsigurare.ShowDialog();
                asigurari.AddRange(formAsigurare.GetAsigurari());
            }
        }

        private void buttonPolita_Click(object sender, EventArgs e)
        {
            using (var formPolita = new FormPolitaDeAsigurare(clienti, asigurari))
            {
                formPolita.ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
