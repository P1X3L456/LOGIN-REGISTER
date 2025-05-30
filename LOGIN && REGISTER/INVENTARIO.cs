using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LOGIN____REGISTER.INVENTARIO;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Globalization;

namespace LOGIN____REGISTER
{
    public partial class INVENTARIO : Form
    {
        public INVENTARIO()
        {
            InitializeComponent();
        }
        List<Producto> listaProductos = new List<Producto>();
        List<Categoria> listaCategorias = new List<Categoria>
        {
            new Categoria("Dispositivos de entretenimiento"),
            new Categoria("Dispositivos de comunicación"),
            new Categoria("Herramientas eléctricas y electrónicas"),
            new Categoria("Aparatos de intercambio de temperatura"),
            new Categoria("Computadoras")
        };
        public class Categoria
        {
            public string Nombre { get; set; }
            public Categoria(string nombre) => Nombre = nombre;
            public override string ToString() => Nombre;
        }

        public class Producto
        {
            public string Nombre { get; set; }
            public Categoria Categoria { get; set; }
            public decimal Precio { get; set; }
            public int Stock { get; set; }

            public Producto(string nombre, Categoria categoria, decimal precio, int stock)
            {
                Nombre = nombre;
                Categoria = categoria;
                Precio = precio;
                Stock = stock;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void INVENTARIO_Load(object sender, EventArgs e)
        {
            lvwProductos.View = View.Details;
            lvwProductos.FullRowSelect = true;
            lvwProductos.GridLines = true;

            lvwProductos.Columns.Add("Nombre", 150);
            lvwProductos.Columns.Add("Categoría", 200);
            lvwProductos.Columns.Add("Precio", 80);
            lvwProductos.Columns.Add("Stock", 60);
            cmbCategoria.DataSource = listaCategorias;
            cmbCategoria.DisplayMember = "Nombre";
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Agregar_btn_Click(object sender, EventArgs e)
        {
            {
                string nombre = txtNombre.Text.Trim();
                Categoria categoria = (Categoria)cmbCategoria.SelectedItem;

                if (string.IsNullOrWhiteSpace(nombre))
                {
                    MessageBox.Show("El nombre del producto es obligatorio.");
                    return;
                }
                var cultura = CultureInfo.CurrentCulture;

                if (!decimal.TryParse(txtPrecio.Text, NumberStyles.Number, cultura, out decimal precio))
                {
                    MessageBox.Show("El precio debe ser un número válido. Usa el separador decimal correcto.");
                    return;
                }

                if (!int.TryParse(txtStock.Text, NumberStyles.Integer, cultura, out int stock))
                {
                    MessageBox.Show("El stock debe ser un número entero válido.");
                    return;
                }


                bool existe = listaProductos.Any(p => p.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
                if (existe)
                {
                    MessageBox.Show("Ya existe un producto con ese nombre.");
                    return;
                }

                Producto nuevo = new Producto(nombre, categoria, precio, stock);
                listaProductos.Add(nuevo);
                ActualizarListView();

                MessageBox.Show("Producto agregado correctamente.");

                txtNombre.Text = "";
                cmbCategoria.SelectedIndex = -1;
                txtPrecio.Text = "";
                txtStock.Text = "";
                txtNombre.Focus();
            }
        }

        private void TextProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void CmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            Categoria categoriaSeleccionada = (Categoria)cmbCategoria.SelectedItem;

            if (categoriaSeleccionada != null)
            {
                var productosFiltrados = listaProductos
                    .Where(p => p.Categoria.Nombre == categoriaSeleccionada.Nombre)
                    .ToList();

                MostrarEnListView(productosFiltrados);
            }
        }

        private void lvwProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ActualizarListView()
        {
            lvwProductos.Items.Clear();

            foreach (var producto in listaProductos)
            {
                ListViewItem item = new ListViewItem(producto.Nombre);
                item.SubItems.Add(producto.Categoria.Nombre);
                item.SubItems.Add(producto.Precio.ToString("0.00"));
                item.SubItems.Add(producto.Stock.ToString());

                lvwProductos.Items.Add(item);
            }
        }
        private void MostrarEnListView(List<Producto> productos)
        {
            lvwProductos.Items.Clear();

            foreach (var producto in productos)
            {
                ListViewItem item = new ListViewItem(producto.Nombre);
                item.SubItems.Add(producto.Categoria.Nombre);
                item.SubItems.Add(producto.Precio.ToString("0.00"));
                item.SubItems.Add(producto.Stock.ToString());

                lvwProductos.Items.Add(item);
            }
        }

        private void btnCalcularStock_Click_1(object sender, EventArgs e)
        {
            if (cmbCategoria.SelectedItem == null)
            {
                MessageBox.Show("Por favor selecciona una categoría primero.");
                return;
            }

            Categoria categoriaSeleccionada = (Categoria)cmbCategoria.SelectedItem;
            string categoriaNombre = categoriaSeleccionada.Nombre;

            var productosCategoria = listaProductos.Where(p => p.Categoria.Nombre == categoriaNombre).ToList();

            if (productosCategoria.Count == 0)
            {
                MessageBox.Show($"No hay productos en la categoría: {categoriaNombre}");
                return;
            }

            int stockTotal = productosCategoria.Sum(p => p.Stock);

            string mensaje = $"CATEGORÍA: {categoriaNombre}\n\n";
            mensaje += $"Productos encontrados: {productosCategoria.Count}\n";
            mensaje += $"Stock total: {stockTotal} unidades\n\n";
            mensaje += "Detalle por producto:\n";

            foreach (var producto in productosCategoria)
            {
                mensaje += $"• {producto.Nombre}: {producto.Stock} unidades\n";
            }

            MessageBox.Show(mensaje, "Stock de Categoría");
        }
    }
}
