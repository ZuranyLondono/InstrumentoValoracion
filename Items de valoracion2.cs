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
    public partial class Items_de_valoracion2 : Form
    {
        public Items_de_valoracion2()
        {
            InitializeComponent();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
             ItemsAtencionVesticular tercerform = new ItemsAtencionVesticular();
            tercerform.Show();
            this.Close();

        }
    }
}
