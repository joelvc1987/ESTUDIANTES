using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESTUDIANTES
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Menu = new Form1();
            Menu.Show();
        }

        private void profesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Menu = new Form2();
            Menu.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form Menu = new Form5();
            Menu.Show();
        }

        private void primariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Menu = new Form3();
            Menu.Show();
        }

        private void secundariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Menu = new Form4();
            Menu.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
