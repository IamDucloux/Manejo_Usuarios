using System;
using System.Windows.Forms;

namespace Arreglos
{
    public partial class Form4 : Form
    {
        string nueUsr = "";
        int nuePassw = 0;
        char nivel_Usuario = ' ';
        int ultimo_L = 0;
        Boolean usuario_disp = true;

        public Form4()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nueUsr = aleatorio();

            usuario_disp = true;


            ultimo_L = 0;
            //inicio.usuarios[inicio.usuarios.Length]=nueUsr;
            //inicio.passwords[inicio.passwords.Length] = nuePassw;
            //inicio.nUsr[inicio.nUsr.Length] = nivel_Usuario;

            try
            {
                nuePassw = int.Parse(textBox2.Text);
                nivel_Usuario = char.Parse(comboBox1.GetItemText(comboBox1.SelectedItem));

                for (int i = 0; i < 30; i++)
                {
                    if (Form1.usuarios[i] == null)
                    {
                        ultimo_L = i;
                        break;
                    }

                }

                for (int i = 0; i < 30; i++)
                {
                    if (Form1.usuarios[i] == nueUsr)
                    {
                        usuario_disp = false;
                        break;
                    }
                }

                if (usuario_disp == true)
                {
                    Form1.usuarios[ultimo_L] = nueUsr;
                    Form1.passwords[ultimo_L] = nuePassw;
                    Form1.nUsr[ultimo_L] = nivel_Usuario;


                    MessageBox.Show("El usuario " + nueUsr + " ha sido registrado exitosamente ");

                    textBox1.Clear();
                    textBox2.Clear();
                }
                else
                {
                    MessageBox.Show("El usuario " + nueUsr + " ya esta ocupado");
                    textBox1.Clear();
                    textBox2.Clear();
                }



                if (ultimo_L == 29)
                {
                    button1.Enabled = false;
                    MessageBox.Show("Se ha llegado al limite de usuarios");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Campos faltantes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }




        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form1 inicio = new Form1();
            inicio.Show();
            Hide();
        }


        string aleatorio()
        {
            Random rnd = new Random();
            int valor = 0;
            string id = "";
            for (int i = 0; i < 6; i++)
            {
                valor = rnd.Next(0, 9);
                id = id + valor.ToString();


            }

            return id;

        }
    }
}
