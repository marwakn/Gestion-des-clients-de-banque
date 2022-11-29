namespace C_sharp_Access_Clients_de_Banque
{
    partial class Formrequetteopclient
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
            this.labelnomclient = new System.Windows.Forms.Label();
            this.labeldateoperation = new System.Windows.Forms.Label();
            this.labellibelle = new System.Windows.Forms.Label();
            this.labeldebitdh = new System.Windows.Forms.Label();
            this.labelcreditdh = new System.Windows.Forms.Label();
            this.labelsolde = new System.Windows.Forms.Label();
            this.textBoxnumoperation = new System.Windows.Forms.TextBox();
            this.textBoxnomclient = new System.Windows.Forms.TextBox();
            this.textBoxdateoperation = new System.Windows.Forms.TextBox();
            this.textBoxlibelle = new System.Windows.Forms.TextBox();
            this.textBoxdebitdh = new System.Windows.Forms.TextBox();
            this.textBoxcreditdh = new System.Windows.Forms.TextBox();
            this.textBoxsolde = new System.Windows.Forms.TextBox();
            this.buttonajouter = new System.Windows.Forms.Button();
            this.buttonaccueil = new System.Windows.Forms.Button();
            this.dataGridViewrequetteopclirnt = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewrequetteopclirnt)).BeginInit();
            this.SuspendLayout();
            // 
            // labelnumoperation
            // 
            this.labelnumoperation.AutoSize = true;
            this.labelnumoperation.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnumoperation.Location = new System.Drawing.Point(51, 58);
            this.labelnumoperation.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelnumoperation.Name = "labelnumoperation";
            this.labelnumoperation.Size = new System.Drawing.Size(113, 21);
            this.labelnumoperation.TabIndex = 0;
            this.labelnumoperation.Text = "N°Opération";
            this.labelnumoperation.Click += new System.EventHandler(this.labelnumoperation_Click);
            // 
            // labelnomclient
            // 
            this.labelnomclient.AutoSize = true;
            this.labelnomclient.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnomclient.Location = new System.Drawing.Point(51, 94);
            this.labelnomclient.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelnomclient.Name = "labelnomclient";
            this.labelnomclient.Size = new System.Drawing.Size(116, 21);
            this.labelnomclient.TabIndex = 1;
            this.labelnomclient.Text = "Nom_Client";
            // 
            // labeldateoperation
            // 
            this.labeldateoperation.AutoSize = true;
            this.labeldateoperation.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldateoperation.Location = new System.Drawing.Point(51, 142);
            this.labeldateoperation.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labeldateoperation.Name = "labeldateoperation";
            this.labeldateoperation.Size = new System.Drawing.Size(143, 21);
            this.labeldateoperation.TabIndex = 2;
            this.labeldateoperation.Text = "Date-Opération";
            // 
            // labellibelle
            // 
            this.labellibelle.AutoSize = true;
            this.labellibelle.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellibelle.Location = new System.Drawing.Point(51, 181);
            this.labellibelle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labellibelle.Name = "labellibelle";
            this.labellibelle.Size = new System.Drawing.Size(73, 21);
            this.labellibelle.TabIndex = 3;
            this.labellibelle.Text = "Libéllé";
            // 
            // labeldebitdh
            // 
            this.labeldebitdh.AutoSize = true;
            this.labeldebitdh.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldebitdh.Location = new System.Drawing.Point(51, 218);
            this.labeldebitdh.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labeldebitdh.Name = "labeldebitdh";
            this.labeldebitdh.Size = new System.Drawing.Size(121, 21);
            this.labeldebitdh.TabIndex = 4;
            this.labeldebitdh.Text = "Débit en DH";
            // 
            // labelcreditdh
            // 
            this.labelcreditdh.AutoSize = true;
            this.labelcreditdh.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcreditdh.Location = new System.Drawing.Point(52, 257);
            this.labelcreditdh.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelcreditdh.Name = "labelcreditdh";
            this.labelcreditdh.Size = new System.Drawing.Size(125, 21);
            this.labelcreditdh.TabIndex = 5;
            this.labelcreditdh.Text = "Crédit en DH";
            // 
            // labelsolde
            // 
            this.labelsolde.AutoSize = true;
            this.labelsolde.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsolde.Location = new System.Drawing.Point(52, 291);
            this.labelsolde.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelsolde.Name = "labelsolde";
            this.labelsolde.Size = new System.Drawing.Size(331, 21);
            this.labelsolde.TabIndex = 6;
            this.labelsolde.Text = "Solde: [Crédit en DH]-[Débit en DH]\r\n";
            // 
            // textBoxnumoperation
            // 
            this.textBoxnumoperation.Location = new System.Drawing.Point(425, 49);
            this.textBoxnumoperation.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxnumoperation.Name = "textBoxnumoperation";
            this.textBoxnumoperation.Size = new System.Drawing.Size(212, 30);
            this.textBoxnumoperation.TabIndex = 7;
            // 
            // textBoxnomclient
            // 
            this.textBoxnomclient.Location = new System.Drawing.Point(425, 89);
            this.textBoxnomclient.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxnomclient.Name = "textBoxnomclient";
            this.textBoxnomclient.Size = new System.Drawing.Size(212, 30);
            this.textBoxnomclient.TabIndex = 8;
            // 
            // textBoxdateoperation
            // 
            this.textBoxdateoperation.Location = new System.Drawing.Point(425, 133);
            this.textBoxdateoperation.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxdateoperation.Name = "textBoxdateoperation";
            this.textBoxdateoperation.Size = new System.Drawing.Size(212, 30);
            this.textBoxdateoperation.TabIndex = 9;
            // 
            // textBoxlibelle
            // 
            this.textBoxlibelle.Location = new System.Drawing.Point(425, 175);
            this.textBoxlibelle.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxlibelle.Name = "textBoxlibelle";
            this.textBoxlibelle.Size = new System.Drawing.Size(212, 30);
            this.textBoxlibelle.TabIndex = 10;
            // 
            // textBoxdebitdh
            // 
            this.textBoxdebitdh.Location = new System.Drawing.Point(425, 212);
            this.textBoxdebitdh.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxdebitdh.Name = "textBoxdebitdh";
            this.textBoxdebitdh.Size = new System.Drawing.Size(212, 30);
            this.textBoxdebitdh.TabIndex = 11;
            // 
            // textBoxcreditdh
            // 
            this.textBoxcreditdh.Location = new System.Drawing.Point(425, 251);
            this.textBoxcreditdh.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxcreditdh.Name = "textBoxcreditdh";
            this.textBoxcreditdh.Size = new System.Drawing.Size(212, 30);
            this.textBoxcreditdh.TabIndex = 12;
            // 
            // textBoxsolde
            // 
            this.textBoxsolde.Location = new System.Drawing.Point(425, 291);
            this.textBoxsolde.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxsolde.Name = "textBoxsolde";
            this.textBoxsolde.Size = new System.Drawing.Size(212, 30);
            this.textBoxsolde.TabIndex = 13;
            this.textBoxsolde.TextChanged += new System.EventHandler(this.textBoxsolde_TextChanged);
            // 
            // buttonajouter
            // 
            this.buttonajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(78)))), ((int)(((byte)(103)))));
            this.buttonajouter.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonajouter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonajouter.Location = new System.Drawing.Point(774, 123);
            this.buttonajouter.Margin = new System.Windows.Forms.Padding(5);
            this.buttonajouter.Name = "buttonajouter";
            this.buttonajouter.Size = new System.Drawing.Size(121, 40);
            this.buttonajouter.TabIndex = 14;
            this.buttonajouter.Text = "Ajouter";
            this.buttonajouter.UseVisualStyleBackColor = false;
            this.buttonajouter.Click += new System.EventHandler(this.buttonajouter_Click);
            // 
            // buttonaccueil
            // 
            this.buttonaccueil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(78)))), ((int)(((byte)(103)))));
            this.buttonaccueil.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonaccueil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonaccueil.Location = new System.Drawing.Point(774, 194);
            this.buttonaccueil.Margin = new System.Windows.Forms.Padding(5);
            this.buttonaccueil.Name = "buttonaccueil";
            this.buttonaccueil.Size = new System.Drawing.Size(121, 40);
            this.buttonaccueil.TabIndex = 15;
            this.buttonaccueil.Text = "Accueil";
            this.buttonaccueil.UseVisualStyleBackColor = false;
            this.buttonaccueil.Click += new System.EventHandler(this.buttonaccueil_Click);
            // 
            // dataGridViewrequetteopclirnt
            // 
            this.dataGridViewrequetteopclirnt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(174)))), ((int)(((byte)(168)))));
            this.dataGridViewrequetteopclirnt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewrequetteopclirnt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridViewrequetteopclirnt.Location = new System.Drawing.Point(56, 380);
            this.dataGridViewrequetteopclirnt.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridViewrequetteopclirnt.Name = "dataGridViewrequetteopclirnt";
            this.dataGridViewrequetteopclirnt.RowTemplate.Height = 24;
            this.dataGridViewrequetteopclirnt.Size = new System.Drawing.Size(876, 189);
            this.dataGridViewrequetteopclirnt.TabIndex = 16;
            this.dataGridViewrequetteopclirnt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "N°Opération";
            this.Column1.Name = "Column1";
            this.Column1.Width = 140;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nom_Client";
            this.Column2.Name = "Column2";
            this.Column2.Width = 140;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Date_Opération";
            this.Column3.Name = "Column3";
            this.Column3.Width = 170;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Libéllé";
            this.Column4.Name = "Column4";
            this.Column4.Width = 90;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Débit en DH";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Crédit en DH";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Solde";
            this.Column7.Name = "Column7";
            this.Column7.Width = 90;
            // 
            // Formrequetteopclient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(233)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1030, 714);
            this.Controls.Add(this.dataGridViewrequetteopclirnt);
            this.Controls.Add(this.buttonaccueil);
            this.Controls.Add(this.buttonajouter);
            this.Controls.Add(this.textBoxsolde);
            this.Controls.Add(this.textBoxcreditdh);
            this.Controls.Add(this.textBoxdebitdh);
            this.Controls.Add(this.textBoxlibelle);
            this.Controls.Add(this.textBoxdateoperation);
            this.Controls.Add(this.textBoxnomclient);
            this.Controls.Add(this.textBoxnumoperation);
            this.Controls.Add(this.labelsolde);
            this.Controls.Add(this.labelcreditdh);
            this.Controls.Add(this.labeldebitdh);
            this.Controls.Add(this.labellibelle);
            this.Controls.Add(this.labeldateoperation);
            this.Controls.Add(this.labelnomclient);
            this.Controls.Add(this.labelnumoperation);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Formrequetteopclient";
            this.Text = "Requêtte Opération Client";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewrequetteopclirnt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelnumoperation;
        private System.Windows.Forms.Label labelnomclient;
        private System.Windows.Forms.Label labeldateoperation;
        private System.Windows.Forms.Label labellibelle;
        private System.Windows.Forms.Label labeldebitdh;
        private System.Windows.Forms.Label labelcreditdh;
        private System.Windows.Forms.Label labelsolde;
        private System.Windows.Forms.TextBox textBoxnumoperation;
        private System.Windows.Forms.TextBox textBoxnomclient;
        private System.Windows.Forms.TextBox textBoxdateoperation;
        private System.Windows.Forms.TextBox textBoxlibelle;
        private System.Windows.Forms.TextBox textBoxdebitdh;
        private System.Windows.Forms.TextBox textBoxcreditdh;
        private System.Windows.Forms.TextBox textBoxsolde;
        private System.Windows.Forms.Button buttonajouter;
        private System.Windows.Forms.Button buttonaccueil;
        private System.Windows.Forms.DataGridView dataGridViewrequetteopclirnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}