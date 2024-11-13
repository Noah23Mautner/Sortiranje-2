using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sortiranje_vozila
{
    public partial class Form1 : Form
    {
        private List<Vozilo> vozila = new List<Vozilo>();
        public Form1()
        {
            InitializeComponent();
            comboBoxSortiranje.Items.AddRange(new string[] { "Marka", "Model", "GodinaProizvodnje", "Kilometraza" });
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                var vozilo = new Vozilo
                {
                    Marka = txtMarka.Text,
                    Model = txtModel.Text,
                    GodinaProizvodnje = int.Parse(txtGodinaProizvodnje.Text),
                    Kilometraza = int.Parse(txtKilometraza.Text)
                };

                vozila.Add(vozilo);
                UpdateListBox();
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Unesite validne podatke.");
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void UpdateListBox()
        {
            listBoxVozila.Items.Clear();
            foreach (var vozilo in vozila)
            {
                listBoxVozila.Items.Add(vozilo);
            }
        }

        private void ClearInputs()
        {
            txtMarka.Clear();
            txtModel.Clear();
            txtGodinaProizvodnje.Clear();
            txtKilometraza.Clear();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtMarka.Text) ||
                string.IsNullOrWhiteSpace(txtModel.Text) ||
                !int.TryParse(txtGodinaProizvodnje.Text, out int godina) || godina <= 0 ||
                !int.TryParse(txtKilometraza.Text, out int kilometraza);
        }

    }
}
