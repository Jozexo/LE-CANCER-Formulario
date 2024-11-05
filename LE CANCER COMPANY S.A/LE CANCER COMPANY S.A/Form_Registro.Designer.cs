namespace LE_CANCER_COMPANY_S.A
{
    partial class Form_Registro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtCedula = new TextBox();
            txtNombre = new TextBox();
            txtEdad = new TextBox();
            txtDeuda = new TextBox();
            lbCedula = new Label();
            lbNombre = new Label();
            lbEdad = new Label();
            lbSexo = new Label();
            lbDeuda = new Label();
            lbEnfermo = new Label();
            cbSexo = new ComboBox();
            lbTitulo = new Label();
            checkEnfermo = new CheckBox();
            btRegistrar = new Button();
            txtCondicion = new TextBox();
            lbCondicion = new Label();
            cbEdadFiltro = new ComboBox();
            checkSanosFiltro = new CheckBox();
            cbSexoFiltro = new ComboBox();
            btBuscar = new Button();
            lbEdadFiltro = new Label();
            lbSexoFiltro = new Label();
            dataGridViewResultados = new DataGridView();
            dataGridViewSanos = new DataGridView();
            dataGridViewEnfermos = new DataGridView();
            txtTotalEnfermos = new TextBox();
            txtTotalSanos = new TextBox();
            txtTotalDeudas = new TextBox();
            lbTotalDeudas = new Label();
            lbTituloSanos = new Label();
            lbTituloEnfermos = new Label();
            btLimpiarEnfermos = new Button();
            btLimpiarSanos = new Button();
            btLimpiarBusqueda = new Button();
            checkEnfermosFiltro = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResultados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSanos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEnfermos).BeginInit();
            SuspendLayout();
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(64, 101);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(100, 21);
            txtCedula.TabIndex = 0;
            txtCedula.KeyPress += txtCedula_KeyPress;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(64, 168);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 21);
            txtNombre.TabIndex = 1;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(64, 233);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 21);
            txtEdad.TabIndex = 2;
            txtEdad.KeyPress += txtEdad_KeyPress;
            // 
            // txtDeuda
            // 
            txtDeuda.Location = new Point(318, 101);
            txtDeuda.Name = "txtDeuda";
            txtDeuda.Size = new Size(144, 21);
            txtDeuda.TabIndex = 4;
            txtDeuda.Text = "iuouopi";
            txtDeuda.TextAlign = HorizontalAlignment.Center;
            txtDeuda.KeyPress += txtDeuda_KeyPress;
            // 
            // lbCedula
            // 
            lbCedula.AutoSize = true;
            lbCedula.Font = new Font("Cascadia Code", 11.25F, FontStyle.Bold);
            lbCedula.Location = new Point(64, 78);
            lbCedula.Name = "lbCedula";
            lbCedula.Size = new Size(72, 20);
            lbCedula.TabIndex = 6;
            lbCedula.Text = "CEDULA:";
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Font = new Font("Cascadia Code", 11.25F, FontStyle.Bold);
            lbNombre.Location = new Point(64, 145);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(72, 20);
            lbNombre.TabIndex = 7;
            lbNombre.Text = "NOMBRE:";
            // 
            // lbEdad
            // 
            lbEdad.AutoSize = true;
            lbEdad.Font = new Font("Cascadia Code", 11.25F, FontStyle.Bold);
            lbEdad.Location = new Point(64, 210);
            lbEdad.Name = "lbEdad";
            lbEdad.Size = new Size(54, 20);
            lbEdad.TabIndex = 8;
            lbEdad.Text = "EDAD:";
            // 
            // lbSexo
            // 
            lbSexo.AutoSize = true;
            lbSexo.Font = new Font("Cascadia Code", 11.25F, FontStyle.Bold);
            lbSexo.Location = new Point(64, 360);
            lbSexo.Name = "lbSexo";
            lbSexo.Size = new Size(54, 20);
            lbSexo.TabIndex = 9;
            lbSexo.Text = "SEXO:";
            // 
            // lbDeuda
            // 
            lbDeuda.AutoSize = true;
            lbDeuda.Font = new Font("Cascadia Code", 11.25F, FontStyle.Bold);
            lbDeuda.Location = new Point(318, 78);
            lbDeuda.Name = "lbDeuda";
            lbDeuda.Size = new Size(144, 20);
            lbDeuda.TabIndex = 10;
            lbDeuda.Text = "MONTO DE DEUDA:";
            // 
            // lbEnfermo
            // 
            lbEnfermo.AutoSize = true;
            lbEnfermo.Font = new Font("Cascadia Code", 11.25F, FontStyle.Bold);
            lbEnfermo.Location = new Point(315, 163);
            lbEnfermo.Name = "lbEnfermo";
            lbEnfermo.Size = new Size(126, 20);
            lbEnfermo.TabIndex = 11;
            lbEnfermo.Text = "ESTÁ ENFERMO?";
            // 
            // cbSexo
            // 
            cbSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSexo.FormattingEnabled = true;
            cbSexo.Location = new Point(64, 383);
            cbSexo.Name = "cbSexo";
            cbSexo.Size = new Size(100, 24);
            cbSexo.TabIndex = 12;
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.Font = new Font("Cascadia Code", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitulo.Location = new Point(79, 25);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(372, 28);
            lbTitulo.TabIndex = 13;
            lbTitulo.Text = "REGISTRO DE DATOS DE PACIENTES";
            // 
            // checkEnfermo
            // 
            checkEnfermo.AutoSize = true;
            checkEnfermo.Location = new Point(447, 168);
            checkEnfermo.Name = "checkEnfermo";
            checkEnfermo.Size = new Size(15, 14);
            checkEnfermo.TabIndex = 14;
            checkEnfermo.UseVisualStyleBackColor = true;
            // 
            // btRegistrar
            // 
            btRegistrar.Font = new Font("Cascadia Code", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btRegistrar.Location = new Point(315, 219);
            btRegistrar.Name = "btRegistrar";
            btRegistrar.Size = new Size(147, 43);
            btRegistrar.TabIndex = 16;
            btRegistrar.Text = "REGISTRAR";
            btRegistrar.UseVisualStyleBackColor = true;
            btRegistrar.Click += btRegistrar_Click;
            // 
            // txtCondicion
            // 
            txtCondicion.Location = new Point(64, 311);
            txtCondicion.Name = "txtCondicion";
            txtCondicion.Size = new Size(100, 21);
            txtCondicion.TabIndex = 17;
            txtCondicion.KeyPress += txtCondicion_KeyPress;
            // 
            // lbCondicion
            // 
            lbCondicion.AutoSize = true;
            lbCondicion.Font = new Font("Cascadia Code", 11.25F, FontStyle.Bold);
            lbCondicion.Location = new Point(64, 288);
            lbCondicion.Name = "lbCondicion";
            lbCondicion.Size = new Size(99, 20);
            lbCondicion.TabIndex = 18;
            lbCondicion.Text = "CONDICIÓN:";
            // 
            // cbEdadFiltro
            // 
            cbEdadFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEdadFiltro.FormattingEnabled = true;
            cbEdadFiltro.Location = new Point(723, 208);
            cbEdadFiltro.Name = "cbEdadFiltro";
            cbEdadFiltro.Size = new Size(121, 24);
            cbEdadFiltro.TabIndex = 24;
            // 
            // checkSanosFiltro
            // 
            checkSanosFiltro.AutoSize = true;
            checkSanosFiltro.Location = new Point(578, 195);
            checkSanosFiltro.Name = "checkSanosFiltro";
            checkSanosFiltro.Size = new Size(61, 20);
            checkSanosFiltro.TabIndex = 25;
            checkSanosFiltro.Text = "Sanos";
            checkSanosFiltro.TextAlign = ContentAlignment.MiddleCenter;
            checkSanosFiltro.UseVisualStyleBackColor = true;
            // 
            // cbSexoFiltro
            // 
            cbSexoFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSexoFiltro.FormattingEnabled = true;
            cbSexoFiltro.Location = new Point(891, 208);
            cbSexoFiltro.Name = "cbSexoFiltro";
            cbSexoFiltro.Size = new Size(121, 24);
            cbSexoFiltro.TabIndex = 26;
            // 
            // btBuscar
            // 
            btBuscar.Location = new Point(1237, 195);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(75, 23);
            btBuscar.TabIndex = 27;
            btBuscar.Text = "BUSCAR";
            btBuscar.UseVisualStyleBackColor = true;
            btBuscar.Click += btBuscar_Click;
            // 
            // lbEdadFiltro
            // 
            lbEdadFiltro.AutoSize = true;
            lbEdadFiltro.Location = new Point(675, 211);
            lbEdadFiltro.Name = "lbEdadFiltro";
            lbEdadFiltro.Size = new Size(42, 16);
            lbEdadFiltro.TabIndex = 28;
            lbEdadFiltro.Text = "Edad:";
            // 
            // lbSexoFiltro
            // 
            lbSexoFiltro.AutoSize = true;
            lbSexoFiltro.Location = new Point(850, 211);
            lbSexoFiltro.Name = "lbSexoFiltro";
            lbSexoFiltro.Size = new Size(42, 16);
            lbSexoFiltro.TabIndex = 29;
            lbSexoFiltro.Text = "Sexo:";
            // 
            // dataGridViewResultados
            // 
            dataGridViewResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResultados.Location = new Point(578, 25);
            dataGridViewResultados.Name = "dataGridViewResultados";
            dataGridViewResultados.ReadOnly = true;
            dataGridViewResultados.Size = new Size(743, 150);
            dataGridViewResultados.TabIndex = 30;
            // 
            // dataGridViewSanos
            // 
            dataGridViewSanos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSanos.Location = new Point(578, 269);
            dataGridViewSanos.Name = "dataGridViewSanos";
            dataGridViewSanos.ReadOnly = true;
            dataGridViewSanos.Size = new Size(743, 150);
            dataGridViewSanos.TabIndex = 31;
            // 
            // dataGridViewEnfermos
            // 
            dataGridViewEnfermos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEnfermos.Location = new Point(578, 473);
            dataGridViewEnfermos.Name = "dataGridViewEnfermos";
            dataGridViewEnfermos.ReadOnly = true;
            dataGridViewEnfermos.Size = new Size(743, 150);
            dataGridViewEnfermos.TabIndex = 32;
            // 
            // txtTotalEnfermos
            // 
            txtTotalEnfermos.Location = new Point(816, 636);
            txtTotalEnfermos.Name = "txtTotalEnfermos";
            txtTotalEnfermos.ReadOnly = true;
            txtTotalEnfermos.Size = new Size(100, 21);
            txtTotalEnfermos.TabIndex = 33;
            txtTotalEnfermos.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTotalSanos
            // 
            txtTotalSanos.Location = new Point(816, 433);
            txtTotalSanos.Name = "txtTotalSanos";
            txtTotalSanos.ReadOnly = true;
            txtTotalSanos.Size = new Size(100, 21);
            txtTotalSanos.TabIndex = 34;
            txtTotalSanos.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTotalDeudas
            // 
            txtTotalDeudas.Location = new Point(1115, 210);
            txtTotalDeudas.Name = "txtTotalDeudas";
            txtTotalDeudas.ReadOnly = true;
            txtTotalDeudas.Size = new Size(100, 21);
            txtTotalDeudas.TabIndex = 35;
            // 
            // lbTotalDeudas
            // 
            lbTotalDeudas.AutoSize = true;
            lbTotalDeudas.Location = new Point(1018, 211);
            lbTotalDeudas.Name = "lbTotalDeudas";
            lbTotalDeudas.Size = new Size(91, 16);
            lbTotalDeudas.TabIndex = 36;
            lbTotalDeudas.Text = "Total Deuda:";
            // 
            // lbTituloSanos
            // 
            lbTituloSanos.AutoSize = true;
            lbTituloSanos.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTituloSanos.Location = new Point(578, 245);
            lbTituloSanos.Name = "lbTituloSanos";
            lbTituloSanos.Size = new Size(145, 21);
            lbTituloSanos.TabIndex = 37;
            lbTituloSanos.Text = "PACIENTES SANOS";
            // 
            // lbTituloEnfermos
            // 
            lbTituloEnfermos.AutoSize = true;
            lbTituloEnfermos.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTituloEnfermos.Location = new Point(578, 449);
            lbTituloEnfermos.Name = "lbTituloEnfermos";
            lbTituloEnfermos.Size = new Size(172, 21);
            lbTituloEnfermos.TabIndex = 38;
            lbTituloEnfermos.Text = "PACIENTES ENFERMOS";
            // 
            // btLimpiarEnfermos
            // 
            btLimpiarEnfermos.Location = new Point(994, 431);
            btLimpiarEnfermos.Name = "btLimpiarEnfermos";
            btLimpiarEnfermos.Size = new Size(75, 23);
            btLimpiarEnfermos.TabIndex = 39;
            btLimpiarEnfermos.Text = "LIMPIAR";
            btLimpiarEnfermos.UseVisualStyleBackColor = true;
            btLimpiarEnfermos.Click += btLimpiarSanos_Click;
            // 
            // btLimpiarSanos
            // 
            btLimpiarSanos.Location = new Point(994, 636);
            btLimpiarSanos.Name = "btLimpiarSanos";
            btLimpiarSanos.Size = new Size(75, 23);
            btLimpiarSanos.TabIndex = 40;
            btLimpiarSanos.Text = "LIMPIAR";
            btLimpiarSanos.UseVisualStyleBackColor = true;
            btLimpiarSanos.Click += btLimpiarEnfermos_Click;
            // 
            // btLimpiarBusqueda
            // 
            btLimpiarBusqueda.Location = new Point(1237, 224);
            btLimpiarBusqueda.Name = "btLimpiarBusqueda";
            btLimpiarBusqueda.Size = new Size(75, 23);
            btLimpiarBusqueda.TabIndex = 41;
            btLimpiarBusqueda.Text = "LIMPIAR";
            btLimpiarBusqueda.UseVisualStyleBackColor = true;
            btLimpiarBusqueda.Click += btLimpiarBusqueda_Click;
            // 
            // checkEnfermosFiltro
            // 
            checkEnfermosFiltro.AutoSize = true;
            checkEnfermosFiltro.Location = new Point(578, 219);
            checkEnfermosFiltro.Name = "checkEnfermosFiltro";
            checkEnfermosFiltro.Size = new Size(82, 20);
            checkEnfermosFiltro.TabIndex = 42;
            checkEnfermosFiltro.Text = "Enfermos";
            checkEnfermosFiltro.UseVisualStyleBackColor = true;
            // 
            // Form_Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1343, 676);
            Controls.Add(checkEnfermosFiltro);
            Controls.Add(btLimpiarBusqueda);
            Controls.Add(btLimpiarSanos);
            Controls.Add(btLimpiarEnfermos);
            Controls.Add(lbTituloEnfermos);
            Controls.Add(lbTituloSanos);
            Controls.Add(lbTotalDeudas);
            Controls.Add(txtTotalDeudas);
            Controls.Add(txtTotalSanos);
            Controls.Add(txtTotalEnfermos);
            Controls.Add(dataGridViewEnfermos);
            Controls.Add(dataGridViewSanos);
            Controls.Add(dataGridViewResultados);
            Controls.Add(lbSexoFiltro);
            Controls.Add(lbEdadFiltro);
            Controls.Add(btBuscar);
            Controls.Add(cbSexoFiltro);
            Controls.Add(checkSanosFiltro);
            Controls.Add(cbEdadFiltro);
            Controls.Add(lbCondicion);
            Controls.Add(txtCondicion);
            Controls.Add(btRegistrar);
            Controls.Add(checkEnfermo);
            Controls.Add(lbTitulo);
            Controls.Add(cbSexo);
            Controls.Add(lbEnfermo);
            Controls.Add(lbDeuda);
            Controls.Add(lbSexo);
            Controls.Add(lbEdad);
            Controls.Add(lbNombre);
            Controls.Add(lbCedula);
            Controls.Add(txtDeuda);
            Controls.Add(txtEdad);
            Controls.Add(txtNombre);
            Controls.Add(txtCedula);
            Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Form_Registro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de Datos - Le Cancer";
            ((System.ComponentModel.ISupportInitialize)dataGridViewResultados).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSanos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEnfermos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCedula;
        private TextBox txtNombre;
        private TextBox txtEdad;
        private TextBox txtDeuda;
        private Label lbCedula;
        private Label lbNombre;
        private Label lbEdad;
        private Label lbSexo;
        private Label lbDeuda;
        private Label lbEnfermo;
        private ComboBox cbSexo;
        private Label lbTitulo;
        private CheckBox checkEnfermo;
        private Button btRegistrar;
        private TextBox txtCondicion;
        private Label lbCondicion;
        private ComboBox cbEdadFiltro;
        private CheckBox checkSanosFiltro;
        private ComboBox cbSexoFiltro;
        private Button btBuscar;
        private Label lbEdadFiltro;
        private Label lbSexoFiltro;
        private DataGridView dataGridViewResultados;
        private DataGridView dataGridViewSanos;
        private DataGridView dataGridViewEnfermos;
        private TextBox txtTotalEnfermos;
        private TextBox txtTotalSanos;
        private TextBox txtTotalDeudas;
        private Label lbTotalDeudas;
        private Label lbTituloSanos;
        private Label lbTituloEnfermos;
        private Button btLimpiarEnfermos;
        private Button btLimpiarSanos;
        private Button btLimpiarBusqueda;
        private CheckBox checkEnfermosFiltro;
    }
}
