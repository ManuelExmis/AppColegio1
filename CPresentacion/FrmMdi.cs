using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPresentacion
{
    public partial class FrmMdi : Form
    {
        public FrmMdi()
        {
            InitializeComponent();
        }

        private void FrmMdi_Load(object sender, EventArgs e)
        {

        }

        private void FrmMdi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void tutoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void alumnosToolStripMenuItem_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void tutoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmTutores formularioTutores = new FrmTutores();
            formularioTutores.MdiParent = this;
            formularioTutores.Show();
        }

        private void alumnosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAlumnos formularioAlumnos = new FrmAlumnos();
            formularioAlumnos.MdiParent = this;
            formularioAlumnos.Show();
        }
    }
}
