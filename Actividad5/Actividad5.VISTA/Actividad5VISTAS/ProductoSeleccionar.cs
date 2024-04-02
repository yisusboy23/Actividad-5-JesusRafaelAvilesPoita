using Actividad5.BSS;
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
    public partial class ProductoSeleccionar : Form
    {
        public ProductoSeleccionar()
        {
            InitializeComponent();
        }
        ProductoBSS bss = new ProductoBSS();
        private void ProductoSeleccionar_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarProductoBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetalleVentaInterfaz.IdProductoSeleccionada= Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }
    }
}
