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
            this.BewerkKlant = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.MedicatieGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.BewerkArts = new System.Windows.Forms.Button();
            this.VerwijderArts = new System.Windows.Forms.Button();
            this.FilterArts = new System.Windows.Forms.Button();
            this.MaakArts = new System.Windows.Forms.Button();
            this.BewerkMedicatie = new System.Windows.Forms.Button();
            this.VerwijderMedicatie = new System.Windows.Forms.Button();
            this.FilterMedicatie = new System.Windows.Forms.Button();
            this.MaakMedicatie = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Klantentab = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Artsentab = new System.Windows.Forms.TabPage();
            this.Medicatietab = new System.Windows.Forms.TabPage();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AdrestxtKlant = new System.Windows.Forms.TextBox();
            this.MaakKlant = new System.Windows.Forms.Button();
            this.PlaatstxtKlant = new System.Windows.Forms.TextBox();
            this.AchternaamtxtKlant = new System.Windows.Forms.TextBox();
            this.VerzekeringsidtxtKlant = new System.Windows.Forms.TextBox();
            this.VoornaamtxtKlant = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.KlantenGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArtsenGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MedicatieGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Klantentab.SuspendLayout();
            this.Artsentab.SuspendLayout();
            this.Medicatietab.SuspendLayout();
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
            // 
            // VerwijderKlant
            // 
            this.VerwijderKlant.Location = new System.Drawing.Point(380, 337);
            this.VerwijderKlant.Margin = new System.Windows.Forms.Padding(4);
            this.VerwijderKlant.Name = "VerwijderKlant";
            this.VerwijderKlant.Size = new System.Drawing.Size(100, 28);
            this.VerwijderKlant.TabIndex = 5;
            this.VerwijderKlant.Text = "Remove";
            this.VerwijderKlant.UseVisualStyleBackColor = true;
            this.VerwijderKlant.Click += new System.EventHandler(this.VerwijderKlant_Click);
            // 
            // BewerkKlant
            // 
            this.BewerkKlant.Location = new System.Drawing.Point(272, 337);
            this.BewerkKlant.Margin = new System.Windows.Forms.Padding(4);
            this.BewerkKlant.Name = "BewerkKlant";
            this.BewerkKlant.Size = new System.Drawing.Size(100, 28);
            this.BewerkKlant.TabIndex = 6;
            this.BewerkKlant.Text = "Edit";
            this.BewerkKlant.UseVisualStyleBackColor = true;
            this.BewerkKlant.Click += new System.EventHandler(this.BewerkKlant_Click);
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
            // BewerkArts
            // 
            this.BewerkArts.Location = new System.Drawing.Point(224, 361);
            this.BewerkArts.Margin = new System.Windows.Forms.Padding(4);
            this.BewerkArts.Name = "BewerkArts";
            this.BewerkArts.Size = new System.Drawing.Size(100, 28);
            this.BewerkArts.TabIndex = 13;
            this.BewerkArts.Text = "Edit";
            this.BewerkArts.UseVisualStyleBackColor = true;
            this.BewerkArts.Click += new System.EventHandler(this.BewerkArts_Click);
            // 
            // VerwijderArts
            // 
            this.VerwijderArts.Location = new System.Drawing.Point(332, 361);
            this.VerwijderArts.Margin = new System.Windows.Forms.Padding(4);
            this.VerwijderArts.Name = "VerwijderArts";
            this.VerwijderArts.Size = new System.Drawing.Size(100, 28);
            this.VerwijderArts.TabIndex = 12;
            this.VerwijderArts.Text = "Remove";
            this.VerwijderArts.UseVisualStyleBackColor = true;
            this.VerwijderArts.Click += new System.EventHandler(this.VerwijderArts_Click);
            // 
            // FilterArts
            // 
            this.FilterArts.Location = new System.Drawing.Point(116, 361);
            this.FilterArts.Margin = new System.Windows.Forms.Padding(4);
            this.FilterArts.Name = "FilterArts";
            this.FilterArts.Size = new System.Drawing.Size(100, 28);
            this.FilterArts.TabIndex = 11;
            this.FilterArts.Text = "Filter";
            this.FilterArts.UseVisualStyleBackColor = true;
            this.FilterArts.Click += new System.EventHandler(this.FilterArts_Click);
            // 
            // MaakArts
            // 
            this.MaakArts.Location = new System.Drawing.Point(8, 361);
            this.MaakArts.Margin = new System.Windows.Forms.Padding(4);
            this.MaakArts.Name = "MaakArts";
            this.MaakArts.Size = new System.Drawing.Size(100, 28);
            this.MaakArts.TabIndex = 10;
            this.MaakArts.Text = "Add";
            this.MaakArts.UseVisualStyleBackColor = true;
            this.MaakArts.Click += new System.EventHandler(this.MaakArts_Click);
            // 
            // BewerkMedicatie
            // 
            this.BewerkMedicatie.Location = new System.Drawing.Point(224, 345);
            this.BewerkMedicatie.Margin = new System.Windows.Forms.Padding(4);
            this.BewerkMedicatie.Name = "BewerkMedicatie";
            this.BewerkMedicatie.Size = new System.Drawing.Size(100, 28);
            this.BewerkMedicatie.TabIndex = 17;
            this.BewerkMedicatie.Text = "Edit";
            this.BewerkMedicatie.UseVisualStyleBackColor = true;
            this.BewerkMedicatie.Click += new System.EventHandler(this.BewerkMedicatie_Click);
            // 
            // VerwijderMedicatie
            // 
            this.VerwijderMedicatie.Location = new System.Drawing.Point(332, 345);
            this.VerwijderMedicatie.Margin = new System.Windows.Forms.Padding(4);
            this.VerwijderMedicatie.Name = "VerwijderMedicatie";
            this.VerwijderMedicatie.Size = new System.Drawing.Size(100, 28);
            this.VerwijderMedicatie.TabIndex = 16;
            this.VerwijderMedicatie.Text = "Remove";
            this.VerwijderMedicatie.UseVisualStyleBackColor = true;
            this.VerwijderMedicatie.Click += new System.EventHandler(this.VerwijderMedicatie_Click);
            // 
            // FilterMedicatie
            // 
            this.FilterMedicatie.Location = new System.Drawing.Point(116, 345);
            this.FilterMedicatie.Margin = new System.Windows.Forms.Padding(4);
            this.FilterMedicatie.Name = "FilterMedicatie";
            this.FilterMedicatie.Size = new System.Drawing.Size(100, 28);
            this.FilterMedicatie.TabIndex = 15;
            this.FilterMedicatie.Text = "Filter";
            this.FilterMedicatie.UseVisualStyleBackColor = true;
            this.FilterMedicatie.Click += new System.EventHandler(this.FilterMedicatie_Click);
            // 
            // MaakMedicatie
            // 
            this.MaakMedicatie.Location = new System.Drawing.Point(8, 345);
            this.MaakMedicatie.Margin = new System.Windows.Forms.Padding(4);
            this.MaakMedicatie.Name = "MaakMedicatie";
            this.MaakMedicatie.Size = new System.Drawing.Size(100, 28);
            this.MaakMedicatie.TabIndex = 14;
            this.MaakMedicatie.Text = "Add";
            this.MaakMedicatie.UseVisualStyleBackColor = true;
            this.MaakMedicatie.Click += new System.EventHandler(this.MaakMedicatie_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Klantentab);
            this.tabControl1.Controls.Add(this.Artsentab);
            this.tabControl1.Controls.Add(this.Medicatietab);
            this.tabControl1.Location = new System.Drawing.Point(16, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1052, 880);
            this.tabControl1.TabIndex = 30;
            // 
            // Klantentab
            // 
            this.Klantentab.Controls.Add(this.label8);
            this.Klantentab.Controls.Add(this.label7);
            this.Klantentab.Controls.Add(this.label6);
            this.Klantentab.Controls.Add(this.label5);
            this.Klantentab.Controls.Add(this.AdrestxtKlant);
            this.Klantentab.Controls.Add(this.MaakKlant);
            this.Klantentab.Controls.Add(this.PlaatstxtKlant);
            this.Klantentab.Controls.Add(this.AchternaamtxtKlant);
            this.Klantentab.Controls.Add(this.VerzekeringsidtxtKlant);
            this.Klantentab.Controls.Add(this.VoornaamtxtKlant);
            this.Klantentab.Controls.Add(this.label4);
            this.Klantentab.Controls.Add(this.textBox1);
            this.Klantentab.Controls.Add(this.KlantenGridView);
            this.Klantentab.Controls.Add(this.label1);
            this.Klantentab.Controls.Add(this.VerwijderKlant);
            this.Klantentab.Controls.Add(this.BewerkKlant);
            this.Klantentab.Location = new System.Drawing.Point(4, 25);
            this.Klantentab.Margin = new System.Windows.Forms.Padding(4);
            this.Klantentab.Name = "Klantentab";
            this.Klantentab.Padding = new System.Windows.Forms.Padding(4);
            this.Klantentab.Size = new System.Drawing.Size(1044, 851);
            this.Klantentab.TabIndex = 0;
            this.Klantentab.Text = "Klanten";
            this.Klantentab.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 337);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 22);
            this.textBox1.TabIndex = 30;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Artsentab
            // 
            this.Artsentab.Controls.Add(this.ArtsenGridview);
            this.Artsentab.Controls.Add(this.MaakArts);
            this.Artsentab.Controls.Add(this.label2);
            this.Artsentab.Controls.Add(this.FilterArts);
            this.Artsentab.Controls.Add(this.VerwijderArts);
            this.Artsentab.Controls.Add(this.BewerkArts);
            this.Artsentab.Location = new System.Drawing.Point(4, 25);
            this.Artsentab.Margin = new System.Windows.Forms.Padding(4);
            this.Artsentab.Name = "Artsentab";
            this.Artsentab.Padding = new System.Windows.Forms.Padding(4);
            this.Artsentab.Size = new System.Drawing.Size(1044, 851);
            this.Artsentab.TabIndex = 1;
            this.Artsentab.Text = "Artsen";
            this.Artsentab.UseVisualStyleBackColor = true;
            // 
            // Medicatietab
            // 
            this.Medicatietab.Controls.Add(this.MedicatieGridView);
            this.Medicatietab.Controls.Add(this.BewerkMedicatie);
            this.Medicatietab.Controls.Add(this.label3);
            this.Medicatietab.Controls.Add(this.VerwijderMedicatie);
            this.Medicatietab.Controls.Add(this.MaakMedicatie);
            this.Medicatietab.Controls.Add(this.FilterMedicatie);
            this.Medicatietab.Location = new System.Drawing.Point(4, 25);
            this.Medicatietab.Margin = new System.Windows.Forms.Padding(4);
            this.Medicatietab.Name = "Medicatietab";
            this.Medicatietab.Padding = new System.Windows.Forms.Padding(4);
            this.Medicatietab.Size = new System.Drawing.Size(1044, 851);
            this.Medicatietab.TabIndex = 2;
            this.Medicatietab.Text = "Medicatie";
            this.Medicatietab.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(687, 125);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 51;
            this.label8.Text = "Voornaam";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(689, 221);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 50;
            this.label7.Text = "Adres";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(687, 189);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 49;
            this.label6.Text = "Plaats";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(687, 157);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 48;
            this.label5.Text = "Achternaam";
            // 
            // AdrestxtKlant
            // 
            this.AdrestxtKlant.Location = new System.Drawing.Point(796, 217);
            this.AdrestxtKlant.Margin = new System.Windows.Forms.Padding(4);
            this.AdrestxtKlant.Name = "AdrestxtKlant";
            this.AdrestxtKlant.Size = new System.Drawing.Size(132, 22);
            this.AdrestxtKlant.TabIndex = 47;
            // 
            // MaakKlant
            // 
            this.MaakKlant.Location = new System.Drawing.Point(692, 264);
            this.MaakKlant.Margin = new System.Windows.Forms.Padding(4);
            this.MaakKlant.Name = "MaakKlant";
            this.MaakKlant.Size = new System.Drawing.Size(100, 28);
            this.MaakKlant.TabIndex = 41;
            this.MaakKlant.Text = "Add";
            this.MaakKlant.UseVisualStyleBackColor = true;
            this.MaakKlant.Click += new System.EventHandler(this.MaakKlant_Click_1);
            // 
            // PlaatstxtKlant
            // 
            this.PlaatstxtKlant.Location = new System.Drawing.Point(796, 185);
            this.PlaatstxtKlant.Margin = new System.Windows.Forms.Padding(4);
            this.PlaatstxtKlant.Name = "PlaatstxtKlant";
            this.PlaatstxtKlant.Size = new System.Drawing.Size(132, 22);
            this.PlaatstxtKlant.TabIndex = 46;
            // 
            // AchternaamtxtKlant
            // 
            this.AchternaamtxtKlant.Location = new System.Drawing.Point(796, 153);
            this.AchternaamtxtKlant.Margin = new System.Windows.Forms.Padding(4);
            this.AchternaamtxtKlant.Name = "AchternaamtxtKlant";
            this.AchternaamtxtKlant.Size = new System.Drawing.Size(132, 22);
            this.AchternaamtxtKlant.TabIndex = 45;
            // 
            // VerzekeringsidtxtKlant
            // 
            this.VerzekeringsidtxtKlant.Location = new System.Drawing.Point(796, 89);
            this.VerzekeringsidtxtKlant.Margin = new System.Windows.Forms.Padding(4);
            this.VerzekeringsidtxtKlant.Name = "VerzekeringsidtxtKlant";
            this.VerzekeringsidtxtKlant.Size = new System.Drawing.Size(132, 22);
            this.VerzekeringsidtxtKlant.TabIndex = 42;
            // 
            // VoornaamtxtKlant
            // 
            this.VoornaamtxtKlant.Location = new System.Drawing.Point(796, 121);
            this.VoornaamtxtKlant.Margin = new System.Windows.Forms.Padding(4);
            this.VoornaamtxtKlant.Name = "VoornaamtxtKlant";
            this.VoornaamtxtKlant.Size = new System.Drawing.Size(132, 22);
            this.VoornaamtxtKlant.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(688, 93);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 43;
            this.label4.Text = "Verzekeringsid";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 765);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Gezondheidszorg Database applicatie";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KlantenGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArtsenGridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MedicatieGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Klantentab.ResumeLayout(false);
            this.Klantentab.PerformLayout();
            this.Artsentab.ResumeLayout(false);
            this.Artsentab.PerformLayout();
            this.Medicatietab.ResumeLayout(false);
            this.Medicatietab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView KlantenGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ArtsenGridview;
        private System.Windows.Forms.Button VerwijderKlant;
        private System.Windows.Forms.Button BewerkKlant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView MedicatieGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BewerkArts;
        private System.Windows.Forms.Button VerwijderArts;
        private System.Windows.Forms.Button FilterArts;
        private System.Windows.Forms.Button MaakArts;
        private System.Windows.Forms.Button BewerkMedicatie;
        private System.Windows.Forms.Button VerwijderMedicatie;
        private System.Windows.Forms.Button FilterMedicatie;
        private System.Windows.Forms.Button MaakMedicatie;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Klantentab;
        private System.Windows.Forms.TabPage Artsentab;
        private System.Windows.Forms.TabPage Medicatietab;
        private System.Windows.Forms.TextBox textBox1;
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
    }
}

