using System;
using System.Windows.Forms;

namespace Tannenbaum_Aufgabe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
 
        private void TanneZeichnenButton_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(StammbreiteTextBox.Text, out int stammbreite) &&
                int.TryParse(StammhoeheTextBox.Text, out int stammhoehe) &&
                int.TryParse(KronenhoeheTextBox.Text, out int kronenhoehe))
            {
                Tanne m = new Tanne(stammhoehe, stammbreite, kronenhoehe);
                string tanneZeichnung = m.Zeichnen();
                Ausgabe.AppendText(tanneZeichnung);


            }
            else
            {
                MessageBox.Show("Ungültige Eingabe. Bitte geben Sie ganze Zahlen ein.");
            }
        }
    }
}