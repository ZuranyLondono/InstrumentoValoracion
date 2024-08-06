using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Instrumento_de_Valoracion__de_la_familia
{
    public partial class Verificacion : Form
    {
        public Verificacion()
        {
            InitializeComponent();
        }

        private void Verificacion_Load(object sender, EventArgs e)
        {

        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            string unicousuario = "usuario1234";
            string contraseña = "contraseña2024";
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) && string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
                return;
            }


            if (txtUsuario.Text == unicousuario && txtContraseña.Text == contraseña)
            {
                btnContinuar.Enabled = true;
            }
            else
            {
                MessageBox.Show("usuario o contraseña incorrectos");
                return;
            }

            Informacion_personal secondform = new Informacion_personal();
            secondform.Show();
            this.Hide();
        }
       
    

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que quieres cancelar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit(); //Cierra el formulario por completo 
            }
            
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            string contraseña = "contraseña2024";



            if (txtContraseña.Text == contraseña)
            {
                btnContinuar.Enabled = true;
                errorcontraseña.SetError(txtContraseña, string.Empty);
            }
            else
            {
                {
                    errorcontraseña.SetError(txtContraseña, "La contraseña es incorrecta");
                }

            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
