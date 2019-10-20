using System;
using System.Windows.Forms;

namespace Arreglos
{


    public partial class Form1 : Form
    {

        public static string[] usuarios = new string[30];
        public static int[] passwords = new int[30];
        public static char[] nUsr = new char[30];
        Boolean bande1 = false;
        char sUsr = ' ';

        static Form2 usuF = new Form2();

        static Form3 mantF = new Form3();

        static Form4 regisU = new Form4();





        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            usuarios[0] = "123456";
            usuarios[1] = "654321";
            usuarios[2] = "111111";
            usuarios[3] = "212121";
            passwords[0] = 12345;
            passwords[1] = 54321;
            passwords[2] = 56789;
            passwords[3] = 12345;
            nUsr[0] = 'U';
            nUsr[1] = 'M';
            nUsr[2] = 'U';
            nUsr[3] = 'M';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sUsr = ' ';
            for (int i = 0; i < 30; i++)
            {
                if (usuarios[i] == textBox1.Text && passwords[i].ToString() == textBox2.Text)
                {
                    bande1 = true;
                    sUsr = nUsr[i];
                }









            }

            if (bande1 == true)
            {
                MessageBox.Show("Bienvenid@ " + textBox1.Text);
                if (sUsr == 'U')
                {
                    usuF.Show();
                    Hide();
                }
                else
                {
                    mantF.Show();
                    Hide();
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
                textBox1.Clear();
                textBox2.Clear();
            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            regisU.Show();
            Hide();
        }
    }
}
