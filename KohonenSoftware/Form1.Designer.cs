
namespace KohonenSoftware
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubirDatos = new System.Windows.Forms.Button();
            this.dgvEntradas = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbEntradas = new System.Windows.Forms.Label();
            this.lbPatrones = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNeuronaMapa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTipoCompetencia = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVecindad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIteraciones = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtRataAprendizaje = new System.Windows.Forms.TextBox();
            this.btnConfiguracionRed = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPesosAleatorio = new System.Windows.Forms.Button();
            this.dgvPesos = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.btnEntrenar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.btnEntrenarRedNuevo = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvVecinas = new System.Windows.Forms.DataGridView();
            this.txtDv = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.dgvDistanciaNeurona = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.txtIteracion = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDt = new System.Windows.Forms.TextBox();
            this.txtCantidadDm = new System.Windows.Forms.TextBox();
            this.txtCantidadVecinas = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCagarPesos = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvPesosCarga = new System.Windows.Forms.DataGridView();
            this.btnPatron = new System.Windows.Forms.Button();
            this.btnSimulacion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dgvDistanciaSimulacion = new System.Windows.Forms.DataGridView();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDvSimulacion = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.dgvPatronSimulacion = new System.Windows.Forms.DataGridView();
            this.lblNeuronas = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lblPatrones = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesos)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVecinas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistanciaNeurona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesosCarga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistanciaSimulacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatronSimulacion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subir Datos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSubirDatos
            // 
            this.btnSubirDatos.Location = new System.Drawing.Point(132, 18);
            this.btnSubirDatos.Name = "btnSubirDatos";
            this.btnSubirDatos.Size = new System.Drawing.Size(213, 23);
            this.btnSubirDatos.TabIndex = 1;
            this.btnSubirDatos.Text = "Cargar";
            this.btnSubirDatos.UseVisualStyleBackColor = true;
            this.btnSubirDatos.Click += new System.EventHandler(this.btnSubirImagen_Click);
            // 
            // dgvEntradas
            // 
            this.dgvEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntradas.Location = new System.Drawing.Point(45, 52);
            this.dgvEntradas.Name = "dgvEntradas";
            this.dgvEntradas.Size = new System.Drawing.Size(324, 150);
            this.dgvEntradas.TabIndex = 2;
            this.dgvEntradas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEntradas_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Numero de entradas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Numeros de patrones";
            // 
            // lbEntradas
            // 
            this.lbEntradas.AutoSize = true;
            this.lbEntradas.Location = new System.Drawing.Point(156, 215);
            this.lbEntradas.Name = "lbEntradas";
            this.lbEntradas.Size = new System.Drawing.Size(13, 13);
            this.lbEntradas.TabIndex = 6;
            this.lbEntradas.Text = "_";
            // 
            // lbPatrones
            // 
            this.lbPatrones.AutoSize = true;
            this.lbPatrones.Location = new System.Drawing.Point(333, 215);
            this.lbPatrones.Name = "lbPatrones";
            this.lbPatrones.Size = new System.Drawing.Size(13, 13);
            this.lbPatrones.TabIndex = 7;
            this.lbPatrones.Text = "_";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cantidad de neurona del mapa";
            // 
            // txtNeuronaMapa
            // 
            this.txtNeuronaMapa.Location = new System.Drawing.Point(222, 241);
            this.txtNeuronaMapa.Name = "txtNeuronaMapa";
            this.txtNeuronaMapa.Size = new System.Drawing.Size(100, 20);
            this.txtNeuronaMapa.TabIndex = 9;
            this.txtNeuronaMapa.TextChanged += new System.EventHandler(this.neuronaMapa_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tipo de competencia";
            // 
            // cmbTipoCompetencia
            // 
            this.cmbTipoCompetencia.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbTipoCompetencia.FormattingEnabled = true;
            this.cmbTipoCompetencia.Items.AddRange(new object[] {
            "Blanda",
            "Dura"});
            this.cmbTipoCompetencia.Location = new System.Drawing.Point(222, 281);
            this.cmbTipoCompetencia.Name = "cmbTipoCompetencia";
            this.cmbTipoCompetencia.Size = new System.Drawing.Size(100, 21);
            this.cmbTipoCompetencia.TabIndex = 11;
            this.cmbTipoCompetencia.SelectedIndexChanged += new System.EventHandler(this.cmbTipoCompetencia_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Coeficiente de vecindad";
            // 
            // txtVecindad
            // 
            this.txtVecindad.Location = new System.Drawing.Point(222, 318);
            this.txtVecindad.Name = "txtVecindad";
            this.txtVecindad.Size = new System.Drawing.Size(100, 20);
            this.txtVecindad.TabIndex = 13;
            this.txtVecindad.Click += new System.EventHandler(this.txtVecindad_Click);
            this.txtVecindad.TextChanged += new System.EventHandler(this.txtVecindad_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Parametros de entrenamiento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Iteraciones";
            // 
            // txtIteraciones
            // 
            this.txtIteraciones.Location = new System.Drawing.Point(7, 36);
            this.txtIteraciones.Name = "txtIteraciones";
            this.txtIteraciones.Size = new System.Drawing.Size(100, 20);
            this.txtIteraciones.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtRataAprendizaje);
            this.panel1.Controls.Add(this.btnConfiguracionRed);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtIteraciones);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(45, 344);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 99);
            this.panel1.TabIndex = 17;
            // 
            // txtRataAprendizaje
            // 
            this.txtRataAprendizaje.Enabled = false;
            this.txtRataAprendizaje.Location = new System.Drawing.Point(147, 36);
            this.txtRataAprendizaje.Name = "txtRataAprendizaje";
            this.txtRataAprendizaje.Size = new System.Drawing.Size(156, 20);
            this.txtRataAprendizaje.TabIndex = 20;
            // 
            // btnConfiguracionRed
            // 
            this.btnConfiguracionRed.Location = new System.Drawing.Point(7, 62);
            this.btnConfiguracionRed.Name = "btnConfiguracionRed";
            this.btnConfiguracionRed.Size = new System.Drawing.Size(156, 23);
            this.btnConfiguracionRed.TabIndex = 19;
            this.btnConfiguracionRed.Text = "Configuracion de la red";
            this.btnConfiguracionRed.UseVisualStyleBackColor = true;
            this.btnConfiguracionRed.Click += new System.EventHandler(this.btnConfiguracionRed_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(145, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Rata de aprendizaje";
            // 
            // btnPesosAleatorio
            // 
            this.btnPesosAleatorio.Enabled = false;
            this.btnPesosAleatorio.Location = new System.Drawing.Point(192, 455);
            this.btnPesosAleatorio.Name = "btnPesosAleatorio";
            this.btnPesosAleatorio.Size = new System.Drawing.Size(147, 23);
            this.btnPesosAleatorio.TabIndex = 19;
            this.btnPesosAleatorio.Text = "Generar";
            this.btnPesosAleatorio.UseVisualStyleBackColor = true;
            this.btnPesosAleatorio.Click += new System.EventHandler(this.btnPesosAleatorio_Click);
            // 
            // dgvPesos
            // 
            this.dgvPesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesos.Location = new System.Drawing.Point(45, 481);
            this.dgvPesos.Name = "dgvPesos";
            this.dgvPesos.Size = new System.Drawing.Size(333, 150);
            this.dgvPesos.TabIndex = 20;
            this.dgvPesos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 460);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Pesos de forma aleatoria";
            // 
            // btnEntrenar
            // 
            this.btnEntrenar.Enabled = false;
            this.btnEntrenar.Location = new System.Drawing.Point(411, 18);
            this.btnEntrenar.Name = "btnEntrenar";
            this.btnEntrenar.Size = new System.Drawing.Size(159, 23);
            this.btnEntrenar.TabIndex = 22;
            this.btnEntrenar.Text = " Entrenar la red";
            this.btnEntrenar.UseVisualStyleBackColor = true;
            this.btnEntrenar.Click += new System.EventHandler(this.btnEntrenar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.btnEntrenarRedNuevo);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.dgvVecinas);
            this.panel2.Controls.Add(this.txtDv);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.dgvDistanciaNeurona);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtIteracion);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.txtDt);
            this.panel2.Controls.Add(this.txtCantidadDm);
            this.panel2.Controls.Add(this.txtCantidadVecinas);
            this.panel2.Location = new System.Drawing.Point(411, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(359, 392);
            this.panel2.TabIndex = 26;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(175, 128);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(24, 13);
            this.label19.TabIndex = 41;
            this.label19.Text = "DM";
            // 
            // btnEntrenarRedNuevo
            // 
            this.btnEntrenarRedNuevo.Location = new System.Drawing.Point(113, 336);
            this.btnEntrenarRedNuevo.Name = "btnEntrenarRedNuevo";
            this.btnEntrenarRedNuevo.Size = new System.Drawing.Size(159, 23);
            this.btnEntrenarRedNuevo.TabIndex = 36;
            this.btnEntrenarRedNuevo.Text = "Entrenar de nuevo";
            this.btnEntrenarRedNuevo.UseVisualStyleBackColor = true;
            this.btnEntrenarRedNuevo.Click += new System.EventHandler(this.btnEntrenarRedNuevo_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 235);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "Vecinas";
            // 
            // dgvVecinas
            // 
            this.dgvVecinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVecinas.Location = new System.Drawing.Point(3, 251);
            this.dgvVecinas.Name = "dgvVecinas";
            this.dgvVecinas.Size = new System.Drawing.Size(271, 55);
            this.dgvVecinas.TabIndex = 38;
            // 
            // txtDv
            // 
            this.txtDv.Enabled = false;
            this.txtDv.Location = new System.Drawing.Point(178, 43);
            this.txtDv.Name = "txtDv";
            this.txtDv.Size = new System.Drawing.Size(96, 20);
            this.txtDv.TabIndex = 36;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(175, 27);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(22, 13);
            this.label18.TabIndex = 37;
            this.label18.Text = "DV";
            // 
            // dgvDistanciaNeurona
            // 
            this.dgvDistanciaNeurona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDistanciaNeurona.Location = new System.Drawing.Point(3, 30);
            this.dgvDistanciaNeurona.Name = "dgvDistanciaNeurona";
            this.dgvDistanciaNeurona.Size = new System.Drawing.Size(141, 183);
            this.dgvDistanciaNeurona.TabIndex = 27;
            this.dgvDistanciaNeurona.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDistanciaNeurona_CellContentClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Distancia euclidiana";
            // 
            // txtIteracion
            // 
            this.txtIteracion.Location = new System.Drawing.Point(178, 193);
            this.txtIteracion.Name = "txtIteracion";
            this.txtIteracion.Size = new System.Drawing.Size(96, 20);
            this.txtIteracion.TabIndex = 32;
            this.txtIteracion.TextChanged += new System.EventHandler(this.txtIteracion_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 313);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Cantidad de vecinas";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(175, 177);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "Iteracion";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(175, 79);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(22, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "DT";
            // 
            // txtDt
            // 
            this.txtDt.Enabled = false;
            this.txtDt.Location = new System.Drawing.Point(178, 95);
            this.txtDt.Name = "txtDt";
            this.txtDt.Size = new System.Drawing.Size(96, 20);
            this.txtDt.TabIndex = 30;
            // 
            // txtCantidadDm
            // 
            this.txtCantidadDm.Enabled = false;
            this.txtCantidadDm.Location = new System.Drawing.Point(178, 144);
            this.txtCantidadDm.Name = "txtCantidadDm";
            this.txtCantidadDm.Size = new System.Drawing.Size(98, 20);
            this.txtCantidadDm.TabIndex = 29;
            this.txtCantidadDm.TextChanged += new System.EventHandler(this.txtCantidadDm_TextChanged);
            // 
            // txtCantidadVecinas
            // 
            this.txtCantidadVecinas.Enabled = false;
            this.txtCantidadVecinas.Location = new System.Drawing.Point(113, 310);
            this.txtCantidadVecinas.Name = "txtCantidadVecinas";
            this.txtCantidadVecinas.Size = new System.Drawing.Size(161, 20);
            this.txtCantidadVecinas.TabIndex = 20;
            // 
            // chart1
            // 
            this.chart1.BorderlineWidth = 10;
            chartArea3.BackColor = System.Drawing.Color.MediumBlue;
            chartArea3.BorderWidth = 10;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(411, 449);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.LabelBackColor = System.Drawing.Color.Black;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(359, 202);
            this.chart1.TabIndex = 27;
            this.chart1.Text = "chart1";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblPatrones);
            this.panel3.Controls.Add(this.label22);
            this.panel3.Controls.Add(this.lblNeuronas);
            this.panel3.Controls.Add(this.label23);
            this.panel3.Controls.Add(this.dgvPatronSimulacion);
            this.panel3.Controls.Add(this.txtDvSimulacion);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.dgvDistanciaSimulacion);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.btnSimulacion);
            this.panel3.Controls.Add(this.btnPatron);
            this.panel3.Controls.Add(this.dgvPesosCarga);
            this.panel3.Location = new System.Drawing.Point(776, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(364, 580);
            this.panel3.TabIndex = 28;
            // 
            // btnCagarPesos
            // 
            this.btnCagarPesos.Location = new System.Drawing.Point(880, 18);
            this.btnCagarPesos.Name = "btnCagarPesos";
            this.btnCagarPesos.Size = new System.Drawing.Size(213, 23);
            this.btnCagarPesos.TabIndex = 30;
            this.btnCagarPesos.Text = "Cargar";
            this.btnCagarPesos.UseVisualStyleBackColor = true;
            this.btnCagarPesos.Click += new System.EventHandler(this.btnCagarPesos_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(794, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Subir Pesos";
            // 
            // dgvPesosCarga
            // 
            this.dgvPesosCarga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesosCarga.Location = new System.Drawing.Point(21, 1);
            this.dgvPesosCarga.Name = "dgvPesosCarga";
            this.dgvPesosCarga.Size = new System.Drawing.Size(324, 150);
            this.dgvPesosCarga.TabIndex = 31;
            // 
            // btnPatron
            // 
            this.btnPatron.Location = new System.Drawing.Point(21, 184);
            this.btnPatron.Name = "btnPatron";
            this.btnPatron.Size = new System.Drawing.Size(324, 23);
            this.btnPatron.TabIndex = 31;
            this.btnPatron.Text = "Cargar patron";
            this.btnPatron.UseVisualStyleBackColor = true;
            this.btnPatron.Click += new System.EventHandler(this.btnPatron_Click);
            // 
            // btnSimulacion
            // 
            this.btnSimulacion.Location = new System.Drawing.Point(21, 300);
            this.btnSimulacion.Name = "btnSimulacion";
            this.btnSimulacion.Size = new System.Drawing.Size(324, 23);
            this.btnSimulacion.TabIndex = 43;
            this.btnSimulacion.Text = "Iniciar simulacion";
            this.btnSimulacion.UseVisualStyleBackColor = true;
            this.btnSimulacion.Click += new System.EventHandler(this.btnSimulacion_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 46);
            this.button1.TabIndex = 42;
            this.button1.Text = "Guardar Pesos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dgvDistanciaSimulacion
            // 
            this.dgvDistanciaSimulacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDistanciaSimulacion.Location = new System.Drawing.Point(21, 355);
            this.dgvDistanciaSimulacion.Name = "dgvDistanciaSimulacion";
            this.dgvDistanciaSimulacion.Size = new System.Drawing.Size(141, 183);
            this.dgvDistanciaSimulacion.TabIndex = 44;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 339);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(102, 13);
            this.label17.TabIndex = 44;
            this.label17.Text = "Distancia euclidiana";
            // 
            // txtDvSimulacion
            // 
            this.txtDvSimulacion.Enabled = false;
            this.txtDvSimulacion.Location = new System.Drawing.Point(190, 355);
            this.txtDvSimulacion.Name = "txtDvSimulacion";
            this.txtDvSimulacion.Size = new System.Drawing.Size(96, 20);
            this.txtDvSimulacion.TabIndex = 45;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(187, 339);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(22, 13);
            this.label20.TabIndex = 46;
            this.label20.Text = "DV";
            // 
            // dgvPatronSimulacion
            // 
            this.dgvPatronSimulacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatronSimulacion.Location = new System.Drawing.Point(21, 213);
            this.dgvPatronSimulacion.Name = "dgvPatronSimulacion";
            this.dgvPatronSimulacion.Size = new System.Drawing.Size(324, 55);
            this.dgvPatronSimulacion.TabIndex = 43;
            // 
            // lblNeuronas
            // 
            this.lblNeuronas.AutoSize = true;
            this.lblNeuronas.Location = new System.Drawing.Point(132, 164);
            this.lblNeuronas.Name = "lblNeuronas";
            this.lblNeuronas.Size = new System.Drawing.Size(13, 13);
            this.lblNeuronas.TabIndex = 50;
            this.lblNeuronas.Text = "_";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(18, 164);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(111, 13);
            this.label23.TabIndex = 48;
            this.label23.Text = "Numeros de neuronas";
            // 
            // lblPatrones
            // 
            this.lblPatrones.AutoSize = true;
            this.lblPatrones.Location = new System.Drawing.Point(132, 274);
            this.lblPatrones.Name = "lblPatrones";
            this.lblPatrones.Size = new System.Drawing.Size(13, 13);
            this.lblPatrones.TabIndex = 52;
            this.lblPatrones.Text = "_";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(18, 274);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(108, 13);
            this.label22.TabIndex = 51;
            this.label22.Text = "Numeros de patrones";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 663);
            this.Controls.Add(this.btnCagarPesos);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnEntrenar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvPesos);
            this.Controls.Add(this.btnPesosAleatorio);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtVecindad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbTipoCompetencia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNeuronaMapa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbPatrones);
            this.Controls.Add(this.lbEntradas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvEntradas);
            this.Controls.Add(this.btnSubirDatos);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVecinas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistanciaNeurona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesosCarga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistanciaSimulacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatronSimulacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubirDatos;
        private System.Windows.Forms.DataGridView dgvEntradas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbEntradas;
        private System.Windows.Forms.Label lbPatrones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNeuronaMapa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTipoCompetencia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVecindad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIteraciones;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPesosAleatorio;
        private System.Windows.Forms.DataGridView dgvPesos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnEntrenar;
        private System.Windows.Forms.Button btnConfiguracionRed;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDistanciaNeurona;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCantidadVecinas;
        private System.Windows.Forms.TextBox txtCantidadDm;
        private System.Windows.Forms.TextBox txtDt;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtIteracion;
        private System.Windows.Forms.TextBox txtRataAprendizaje;
        private System.Windows.Forms.TextBox txtDv;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvVecinas;
        private System.Windows.Forms.Button btnEntrenarRedNuevo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSimulacion;
        private System.Windows.Forms.Button btnPatron;
        private System.Windows.Forms.DataGridView dgvPesosCarga;
        private System.Windows.Forms.Button btnCagarPesos;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtDvSimulacion;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView dgvDistanciaSimulacion;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dgvPatronSimulacion;
        private System.Windows.Forms.Label lblNeuronas;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblPatrones;
        private System.Windows.Forms.Label label22;
    }
}

