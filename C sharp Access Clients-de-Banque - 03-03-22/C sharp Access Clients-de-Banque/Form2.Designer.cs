namespace C_sharp_Access_Clients_de_Banque
{
    partial class Formformulaireclient
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.rechercherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parBanqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parVilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parBanqueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.parVilleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.accueilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelnumcin = new System.Windows.Forms.Label();
            this.labelnumcompte = new System.Windows.Forms.Label();
            this.labelnomclient = new System.Windows.Forms.Label();
            this.labelprenomclient = new System.Windows.Forms.Label();
            this.labelvilledclient = new System.Windows.Forms.Label();
            this.labelbanque = new System.Windows.Forms.Label();
            this.textBoxnumcin = new System.Windows.Forms.TextBox();
            this.textBoxnumcompte = new System.Windows.Forms.TextBox();
            this.textBoxnomclient = new System.Windows.Forms.TextBox();
            this.textBoxprenomclient = new System.Windows.Forms.TextBox();
            this.textBoxvilledclient = new System.Windows.Forms.TextBox();
            this.textBoxbanque = new System.Windows.Forms.TextBox();
            this.buttonajouter = new System.Windows.Forms.Button();
            this.buttonafficher = new System.Windows.Forms.Button();
            this.buttonrechercher = new System.Windows.Forms.Button();
            this.buttonmodifier = new System.Windows.Forms.Button();
            this.buttonsupprimer = new System.Windows.Forms.Button();
            this.buttonaccueil = new System.Windows.Forms.Button();
            this.dataGridViewclient = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewclient)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(140)))), ((int)(((byte)(151)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1080, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.afficherToolStripMenuItem,
            this.toolStripMenuItem1,
            this.rechercherToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem,
            this.toolStripMenuItem2,
            this.accueilToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // afficherToolStripMenuItem
            // 
            this.afficherToolStripMenuItem.Name = "afficherToolStripMenuItem";
            this.afficherToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.afficherToolStripMenuItem.Text = "Afficher";
            this.afficherToolStripMenuItem.Click += new System.EventHandler(this.afficherToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(148, 6);
            // 
            // rechercherToolStripMenuItem
            // 
            this.rechercherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parBanqueToolStripMenuItem,
            this.parVilleToolStripMenuItem});
            this.rechercherToolStripMenuItem.Name = "rechercherToolStripMenuItem";
            this.rechercherToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.rechercherToolStripMenuItem.Text = "Rechercher";
            this.rechercherToolStripMenuItem.Click += new System.EventHandler(this.rechercherToolStripMenuItem_Click);
            // 
            // parBanqueToolStripMenuItem
            // 
            this.parBanqueToolStripMenuItem.Name = "parBanqueToolStripMenuItem";
            this.parBanqueToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.parBanqueToolStripMenuItem.Text = "par Banque";
            this.parBanqueToolStripMenuItem.Click += new System.EventHandler(this.parBanqueToolStripMenuItem_Click);
            // 
            // parVilleToolStripMenuItem
            // 
            this.parVilleToolStripMenuItem.Name = "parVilleToolStripMenuItem";
            this.parVilleToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.parVilleToolStripMenuItem.Text = "par Ville";
            this.parVilleToolStripMenuItem.Click += new System.EventHandler(this.parVilleToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parBanqueToolStripMenuItem1,
            this.parVilleToolStripMenuItem1});
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // parBanqueToolStripMenuItem1
            // 
            this.parBanqueToolStripMenuItem1.Name = "parBanqueToolStripMenuItem1";
            this.parBanqueToolStripMenuItem1.Size = new System.Drawing.Size(154, 24);
            this.parBanqueToolStripMenuItem1.Text = "par Banque";
            this.parBanqueToolStripMenuItem1.Click += new System.EventHandler(this.parBanqueToolStripMenuItem1_Click);
            // 
            // parVilleToolStripMenuItem1
            // 
            this.parVilleToolStripMenuItem1.Name = "parVilleToolStripMenuItem1";
            this.parVilleToolStripMenuItem1.Size = new System.Drawing.Size(154, 24);
            this.parVilleToolStripMenuItem1.Text = "par Ville";
            this.parVilleToolStripMenuItem1.Click += new System.EventHandler(this.parVilleToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(148, 6);
            // 
            // accueilToolStripMenuItem
            // 
            this.accueilToolStripMenuItem.Name = "accueilToolStripMenuItem";
            this.accueilToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.accueilToolStripMenuItem.Text = "Accueil";
            this.accueilToolStripMenuItem.Click += new System.EventHandler(this.accueilToolStripMenuItem_Click);
            // 
            // labelnumcin
            // 
            this.labelnumcin.AutoSize = true;
            this.labelnumcin.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnumcin.Location = new System.Drawing.Point(79, 88);
            this.labelnumcin.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelnumcin.Name = "labelnumcin";
            this.labelnumcin.Size = new System.Drawing.Size(62, 21);
            this.labelnumcin.TabIndex = 1;
            this.labelnumcin.Text = "N°CIN";
            this.labelnumcin.Click += new System.EventHandler(this.labelnumcin_Click);
            // 
            // labelnumcompte
            // 
            this.labelnumcompte.AutoSize = true;
            this.labelnumcompte.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnumcompte.Location = new System.Drawing.Point(80, 133);
            this.labelnumcompte.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelnumcompte.Name = "labelnumcompte";
            this.labelnumcompte.Size = new System.Drawing.Size(105, 21);
            this.labelnumcompte.TabIndex = 2;
            this.labelnumcompte.Text = "N°_Compte";
            // 
            // labelnomclient
            // 
            this.labelnomclient.AutoSize = true;
            this.labelnomclient.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnomclient.Location = new System.Drawing.Point(80, 177);
            this.labelnomclient.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelnomclient.Name = "labelnomclient";
            this.labelnomclient.Size = new System.Drawing.Size(116, 21);
            this.labelnomclient.TabIndex = 3;
            this.labelnomclient.Text = "Nom_Client";
            // 
            // labelprenomclient
            // 
            this.labelprenomclient.AutoSize = true;
            this.labelprenomclient.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelprenomclient.Location = new System.Drawing.Point(80, 226);
            this.labelprenomclient.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelprenomclient.Name = "labelprenomclient";
            this.labelprenomclient.Size = new System.Drawing.Size(143, 21);
            this.labelprenomclient.TabIndex = 4;
            this.labelprenomclient.Text = "Prénom_Client";
            // 
            // labelvilledclient
            // 
            this.labelvilledclient.AutoSize = true;
            this.labelvilledclient.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelvilledclient.Location = new System.Drawing.Point(82, 271);
            this.labelvilledclient.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelvilledclient.Name = "labelvilledclient";
            this.labelvilledclient.Size = new System.Drawing.Size(121, 21);
            this.labelvilledclient.TabIndex = 5;
            this.labelvilledclient.Text = "Ville_Client";
            // 
            // labelbanque
            // 
            this.labelbanque.AutoSize = true;
            this.labelbanque.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbanque.Location = new System.Drawing.Point(82, 315);
            this.labelbanque.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelbanque.Name = "labelbanque";
            this.labelbanque.Size = new System.Drawing.Size(76, 21);
            this.labelbanque.TabIndex = 6;
            this.labelbanque.Text = "Banque";
            // 
            // textBoxnumcin
            // 
            this.textBoxnumcin.Location = new System.Drawing.Point(294, 88);
            this.textBoxnumcin.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxnumcin.Name = "textBoxnumcin";
            this.textBoxnumcin.Size = new System.Drawing.Size(236, 30);
            this.textBoxnumcin.TabIndex = 7;
            // 
            // textBoxnumcompte
            // 
            this.textBoxnumcompte.Location = new System.Drawing.Point(294, 133);
            this.textBoxnumcompte.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxnumcompte.Name = "textBoxnumcompte";
            this.textBoxnumcompte.Size = new System.Drawing.Size(236, 30);
            this.textBoxnumcompte.TabIndex = 8;
            // 
            // textBoxnomclient
            // 
            this.textBoxnomclient.Location = new System.Drawing.Point(294, 177);
            this.textBoxnomclient.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxnomclient.Name = "textBoxnomclient";
            this.textBoxnomclient.Size = new System.Drawing.Size(236, 30);
            this.textBoxnomclient.TabIndex = 9;
            // 
            // textBoxprenomclient
            // 
            this.textBoxprenomclient.Location = new System.Drawing.Point(294, 226);
            this.textBoxprenomclient.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxprenomclient.Name = "textBoxprenomclient";
            this.textBoxprenomclient.Size = new System.Drawing.Size(236, 30);
            this.textBoxprenomclient.TabIndex = 10;
            // 
            // textBoxvilledclient
            // 
            this.textBoxvilledclient.Location = new System.Drawing.Point(294, 271);
            this.textBoxvilledclient.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxvilledclient.Name = "textBoxvilledclient";
            this.textBoxvilledclient.Size = new System.Drawing.Size(236, 30);
            this.textBoxvilledclient.TabIndex = 11;
            // 
            // textBoxbanque
            // 
            this.textBoxbanque.Location = new System.Drawing.Point(294, 315);
            this.textBoxbanque.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxbanque.Name = "textBoxbanque";
            this.textBoxbanque.Size = new System.Drawing.Size(236, 30);
            this.textBoxbanque.TabIndex = 12;
            // 
            // buttonajouter
            // 
            this.buttonajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(78)))), ((int)(((byte)(103)))));
            this.buttonajouter.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonajouter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonajouter.Location = new System.Drawing.Point(599, 88);
            this.buttonajouter.Margin = new System.Windows.Forms.Padding(5);
            this.buttonajouter.Name = "buttonajouter";
            this.buttonajouter.Size = new System.Drawing.Size(198, 37);
            this.buttonajouter.TabIndex = 13;
            this.buttonajouter.Text = "Ajouter";
            this.buttonajouter.UseVisualStyleBackColor = false;
            this.buttonajouter.Click += new System.EventHandler(this.buttonajouter_Click);
            // 
            // buttonafficher
            // 
            this.buttonafficher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(78)))), ((int)(((byte)(103)))));
            this.buttonafficher.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonafficher.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonafficher.Location = new System.Drawing.Point(817, 88);
            this.buttonafficher.Margin = new System.Windows.Forms.Padding(5);
            this.buttonafficher.Name = "buttonafficher";
            this.buttonafficher.Size = new System.Drawing.Size(198, 37);
            this.buttonafficher.TabIndex = 14;
            this.buttonafficher.Text = "Afficher";
            this.buttonafficher.UseVisualStyleBackColor = false;
            this.buttonafficher.Click += new System.EventHandler(this.buttonafficher_Click);
            // 
            // buttonrechercher
            // 
            this.buttonrechercher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(78)))), ((int)(((byte)(103)))));
            this.buttonrechercher.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonrechercher.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonrechercher.Location = new System.Drawing.Point(599, 150);
            this.buttonrechercher.Margin = new System.Windows.Forms.Padding(5);
            this.buttonrechercher.Name = "buttonrechercher";
            this.buttonrechercher.Size = new System.Drawing.Size(198, 37);
            this.buttonrechercher.TabIndex = 15;
            this.buttonrechercher.Text = "Rechercher";
            this.buttonrechercher.UseVisualStyleBackColor = false;
            this.buttonrechercher.Click += new System.EventHandler(this.buttonrechercher_Click);
            // 
            // buttonmodifier
            // 
            this.buttonmodifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(78)))), ((int)(((byte)(103)))));
            this.buttonmodifier.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmodifier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonmodifier.Location = new System.Drawing.Point(817, 150);
            this.buttonmodifier.Margin = new System.Windows.Forms.Padding(5);
            this.buttonmodifier.Name = "buttonmodifier";
            this.buttonmodifier.Size = new System.Drawing.Size(198, 37);
            this.buttonmodifier.TabIndex = 16;
            this.buttonmodifier.Text = "Modifier";
            this.buttonmodifier.UseVisualStyleBackColor = false;
            this.buttonmodifier.Click += new System.EventHandler(this.buttonmodifier_Click);
            // 
            // buttonsupprimer
            // 
            this.buttonsupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(78)))), ((int)(((byte)(103)))));
            this.buttonsupprimer.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsupprimer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonsupprimer.Location = new System.Drawing.Point(709, 210);
            this.buttonsupprimer.Margin = new System.Windows.Forms.Padding(5);
            this.buttonsupprimer.Name = "buttonsupprimer";
            this.buttonsupprimer.Size = new System.Drawing.Size(198, 37);
            this.buttonsupprimer.TabIndex = 17;
            this.buttonsupprimer.Text = "Supprimer";
            this.buttonsupprimer.UseVisualStyleBackColor = false;
            this.buttonsupprimer.Click += new System.EventHandler(this.buttonsupprimer_Click);
            // 
            // buttonaccueil
            // 
            this.buttonaccueil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(78)))), ((int)(((byte)(103)))));
            this.buttonaccueil.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonaccueil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonaccueil.Location = new System.Drawing.Point(709, 263);
            this.buttonaccueil.Margin = new System.Windows.Forms.Padding(5);
            this.buttonaccueil.Name = "buttonaccueil";
            this.buttonaccueil.Size = new System.Drawing.Size(198, 37);
            this.buttonaccueil.TabIndex = 18;
            this.buttonaccueil.Text = "Accueil";
            this.buttonaccueil.UseVisualStyleBackColor = false;
            this.buttonaccueil.Click += new System.EventHandler(this.buttonaccueil_Click);
            // 
            // dataGridViewclient
            // 
            this.dataGridViewclient.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(174)))), ((int)(((byte)(168)))));
            this.dataGridViewclient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewclient.Location = new System.Drawing.Point(83, 400);
            this.dataGridViewclient.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridViewclient.Name = "dataGridViewclient";
            this.dataGridViewclient.RowTemplate.Height = 24;
            this.dataGridViewclient.Size = new System.Drawing.Size(948, 180);
            this.dataGridViewclient.TabIndex = 19;
            // 
            // Formformulaireclient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(233)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1080, 652);
            this.Controls.Add(this.dataGridViewclient);
            this.Controls.Add(this.buttonaccueil);
            this.Controls.Add(this.buttonsupprimer);
            this.Controls.Add(this.buttonmodifier);
            this.Controls.Add(this.buttonrechercher);
            this.Controls.Add(this.buttonafficher);
            this.Controls.Add(this.buttonajouter);
            this.Controls.Add(this.textBoxbanque);
            this.Controls.Add(this.textBoxvilledclient);
            this.Controls.Add(this.textBoxprenomclient);
            this.Controls.Add(this.textBoxnomclient);
            this.Controls.Add(this.textBoxnumcompte);
            this.Controls.Add(this.textBoxnumcin);
            this.Controls.Add(this.labelbanque);
            this.Controls.Add(this.labelvilledclient);
            this.Controls.Add(this.labelprenomclient);
            this.Controls.Add(this.labelnomclient);
            this.Controls.Add(this.labelnumcompte);
            this.Controls.Add(this.labelnumcin);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Formformulaireclient";
            this.Text = "Formulaire Client";
            this.Load += new System.EventHandler(this.Formformulaireclient_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewclient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rechercherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parBanqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parVilleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parBanqueToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem parVilleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem accueilToolStripMenuItem;
        private System.Windows.Forms.Label labelnumcin;
        private System.Windows.Forms.Label labelnumcompte;
        private System.Windows.Forms.Label labelnomclient;
        private System.Windows.Forms.Label labelprenomclient;
        private System.Windows.Forms.Label labelvilledclient;
        private System.Windows.Forms.Label labelbanque;
        private System.Windows.Forms.TextBox textBoxnumcin;
        private System.Windows.Forms.TextBox textBoxnumcompte;
        private System.Windows.Forms.TextBox textBoxnomclient;
        private System.Windows.Forms.TextBox textBoxprenomclient;
        private System.Windows.Forms.TextBox textBoxvilledclient;
        private System.Windows.Forms.TextBox textBoxbanque;
        private System.Windows.Forms.Button buttonajouter;
        private System.Windows.Forms.Button buttonafficher;
        private System.Windows.Forms.Button buttonrechercher;
        private System.Windows.Forms.Button buttonmodifier;
        private System.Windows.Forms.Button buttonsupprimer;
        private System.Windows.Forms.Button buttonaccueil;
        private System.Windows.Forms.DataGridView dataGridViewclient;
    }
}