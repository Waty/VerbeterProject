using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VerbeterProject
{
    public partial class InzetForm : Form
    {
        private Label[] deelnemers;

        public InzetForm()
        {
            InitializeComponent();
            deelnemers = new[] { lblDeelnemer1, lblDeelnemer2, lblDeelnemer3, lblDeelnemer4 };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetColors();
            Random randomizer = new Random();

            //genereer een random nummer tussen 1 en 4, dit is de winnaar van de race
            int winnaar = randomizer.Next(1, 5);

            //zet het nummer van de winnaar in het label
            lblWinnaar.Text = winnaar.ToString();

            //kleur de naam van de winnaar rood
            deelnemers[winnaar - 1].ForeColor = Color.Red;

            //kleur de naam van degenen die goed gegokt hebben groen
            if (Convert.ToInt32(textBoxJohn.Text) == winnaar) lblJohn.ForeColor = Color.Green;
            if (Convert.ToInt32(textBoxJames.Text) == winnaar) lblJames.ForeColor = Color.Green;
            if (Convert.ToInt32(textBoxLuke.Text) == winnaar) lblLuke.ForeColor = Color.Green;
            if (Convert.ToInt32(textBoxAnna.Text) == winnaar) lblAnna.ForeColor = Color.Green;
        }

        private void KeuzeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '1':
                case '2':
                case '3':
                case '4':
                    e.Handled = false;
                    break;

                default:
                    e.Handled = true;
                    break;
            }
        }

        void ResetColors()
        {
            lblDeelnemer1.ForeColor = Color.Black;
            lblDeelnemer2.ForeColor = Color.Black;
            lblDeelnemer3.ForeColor = Color.Black;
            lblDeelnemer4.ForeColor = Color.Black;

            lblAnna.ForeColor = Color.Black;
            lblJames.ForeColor = Color.Black;
            lblJohn.ForeColor = Color.Black;
            lblLuke.ForeColor = Color.Black;
        }
    }
}
