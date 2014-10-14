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
    public partial class inzetForm : Form
    {
        public inzetForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random randomizer = new Random();

            //genereer een random nummer tussen 1 en 4, dit is de winnaar van de race
            int winnaar = randomizer.Next(1, 5);

            //zet het nummer van de winnaar in het label
            lblWinnaar.Text = winnaar.ToString();

            //kleur de naam van de winnaar rood
            switch (winnaar)
            {
                case 1:
                    lblDeelnemer1.ForeColor = Color.Red;
                    break;
                case 2:
                    lblDeelnemer2.ForeColor = Color.Red;
                    break;
                case 3:
                    lblDeelnemer3.ForeColor = Color.Red;
                    break;
                case 4:
                    lblDeelnemer4.ForeColor = Color.Red;
                    break;
            }

            //kleur de naam van degenen die goed gegokt hebben groen
            int gokVanJohn = Convert.ToInt32(textBoxJohn.Text);
            int gokVanJames = Convert.ToInt32(textBoxJames.Text);
            int gokVanLuke = Convert.ToInt32(textBoxLuke.Text);
            int gokVanAnna = Convert.ToInt32(textBoxAnna.Text);

            if (gokVanJohn == winnaar)
            {
                lblJohn.ForeColor = Color.Green;
            }
            if (gokVanJames == winnaar)
            {
                lblJames.ForeColor = Color.Green;
            }
            if (gokVanLuke == winnaar)
            {
                lblLuke.ForeColor = Color.Green;
            }
            if (gokVanAnna == winnaar)
            {
                lblAnna.ForeColor = Color.Green;
            }
            
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
    }
}
