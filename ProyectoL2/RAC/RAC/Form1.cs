using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RAC.BL;

namespace RAC
{
    public partial class FrmMenu : Form
    {

       ListaAutos _listaAutos;
       FacturaBL _facturabl;
       ClientesBL _clientes;
       Factura _facturadetalles;


        public FrmMenu()
        {
            InitializeComponent();

            _listaAutos = new ListaAutos();
            _facturabl = new FacturaBL();
            _clientes = new ClientesBL();
            _facturadetalles = new Factura();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMenu.ActiveForm.Close();
     
        }

        private void alquilarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Frmalquilar = new FrmFacturas();
            Frmalquilar.MdiParent = this;

            Frmalquilar.CargarDatos(_listaAutos,_facturabl,_facturadetalles,_clientes);

            Frmalquilar.Show();
        }

        private void porAñoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FrmReporte = new FrmReporte();
            FrmReporte.MdiParent = this;

            FrmReporte.CargarDatos(_listaAutos);
            FrmReporte.Show();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
