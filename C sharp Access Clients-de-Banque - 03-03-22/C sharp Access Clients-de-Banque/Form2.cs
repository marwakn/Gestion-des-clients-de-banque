using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Threading;



namespace C_sharp_Access_Clients_de_Banque
{
    public partial class Formformulaireclient : Form
    {
        OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HP GIMER\Desktop\examen finale 169 el kzit\Access Clients-de-Banque.accdb");
        int count = 0;
        public Formformulaireclient()
        {
            InitializeComponent();
        }

        private void executerFormAcceuil(Object obj)
        {
            Application.Run(new Formpagedemarrage());
        }

        private void buttonaccueil_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Voulez-vous quitter le formulaire client?", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Thread thread = new Thread(executerFormAcceuil);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }

        private void accueilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Voulez-vous quitter le formulaire client?", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Thread thread = new Thread(executerFormAcceuil);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }

        private void buttonajouter_Click(object sender, EventArgs e)
        {
            cn.Open();
            OleDbCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
           cmd.CommandText = "insert into  Client values( '"+textBoxnumcin.Text+ "', '"+textBoxnumcompte.Text+ "', '"+textBoxnomclient.Text+ "', '"+textBoxprenomclient.Text+ "', '"+textBoxvilledclient.Text+ "', '"+textBoxbanque.Text+"')";
            cmd.ExecuteNonQuery();
            cn.Close();
            //dataGridViewclient.Rows.Add(textBoxnumcin.Text, textBoxnumcompte.Text, textBoxnomclient.Text, textBoxprenomclient.Text, textBoxvilledclient.Text, textBoxbanque.Text);
            textBoxnumcin.Clear();
            textBoxnumcompte.Clear();
            textBoxnomclient.Clear();
            textBoxprenomclient.Clear();
            textBoxvilledclient.Clear();
            textBoxbanque.Clear();
            cn.Close();
            MessageBox.Show("Enregistrement ajouté avec succès");
        }
        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cn.Open();
            OleDbCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Client values( '" + textBoxnumcin.Text + "', '" + textBoxnumcompte.Text + "', '" + textBoxnomclient.Text + "', '" + textBoxprenomclient + "', '" + textBoxvilledclient.Text + "', '" + textBoxbanque.Text + "')";
            cmd.ExecuteNonQuery();
            cn.Close();
            //dataGridViewclient.Rows.Add(textBoxnumcin.Text, textBoxnumcompte.Text, textBoxnomclient.Text, textBoxprenomclient.Text, textBoxvilledclient.Text, textBoxbanque.Text);
            textBoxnumcin.Clear();
            textBoxnumcompte.Clear();
            textBoxnomclient.Clear();
            textBoxprenomclient.Clear();
            textBoxvilledclient.Clear();
            textBoxbanque.Clear();
            cn.Close();
            MessageBox.Show("Enregistrement ajouté avec succès");
        }

        private void buttonafficher_Click(object sender, EventArgs e)
        {
            cn.Open();
            OleDbCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Client";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewclient.DataSource = dt;
            textBoxnumcin.Clear();
            textBoxnumcompte.Clear();
            textBoxnomclient.Clear();
            textBoxprenomclient.Clear();
            textBoxvilledclient.Clear();
            textBoxbanque.Clear();
            cn.Close();
            MessageBox.Show("Mise à jour effectuée");
        }

