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
    public partial class Condiciones_Estructurales : Form
    {
        public Condiciones_Estructurales()
        {
            InitializeComponent();
        }


        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Items_de_Valoracion tercerform = new Items_de_Valoracion();
            tercerform.Show();
            this.Close();

        }
    }
}
