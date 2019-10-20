using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arreglos
{
    public partial class Form5 : Form
    {
        string user = null;
        int indice = 0;
        bool bandera = false;

        public Form5()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            user = textBox1.Text;
            for (int i = 0; i < Form1.usuarios.Length; i++)
            {
                if (Form1.usuarios[i] == user)
                {
                    bandera = true;
                    indice = i;
                    break;
                }


            }

            if (bandera==true)
            {
                Form1.usuarios.SetValue(null, indice);
                Form1.nUsr.SetValue(null, indice);
                Form1.passwords.SetValue(null,indice);
            }
            else
            {
                MessageBox.Show("Usuario no encontrado");
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
