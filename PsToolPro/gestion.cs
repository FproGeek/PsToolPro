using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PS3Lib;

namespace PsToolPro
{
    public partial class gestion : Form
    {

        PS3API PS3 = new PS3API();
        Random rand = new Random();

        public gestion()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (metroComboBox1.SelectedIndex == 0)
            {
                PS3.CCAPI.Notify(CCAPI.NotifyIcon.ARROW, metroTextBox1.Text);
            }

            if (metroComboBox1.SelectedIndex == 1)
            {
                PS3.CCAPI.Notify(CCAPI.NotifyIcon.INFO, metroTextBox1.Text);
            }

            if (metroComboBox1.SelectedIndex == 2)
            {
                PS3.CCAPI.Notify(CCAPI.NotifyIcon.CAUTION, metroTextBox1.Text);
            }

            if (metroComboBox1.SelectedIndex == 3)
            {
                PS3.CCAPI.Notify(CCAPI.NotifyIcon.FRIEND, metroTextBox1.Text);
            }

            if (metroComboBox1.SelectedIndex == 4)
            {
                PS3.CCAPI.Notify(CCAPI.NotifyIcon.SLIDER, metroTextBox1.Text);
            }

            if (metroComboBox1.SelectedIndex == 5)
            {
                PS3.CCAPI.Notify(CCAPI.NotifyIcon.DIALOG, metroTextBox1.Text);
            }

            if (metroComboBox1.SelectedIndex == 6)
            {
                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TEXT, metroTextBox1.Text);
            }

            if (metroComboBox1.SelectedIndex == 7)
            {
                PS3.CCAPI.Notify(CCAPI.NotifyIcon.POINTER, metroTextBox1.Text);
            }

            if (metroComboBox1.SelectedIndex == 8)
            {
                PS3.CCAPI.Notify(CCAPI.NotifyIcon.GRAB, metroTextBox1.Text);
            }

            if (metroComboBox1.SelectedIndex == 9)
            {
                PS3.CCAPI.Notify(CCAPI.NotifyIcon.PEN, metroTextBox1.Text);
            }

            if (metroComboBox1.SelectedIndex == 10)
            {
                PS3.CCAPI.Notify(CCAPI.NotifyIcon.FINGER, metroTextBox1.Text);
            }

            if (metroComboBox1.SelectedIndex == 11)
            {
                PS3.CCAPI.Notify(CCAPI.NotifyIcon.PROGRESS, metroTextBox1.Text);
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            PS3.CCAPI.SetConsoleID(metroTextBox2.Text);
            PS3.CCAPI.Notify(CCAPI.NotifyIcon.INFO, "Console ID Changer");
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            PS3.CCAPI.SetPSID(metroTextBox3.Text);
            PS3.CCAPI.Notify(CCAPI.NotifyIcon.INFO, "PSID Changer");
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            PS3.CCAPI.SetBootConsoleID(metroTextBox3.Text);
            PS3.CCAPI.Notify(CCAPI.NotifyIcon.INFO, "Le Console ID boot a chaque redemarrage de la console.");
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
    }
}
