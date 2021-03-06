﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

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
            KlantenGridView.DataSource = con.klanten.Select(p => new
            {
                KlantID = p.KlantID,
                Voornaam = p.Voornaam,
                Achternaam = p.Achternaam,
                Adres = p.Adres,
                Plaats = p.Plaats
            }).OrderBy(p => p.Achternaam).ToList();
            //KlantenGridView.Columns["VerzekeringsID"].Visible = false;

            ArtsenGridview.DataSource = con.arts.Select(p => new
            {
                ArtsID = p.ArtsID,
                Naam = p.Naam,
                Adres = p.Adres,
                Einddatum = p.Einddatum,
            }).OrderBy(p => p.Naam).ToList();
            //ArtsenGridview.Columns["ArtsID"].Visible = false;

            MedicatieGridView.DataSource = con.medicatie.Select(p => new
            {
                MedicatieID = p.MedicatieID,
                MedicatieNaam = p.MedicatieNaam,
            }).OrderBy(p => p.MedicatieNaam).ToList();
            //MedicatieGridView.Columns["MedicatieID"].Visible = false;

            KlantenMedicatieLinkGridview.DataSource = con.KlantenMedicatie.Select(p => new
            {
                MedicatieID = p.MedicatieID,
                KlantID = p.KlantID
            }).OrderBy(p => p.KlantID).ToList();

            klanten_verzekeringgridview.DataSource = con.klantenverzekering.Select(p => new
            {
                VerzekeringID = p.VerzekeringID,
                VerzekeringNaam = p.VerzekeringNaam,
                KlantID = p.KlantID
            }).OrderBy(p => p.KlantID).ToList();
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
            try
            {
                //klant Verwijderen
                int value = int.Parse(KlantenGridView.CurrentRow.Cells[0].Value.ToString());

                Klanten k = con.klanten.Find(value);

                // Klant verwijderen en database opslaan

                con.klanten.Remove(k);
            }
            catch (Exception)
            {
                MessageBox.Show("Je hebt geen correct nummer ingevuld.", "System Failier",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.SaveChanges();
            KlantenGridView.DataSource = con.klanten.Select(p => new
            {
                KlantID = p.KlantID,
                Voornaam = p.Voornaam,
                Achternaam = p.Achternaam,
                Adres = p.Adres,
                Plaats = p.Plaats
            }).OrderBy(p => p.Achternaam).ToList();

            /* KlantenGridView.Columns["KlantID"].Visible = false;
             KlantenGridView.Columns["VerzekeringsID"].Visible = false;*/
        }

        private void MaakArts_Click(object sender, EventArgs e)
        {
        }


        private void FilterArts_Click(object sender, EventArgs e)
        {

        }

        private void BewerkArts_Click(object sender, EventArgs e)
        {

        }

        private void VerwijderArts_Click(object sender, EventArgs e)
        {
            try
            {
                //arts Verwijderen
                int value = int.Parse(ArtsenGridview.CurrentRow.Cells[0].Value.ToString());

                Arts k = con.arts.Find(value);

                //arts verwijderen en database opslaan

                con.arts.Remove(k);
            }
            catch (Exception)
            {
                MessageBox.Show("Je hebt geen correct nummer ingevuld.", "System Failier",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.SaveChanges();

            ArtsenGridview.DataSource = con.arts.Select(p => new
            {
                ArtsID = p.ArtsID,
                Naam = p.Naam,
                Adres = p.Adres,
                Einddatum = p.Einddatum
                //  Achternaam = p.Einddatum,
            }).OrderBy(p => p.Naam).ToList();
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
            try
            {
                //medicatie Verwijderen
                int value = int.Parse(MedicatieGridView.CurrentRow.Cells[0].Value.ToString());

                Medicatie k = con.medicatie.Find(value);

                // medicatie verwijderen en database opslaan

                con.medicatie.Remove(k);
            }
            catch (Exception)
            {
                MessageBox.Show("Je hebt geen correct nummer ingevuld.", "System Failier",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.SaveChanges();

            MedicatieGridView.DataSource = con.medicatie.Select(p => new
            {
                MedicatieID = p.MedicatieID,
                MedicatieNaam = p.MedicatieNaam,
            }).OrderBy(p => p.MedicatieNaam).ToList();
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
            try
            {
                int artsid = Convert.ToInt16(ArtsIDtxtklant.Text);
                string voornaam = VoornaamtxtKlant.Text;
                string achternaam = AchternaamtxtKlant.Text;
                string plaats = PlaatstxtKlant.Text;
                string adres = AdrestxtKlant.Text;

                Klanten k = new Klanten();
                k.ArtsID = artsid;
                k.Voornaam = voornaam;
                k.Achternaam = achternaam;
                k.Plaats = plaats;
                k.Adres = adres;
                con.klanten.Add(k);
                con.SaveChanges();
                KlantenGridView.DataSource = con.klanten.Select(p => new
                {
                    KlantID = p.KlantID,
                    Voornaam = p.Voornaam,
                    Achternaam = p.Achternaam,
                    Adres = p.Adres,
                    Plaats = p.Plaats
                }).OrderBy(p => p.Achternaam).ToList();
            }
            catch
            {
                MessageBox.Show("Something failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            ArtsenGridview.DataSource = con.arts.Select(p => new
            {
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
            try
            {
                string medicatienaam = MedicatieNaamtxt.Text;

                Medicatie k = new Medicatie();
                k.MedicatieNaam = medicatienaam;
                con.medicatie.Add(k);
                con.SaveChanges();
                MedicatieGridView.DataSource = con.medicatie.Select(p => new
                {
                    MedicatieID = p.MedicatieID,
                    MedicatieNaam = p.MedicatieNaam,
                }).OrderBy(p => p.MedicatieNaam).ToList();

                //MedicatieGridView.Columns["MedicatieNaam"].Visible = false;

            }
            catch (Exception)
            {
                MessageBox.Show("Geen geldig KlantID opgegeven", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
            //var query = Klanten.KlantID.SqlQuery("SELECT * FROM Klanten").ToList();
            SrcKlantentxt.Text = "";
            //KlantenGridView.DataSource = query.ToList();
        }

        private void ArtsIDtxtklant_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //klant Verwijderen
                int value = int.Parse(KlantenMedicatieLinkGridview.CurrentRow.Cells[0].Value.ToString());

                KlantenMedicatie k = con.KlantenMedicatie.Find(value);

                // Klant verwijderen en database opslaan

                con.KlantenMedicatie.Remove(k);
            }
            catch (Exception)
            {
                MessageBox.Show("Je hebt geen correct nummer ingevuld.", "System Failier",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.SaveChanges();
            KlantenMedicatieLinkGridview.DataSource = con.KlantenMedicatie.Select(p => new
            {
                KlantID = p.KlantID,
                MedicatieID = p.MedicatieID,
            }).OrderBy(p => p.MedicatieID).ToList();
        }

        private void Klanten_MedicatieLinkbtn_Click(object sender, EventArgs e)
        {
            try
            {
                int klantid = Convert.ToInt16(KlantIDKlantenMedicatietxt.Text);
                int medicatieid = Convert.ToInt16(MedicatieIDKlantenMedicatietxt.Text);

                KlantenMedicatie k = new KlantenMedicatie();
                k.KlantID = klantid;
                k.MedicatieID = medicatieid;
                con.KlantenMedicatie.Add(k);
                con.SaveChanges();
                KlantenMedicatieLinkGridview.DataSource = con.KlantenMedicatie.Select(p => new
                {
                    KlantID = p.KlantID,
                    MedicatieID = p.MedicatieID,
                }).OrderBy(p => p.KlantID).ToList();
            }
            catch
            {
                MessageBox.Show("Something failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void MedicatieGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public List<string> gegevens = new List<string>();

        private void btn_print_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in KlantenGridView.SelectedRows)
                gegevens.Add("Naam: " + row.Cells[1].Value.ToString() + " " + row.Cells[2].Value.ToString() + ", Adres: " + row.Cells[3].Value.ToString() + ", Plaats: " + row.Cells[4].Value.ToString());

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(PrintImage);
            pd.Print();
            gegevens.Clear();
        }
        public void PrintImage(object o, PrintPageEventArgs e)
        {
            float x = 10f;
            float y = 10f;
            Font drawFont = new Font("Arial", 11);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            PointF drawPoint = new PointF(x, y);

            foreach (string item in gegevens)
            {
                e.Graphics.DrawString(item, drawFont, drawBrush, drawPoint);
                y += 20f;
                drawPoint = new PointF(x, y);
            }
        }

        private void LinkKlanten_verzekeringbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string naam = KlantenVerzekeringNaamtxt.Text;
                int klantid = Convert.ToInt16(KlantenIDVerzekeringtxt.Text);

                KlantenVerzekering k = new KlantenVerzekering();
                k.VerzekeringNaam = naam;
                k.KlantID = klantid;
                con.klantenverzekering.Add(k);
                con.SaveChanges();
                klanten_verzekeringgridview.DataSource = con.klantenverzekering.Select(p => new
                {
                    VerzekeringID = p.VerzekeringID,
                    VerzekeringNaam = p.VerzekeringNaam,
                    KlantID = p.KlantID,
                }).OrderBy(p => p.VerzekeringNaam).ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Geen geldig KlantID opgegeven", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UnlinkKlanten_verzekeringbtn_Click(object sender, EventArgs e)
        {
            try
            {
                int value = int.Parse(klanten_verzekeringgridview.CurrentRow.Cells[0].Value.ToString());

                KlantenVerzekering k = con.klantenverzekering.Find(value);

                con.klantenverzekering.Remove(k);
            }
            catch (Exception)
            {
                MessageBox.Show("Je hebt geen correct nummer ingevuld.", "System Failier",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.SaveChanges();

            klanten_verzekeringgridview.DataSource = con.klantenverzekering.Select(p => new
            {
                VerzekeringID = p.VerzekeringID,
                VerzekeringNaam = p.VerzekeringNaam,
                KlantID = p.KlantID,
            }).OrderBy(p => p.VerzekeringID).ToList();
        }

        private void ArtsenVerlengbtn_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(ArtsenGridview.CurrentRow.Cells[0].Value.ToString());
            var entity = con.arts.Find(ID);

            entity.Einddatum = entity.Einddatum.AddYears(1);
            con.SaveChanges();

            ArtsenGridview.DataSource = con.arts.Select(p => new
            {
                ArtsID = p.ArtsID,
                Naam = p.Naam,
                Adres = p.Adres,
                Einddatum = p.Einddatum,
            }).OrderBy(p => p.Naam).ToList();
            //ArtsenGridview.Columns["ArtsID"].Visible = false;

        }
    }
}

        
