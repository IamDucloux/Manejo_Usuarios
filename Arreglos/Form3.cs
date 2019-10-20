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
    public partial class Form3 : Form
    {
        public static string busqueda = "";
        Form4 Alta = new Form4();
        Form6 Elimi = new Form6();
        Form5 Camb_pass = new Form5();
        Form8 Buscar = new Form8();

        public Form3()
        {
            InitializeComponent();
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void BindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Alta.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Camb_pass.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Elimi.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            
            Buscar.Show();
            
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
