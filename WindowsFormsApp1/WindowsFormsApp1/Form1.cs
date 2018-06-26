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
/*using System.Data.EntityState;*/

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

            ArtsenGridview.DataSource = con.arts.Select(p => new {
                ArtsID = p.ArtsID,
                Naam = p.Naam,
                Adres = p.Adres,
                Einddatum = p.Einddatum,
            }).OrderBy(p => p.Naam).ToList();
            ArtsenGridview.Columns["ArtsID"].Visible = false;

            MedicatieGridView.DataSource = con.medicatie.Select(p => new {
                MedicatieID = p.MedicatieID,
                MedicatieNaam = p.MedicatieNaam,
                KlantID = p.KlantID,
            }).OrderBy(p => p.MedicatieNaam).ToList();
            MedicatieGridView.Columns["MedicatieID"].Visible = false;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MaakKlant_Click(object sender, EventArgs e)
        {
           //moet nog worden verwijderd
        }

        private void BewerkKlant_Click(object sender, EventArgs e)
        {

        }

        private void VerwijderKlant_Click(object sender, EventArgs e)
        {

            int klantid = Convert.ToInt32(klantidtxtKlant.Text);


            /*Klanten k = new Klanten();
            k.KlantID = klantid;
            con.klanten.Remove(k);
            con.klanten(klantid).State = EntityState.Deleted;
            con.SaveChanges();*/

            /*
            var delklant = new Klanten { KlantID = klantid };
            con.Entry(delklant).State = EntityState.Deleted;
            con.SaveChanges();
            */

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
            //Dit stukje code kunnen we misschien hergebruiken voor het verwijderen van records
            var query = from Klanten in con.klanten
                        where Klanten.Voornaam.Contains(SrcKlantentxt.Text)
                        select Klanten;

            KlantenGridView.DataSource = query.ToList();
        }

        private void MaakKlant_Click_1(object sender, EventArgs e)
        {
            string voornaam = VoornaamtxtKlant.Text;
            string achternaam = AchternaamtxtKlant.Text;
            string verzekeringsid = VerzekeringsidtxtKlant.Text;
            string plaats = PlaatstxtKlant.Text;
            string adres = AdrestxtKlant.Text;

            Klanten k = new Klanten();
            k.Voornaam = voornaam;
            k.Achternaam = achternaam;
            k.Plaats = plaats;
            k.Adres = adres;
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

        private void SearchArtsen_TextChanged(object sender, EventArgs e)
        {
            var query = from arts in con.arts
                        where arts.Naam.Contains(SearchArtsen.Text)
                        select arts;

            ArtsenGridview.DataSource = query.ToList();
        }

        private void MaakArtsbtn_Click(object sender, EventArgs e)
        {
            string naam = NaamArtstxt.Text;
            string adres = AdresArtstxt.Text;
            DateTime einddatum = Convert.ToDateTime(EinddatumArtstxt.Text);

            Arts k = new Arts();
            k.Naam = naam;
            k.Adres = adres;
            k.Einddatum = einddatum;
            con.arts.Add(k);
            con.SaveChanges();
            ArtsenGridview.DataSource = con.arts.Select(p => new {
                ArtsID = p.ArtsID,
                Naam = p.Naam,
                Adres = p.Adres,
                Einddatum = p.Einddatum
              //  Achternaam = p.Einddatum,
            }).OrderBy(p => p.Naam).ToList();

            //ArtsenGridview.Columns["Naam"].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string medicatienaam = MedicatieNaamtxt.Text;
            int klantid = Convert.ToInt32(MedicatieKlantid.Text);

            Medicatie k = new Medicatie();
            k.MedicatieNaam = medicatienaam;
            k.KlantID = klantid;
            con.medicatie.Add(k);
            con.SaveChanges();
            MedicatieGridView.DataSource = con.medicatie.Select(p => new {
                MedicatieNaam = p.MedicatieNaam,
                KlantID = p.KlantID,
            }).OrderBy(p => p.MedicatieNaam).ToList();

            //MedicatieGridView.Columns["MedicatieNaam"].Visible = false;

        }

        private void SearchMedicatie_TextChanged(object sender, EventArgs e)
        {
            var query = from Medicatie in con.medicatie
                        where Medicatie.MedicatieNaam.Contains(SearchMedicatie.Text)
                        select Medicatie;

            MedicatieGridView.DataSource = query.ToList();
        }

        private void ArtsenGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Klantentab_Click(object sender, EventArgs e)
        {

        }

        private void SelectAllKlantenbtn_Click(object sender, EventArgs e)
        {
            //deze moet nog een functie krijgen waarmee we alle resultaten kunnen tonen na het zoeken
                        /*var query = from Klanten in con.klanten
                        where Klanten.Voornaam.Contains(SrcKlantentxt.Text)
                        select Klanten;*/
            var query = Klanten.KlantID.SqlQuery("SELECT * FROM Klanten").ToList();
            SrcKlantentxt.Text = "";
            KlantenGridView.DataSource = query.ToList();
        }
    }
}
