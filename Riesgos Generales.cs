﻿using System;
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
    public partial class Riesgos_Generales : Form
    {
        public Riesgos_Generales()
        {
            InitializeComponent();
        }



        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Condiciones_Estructurales tercerform = new Condiciones_Estructurales();
            tercerform.Show();
            this.Close();

        }
    }
}
