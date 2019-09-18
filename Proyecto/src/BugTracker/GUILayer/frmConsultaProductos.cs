using BugTracker.BusinessLayer;
using BugTracker.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTracker
{
    public partial class frmConsultaProductos : Form
    {
        private readonly MarcaService marcaService;
        private readonly ProductoService productoService;
       
        public frmConsultaProductos()
        {
            InitializeComponent();
            // Inicializamos la grilla de bugs
            InitializeDataGridView();
            marcaService = new MarcaService();
            productoService = new ProductoService();

        }

        private void frmProductos_Load(object sender, EventArgs e)
        {

            //LLenar combos y limpiar grid
            LlenarCombo(cboMarcas, marcaService.ObtenerTodos(), "Descripcion", "IDMarca");
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // las condiciones de los filtros se puede pasar a traves de una coleccion de claves y valores (Dictionary)
            // o bien a través de una cadena de condiciones 
            String sqlcondiciones;
            sqlcondiciones = "";

            DateTime fechaDesde;
            DateTime fechaHasta;
            if (DateTime.TryParse(txtFechaDesde.Text, out fechaDesde) &&
                DateTime.TryParse(txtFechaHasta.Text, out fechaHasta))
            {
                sqlcondiciones += " AND (bug.fecha_alta>=" + fechaDesde + " AND bug.fecha_alta<=" + fechaHasta + ") ";
            }




            if (!string.IsNullOrEmpty(cboMarcas.Text))
            {
                var marca = cboMarcas.SelectedValue.ToString();
                sqlcondiciones += " AND (producto.id_marca=" + marca + ") ";
            }



            //sin usar parametros (concatenando condiciones)
            IList<Producto> listadoProductos = productoService.ConsultarProductosConFiltrosCondiciones(sqlcondiciones);

            //Asigno a la grilla la lista de objetos bug
            dgvProductos.DataSource = listadoProductos;

            if (dgvProductos.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron coincidencias para el/los filtros ingresados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            // Datasource: establece el origen de datos de este objeto.
            cbo.DataSource = source;
            // DisplayMember: establece la propiedad que se va a mostrar para este ListControl.
            cbo.DisplayMember = display;
            // ValueMember: establece la ruta de acceso de la propiedad que se utilizará como valor real para los elementos de ListControl.
            cbo.ValueMember = value;
            //SelectedIndex: establece el índice que especifica el elemento seleccionado actualmente.
            cbo.SelectedIndex = -1;
        }


        private void InitializeDataGridView()
        {
            // Cree un DataGridView no vinculado declarando un recuento de columnas.
            dgvProductos.ColumnCount = 4;
            dgvProductos.ColumnHeadersVisible = true;

            // Configuramos la AutoGenerateColumns en false para que no se autogeneren las columnas
            dgvProductos.AutoGenerateColumns = false;

            // Cambia el estilo de la cabecera de la grilla.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
            dgvProductos.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Definimos el nombre de la columnas y el DataPropertyName que se asocia a DataSource
            //SELECT TOP 1000 [id_producto],[nombre],id_marca],[cantidad],[precio_venta],[borrado]FROM [Deportivo].[dbo].[Productos]
            dgvProductos.Columns[0].Name = "ID";
            dgvProductos.Columns[0].DataPropertyName = "id_producto";
            // Definimos el ancho de la columna.
            dgvProductos.Columns[0].Width = 50;

            dgvProductos.Columns[1].Name = "Nombre";
            dgvProductos.Columns[1].DataPropertyName = "nombre";

            dgvProductos.Columns[2].Name = "Marca";
            dgvProductos.Columns[2].DataPropertyName = "marca";


            dgvProductos.Columns[3].Name = "Precio_Venta";
            dgvProductos.Columns[3].DataPropertyName = "precio_venta";

            // Cambia el tamaño de la altura de los encabezados de columna.
            dgvProductos.AutoResizeColumnHeadersHeight();

            // Cambia el tamaño de todas las alturas de fila para ajustar el contenido de todas las celdas que no sean de encabezado.
            dgvProductos.AutoResizeRows(
                DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
        }

        private void btnDetalleBug_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
             //  frmDetalleProducto frmDetalle = new frmDetalleProducto();
             //   Producto selectedItem = (Producto)dgvProductos.CurrentRow.DataBoundItem;
             //   frmDetalle.InicializarDetalleProducto(selectedItem.IdProducto);
             //   frmDetalle.ShowDialog();
            }
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Cuando seleccionamos una fila de la grilla habilitamos el boton btnDetalleBug.
            btnDetalleProducto.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
