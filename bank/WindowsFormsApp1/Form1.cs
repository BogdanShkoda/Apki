using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            trackBar1.Maximum = 100000;
            trackBar1.Minimum = 1000;
            trackBar2.Maximum = 72;
            trackBar2.Minimum = 12;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            const string Format = @"D:\test\{0}_{1}.txt";
            string path = string.Format(Format, textBox1.Text, textBox5.Text);

            string tekst = "Dane klienta : \r\n";
            tekst += "Imię : " + textBox1.Text + " Nazwisko : " + textBox5.Text + " \r\n";
            tekst += "Dane Kontaktowe : \r\n";
            tekst += "Telefon : " + textBox4.Text + " E-Mail : " + textBox3.Text + " \r\n";
            tekst += "Kwota Kredytu : " + textBox2.Text + " Okres Kredytowania : " + textBox6.Text + " \r\n";
            tekst += "Godzina Kontaktu : " +box1.Text + " \r\n";
            tekst += "Zgoda na przetwarzanie danych osobowych: " + ((checkBox1.Checked) ? "TAK" : "NIE") + "\r\n";
            tekst += "Zgoda na przetwarzanie danych handlowych: " + ((checkBox2.Checked) ? "TAK" : "NIE") + "\r\n";
            tekst += "Złożono : " + DateTime.Now.ToString("F") + " \r\n";

            if (File.Exists(path))
            {
                string zmiana = "Kwota Kredytu : " + textBox2.Text + " Okres Kredytowania : " + textBox6.Text + " \r\n";
                zmiana += "Godzina Kontaktu : " + box1.Text + " \r\n";
                zmiana += "Złożono : " + DateTime.Now.ToString("F") + " \r\n";
                File.AppendAllText(path, zmiana);
            }
            else
            {
                File.WriteAllText(path, tekst);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox2.Text = "" + trackBar1.Value + "zł";
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            textBox6.Text = "" + trackBar2.Value + "m-cy";
        }
    }
}
