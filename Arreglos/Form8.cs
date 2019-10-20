using System;
using System.Windows.Forms;

namespace Arreglos
{
    
    public partial class Form8 : Form
    {
        int longBusqueda = 0;
        int i = 0;
        int coinc = 0;
        //string[,,] datosUsuarios = new string[30,30,30];
        Boolean found = false;
        

        public Form8()
        {
            InitializeComponent();
            
        }

        private void BindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void BindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            longBusqueda += 1;
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Hide();
            textBox1.Clear();
            

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            
            if (longBusqueda==6)
            {
                for ( i = 0; i < 30; i++)
                {
                    if (textBox1.Text==Form1.usuarios[i])
                    {
                        
                        found = true;
                        break;
                    }
                }

                if (found==true)
                {
                    richTextBox1.Text = "ID: " + textBox1.Text + " Nivel: " + Form1.nUsr[i];
                    coinc = 1;
                }
            }
            else
            {

                

                for (i = 0; i < 30; i++)
                {
                    if (ComparadorCadenas(Form1.usuarios[i],textBox1.Text)==true)
                    {
                        coinc += 1;
                        richTextBox1.AppendText("ID: " + Form1.usuarios[i] + " Nivel: " + Form1.nUsr[i]);
                    }
                }
            }

            if (coinc==0)
            {
                MessageBox.Show("No se encontraron coincidencias de la busqueda","Sin coincidencias",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

            
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        

        private void Button3_Click(object sender, EventArgs e)
        {
            
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        Boolean ComparadorCadenas(string cadena1,string cadena2)
        {
            int longi_c2 = 0;
            int coin_char = 0;
            Boolean comresult = false;
            char[][] cadenas = new char[2][];
            cadenas[0] = new char[6];
            cadenas[1] = new char[6];
            cadenas[0] = cadena1.ToCharArray();
            cadenas[1] = cadena2.ToCharArray();
            

            for (int i = 0; i < cadenas[1].Length; i++)
            {
                //Exception index out of bounds, checar el arreglo de arreglos
                if (cadenas[0][i]==cadenas[1][i])
                {
                    coin_char +=1;
                    MessageBox.Show(coin_char.ToString());
                }
            }

            if (coin_char>0)
            {
                comresult = true;
            }

            return comresult;
        }
    }
}
