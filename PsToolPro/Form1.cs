using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PS3Lib;


namespace PsToolPro
{
    public partial class Form1 : Form
    {

        PS3API PS3 = new PS3API();
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            PS3.ChangeAPI(SelectAPI.ControlConsole);
        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            PS3.ChangeAPI(SelectAPI.TargetManager);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            PS3.ConnectTarget(0);
            PS3.CCAPI.Notify(CCAPI.NotifyIcon.INFO, "PsToolPro est connecter");
            PS3.CCAPI.RingBuzzer(CCAPI.BuzzerMode.Single);
            MessageBox.Show("PSToolPro est connecté avec succès.","Connecté avec succès.");
            metroLabel1.Text = "Connecter: Oui";
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            PS3.AttachProcess();
            PS3.CCAPI.Notify(CCAPI.NotifyIcon.INFO, "PsToolPro est connecter");
            PS3.CCAPI.RingBuzzer(CCAPI.BuzzerMode.Single);
            MessageBox.Show("PSToolPro est attacher avec succès.", "Attacher avec succès.");
            metroLabel2.Text = "Attacher: Oui";
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            PS3.CCAPI.Notify(CCAPI.NotifyIcon.INFO, "PsToolPro est deconnecter");
            PS3.CCAPI.RingBuzzer(CCAPI.BuzzerMode.Double);
            PS3.DisconnectTarget();
            MessageBox.Show("PSToolPro s'est déconnecté avec succès.", "Déconnexion avec succès.");
            metroLabel1.Text = "Connecter: Non";
            metroLabel2.Text = "Attacher: Non";
        }

        private void acceuilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
            this.Hide();
        }

        private void gestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gestion gestion = new gestion();
            gestion.Show();
            this.Hide();
        }

        private void systemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            systeme systeme = new systeme();
            systeme.Show();
            this.Hide();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
