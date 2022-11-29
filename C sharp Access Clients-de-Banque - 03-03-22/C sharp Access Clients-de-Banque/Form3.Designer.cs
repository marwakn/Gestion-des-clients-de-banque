namespace C_sharp_Access_Clients_de_Banque
{
    partial class Formformulaireoperation
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
            this.labelnumoperation = new System.Windows.Forms.Label();
            this.labelnumcin = new System.Windows.Forms.Label();
            this.labeldateoperation = new System.Windows.Forms.Label();
            this.labelLibelle = new System.Windows.Forms.Label();
            this.labeldebitdh = new System.Windows.Forms.Label();
            this.labelcreditdh = new System.Windows.Forms.Label();
            this.textBoxnumoperation = new System.Windows.Forms.TextBox();
            this.textBoxnumcin = new System.Windows.Forms.TextBox();
            this.textBoxdateoperation = new System.Windows.Forms.TextBox();
            this.textBoxdebitdh = new System.Windows.Forms.TextBox();
            this.textBoxcreditdh = new System.Windows.Forms.TextBox();
            this.buttonajouter = new System.Windows.Forms.Button();
            this.buttonafficher = new System.Windows.Forms.Button();
            this.buttonrechercher = new System.Windows.Forms.Button();
            this.buttonmodifier = new System.Windows.Forms.Button();
            this.buttonsupprimer = new System.Windows.Forms.Button();
            this.buttonaccueil = new System.Windows.Forms.Button();
            this.dataGridViewoperation = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeDOpérationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerUneOpérationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeDOpérationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.accueilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxlibelle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewoperation)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelnumoperation
            // 
            this.labelnumoperation.AutoSize = true;
            this.labelnumoperation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(233)))), ((int)(((byte)(229)))));
            this.labelnumoperation.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnumoperation.Location = new System.Drawing.Point(66, 101);
            this.labelnumoperation.Name = "labelnumoperation";
            this.labelnumoperation.Size = new System.Drawing.Size(113, 21);
            this.labelnumoperation.TabIndex = 0;
            this.labelnumoperation.Text = "N°Opération";
            // 
            // labelnumcin
            // 
            this.labelnumcin.AutoSize = true;
            this.labelnumcin.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnumcin.Location = new System.Drawing.Point(66, 147);
            this.labelnumcin.Name = "labelnumcin";
            this.labelnumcin.Size = new System.Drawing.Size(62, 21);
            this.labelnumcin.TabIndex = 1;
            this.labelnumcin.Text = "N°CIN";
            // 
            // labeldateoperation
            // 
            this.labeldateoperation.AutoSize = true;
            this.labeldateoperation.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldateoperation.Location = new System.Drawing.Point(66, 192);
            this.labeldateoperation.Name = "labeldateoperation";
            this.labeldateoperation.Size = new System.Drawing.Size(143, 21);
            this.labeldateoperation.TabIndex = 2;
            this.labeldateoperation.Text = "Date-Opération";
            // 
            // labelLibelle
            // 
            this.labelLibelle.AutoSize = true;
            this.labelLibelle.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLibelle.Location = new System.Drawing.Point(66, 239);
            this.labelLibelle.Name = "labelLibelle";
            this.labelLibelle.Size = new System.Drawing.Size(73, 21);
            this.labelLibelle.TabIndex = 3;
            this.labelLibelle.Text = "Libéllé";
            // 
            // labeldebitdh
            // 
            this.labeldebitdh.AutoSize = true;
            this.labeldebitdh.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldebitdh.Location = new System.Drawing.Point(66, 285);
            this.labeldebitdh.Name = "labeldebitdh";
            this.labeldebitdh.Size = new System.Drawing.Size(121, 21);
            this.labeldebitdh.TabIndex = 4;
            this.labeldebitdh.Text = "Débit en DH";
            // 
            // labelcreditdh
            // 
            this.labelcreditdh.AutoSize = true;
            this.labelcreditdh.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcreditdh.Location = new System.Drawing.Point(66, 334);
            this.labelcreditdh.Name = "labelcreditdh";
            this.labelcreditdh.Size = new System.Drawing.Size(125, 21);
            this.labelcreditdh.TabIndex = 5;
            this.labelcreditdh.Text = "Crédit en DH";
            // 
            // textBoxnumoperation
            // 
            this.textBoxnumoperation.Location = new System.Drawing.Point(281, 101);
            this.textBoxnumoperation.Name = "textBoxnumoperation";
            this.textBoxnumoperation.Size = new System.Drawing.Size(164, 22);
            this.textBoxnumoperation.TabIndex = 6;
            // 
            // textBoxnumcin
            // 
            this.textBoxnumcin.Location = new System.Drawing.Point(281, 147);
            this.textBoxnumcin.Name = "textBoxnumcin";
            this.textBoxnumcin.Size = new System.Drawing.Size(164, 22);
            this.textBoxnumcin.TabIndex = 7;
            // 
            // textBoxdateoperation
            // 
            this.textBoxdateoperation.Location = new System.Drawing.Point(281, 192);
            this.textBoxdateoperation.Name = "textBoxdateoperation";
            this.textBoxdateoperation.Size = new System.Drawing.Size(164, 22);
            this.textBoxdateoperation.TabIndex = 8;
            this.textBoxdateoperation.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBoxdebitdh
            // 
            this.textBoxdebitdh.Location = new System.Drawing.Point(281, 285);
            this.textBoxdebitdh.Name = "textBoxdebitdh";
            this.textBoxdebitdh.Size = new System.Drawing.Size(164, 22);
            this.textBoxdebitdh.TabIndex = 10;
            // 
            // textBoxcreditdh
            // 
            this.textBoxcreditdh.Location = new System.Drawing.Point(281, 334);
            this.textBoxcreditdh.Name = "textBoxcreditdh";
            this.textBoxcreditdh.Size = new System.Drawing.Size(164, 22);
            this.textBoxcreditdh.TabIndex = 11;
            // 
            // buttonajouter
            // 
            this.buttonajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(78)))), ((int)(((byte)(103)))));
            this.buttonajouter.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonajouter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonajouter.Location = new System.Drawing.Point(542, 113);
            this.buttonajouter.Name = "buttonajouter";
            this.buttonajouter.Size = new System.Drawing.Size(141, 40);
            this.buttonajouter.TabIndex = 12;
            this.buttonajouter.Text = "Ajouter";
            this.buttonajouter.UseVisualStyleBackColor = false;
            this.buttonajouter.Click += new System.EventHandler(this.buttonajouter_Click);
            // 
            // buttonafficher
            // 
            this.buttonafficher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(78)))), ((int)(((byte)(103)))));
            this.buttonafficher.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonafficher.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonafficher.Location = new System.Drawing.Point(744, 113);
            this.buttonafficher.Name = "buttonafficher";
            this.buttonafficher.Size = new System.Drawing.Size(141, 40);
            this.buttonafficher.TabIndex = 13;
            this.buttonafficher.Text = "Afficher";
            this.buttonafficher.UseVisualStyleBackColor = false;
            this.buttonafficher.Click += new System.EventHandler(this.buttonafficher_Click);
            // 
            // buttonrechercher
            // 
            this.buttonrechercher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(78)))), ((int)(((byte)(103)))));
            this.buttonrechercher.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonrechercher.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonrechercher.Location = new System.Drawing.Point(542, 173);
            this.buttonrechercher.Name = "buttonrechercher";
            this.buttonrechercher.Size = new System.Drawing.Size(141, 40);
            this.buttonrechercher.TabIndex = 14;
            this.buttonrechercher.Text = "Rechercher";
            this.buttonrechercher.UseVisualStyleBackColor = false;
            this.buttonrechercher.Click += new System.EventHandler(this.buttonrechercher_Click);
            // 
            // buttonmodifier
            // 
            this.buttonmodifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(78)))), ((int)(((byte)(103)))));
            this.buttonmodifier.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmodifier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonmodifier.Location = new System.Drawing.Point(744, 173);
            this.buttonmodifier.Name = "buttonmodifier";
            this.buttonmodifier.Size = new System.Drawing.Size(141, 40);
            this.buttonmodifier.TabIndex = 15;
            this.buttonmodifier.Text = "Modifier";
            this.buttonmodifier.UseVisualStyleBackColor = false;
            this.buttonmodifier.Click += new System.EventHandler(this.buttonmodifier_Click);
            // 
            // buttonsupprimer
            // 
            this.buttonsupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(78)))), ((int)(((byte)(103)))));
            this.buttonsupprimer.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsupprimer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonsupprimer.Location = new System.Drawing.Point(639, 234);
            this.buttonsupprimer.Name = "buttonsupprimer";
            this.buttonsupprimer.Size = new System.Drawing.Size(141, 40);
            this.buttonsupprimer.TabIndex = 16;
            this.buttonsupprimer.Text = "Supprimer";
            this.buttonsupprimer.UseVisualStyleBackColor = false;
            this.buttonsupprimer.Click += new System.EventHandler(this.buttonsupprimer_Click);
            // 
            // buttonaccueil
            // 
            this.buttonaccueil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(78)))), ((int)(((byte)(103)))));
            this.buttonaccueil.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonaccueil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonaccueil.Location = new System.Drawing.Point(639, 288);
            this.buttonaccueil.Name = "buttonaccueil";
            this.buttonaccueil.Size = new System.Drawing.Size(141, 40);
            this.buttonaccueil.TabIndex = 17;
            this.buttonaccueil.Text = "Accueil";
            this.buttonaccueil.UseVisualStyleBackColor = false;
            this.buttonaccueil.Click += new System.EventHandler(this.buttonaccueil_Click);
            // 
            // dataGridViewoperation
            // 
            this.dataGridViewoperation.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(174)))), ((int)(((byte)(168)))));
            this.dataGridViewoperation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewoperation.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dataGridViewoperation.Location = new System.Drawing.Point(71, 382);
            this.dataGridViewoperation.Name = "dataGridViewoperation";
            this.dataGridViewoperation.RowTemplate.Height = 24;
            this.dataGridViewoperation.Size = new System.Drawing.Size(1018, 213);
            this.dataGridViewoperation.TabIndex = 18;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(140)))), ((int)(((byte)(151)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1224, 28);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.afficherToolStripMenuItem,
            this.rechercherToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.supprimerUneOpérationToolStripMenuItem,
            this.accueilToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(246, 24);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // afficherToolStripMenuItem
            // 
            this.afficherToolStripMenuItem.Name = "afficherToolStripMenuItem";
            this.afficherToolStripMenuItem.Size = new System.Drawing.Size(246, 24);
            this.afficherToolStripMenuItem.Text = "Afficher ";
            this.afficherToolStripMenuItem.Click += new System.EventHandler(this.afficherToolStripMenuItem_Click);
            // 
            // rechercherToolStripMenuItem
            // 
            this.rechercherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.typeDOpérationToolStripMenuItem});
            this.rechercherToolStripMenuItem.Name = "rechercherToolStripMenuItem";
            this.rechercherToolStripMenuItem.Size = new System.Drawing.Size(246, 24);
            this.rechercherToolStripMenuItem.Text = "Rechercher";
            // 
            // typeDOpérationToolStripMenuItem
            // 
            this.typeDOpérationToolStripMenuItem.Name = "typeDOpérationToolStripMenuItem";
            this.typeDOpérationToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.typeDOpérationToolStripMenuItem.Text = "Type d\'Opération";
            this.typeDOpérationToolStripMenuItem.Click += new System.EventHandler(this.typeDOpérationToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(246, 24);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // supprimerUneOpérationToolStripMenuItem
            // 
            this.supprimerUneOpérationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.typeDOpérationToolStripMenuItem1});
            this.supprimerUneOpérationToolStripMenuItem.Name = "supprimerUneOpérationToolStripMenuItem";
            this.supprimerUneOpérationToolStripMenuItem.Size = new System.Drawing.Size(246, 24);
            this.supprimerUneOpérationToolStripMenuItem.Text = "Supprimer une Opération";
            this.supprimerUneOpérationToolStripMenuItem.Click += new System.EventHandler(this.supprimerUneOpérationToolStripMenuItem_Click);
            // 
            // typeDOpérationToolStripMenuItem1
            // 
            this.typeDOpérationToolStripMenuItem1.Name = "typeDOpérationToolStripMenuItem1";
            this.typeDOpérationToolStripMenuItem1.Size = new System.Drawing.Size(192, 24);
            this.typeDOpérationToolStripMenuItem1.Text = "Type d\'Opération";
            this.typeDOpérationToolStripMenuItem1.Click += new System.EventHandler(this.typeDOpérationToolStripMenuItem1_Click);
            // 
            // accueilToolStripMenuItem
            // 
            this.accueilToolStripMenuItem.Name = "accueilToolStripMenuItem";
            this.accueilToolStripMenuItem.Size = new System.Drawing.Size(246, 24);
            this.accueilToolStripMenuItem.Text = "Accueil";
            this.accueilToolStripMenuItem.Click += new System.EventHandler(this.accueilToolStripMenuItem_Click);
            // 
            // textBoxlibelle
            // 
            this.textBoxlibelle.Location = new System.Drawing.Point(281, 239);
            this.textBoxlibelle.Name = "textBoxlibelle";
            this.textBoxlibelle.Size = new System.Drawing.Size(164, 22);
            this.textBoxlibelle.TabIndex = 20;
            // 
            // Formformulaireoperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(233)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1224, 647);
            this.Controls.Add(this.textBoxlibelle);
            this.Controls.Add(this.dataGridViewoperation);
            this.Controls.Add(this.buttonaccueil);
            this.Controls.Add(this.buttonsupprimer);
            this.Controls.Add(this.buttonmodifier);
            this.Controls.Add(this.buttonrechercher);
            this.Controls.Add(this.buttonafficher);
            this.Controls.Add(this.buttonajouter);
            this.Controls.Add(this.textBoxcreditdh);
            this.Controls.Add(this.textBoxdebitdh);
            this.Controls.Add(this.textBoxdateoperation);
            this.Controls.Add(this.textBoxnumcin);
            this.Controls.Add(this.textBoxnumoperation);
            this.Controls.Add(this.labelcreditdh);
            this.Controls.Add(this.labeldebitdh);
            this.Controls.Add(this.labelLibelle);
            this.Controls.Add(this.labeldateoperation);
            this.Controls.Add(this.labelnumcin);
            this.Controls.Add(this.labelnumoperation);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Formformulaireoperation";
            this.Text = "Formulaire Opération";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewoperation)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelnumoperation;
        private System.Windows.Forms.Label labelnumcin;
        private System.Windows.Forms.Label labeldateoperation;
        private System.Windows.Forms.Label labelLibelle;
        private System.Windows.Forms.Label labeldebitdh;
        private System.Windows.Forms.Label labelcreditdh;
        private System.Windows.Forms.TextBox textBoxnumoperation;
        private System.Windows.Forms.TextBox textBoxnumcin;
        private System.Windows.Forms.TextBox textBoxdateoperation;
        private System.Windows.Forms.TextBox textBoxdebitdh;
        private System.Windows.Forms.TextBox textBoxcreditdh;
        private System.Windows.Forms.Button buttonajouter;
        private System.Windows.Forms.Button buttonafficher;
        private System.Windows.Forms.Button buttonrechercher;
        private System.Windows.Forms.Button buttonmodifier;
        private System.Windows.Forms.Button buttonsupprimer;
        private System.Windows.Forms.Button buttonaccueil;
        private System.Windows.Forms.DataGridView dataGridViewoperation;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typeDOpérationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerUneOpérationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typeDOpérationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem accueilToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxlibelle;

    }
}