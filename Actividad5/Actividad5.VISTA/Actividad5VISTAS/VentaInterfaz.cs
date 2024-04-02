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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Actividad5.VISTA.Actividad5VISTAS
{
    public partial class VentaInterfaz : Form
    {
        public VentaInterfaz()
        {
            InitializeComponent();
        }
        VentaBSS bss = new VentaBSS();
        private void VentaInterfaz_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarVentaBss();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Venta u = new Venta();
            u.TotalVenta = Convert.ToDecimal(textBox1.Text);
            u.FechaVenta = dateTimePicker1.Value;

            bss.InsertarVentaBss(u);
            MessageBox.Show("Se guardo correctamente ");
            dataGridView1.DataSource = bss.ListarVentaBss();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int IdVentaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            Venta editarVenta = bss.ObtenerVentaIdBss(IdVentaSeleccionada);
            editarVenta.TotalVenta = Convert.ToDecimal(textBox1.Text);
            editarVenta.FechaVenta = dateTimePicker1.Value;
            bss.EditarVentaBss(editarVenta);
            MessageBox.Show("Datos Actualizados");

            dataGridView1.DataSource = bss.ListarVentaBss();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdVentaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta seguro que desea eliminar a esta venta?", "ELIMINAR", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarVentaBss(IdVentaSeleccionada);
                dataGridView1.DataSource = bss.ListarVentaBss();
            }
        }
    }
}
