using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;

namespace LE_CANCER_COMPANY_S.A
{
    public partial class Form_Registro : Form
    {

        private List<string> cedulas = new List<string>();

        public Form_Registro()
        {
            InitializeComponent();

            btLimpiarSanos.Click += btLimpiarSanos_Click;
            btLimpiarEnfermos.Click += btLimpiarEnfermos_Click;

            txtTotalEnfermos.Text = "0";
            txtTotalSanos.Text = "0";

            for (int i = 5; i <= 50; i += 5)
            {
                cbEdadFiltro.Items.Add(i);
            }

            cbSexoFiltro.Items.Add("MASCULINO");
            cbSexoFiltro.Items.Add("FEMENINO");
            cbSexoFiltro.Items.Add("OTRO");
            cbSexo.Items.Add("MASCULINO");
            cbSexo.Items.Add("FEMENINO");
            cbSexo.Items.Add("OTRO");

            // Configurar DataGridViewEnfermos
            dataGridViewEnfermos.Columns.Add("Cedula", "Cédula");
            dataGridViewEnfermos.Columns.Add("Nombre", "Nombre");
            dataGridViewEnfermos.Columns.Add("Edad", "Edad");
            dataGridViewEnfermos.Columns.Add("Sexo", "Sexo");
            dataGridViewEnfermos.Columns.Add("Condicion", "Condición");
            dataGridViewEnfermos.Columns.Add("Enfermo", "Enfermo");
            dataGridViewEnfermos.Columns.Add("MontoDeuda", "Monto de Deuda");

            // Configurar DataGridViewSanos
            dataGridViewSanos.Columns.Add("Cedula", "Cédula");
            dataGridViewSanos.Columns.Add("Nombre", "Nombre");
            dataGridViewSanos.Columns.Add("Edad", "Edad");
            dataGridViewSanos.Columns.Add("Sexo", "Sexo");
            dataGridViewSanos.Columns.Add("Condicion", "Condición");
            dataGridViewSanos.Columns.Add("Enfermo", "Enfermo");
            dataGridViewSanos.Columns.Add("MontoDeuda", "Monto de Deuda");


            // Configurar DataGridViewContador
            dataGridViewResultados.Columns.Add("Orden", "Orden");
            dataGridViewResultados.Columns.Add("Cedula", "Cédula");
            dataGridViewResultados.Columns.Add("Nombre", "Nombre");
            dataGridViewResultados.Columns.Add("Edad", "Edad");
            dataGridViewResultados.Columns.Add("Sexo", "Sexo");
            dataGridViewResultados.Columns.Add("Condicion", "Condición");
            dataGridViewResultados.Columns.Add("Enfermo", "Enfermo");
            dataGridViewResultados.Columns.Add("MontoDeuda", "Monto de Deuda");
        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
            string cedula = txtCedula.Text.Trim();
            string nombre = txtNombre.Text.Trim();
            int edad;
            bool esEdadValida = int.TryParse(txtEdad.Text, out edad);
            string sexo = cbSexo.SelectedItem?.ToString();
            string condicion = txtCondicion.Text.Trim();
            bool estaEnfermo = checkEnfermo.Checked;
            decimal montoDeuda;
            bool esMontoValido = decimal.TryParse(txtDeuda.Text, out montoDeuda);


            if (string.IsNullOrWhiteSpace(cedula) || string.IsNullOrWhiteSpace(nombre) || !esEdadValida || edad < 0 || edad > 120 ||
                string.IsNullOrWhiteSpace(sexo) || string.IsNullOrWhiteSpace(condicion) || condicion.Length > 50 || !esMontoValido || montoDeuda < 0)
            {
                MessageBox.Show("COMPLETE TODOS LOS CAMPOS CORRECTAMENTE");
                return;
            }

            if (cedulas.Contains(cedula))
            {
                MessageBox.Show("ESTÁ CÉDULA YA ESTA REGISTRADA");
                return;
            }

            cedulas.Add(cedula);

            var fila = new object[] { cedula, nombre, edad, sexo, condicion, estaEnfermo, montoDeuda };

            if (estaEnfermo)
            {
                dataGridViewEnfermos.Rows.Add(fila);
            }

            else
            {
                dataGridViewSanos.Rows.Add(fila);
            }

            ActualizarTotales();
            LimpiarCampos();

        }
        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (txtCedula.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }

