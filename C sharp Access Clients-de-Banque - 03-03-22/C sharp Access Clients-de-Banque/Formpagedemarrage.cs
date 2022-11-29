using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace C_sharp_Access_Clients_de_Banque
{
    public partial class Formpagedemarrage : Form
    {
        public Formpagedemarrage()
        {
            InitializeComponent();
        }

       
       
        private void buttonfin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Voulez-vous quitter l'application?", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void executeFormClient(Object obj)
        {
            Application.Run(new Formformulaireclient());

        }

        private void buttonouvertureclient_Click(object sender, EventArgs e)
        {
            
            Thread thread = new Thread(executeFormClient);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
            
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(executeFormClient);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }

        private void executeFormOperation(Object obj)
        {
            Application.Run(new Formformulaireoperation());

        }


        private void buttonouvertureoperations_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(executeFormOperation);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }

        private void opérationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(executeFormOperation);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }

        private void executeRequetteOperationClient(Object obj)
       {
           Application.Run(new Formrequetteopclient());

       }

        private void buttonouverturerequetteoperclient_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(executeRequetteOperationClient);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }

        private void requêteOpérationClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(executeRequetteOperationClient);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Voulez-vous quitter l'application?", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void labeltitre_Click(object sender, EventArgs e)
        {

        }

       

    }
}
