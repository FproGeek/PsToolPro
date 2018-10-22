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
    public partial class systeme : Form
    {

        PS3API PS3 = new PS3API();
        Random rand = new Random();

        public systeme()
        {
            InitializeComponent();
        }

        private void systeme_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {
            PS3.CCAPI.GetFirmwareVersion();
        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {
            PS3.CCAPI.GetFirmwareType();
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {
        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {
            PS3.CCAPI.GetTemperatureCELL();
        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {
            PS3.CCAPI.GetTemperatureRSX();
        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            PS3.CCAPI.RingBuzzer(CCAPI.BuzzerMode.Single);
        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            PS3.CCAPI.RingBuzzer(CCAPI.BuzzerMode.Double);
        }

        private void metroRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            PS3.CCAPI.RingBuzzer(CCAPI.BuzzerMode.Triple);
        }

        private void metroRadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            PS3.CCAPI.RingBuzzer(CCAPI.BuzzerMode.Continuous);
        }

        private void gestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gestion gestion = new gestion();
            gestion.Show();
            this.Hide();
        }

        private void acceuilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
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
