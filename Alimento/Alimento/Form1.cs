using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alimento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbalimentos.Items.Add("Pozole");
            cbalimentos.Items.Add("Tostadas de Pata");
        }

        private void Btnaceptar_Click(object sender, EventArgs e)
        {
            cbalimentos.Items.Add(textBox1.Text);
        }

        private void Cbalimentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = cbalimentos.SelectedIndex;
            label1.Text = indice.ToString();
            label2.Text = cbalimentos.Items[indice].ToString();
        }

        private void Btnaceptar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Btnaceptar_Click(sender, e);
            }
        }
    }
}
