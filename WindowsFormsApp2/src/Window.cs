using System;
using System.Windows.Forms;
using utils;

namespace WindowsFormsApp2
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
            Input_Cantidad.Enabled = false;
            Input_Descripcion.Enabled = false;
            Input_PrecioVenta.Enabled = false;
            Button_Insertar.Enabled = false;
            Button_Borrar.Enabled = false;
            Button_Actualizar.Enabled = false;
        }

        private void Input_Codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(Validation.OnlyInts(e.KeyChar));
        }

        private void Input_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(Validation.OnlyInts(e.KeyChar));
        }

        private void Input_Descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(Validation.OnlyLetters(e.KeyChar));
        }

        private void Input_PrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(Validation.OnlyDoubles(e.KeyChar));
        }

        private void Button_Limpiar_Click(object sender, EventArgs e)
        {
            Input_Codigo.Clear();
            Input_Descripcion.Clear();
            Input_Cantidad.Clear();
            Input_PrecioVenta.Clear();
        }
    }
}
