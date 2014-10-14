using System;
using System.Drawing;
using System.Windows.Forms;

namespace VerbeterProject
{
    public partial class InzetForm : Form
    {
        private readonly Label[] deelnemers;

        public InzetForm()
        {
            InitializeComponent();
            deelnemers = new[] { lblCompetitor1, lblCompetitor2, lblCompetitor3, lblCompetitor4 };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetColors();
            var randomizer = new Random();

            //genereer een random nummer tussen 1 en 4, dit is de winnaar van de race
            int winnaar = randomizer.Next(1, 5);

            //zet het nummer van de winnaar in het label
            lblWinner.Text = winnaar.ToString();

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

        private void ResetColors()
        {
            lblCompetitor1.ForeColor = Color.Black;
            lblCompetitor2.ForeColor = Color.Black;
            lblCompetitor3.ForeColor = Color.Black;
            lblCompetitor4.ForeColor = Color.Black;

            lblAnna.ForeColor = Color.Black;
            lblJames.ForeColor = Color.Black;
            lblJohn.ForeColor = Color.Black;
            lblLuke.ForeColor = Color.Black;
        }
    }
}