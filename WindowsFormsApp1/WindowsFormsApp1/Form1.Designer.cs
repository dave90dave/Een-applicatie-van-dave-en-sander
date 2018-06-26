namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.KlantenGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ArtsenGridview = new System.Windows.Forms.DataGridView();
            this.VerwijderKlant = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.MedicatieGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.VerwijderArts = new System.Windows.Forms.Button();
            this.VerwijderMedicatie = new System.Windows.Forms.Button();
            this.MaakMedicatiebtn = new System.Windows.Forms.TabControl();
            this.Klantentab = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.klantidtxtKlant = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.VoornaamtxtKlant = new System.Windows.Forms.TextBox();
            this.VerzekeringsidtxtKlant = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AchternaamtxtKlant = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PlaatstxtKlant = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MaakKlant = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.AdrestxtKlant = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SrcKlantentxt = new System.Windows.Forms.TextBox();
            this.Artsentab = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Artsidtxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.MaakArtsbtn = new System.Windows.Forms.Button();
            this.NaamArtstxt = new System.Windows.Forms.TextBox();
            this.EinddatumArtstxt = new System.Windows.Forms.DateTimePicker();
            this.AdresArtstxt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SearchArtsen = new System.Windows.Forms.TextBox();
            this.Medicatietab = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.MedicatieIDtxt = new System.Windows.Forms.TextBox();
            this.MedicatieNaamtxt = new System.Windows.Forms.TextBox();
            this.MedicatieKlantid = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SearchMedicatie = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.KlantenGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArtsenGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MedicatieGridView)).BeginInit();
            this.MaakMedicatiebtn.SuspendLayout();
            this.Klantentab.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Artsentab.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Medicatietab.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // KlantenGridView
            // 
            this.KlantenGridView.AllowUserToAddRows = false;
            this.KlantenGridView.AllowUserToDeleteRows = false;
            this.KlantenGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.KlantenGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KlantenGridView.Location = new System.Drawing.Point(8, 43);
            this.KlantenGridView.Margin = new System.Windows.Forms.Padding(4);
            this.KlantenGridView.Name = "KlantenGridView";
            this.KlantenGridView.ReadOnly = true;
            this.KlantenGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.KlantenGridView.Size = new System.Drawing.Size(667, 283);
            this.KlantenGridView.TabIndex = 0;
            this.KlantenGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Klanten";
            // 
            // ArtsenGridview
            // 
            this.ArtsenGridview.AllowUserToAddRows = false;
            this.ArtsenGridview.AllowUserToDeleteRows = false;
            this.ArtsenGridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ArtsenGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ArtsenGridview.Location = new System.Drawing.Point(4, 41);
            this.ArtsenGridview.Margin = new System.Windows.Forms.Padding(4);
            this.ArtsenGridview.Name = "ArtsenGridview";
            this.ArtsenGridview.ReadOnly = true;
            this.ArtsenGridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ArtsenGridview.Size = new System.Drawing.Size(667, 293);
            this.ArtsenGridview.TabIndex = 4;
            this.ArtsenGridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ArtsenGridview_CellContentClick);
            // 
            // VerwijderKlant
            // 
            this.VerwijderKlant.Location = new System.Drawing.Point(310, 29);
            this.VerwijderKlant.Margin = new System.Windows.Forms.Padding(4);
            this.VerwijderKlant.Name = "VerwijderKlant";
            this.VerwijderKlant.Size = new System.Drawing.Size(100, 28);
            this.VerwijderKlant.TabIndex = 5;
            this.VerwijderKlant.Text = "Remove";
            this.VerwijderKlant.UseVisualStyleBackColor = true;
            this.VerwijderKlant.Click += new System.EventHandler(this.VerwijderKlant_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Artsen";
            // 
            // MedicatieGridView
            // 
            this.MedicatieGridView.AllowUserToAddRows = false;
            this.MedicatieGridView.AllowUserToDeleteRows = false;
            this.MedicatieGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MedicatieGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MedicatieGridView.Location = new System.Drawing.Point(8, 43);
            this.MedicatieGridView.Margin = new System.Windows.Forms.Padding(4);
            this.MedicatieGridView.Name = "MedicatieGridView";
            this.MedicatieGridView.ReadOnly = true;
            this.MedicatieGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MedicatieGridView.Size = new System.Drawing.Size(667, 294);
            this.MedicatieGridView.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "Medicatie";
            // 
            // VerwijderArts
            // 
            this.VerwijderArts.Location = new System.Drawing.Point(307, 29);
            this.VerwijderArts.Margin = new System.Windows.Forms.Padding(4);
            this.VerwijderArts.Name = "VerwijderArts";
            this.VerwijderArts.Size = new System.Drawing.Size(100, 28);
            this.VerwijderArts.TabIndex = 12;
            this.VerwijderArts.Text = "Remove";
            this.VerwijderArts.UseVisualStyleBackColor = true;
            this.VerwijderArts.Click += new System.EventHandler(this.VerwijderArts_Click);
            // 
            // VerwijderMedicatie
            // 
            this.VerwijderMedicatie.Location = new System.Drawing.Point(311, 33);
            this.VerwijderMedicatie.Margin = new System.Windows.Forms.Padding(4);
            this.VerwijderMedicatie.Name = "VerwijderMedicatie";
            this.VerwijderMedicatie.Size = new System.Drawing.Size(100, 28);
            this.VerwijderMedicatie.TabIndex = 16;
            this.VerwijderMedicatie.Text = "Remove";
            this.VerwijderMedicatie.UseVisualStyleBackColor = true;
            this.VerwijderMedicatie.Click += new System.EventHandler(this.VerwijderMedicatie_Click);
            // 
            // MaakMedicatiebtn
            // 
            this.MaakMedicatiebtn.Controls.Add(this.Klantentab);
            this.MaakMedicatiebtn.Controls.Add(this.Artsentab);
            this.MaakMedicatiebtn.Controls.Add(this.Medicatietab);
            this.MaakMedicatiebtn.Controls.Add(this.tabPage1);
            this.MaakMedicatiebtn.Controls.Add(this.tabPage2);
            this.MaakMedicatiebtn.Controls.Add(this.tabPage3);
            this.MaakMedicatiebtn.Location = new System.Drawing.Point(4, 3);
            this.MaakMedicatiebtn.Margin = new System.Windows.Forms.Padding(4);
            this.MaakMedicatiebtn.Name = "MaakMedicatiebtn";
            this.MaakMedicatiebtn.SelectedIndex = 0;
            this.MaakMedicatiebtn.Size = new System.Drawing.Size(1016, 462);
            this.MaakMedicatiebtn.TabIndex = 30;
            // 
            // Klantentab
            // 
            this.Klantentab.Controls.Add(this.groupBox7);
            this.Klantentab.Controls.Add(this.groupBox6);
            this.Klantentab.Controls.Add(this.groupBox1);
            this.Klantentab.Controls.Add(this.KlantenGridView);
            this.Klantentab.Controls.Add(this.label1);
            this.Klantentab.Location = new System.Drawing.Point(4, 25);
            this.Klantentab.Margin = new System.Windows.Forms.Padding(4);
            this.Klantentab.Name = "Klantentab";
            this.Klantentab.Padding = new System.Windows.Forms.Padding(4);
            this.Klantentab.Size = new System.Drawing.Size(1008, 433);
            this.Klantentab.TabIndex = 0;
            this.Klantentab.Text = "Klanten";
            this.Klantentab.UseVisualStyleBackColor = true;
            this.Klantentab.Click += new System.EventHandler(this.Klantentab_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 30);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 17);
            this.label14.TabIndex = 53;
            this.label14.Text = "KlantID";
            // 
            // klantidtxtKlant
            // 
            this.klantidtxtKlant.Location = new System.Drawing.Point(67, 30);
            this.klantidtxtKlant.Name = "klantidtxtKlant";
            this.klantidtxtKlant.Size = new System.Drawing.Size(206, 22);
            this.klantidtxtKlant.TabIndex = 52;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Controls.Add(this.VoornaamtxtKlant);
            this.groupBox7.Controls.Add(this.VerzekeringsidtxtKlant);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.AchternaamtxtKlant);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.PlaatstxtKlant);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.MaakKlant);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.AdrestxtKlant);
            this.groupBox7.Location = new System.Drawing.Point(696, 48);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(269, 224);
            this.groupBox7.TabIndex = 56;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Maken";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 43;
            this.label4.Text = "Verzekeringsid";
            // 
            // VoornaamtxtKlant
            // 
            this.VoornaamtxtKlant.Location = new System.Drawing.Point(115, 55);
            this.VoornaamtxtKlant.Margin = new System.Windows.Forms.Padding(4);
            this.VoornaamtxtKlant.Name = "VoornaamtxtKlant";
            this.VoornaamtxtKlant.Size = new System.Drawing.Size(132, 22);
            this.VoornaamtxtKlant.TabIndex = 44;
            // 
            // VerzekeringsidtxtKlant
            // 
            this.VerzekeringsidtxtKlant.Location = new System.Drawing.Point(115, 23);
            this.VerzekeringsidtxtKlant.Margin = new System.Windows.Forms.Padding(4);
            this.VerzekeringsidtxtKlant.Name = "VerzekeringsidtxtKlant";
            this.VerzekeringsidtxtKlant.Size = new System.Drawing.Size(132, 22);
            this.VerzekeringsidtxtKlant.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 59);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 51;
            this.label8.Text = "Voornaam";
            // 
            // AchternaamtxtKlant
            // 
            this.AchternaamtxtKlant.Location = new System.Drawing.Point(115, 87);
            this.AchternaamtxtKlant.Margin = new System.Windows.Forms.Padding(4);
            this.AchternaamtxtKlant.Name = "AchternaamtxtKlant";
            this.AchternaamtxtKlant.Size = new System.Drawing.Size(132, 22);
            this.AchternaamtxtKlant.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 155);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 50;
            this.label7.Text = "Adres";
            // 
            // PlaatstxtKlant
            // 
            this.PlaatstxtKlant.Location = new System.Drawing.Point(115, 119);
            this.PlaatstxtKlant.Margin = new System.Windows.Forms.Padding(4);
            this.PlaatstxtKlant.Name = "PlaatstxtKlant";
            this.PlaatstxtKlant.Size = new System.Drawing.Size(132, 22);
            this.PlaatstxtKlant.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 123);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 49;
            this.label6.Text = "Plaats";
            // 
            // MaakKlant
            // 
            this.MaakKlant.Location = new System.Drawing.Point(6, 190);
            this.MaakKlant.Margin = new System.Windows.Forms.Padding(4);
            this.MaakKlant.Name = "MaakKlant";
            this.MaakKlant.Size = new System.Drawing.Size(100, 28);
            this.MaakKlant.TabIndex = 41;
            this.MaakKlant.Text = "Add";
            this.MaakKlant.UseVisualStyleBackColor = true;
            this.MaakKlant.Click += new System.EventHandler(this.MaakKlant_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 48;
            this.label5.Text = "Achternaam";
            // 
            // AdrestxtKlant
            // 
            this.AdrestxtKlant.Location = new System.Drawing.Point(115, 151);
            this.AdrestxtKlant.Margin = new System.Windows.Forms.Padding(4);
            this.AdrestxtKlant.Name = "AdrestxtKlant";
            this.AdrestxtKlant.Size = new System.Drawing.Size(132, 22);
            this.AdrestxtKlant.TabIndex = 47;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.klantidtxtKlant);
            this.groupBox6.Controls.Add(this.VerwijderKlant);
            this.groupBox6.Location = new System.Drawing.Point(258, 337);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(417, 82);
            this.groupBox6.TabIndex = 55;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Verwijderen";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SrcKlantentxt);
            this.groupBox1.Location = new System.Drawing.Point(8, 337);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 82);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zoeken";
            // 
            // SrcKlantentxt
            // 
            this.SrcKlantentxt.Location = new System.Drawing.Point(10, 35);
            this.SrcKlantentxt.Name = "SrcKlantentxt";
            this.SrcKlantentxt.Size = new System.Drawing.Size(227, 22);
            this.SrcKlantentxt.TabIndex = 30;
            this.SrcKlantentxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Artsentab
            // 
            this.Artsentab.Controls.Add(this.groupBox8);
            this.Artsentab.Controls.Add(this.groupBox5);
            this.Artsentab.Controls.Add(this.groupBox2);
            this.Artsentab.Controls.Add(this.ArtsenGridview);
            this.Artsentab.Controls.Add(this.label2);
            this.Artsentab.Location = new System.Drawing.Point(4, 25);
            this.Artsentab.Margin = new System.Windows.Forms.Padding(4);
            this.Artsentab.Name = "Artsentab";
            this.Artsentab.Padding = new System.Windows.Forms.Padding(4);
            this.Artsentab.Size = new System.Drawing.Size(1008, 433);
            this.Artsentab.TabIndex = 1;
            this.Artsentab.Text = "Artsen";
            this.Artsentab.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label9);
            this.groupBox8.Controls.Add(this.MaakArtsbtn);
            this.groupBox8.Controls.Add(this.NaamArtstxt);
            this.groupBox8.Controls.Add(this.EinddatumArtstxt);
            this.groupBox8.Controls.Add(this.AdresArtstxt);
            this.groupBox8.Controls.Add(this.label13);
            this.groupBox8.Controls.Add(this.label12);
            this.groupBox8.Location = new System.Drawing.Point(690, 41);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(311, 168);
            this.groupBox8.TabIndex = 57;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Maken";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 38);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 17);
            this.label15.TabIndex = 55;
            this.label15.Text = "ArtsID";
            // 
            // Artsidtxt
            // 
            this.Artsidtxt.Location = new System.Drawing.Point(60, 33);
            this.Artsidtxt.Name = "Artsidtxt";
            this.Artsidtxt.Size = new System.Drawing.Size(210, 22);
            this.Artsidtxt.TabIndex = 54;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 48;
            this.label9.Text = "Naam";
            // 
            // MaakArtsbtn
            // 
            this.MaakArtsbtn.Location = new System.Drawing.Point(9, 129);
            this.MaakArtsbtn.Margin = new System.Windows.Forms.Padding(4);
            this.MaakArtsbtn.Name = "MaakArtsbtn";
            this.MaakArtsbtn.Size = new System.Drawing.Size(100, 28);
            this.MaakArtsbtn.TabIndex = 42;
            this.MaakArtsbtn.Text = "Add";
            this.MaakArtsbtn.UseVisualStyleBackColor = true;
            this.MaakArtsbtn.Click += new System.EventHandler(this.MaakArtsbtn_Click);
            // 
            // NaamArtstxt
            // 
            this.NaamArtstxt.Location = new System.Drawing.Point(105, 24);
            this.NaamArtstxt.Name = "NaamArtstxt";
            this.NaamArtstxt.Size = new System.Drawing.Size(145, 22);
            this.NaamArtstxt.TabIndex = 43;
            // 
            // EinddatumArtstxt
            // 
            this.EinddatumArtstxt.Location = new System.Drawing.Point(105, 78);
            this.EinddatumArtstxt.Name = "EinddatumArtstxt";
            this.EinddatumArtstxt.Size = new System.Drawing.Size(200, 22);
            this.EinddatumArtstxt.TabIndex = 53;
            // 
            // AdresArtstxt
            // 
            this.AdresArtstxt.Location = new System.Drawing.Point(105, 50);
            this.AdresArtstxt.Name = "AdresArtstxt";
            this.AdresArtstxt.Size = new System.Drawing.Size(145, 22);
            this.AdresArtstxt.TabIndex = 46;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 17);
            this.label13.TabIndex = 52;
            this.label13.Text = "Einddatum";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 17);
            this.label12.TabIndex = 51;
            this.label12.Text = "Adres";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.Artsidtxt);
            this.groupBox5.Controls.Add(this.VerwijderArts);
            this.groupBox5.Location = new System.Drawing.Point(257, 341);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(414, 82);
            this.groupBox5.TabIndex = 55;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Verwijderen";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SearchArtsen);
            this.groupBox2.Location = new System.Drawing.Point(7, 341);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 82);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zoeken";
            // 
            // SearchArtsen
            // 
            this.SearchArtsen.Location = new System.Drawing.Point(11, 35);
            this.SearchArtsen.Name = "SearchArtsen";
            this.SearchArtsen.Size = new System.Drawing.Size(227, 22);
            this.SearchArtsen.TabIndex = 31;
            this.SearchArtsen.TextChanged += new System.EventHandler(this.SearchArtsen_TextChanged);
            // 
            // Medicatietab
            // 
            this.Medicatietab.Controls.Add(this.groupBox9);
            this.Medicatietab.Controls.Add(this.groupBox4);
            this.Medicatietab.Controls.Add(this.groupBox3);
            this.Medicatietab.Controls.Add(this.MedicatieGridView);
            this.Medicatietab.Controls.Add(this.label3);
            this.Medicatietab.Location = new System.Drawing.Point(4, 25);
            this.Medicatietab.Margin = new System.Windows.Forms.Padding(4);
            this.Medicatietab.Name = "Medicatietab";
            this.Medicatietab.Padding = new System.Windows.Forms.Padding(4);
            this.Medicatietab.Size = new System.Drawing.Size(1008, 433);
            this.Medicatietab.TabIndex = 2;
            this.Medicatietab.Text = "Medicatie";
            this.Medicatietab.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label10);
            this.groupBox9.Controls.Add(this.button2);
            this.groupBox9.Controls.Add(this.MedicatieNaamtxt);
            this.groupBox9.Controls.Add(this.MedicatieKlantid);
            this.groupBox9.Controls.Add(this.label11);
            this.groupBox9.Location = new System.Drawing.Point(694, 43);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(272, 136);
            this.groupBox9.TabIndex = 57;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Maken";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 17);
            this.label10.TabIndex = 44;
            this.label10.Text = "Medicatie Naam";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 39);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 17);
            this.label16.TabIndex = 55;
            this.label16.Text = "MedicatieID";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 99);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 42;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MedicatieIDtxt
            // 
            this.MedicatieIDtxt.Location = new System.Drawing.Point(95, 36);
            this.MedicatieIDtxt.Name = "MedicatieIDtxt";
            this.MedicatieIDtxt.Size = new System.Drawing.Size(181, 22);
            this.MedicatieIDtxt.TabIndex = 54;
            // 
            // MedicatieNaamtxt
            // 
            this.MedicatieNaamtxt.Location = new System.Drawing.Point(126, 27);
            this.MedicatieNaamtxt.Name = "MedicatieNaamtxt";
            this.MedicatieNaamtxt.Size = new System.Drawing.Size(132, 22);
            this.MedicatieNaamtxt.TabIndex = 43;
            // 
            // MedicatieKlantid
            // 
            this.MedicatieKlantid.Location = new System.Drawing.Point(126, 55);
            this.MedicatieKlantid.Name = "MedicatieKlantid";
            this.MedicatieKlantid.Size = new System.Drawing.Size(132, 22);
            this.MedicatieKlantid.TabIndex = 45;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 17);
            this.label11.TabIndex = 46;
            this.label11.Text = "Klant ID";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.VerwijderMedicatie);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.MedicatieIDtxt);
            this.groupBox4.Location = new System.Drawing.Point(257, 344);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(418, 82);
            this.groupBox4.TabIndex = 54;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Verwijderen";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SearchMedicatie);
            this.groupBox3.Location = new System.Drawing.Point(7, 344);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(244, 82);
            this.groupBox3.TabIndex = 53;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Zoeken";
            // 
            // SearchMedicatie
            // 
            this.SearchMedicatie.Location = new System.Drawing.Point(6, 36);
            this.SearchMedicatie.Name = "SearchMedicatie";
            this.SearchMedicatie.Size = new System.Drawing.Size(227, 22);
            this.SearchMedicatie.TabIndex = 31;
            this.SearchMedicatie.TextChanged += new System.EventHandler(this.SearchMedicatie_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1008, 433);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Klanten_Artsen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1008, 433);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "Klanten_Medicatie";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1008, 433);
            this.tabPage3.TabIndex = 5;
            this.tabPage3.Text = "Verzekeringen???";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 467);
            this.Controls.Add(this.MaakMedicatiebtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Gezondheidszorg Database applicatie";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KlantenGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArtsenGridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MedicatieGridView)).EndInit();
            this.MaakMedicatiebtn.ResumeLayout(false);
            this.Klantentab.ResumeLayout(false);
            this.Klantentab.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Artsentab.ResumeLayout(false);
            this.Artsentab.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Medicatietab.ResumeLayout(false);
            this.Medicatietab.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView KlantenGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ArtsenGridview;
        private System.Windows.Forms.Button VerwijderKlant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView MedicatieGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button VerwijderArts;
        private System.Windows.Forms.Button VerwijderMedicatie;
        private System.Windows.Forms.TabControl MaakMedicatiebtn;
        private System.Windows.Forms.TabPage Klantentab;
        private System.Windows.Forms.TabPage Artsentab;
        private System.Windows.Forms.TabPage Medicatietab;
        private System.Windows.Forms.TextBox SrcKlantentxt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AdrestxtKlant;
        private System.Windows.Forms.Button MaakKlant;
        private System.Windows.Forms.TextBox PlaatstxtKlant;
        private System.Windows.Forms.TextBox AchternaamtxtKlant;
        private System.Windows.Forms.TextBox VerzekeringsidtxtKlant;
        private System.Windows.Forms.TextBox VoornaamtxtKlant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SearchArtsen;
        private System.Windows.Forms.TextBox SearchMedicatie;
        private System.Windows.Forms.Button MaakArtsbtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox AdresArtstxt;
        private System.Windows.Forms.TextBox NaamArtstxt;
        private System.Windows.Forms.DateTimePicker EinddatumArtstxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox MedicatieNaamtxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox MedicatieKlantid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox klantidtxtKlant;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Artsidtxt;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox MedicatieIDtxt;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
    }
}

