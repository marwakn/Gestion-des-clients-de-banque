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
    public partial class Formformulaireoperation : Form
    {
       OleDbConnection cn =
       new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HP GIMER\Desktop\examen finale 169 el kzit\Access Clients-de-Banque.accdb");
        public Formformulaireoperation()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void executeFormAcueil(Object obj)
        {
            Application.Run(new Formpagedemarrage());
        }

        private void buttonaccueil_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Voulez-vous quitter le formulaire opération?", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Thread thread = new Thread(executeFormAcueil);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }

        private void accueilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Voulez-vous quitter le formulaire opération?", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Thread thread = new Thread(executeFormAcueil);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }

        private void buttonsupprimer_Click(object sender, EventArgs e)
        {
            if (textBoxnumoperation.Text == "")
            {
                MessageBox.Show("Enter le numéro d'opération !!"
                    , "Infomation insuffisant",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                cn.Open();
                OleDbCommand cmd = cn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM Opérations WHERE N°Opération = " + textBoxnumoperation.Text;
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("Opération est supprimé"
                    , "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    textBoxnumoperation.Text = "";

                }
                else
                {
                    MessageBox.Show("Aucun Opération porte numéro " + textBoxnumoperation.Text
                     , "Information",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information);
                }
                cn.Close();
            }
        }

        private void supprimerUneOpérationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void typeDOpérationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (textBoxlibelle.Enabled == true)
            {
                MessageBox.Show("taper le libéLLé avant de supprimer !! ",
                    "Information ",
                    MessageBoxButtons.OK);
                return;
            }
            cn.Open();
            OleDbCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE * FROM Opérations WHERE Libéllé ='" + textBoxlibelle + "'";
            int count = cmd.ExecuteNonQuery();

            MessageBox.Show(count + " Opérations sont supprimés ",
                     "Information ",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            cn.Close();

        }

        private void buttonajouter_Click(object sender, EventArgs e)
        {
            cn.Open();
            OleDbCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into  Opérations values( '" + textBoxnumoperation.Text + "', '" + textBoxnumcin.Text + "', '" + textBoxdateoperation.Text + "', '" + textBoxlibelle.Text + "', '" + textBoxdebitdh.Text + "', '" + textBoxcreditdh.Text + "')";
            cmd.ExecuteNonQuery();
            cn.Close();
            textBoxnumoperation.Clear();
            textBoxnumcin.Clear();
            textBoxdateoperation.Clear();
            textBoxlibelle.Clear();
            textBoxdebitdh.Clear();
            textBoxcreditdh.Clear();
            cn.Close();
            MessageBox.Show("Enregistrement ajouté avec succès");
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cn.Open();
            OleDbCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into  Opérations values( '" + textBoxnumoperation.Text + "', '" + textBoxnumcin.Text + "', '" + textBoxdateoperation.Text + "', '" + textBoxlibelle.Text + "', '" + textBoxdebitdh.Text + "', '" + textBoxcreditdh.Text + "')";
            cmd.ExecuteNonQuery();
            cn.Close();
            textBoxnumoperation.Clear();
            textBoxnumcin.Clear();
            textBoxdateoperation.Clear();
            textBoxlibelle.Clear();
            textBoxdebitdh.Clear();
            textBoxcreditdh.Clear();
            cn.Close();
            MessageBox.Show("Enregistrement ajouté avec succès");
        }
      

        private void buttonafficher_Click(object sender, EventArgs e)
        {
            cn.Open();
            OleDbCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Opérations";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewoperation.DataSource = dt;
            textBoxnumoperation.Clear();
            textBoxnumcin.Clear();
            textBoxdateoperation.Clear();
            textBoxlibelle.Clear();
            textBoxdebitdh.Clear();
            textBoxcreditdh.Clear();
            cn.Close();
            MessageBox.Show("Mise à jour effectuée");
        }

        private void afficherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cn.Open();
            OleDbCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Opérations";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewoperation.DataSource = dt;
            textBoxnumoperation.Clear();
            textBoxnumcin.Clear();
            textBoxdateoperation.Clear();
            textBoxlibelle.Clear();
            textBoxdebitdh.Clear();
            textBoxcreditdh.Clear();
            cn.Close();
            MessageBox.Show("Mise à jour effectuée");
        }

        private void buttonmodifier_Click(object sender, EventArgs e)
        {
            if (textBoxnumoperation.Enabled == true)
            {
                MessageBox.Show("Rechercher un numéro d'opération avant de modifier !! ",
                    "Information ",
                    MessageBoxButtons.OK);
                return;
            }
            cn.Open();
            OleDbCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            textBoxnumoperation.Enabled = true;

            cmd.CommandText = "UPDATE Opérations SET N°CIN = '" + textBoxnumcin.Text +
                "', Date-Opération= '" + textBoxdateoperation.Text +
               "', Libéllé = '" + textBoxlibelle.Text +
               "', Débit en DH = '" + textBoxdebitdh.Text +
               "', Crédit en DH= '" + textBoxcreditdh.Text +
            "' WHERE N°Opération = '" + textBoxnumoperation.Text +"'";

            cmd.ExecuteNonQuery();
            textBoxnumcin.Text = "";
            textBoxdateoperation.Text = "";
            textBoxlibelle.Text = "";
            textBoxdebitdh.Text = "";
            textBoxcreditdh.Text = "";
            textBoxnumoperation.Text = "";
            MessageBox.Show("Modification effectuée ", "Information ",
                            MessageBoxButtons.OK);
            cn.Close();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBoxnumoperation.Enabled == true)
            {
                MessageBox.Show("Rechercher un numéro d'opération avant de modifier !! ",
                    "Information ",
                    MessageBoxButtons.OK);
                return;
            }
            cn.Open();
            OleDbCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            textBoxnumoperation.Enabled = true;

            cmd.CommandText = "UPDATE Opérations SET N°CIN = '" + textBoxnumcin.Text +
                "', Date-Opération= '" + textBoxdateoperation.Text +
               "', Libéllé = '" + textBoxlibelle.Text +
               "', Débit en DH = '" + textBoxdebitdh.Text +
               "', Crédit en DH= '" + textBoxcreditdh.Text +
            "' WHERE N°Opération = '" + textBoxnumoperation.Text + "'";

            cmd.ExecuteNonQuery();
            textBoxnumcin.Text = "";
            textBoxdateoperation.Text = "";
            textBoxlibelle.Text = "";
            textBoxdebitdh.Text = "";
            textBoxcreditdh.Text = "";
            textBoxnumoperation.Text = "";
            MessageBox.Show("Modification effectuée ", "Information ",
                            MessageBoxButtons.OK);
            cn.Close();
        }

        private void buttonrechercher_Click(object sender, EventArgs e)
        {
            int count;
            count = 0;
            cn.Open();
            OleDbCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " Select * from Opérations where Libéllé ='" + textBoxlibelle.Text + "' ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            count = Convert.ToInt32(dt.Rows.Count.ToString());
            dataGridViewoperation.DataSource = dt;
            textBoxlibelle.Text = "";
            textBoxnumcin.Clear();
            if (count == 0)
            {
                MessageBox.Show("Enregistrement non trouvé");
            }
        }

        private void typeDOpérationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count;
            count = 0;
            cn.Open();
            OleDbCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " Select * from Opérations where Libéllé ='" + textBoxlibelle.Text + "' ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            count = Convert.ToInt32(dt.Rows.Count.ToString());
            dataGridViewoperation.DataSource = dt;
            textBoxlibelle.Text = "";
            textBoxnumcin.Clear();
            if (count == 0)
            {
                MessageBox.Show("Enregistrement non trouvé");
            }
        }


    }
}
