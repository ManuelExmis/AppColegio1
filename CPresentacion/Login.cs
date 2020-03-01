using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CNegocio;

namespace CPresentacion
{
    public partial class Login : Form
    {
        private CNUsuarios _CNUsuarios = new CNUsuarios();
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            if(txtPassword.Text.Length > 0 && txtUsuarios.Text.Length > 0)
            {
                CNUsuarios _CNUsuarios = new CNUsuarios();
                if(_CNUsuarios.FindUser(txtUsuarios.Text, txtPassword.Text) == true)
                {
                    FrmMdi formularioMdi = new FrmMdi();
                    formularioMdi.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario invalido");
                }
            }
            else
            {
                MessageBox.Show("Ingrese Usuario y contraseña");
            }
        }
    }
}
