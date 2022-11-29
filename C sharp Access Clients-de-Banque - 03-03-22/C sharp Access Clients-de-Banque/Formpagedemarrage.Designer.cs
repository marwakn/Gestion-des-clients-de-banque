namespace C_sharp_Access_Clients_de_Banque
{
    partial class Formpagedemarrage
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opérationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.requêteOpérationClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labeltitre = new System.Windows.Forms.Label();
            this.buttonouvertureclient = new System.Windows.Forms.Button();
            this.buttonouvertureoperations = new System.Windows.Forms.Button();
            this.buttonouverturerequetteoperclient = new System.Windows.Forms.Button();
            this.buttonfin = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(140)))), ((int)(((byte)(151)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(849, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientsToolStripMenuItem,
            this.opérationsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.requêteOpérationClientsToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(252, 24);
            this.clientsToolStripMenuItem.Text = "Clients";
            this.clientsToolStripMenuItem.Click += new System.EventHandler(this.clientsToolStripMenuItem_Click);
            // 
            // opérationsToolStripMenuItem
            // 
            this.opérationsToolStripMenuItem.Name = "opérationsToolStripMenuItem";
            this.opérationsToolStripMenuItem.Size = new System.Drawing.Size(252, 24);
            this.opérationsToolStripMenuItem.Text = "Opérations";
            this.opérationsToolStripMenuItem.Click += new System.EventHandler(this.opérationsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(249, 6);
            // 
            // requêteOpérationClientsToolStripMenuItem
            // 
            this.requêteOpérationClientsToolStripMenuItem.Name = "requêteOpérationClientsToolStripMenuItem";
            this.requêteOpérationClientsToolStripMenuItem.Size = new System.Drawing.Size(252, 24);
            this.requêteOpérationClientsToolStripMenuItem.Text = "Requête Opération Clients";
            this.requêteOpérationClientsToolStripMenuItem.Click += new System.EventHandler(this.requêteOpérationClientsToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(252, 24);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // labeltitre
            // 
            this.labeltitre.AutoSize = true;
            this.labeltitre.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitre.Location = new System.Drawing.Point(164, 53);
            this.labeltitre.Name = "labeltitre";
            this.labeltitre.Size = new System.Drawing.Size(478, 21);
            this.labeltitre.TabIndex = 1;
            this.labeltitre.Text = "Projet de classe 2ème année Ingénieurie Informatique";
            this.labeltitre.Click += new System.EventHandler(this.labeltitre_Click);
            // 
            // buttonouvertureclient
            // 
            this.buttonouvertureclient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(78)))), ((int)(((byte)(103)))));
            this.buttonouvertureclient.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonouvertureclient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonouvertureclient.Location = new System.Drawing.Point(48, 159);
            this.buttonouvertureclient.Name = "buttonouvertureclient";
            this.buttonouvertureclient.Size = new System.Drawing.Size(296, 41);
            this.buttonouvertureclient.TabIndex = 2;
            this.buttonouvertureclient.Text = "Acceder aux Clients";
            this.buttonouvertureclient.UseVisualStyleBackColor = false;
            this.buttonouvertureclient.Click += new System.EventHandler(this.buttonouvertureclient_Click);
            // 
            // buttonouvertureoperations
            // 
            this.buttonouvertureoperations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(78)))), ((int)(((byte)(103)))));
            this.buttonouvertureoperations.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonouvertureoperations.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonouvertureoperations.Location = new System.Drawing.Point(48, 231);
            this.buttonouvertureoperations.Name = "buttonouvertureoperations";
            this.buttonouvertureoperations.Size = new System.Drawing.Size(296, 41);
            this.buttonouvertureoperations.TabIndex = 3;
            this.buttonouvertureoperations.Text = "Acceder aux Opérations";
            this.buttonouvertureoperations.UseVisualStyleBackColor = false;
            this.buttonouvertureoperations.Click += new System.EventHandler(this.buttonouvertureoperations_Click);
            // 
            // buttonouverturerequetteoperclient
            // 
            this.buttonouverturerequetteoperclient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(78)))), ((int)(((byte)(103)))));
            this.buttonouverturerequetteoperclient.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonouverturerequetteoperclient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonouverturerequetteoperclient.Location = new System.Drawing.Point(48, 305);
            this.buttonouverturerequetteoperclient.Name = "buttonouverturerequetteoperclient";
            this.buttonouverturerequetteoperclient.Size = new System.Drawing.Size(473, 41);
            this.buttonouverturerequetteoperclient.TabIndex = 4;
            this.buttonouverturerequetteoperclient.Text = "Acceder à la requête Opérations Clients";
            this.buttonouverturerequetteoperclient.UseVisualStyleBackColor = false;
            this.buttonouverturerequetteoperclient.Click += new System.EventHandler(this.buttonouverturerequetteoperclient_Click);
            // 
            // buttonfin
            // 
            this.buttonfin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(78)))), ((int)(((byte)(103)))));
            this.buttonfin.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonfin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonfin.Location = new System.Drawing.Point(593, 380);
            this.buttonfin.Name = "buttonfin";
            this.buttonfin.Size = new System.Drawing.Size(92, 37);
            this.buttonfin.TabIndex = 5;
            this.buttonfin.Text = "Quitter";
            this.buttonfin.UseVisualStyleBackColor = false;
            this.buttonfin.Click += new System.EventHandler(this.buttonfin_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(484, 106);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(266, 26);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // Formpagedemarrage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(233)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(849, 458);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonfin);
            this.Controls.Add(this.buttonouverturerequetteoperclient);
            this.Controls.Add(this.buttonouvertureoperations);
            this.Controls.Add(this.buttonouvertureclient);
            this.Controls.Add(this.labeltitre);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Formpagedemarrage";
            this.Text = "Page de démarrage";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opérationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem requêteOpérationClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.Label labeltitre;
        private System.Windows.Forms.Button buttonouvertureclient;
        private System.Windows.Forms.Button buttonouvertureoperations;
        private System.Windows.Forms.Button buttonouverturerequetteoperclient;
        private System.Windows.Forms.Button buttonfin;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;

       public System.EventHandler Formpagedemarrage_Load { get; set; }
    }
}

