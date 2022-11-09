using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace NobelDij {
    public partial class Form1 : Form {

        private readonly List<OrvosiNobeldijas> orvosiNobeldijasok = new List<OrvosiNobeldijas>(500);

        public Form1() {
            InitializeComponent();

            foreach (string line in File.ReadAllLines("orvosi_nobeldijak.txt").Skip(1)) {
                string[] parts = line.Split(';');

                orvosiNobeldijasok.Add(new OrvosiNobeldijas(int.Parse(parts[0]), parts[1], parts[2], parts[3]));
            }
        }

        private void adatokMentese_Click(object sender, EventArgs e) {
            string doctName = nev.Text;

            if (doctName.Length == 0) {
                errorProvider.SetError(nev, "Meg kell adni egy nevet!");
                MessageBox.Show("Töltsön ki minden mezőt!", "Hiányos adatok", MessageBoxButtons.OK);
                return;
            }

            string szulhal = szh.Text;

            if (szulhal.Length == 0) {
                errorProvider.SetError(szh, "Meg kell adni egy Sz/H!");
                MessageBox.Show("Töltsön ki minden mezőt!", "Hiányos adatok", MessageBoxButtons.OK);
                return;
            }

            string orsz = orszag.Text;

            if (orsz.Length == 0) {
                errorProvider.SetError(orszag, "Meg kell adni egy ország nevet!");
                MessageBox.Show("Töltsön ki minden mezőt!", "Hiányos adatok", MessageBoxButtons.OK);
                return;
            }

            decimal val = evUpDown.Value;

            if (val < 1989) {
                errorProvider.SetError(evUpDown, "Hiba! Az évszám nem megfelelő!");
                MessageBox.Show("Hiba! Az évszám nem megfelelő!", "Mentés", MessageBoxButtons.OK);
                return;
            }

            orszag.Text = szh.Text = nev.Text = "";
            evUpDown.Value = 1900;

            try {
                using (StreamWriter writer = File.CreateText("uj_dijazott.txt")) {
                    writer.WriteLine("Év;Név;SzületésHalálozás;Országkód");
                    writer.WriteLine($"{val};{doctName};{szulhal};{orsz}");
                }
            } catch (Exception) {
                MessageBox.Show("Hiba az állomány írásánál!", "Hiba", MessageBoxButtons.OK);
            }
        }
    }
}
