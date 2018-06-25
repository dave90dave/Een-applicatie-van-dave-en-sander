using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
            database con = new database();

        private void Form1_Load(object sender, EventArgs e)
        {
            Klanten k = new Klanten();
            //k.Voornaam = "Sander";
            //k.Achternaam = "Baak";
            //k.Plaats = "Alkmaar";
            //k.Adres = "Mogool 10";
            con.klanten.Add(k);
             con.SaveChanges();
            KlantenGridView.DataSource = con.klanten.Select(p => new {
                KlantID = p.KlantID,
                VerzekeringsID = p.VerzekeringsID,
                Voornaam = p.Voornaam,
                Achternaam = p.Achternaam,
                Adres = p.Adres,
                Plaats = p.Plaats
            }).OrderBy(p => p.Achternaam).ToList();

            KlantenGridView.Columns["KlantID"].Visible = false;
            KlantenGridView.Columns["VerzekeringsID"].Visible = false;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MaakKlant_Click(object sender, EventArgs e)
        {
            string voornaam = VoornaamtxtKlant.Text;
            string achternaam = AchternaamtxtKlant.Text;
            string verzekeringsid = VerzekeringsidtxtKlant.Text;
            string plaats = PlaatstxtKlant.Text;
            string adres = AdrestxtKlant.Text;
            
            /*
            if (verzekeringsid != null && voornaam != null && achternaam != null && plaats != null && adres != null)
            {
                Klanten k = new Klanten();
                k.Voornaam = voornaam;
                k.Achternaam = achternaam;
                k.Adres = adres;
                k.Plaats = plaats;

                con.klanten.Add(k);
                con.SaveChanges();
                KlantenGridView.DataSource = Klanten.voornaam.ToList();

                voornaam = ""; achternaam = ""; verzekeringsid = ""; plaats = ""; adres = "";
                k.Items.Add(voornaam);
            }*/
        }

        private void FilterKlant_Click(object sender, EventArgs e)
        {

        }

        private void BewerkKlant_Click(object sender, EventArgs e)
        {

        }

        private void VerwijderKlant_Click(object sender, EventArgs e)
        {

        }

        private void MaakArts_Click(object sender, EventArgs e)
        {
            /*
            //Onderstaande velden moeten nog aangemaakt worden in de designer
            string Naam = NaamtxtArts.Text;
            string Adres = AdrestxtArts.Text;
            string Postcode = PostcodetxtArts.Text;
            DateTime Einddatum = EinddatumtxtArts.Text;



            if (Naam != null && Adres != null && Postcode != null && Einddatum != null)
            {
                Arts a = new Arts();
                a.Naam = Naam;
                a.Adres = Adres;
                a.Postcode = Postcode;
                a.Einddatum = Einddatum;

                con.klanten.Add(k);
                con.SaveChanges();
                ArtsGridView.DataSource = Arts.arts.ToList();

                Naam = ""; Adres = ""; Postcode = ""; Einddatum = "";
                k.Items.Add(Naam);
            }*/
        }
        

        private void FilterArts_Click(object sender, EventArgs e)
        {

        }

        private void BewerkArts_Click(object sender, EventArgs e)
        {

        }

        private void VerwijderArts_Click(object sender, EventArgs e)
        {

        }

        private void MaakMedicatie_Click(object sender, EventArgs e)
        {/*
            //Textvelden moeten nog toegevoegd worden in de designer
            string MedicatieID = MedicatieIDtxt.Text;
            string MedicatieNaam = NaamMedicatietxt.Text;


            if (MedicatieID != null && MedicatieNaam != null)
            {
                Medicatie m = new Medicatie();
                m.MedicatieID = Convert.ToInt32(MedicatieNaam);
                m.MedicatieNaam = MedicatieNaam;

                con.klanten.Add(m);
                con.SaveChanges();
                KlantenGridView.DataSource = Medicatie.medicatie.ToList();

                MedicatieID = ""; MedicatieNaam = "";
                m.Items.Add(MedicatieID);
            }*/
        }
                

        private void FilterMedicatie_Click(object sender, EventArgs e)
        {

        }

        private void BewerkMedicatie_Click(object sender, EventArgs e)
        {

        }

        private void VerwijderMedicatie_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var query = from Klanten in con.klanten
                        where Klanten.Voornaam.Contains(textBox1.Text)
                        select Klanten;

            KlantenGridView.DataSource = query.ToList();
        }
    }
}