            if (txtNombre.Text.Length >= 50 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (char.IsLetter(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (txtEdad.Text.Length >= 3 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtCondicion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }

            if (txtCondicion.Text.Length >= 50 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (char.IsLetter(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void txtDeuda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',' && txtDeuda.Text.Contains(','))
            {
                e.Handled = true;
            }
        }

        private void LimpiarCampos()

        {
            txtCedula.Clear();
            txtNombre.Clear();
            txtEdad.Clear();
            cbSexo.SelectedIndex = -1;
            txtCondicion.Clear();
            checkEnfermo.Checked = false;
            txtDeuda.Clear();
        }

        private void ActualizarTotales()
        {
            txtTotalEnfermos.Text = (dataGridViewEnfermos.Rows.Count - 1).ToString();
            txtTotalSanos.Text = (dataGridViewSanos.Rows.Count - 1).ToString();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            dataGridViewResultados.Rows.Clear();
            txtTotalDeudas.Text = "0";

            var enfermos = dataGridViewEnfermos.Rows.Cast<DataGridViewRow>().ToList();
            var sanos = dataGridViewSanos.Rows.Cast<DataGridViewRow>().ToList();

            int? edadFiltro = cbEdadFiltro.SelectedItem != null ? (int?)Convert.ToInt32(cbEdadFiltro.SelectedItem) : null;
            string sexoFiltro = cbSexoFiltro.SelectedItem?.ToString();
            bool? enfermoFiltro = checkEnfermosFiltro.Checked ? (bool?)true : null;

            bool mostrarSanos = checkSanosFiltro.Checked;
            bool mostrarEnfermos = checkEnfermosFiltro.Checked;
            decimal totalDeudas = 0;

            foreach (var row in sanos.Concat(enfermos))
            {
                if (row.Cells["Edad"].Value == null || row.Cells["Sexo"].Value == null || row.Cells["Enfermo"].Value == null || row.Cells["MontoDeuda"].Value == null)
                    continue;

                int edad = Convert.ToInt32(row.Cells["Edad"].Value);
                string sexo = row.Cells["Sexo"].Value.ToString();
                bool estadoEnfermo = Convert.ToBoolean(row.Cells["Enfermo"].Value);
                decimal montoDeuda = Convert.ToDecimal(row.Cells["MontoDeuda"].Value);

                bool cumpleEdad = !edadFiltro.HasValue || edad == edadFiltro.Value;
                bool cumpleSexo = string.IsNullOrEmpty(sexoFiltro) || sexo.Equals(sexoFiltro, StringComparison.OrdinalIgnoreCase);
                bool cumpleEstado = !enfermoFiltro.HasValue || estadoEnfermo == enfermoFiltro.Value;

                bool debeMostrar = (mostrarSanos && !mostrarEnfermos && !estadoEnfermo) ||
                                   (mostrarEnfermos && !mostrarSanos && estadoEnfermo) ||
                                   (mostrarSanos && mostrarEnfermos);

                if (debeMostrar && cumpleEdad && cumpleSexo && cumpleEstado)
                {
                    int index = dataGridViewResultados.Rows.Count + 1;
                    dataGridViewResultados.Rows.Add(index, row.Cells["Cedula"].Value, row.Cells["Nombre"].Value, edad, sexo, row.Cells["Condicion"].Value, estadoEnfermo, montoDeuda);
                    totalDeudas += montoDeuda;
                }
            }

            txtTotalDeudas.Text = totalDeudas.ToString();

        }

        private void btLimpiarSanos_Click(object sender, EventArgs e)
        {
            dataGridViewSanos.Rows.Clear();
            txtTotalDeudas.Text = "0";
            ActualizarTotales();
        }

        private void btLimpiarEnfermos_Click(object sender, EventArgs e)
        {
            dataGridViewEnfermos.Rows.Clear();
            txtTotalDeudas.Text = "0";
            ActualizarTotales();
        }

        private void btLimpiarBusqueda_Click(object sender, EventArgs e)
        {
            dataGridViewResultados.Rows.Clear();

            txtTotalDeudas.Text = "0";

            checkSanosFiltro.Checked = false;
            cbEdadFiltro.SelectedIndex = -1;
            cbSexoFiltro.SelectedIndex = -1;
        }
    }
}