        private void afficherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cn.Open();
            OleDbCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Client";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewclient.DataSource = dt;
            textBoxnumcin.Clear();
            textBoxnumcompte.Clear();
            textBoxnomclient.Clear();
            textBoxprenomclient.Clear();
            textBoxvilledclient.Clear();
            textBoxbanque.Clear();
            cn.Close();
            MessageBox.Show("Mise à jour effectuée");
        }
                private void buttonrechercher_Click(object sender, EventArgs e)
        {
            count = 0;
            cn.Open();
            OleDbCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " Select * from Client where Ville_Client ='" + textBoxvilledclient.Text + "' OR Banque='" + textBoxbanque.Text + "' ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            count = Convert.ToInt32(dt.Rows.Count.ToString());
            dataGridViewclient.DataSource = dt;
            textBoxvilledclient.Text = "";
            textBoxbanque.Clear();
            if (count == 0)
            {
                MessageBox.Show("Enregistrement non trouvé");
            }

        }

                private void parBanqueToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    count = 0;
                    cn.Open();
                    OleDbCommand cmd = cn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = " Select * from Client where Banque='" + textBoxbanque.Text + "' ";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    da.Fill(dt);
                    count = Convert.ToInt32(dt.Rows.Count.ToString());
                    dataGridViewclient.DataSource = dt;

                    if (count == 0)
                    {
                        MessageBox.Show("Enregistrement non trouvé");
                    }

                }

                private void parVilleToolStripMenuItem_Click(object sender, EventArgs e)
                {

                    count = 0;
                    cn.Open();
                    OleDbCommand cmd = cn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = " Select * from Client where Ville_Client ='" + textBoxvilledclient.Text + "' ";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    da.Fill(dt);
                    count = Convert.ToInt32(dt.Rows.Count.ToString());
                    dataGridViewclient.DataSource = dt;

                    if (count == 0)
                    {
                        MessageBox.Show("Enregistrement non trouvé");
                    }
                }



        private void Formformulaireclient_Load(object sender, EventArgs e)
        {

        }

       



   



        private void rechercherToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void buttonsupprimer_Click(object sender, EventArgs e)
        {
            if (textBoxnumcin.Text == "")
            {
                MessageBox.Show("Enter le numero CIN !!"
                    , "Infomation insuffisant",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                cn.Open();
                OleDbCommand cmd = cn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM Client WHERE N°CIN = '" + textBoxnumcin.Text + "'";
                int count = 0;
                try
                {
                    count = cmd.ExecuteNonQuery();
                }
                catch (OleDbException OlDbExeption)
                {

                    MessageBox.Show("Supprimer tous les opérations faites par " + textBoxnumcin.Text + ". C:- "
                    , "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    cn.Close();
                    return;
                }

                if (count > 0)
                {
                    MessageBox.Show("Client est supprimer"
                    , "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    textBoxnumcin.Text = "";

                }
                else
                {
                    MessageBox.Show("Aucun client port ce Numero CIN !!"
                     , "Information",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information);
                }
                cn.Close();
            }

        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void parBanqueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (textBoxbanque.Enabled == true)
            {
                MessageBox.Show("taper le nom de banque avant de supprimer !! ",
                    "Information ",
                    MessageBoxButtons.OK);
                return;
            }
            cn.Open();
            OleDbCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE * FROM Client WHERE Banque ='" + textBoxbanque + "'";
            int count = cmd.ExecuteNonQuery();

            MessageBox.Show(count + " clients sont supprimés ",
                     "Information ",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            cn.Close();
        }

        private void parVilleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (textBoxvilledclient.Enabled == true)
            {
                MessageBox.Show("taper le nom de ville avant de supprimer !! ",
                    "Information ",
                    MessageBoxButtons.OK);
                return;
            }
            cn.Open();
            OleDbCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE * FROM Client WHERE Ville_Client ='" + textBoxvilledclient + "'";
            int count = cmd.ExecuteNonQuery();

            MessageBox.Show(count + " clients sont supprimés ",
                     "Information ",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            cn.Close();
        }

        private void buttonmodifier_Click(object sender, EventArgs e)
        {
                 if (textBoxnumcin.Enabled == true)
            {
                MessageBox.Show("Rechercher un client avant de modifier !! ",
                    "Information ",
                    MessageBoxButtons.OK);
                return;
            }
            cn.Open();
            OleDbCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            textBoxnumcin.Enabled = true;

             cmd.CommandText = "UPDATE Client SET N°_Compte = '"+ textBoxnumcompte.Text +
                 "', Nom_Client = '"+ textBoxnomclient.Text +
                "', Prénom_Client = '"+ textBoxprenomclient.Text +
                "', Ville_Client = '"+ textBoxvilledclient.Text +
                "', Banque = '"+ textBoxbanque.Text +
                "' WHERE N°CIN = '"+textBoxnumcin.Text+"'";

               cmd.ExecuteNonQuery();
               textBoxnumcin.Text = "";
               textBoxnumcompte.Text = "";
               textBoxnomclient.Text = "";
               textBoxprenomclient.Text = "";
               textBoxvilledclient.Text = "";
               textBoxbanque.Text = "";
               MessageBox.Show("Modification effectuée ", "Information ",
                               MessageBoxButtons.OK);
               cn.Close();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBoxnumcin.Enabled == true)
            {
                MessageBox.Show("Rechercher un client avant de modifier !! ",
                    "Information ",
                    MessageBoxButtons.OK);
                return;
            }
            cn.Open();
            OleDbCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            textBoxnumcin.Enabled = true;

            cmd.CommandText = "UPDATE Client SET N°_Compte = '" + textBoxnumcompte.Text +
                "', Nom_Client = '" + textBoxnomclient.Text +
               "', Prénom_Client = '" + textBoxprenomclient.Text +
               "', Ville_Client = '" + textBoxvilledclient.Text +
               "', Banque = '" + textBoxbanque.Text +
               "' WHERE N°CIN = '" + textBoxnumcin.Text + "'";

            cmd.ExecuteNonQuery();
            textBoxnumcin.Text = "";
            textBoxnumcompte.Text = "";
            textBoxnomclient.Text = "";
            textBoxprenomclient.Text = "";
            textBoxvilledclient.Text = "";
            textBoxbanque.Text = "";
            MessageBox.Show("Modification effectuée ", "Information ",
                            MessageBoxButtons.OK);
            cn.Close();
        }
        private void labelnumcin_Click(object sender, EventArgs e)
        {
        
        }

       

       
      

       

    }
}
