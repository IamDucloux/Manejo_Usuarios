using System;
using System.Windows.Forms;

namespace Arreglos
{
    public partial class Form6 : Form
    {
        bool bandera = false;
        int indice = 0;
        Form3 menu = new Form3();

        public Form6()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 30; i++)
            {
                if (Form1.usuarios[i] == textBox1.Text)
                {
                    bandera = true;
                    indice = i;
                };
            }

            if (bandera == true)
            {
                textBox2.Text = Form1.usuarios[indice];
                textBox3.Text = Form1.passwords[indice].ToString();
                textBox4.Text = Form1.nUsr[indice].ToString();
            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            menu.Show();
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1.usuarios[indice] = textBox2.Text;
            Form1.passwords[indice] = int.Parse(textBox3.Text);
            Form1.nUsr[indice] = char.Parse(textBox4.Text);
        }
    }
}
