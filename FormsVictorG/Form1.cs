using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsVictorG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCalculadora calculadora = new FormCalculadora();
            calculadora.ShowDialog();
        }

        private void sobreOAutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAutor formulario_autor = new FormAutor();
            formulario_autor.ShowDialog();
        }
    }
}
