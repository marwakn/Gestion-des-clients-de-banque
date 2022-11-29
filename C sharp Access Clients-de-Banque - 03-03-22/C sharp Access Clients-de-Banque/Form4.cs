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
    public partial class Formrequetteopclient : Form
    {
        OleDbConnection cn =
     new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HP GIMER\Desktop\examen finale 169 el kzit\Access Clients-de-Banque.accdb");
        public Formrequetteopclient()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelnumoperation_Click(object sender, EventArgs e)
        {

        }
        private void executFormpagedemarrage(object obj)
        {
            Application.Run(new Formpagedemarrage());
        } 
        private void buttonaccueil_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Voulez-vous quitter la requêtte opération client?", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Thread thread = new Thread (executFormpagedemarrage);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }

        private void buttonajouter_Click(object sender, EventArgs e)
        {
            cn.Open();
            OleDbCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into  Opération-Client values( '" + textBoxnumoperation.Text + "', '" + textBoxnomclient.Text + "', '" + textBoxdateoperation.Text + "', '" + textBoxlibelle.Text + "', '" + textBoxdebitdh.Text + "', '" + textBoxcreditdh.Text + "', '" + textBoxsolde.Text + "')";
            cmd.ExecuteNonQuery();
            cn.Close();
            //dataGridViewclient.Rows.Add(textBoxnumcin.Text, textBoxnumcompte.Text, textBoxnomclient.Text, textBoxprenomclient.Text, textBoxvilledclient.Text, textBoxbanque.Text);
            textBoxnumoperation.Clear();
            textBoxnomclient.Clear();
            textBoxdateoperation.Clear();
            textBoxlibelle.Clear();
            textBoxdebitdh.Clear();
            textBoxcreditdh.Clear();
            textBoxsolde.Clear();
            cn.Close();
            MessageBox.Show("Enregistrement ajouté avec succès");
        }

        private void textBoxsolde_TextChanged(object sender, EventArgs e)
        {

        }

      
    }
}
