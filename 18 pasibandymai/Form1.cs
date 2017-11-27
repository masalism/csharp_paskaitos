using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_pasibandymai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Paspaudete ant mygtuko :D");
        }

        private void button3_Click(object sender, EventArgs e)
        {

            //pasiimti reiksme is text box
            var tekstas = textBox1.Text;

            //ideti teksta
            LabelPaskeisti.Text = tekstas;

            //isvalyti laukeli
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var pirmas = Convert.ToInt64(textBox2.Text);
            var antras = Convert.ToInt64(textBox3.Text);
            var suma = pirmas + antras;
            label1.Text = suma.ToString();

            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var form2 = new Forma();
            form2.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var vardas = Vardas.Text;
            var amzius = Convert.ToInt32(Amzius.Text);
            var forma = new DuomenysForma(vardas, amzius);
            forma.ShowDialog();
        }

        private void Vardas_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (var forma = new IvestiDuomenisForma())
            {
                forma.ShowDialog();

                if (forma.DialogResult == DialogResult.OK)
                {
                    textBoxVardasGauti.Text = forma.Vardas;
                    textBoxAmziusGauti.Text = forma.Amzius.ToString();
                }
            }
        }
    }
}
