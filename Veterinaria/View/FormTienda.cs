using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinaria.View
{
    public partial class FormTienda : Form
    {
        public FormTienda()
        {
            InitializeComponent();
        }

        private void btAgregarProducto_Click(object sender, EventArgs e)
        {
            FormAgregarProducto fProducto = new FormAgregarProducto();
            fProducto.Show();
        }

        private void btAbrirInv_Click(object sender, EventArgs e)
        {
            FormInventario fInventario = new FormInventario();
            fInventario.Show();
        }

        #region Botones
        /*
         * Todos los botones llevan al mismo formulario con la diferencia de que cada uno envia
         * su contenido de texto para que el carrito ubique una categoria de las 4 más grandes
         */
        private void btJuguetes_Click(object sender, EventArgs e)
        {
            FormCarrito fCarrito = new FormCarrito();
            fCarrito.lbCategoria.Text = btJuguetes.Text;
            fCarrito.Show();          
        }
        private void btAlimento_Click(object sender, EventArgs e)
        {
            FormCarrito fCarrito = new FormCarrito();
            fCarrito.lbCategoria.Text = btAlimento.Text;
            fCarrito.Show();           
        }
        private void btCuidado_Click(object sender, EventArgs e)
        {
            FormCarrito fCarrito = new FormCarrito();
            fCarrito.lbCategoria.Text = btCuidado.Text;
            fCarrito.Show();      
        }
        private void btMedicina_Click(object sender, EventArgs e)
        {
            FormCarrito fCarrito = new FormCarrito();
            fCarrito.lbCategoria.Text = btMedicina.Text;
            fCarrito.Show();
        }
        #endregion

    }
}
