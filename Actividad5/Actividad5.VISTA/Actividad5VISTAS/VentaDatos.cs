using Actividad5.BSS;
using Actividad5.MODELOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad5.VISTA.Actividad5VISTAS
{
    public partial class VentaDatos : Form
    {
        public VentaDatos(int id)
        {
            idx = id;
            InitializeComponent();
        }
        int idx = 0;
        DetalleVenta c = new DetalleVenta();
        DetalleVentaBSS bss = new DetalleVentaBSS();
        private void VentaDatos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.DetalleVentaDatosBSS(idx);
        }
    }
}
