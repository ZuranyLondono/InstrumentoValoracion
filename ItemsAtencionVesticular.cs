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
    public partial class ItemsAtencionVesticular : Form
    {
        public ItemsAtencionVesticular()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sus datos han sido guardados correctamente");
            Application.Exit();
        }
    }
}
