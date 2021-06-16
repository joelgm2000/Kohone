using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KohonenSoftware
{
    public partial class Form1 : Form
    {
        OpenFileDialog buscarDialog = new OpenFileDialog();
        public string archivo = "";
        bool validacion = true;
        double ganadora = 9999999999999999999, SumGanadora = 0;
        double dt = 0, dm = 0, iteracion = 1, ra = 1, total = 0, total2 = 0, numFilaPO, numColmPO;

        double[,] datosEntradasMatriz = new double[1000, 1000];
        double[,] datosPesosMatriz = new double[1000, 1000];
        List<double> datosEntradasList = new List<double>();
        List<double> lis_patrones = new List<double>();
        List<double> vencedoraList = new List<double>();
        List<double> Di = new List<double>();
        List<double> diPosicionList = new List<double>();
        List<double> dmList = new List<double>();
        List<double> dtList = new List<double>();
        List<double> ganadoraList = new List<double>();
        List<string> listPatronesOptimos = new List<string>();
        List<double> pesosSimulacion = new List<double>();
        List<double> listaPatronesSimulacion = new List<double>();
        int numeroEntrada, numeroNeurona, ganadoraPosicion;
        int stop1, stop2 = 0, c;
        double[,] matrizPesosOptimos;
        string[] obtenerPesosO;
 

        public Form1()
        {
            InitializeComponent();
            txtRataAprendizaje.Text = "1";
            txtVecindad.Text = "0";
            txtVecindad.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubirImagen_Click(object sender, EventArgs e)
        {
            dgvEntradas.Rows.Clear();
            dgvEntradas.AllowUserToAddRows = false;
            cargarArchivo();
            lbEntradas.Text = dgvEntradas.ColumnCount.ToString();
            lbPatrones.Text = dgvEntradas.Rows.Count.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnConfiguracionRed_Click(object sender, EventArgs e)
        {
            this.numeroNeurona = Convert.ToInt32(lbPatrones.Text);
            stop1 = numeroNeurona;

            validacionNumerosNeurona();
            if (validacion)
            {
                btnPesosAleatorio.Enabled = true;
                btnEntrenar.Enabled = true;
            }
            else
            {
                btnPesosAleatorio.Enabled = false;
                btnEntrenar.Enabled = false;
            }
        }

        private void dgvEntradas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void txtVecindad_TextChanged(object sender, EventArgs e)
        {

        }

        private void neuronaMapa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPesosAleatorio_Click(object sender, EventArgs e)
        {
            llenarTablaPesos();

            MostrarTablaPesosP(dgvPesos, datosPesosMatriz);
            btnEntrenar.Enabled = true;
        }

        private void btnEntrenar_Click(object sender, EventArgs e)
        {
            //PasarDeDGVaList(archivo);

            //matrizPasarDeDGVaList(); 

            PorPatrones();

            LlenarEntrenar();

            btnEntrenar.Enabled = false;

        }

        private void dgvDistanciaNeurona_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Archivos
        public void leerArchivo(DataGridView tabla, char caracter, string ruta)
        {
            string sLine = "";
            int fila = 0;

            StreamReader objReader = new StreamReader(ruta);

            do
            {
                sLine = objReader.ReadLine();

                if ((sLine != null))
                {
                    if (fila == 0)
                    {
                        tabla.ColumnCount = sLine.Split(caracter).Length;
                        nombrarTitulo(tabla, sLine.Split(caracter));
                        fila += 1;
                    }
                    else
                    {
                        agregarFilaDatagridView(tabla, sLine, caracter, fila);
                        fila += 1;

                    }

                }
            } while (!(sLine == null));



            objReader.Close();
        }

        public void nombrarTitulo(DataGridView tabla, string[] titulos)
        {
            int x = 0;
            for (x = 0; x <= tabla.ColumnCount - 1; x++)
            {
                tabla.Columns[x].HeaderText = titulos[x];
            }
        }

        public void agregarFilaDatagridView(DataGridView tabla, string linea, char caracter, int fila)
        {
            string[] arreglo = linea.Split(caracter);

            tabla.Rows.Add(arreglo);
        }

        public void cargarArchivo()
        {
            try
            {
                this.buscarDialog.ShowDialog();

                if (!string.IsNullOrEmpty(this.buscarDialog.FileName))
                {
                    archivo = this.buscarDialog.FileName;
                    PasarDeDGVaList(archivo);
                    leerArchivo(dgvEntradas, ';', archivo);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        public void PasarDeDGVaList(String fileName)
        {
            int bandera = 0;
            lis_patrones.Clear();
            TextReader reader = new StreamReader(File.OpenRead(fileName));
            string fila;


            while ((fila = reader.ReadLine()) != null)
            {
                if (bandera == 0)
                {
                    bandera = 1;
                }
                else
                {

                    foreach (var item in fila.Split(';'))
                    {

                        lis_patrones.Add(Convert.ToDouble(item.ToString()));

                    }



                }
            }

        }
        public void matrizPasarDeDGVaList()
        {
            this.numeroEntrada = Convert.ToInt32(dgvEntradas.ColumnCount.ToString());
            this.numeroNeurona = Convert.ToInt32(lbPatrones.Text);

            for (int i = 0; i < numeroNeurona; i++)
            {
                for (int j = 0; j < numeroEntrada; j++)
                {
                    datosEntradasMatriz[i, j] = lis_patrones[j];
                    Console.WriteLine(i + " " + j + " " + datosEntradasMatriz[i, j]);
                }
            }
        }
        //Validaciones
        public void validacionNumerosNeurona()
        {
            this.validacion = true;
            if (TxtVacio(txtNeuronaMapa, "Neurona Mapa") == true && TxtVacio(txtVecindad, "Vecindad") == true && TxtVacio(txtIteraciones, "Iteraciones") == true)
            {
                int numero = Convert.ToInt32(txtNeuronaMapa.Text),
                    numeroEntradasDobles = Convert.ToInt32(dgvEntradas.ColumnCount);
                double cv = Convert.ToDouble(txtVecindad.Text);

                if (EsPrimo(numero) || numero < (numeroEntradasDobles * 2))
                {
                    this.validacion = false;
                    MessageBox.Show("El numero de Neurona NO debe ser primo o el numero de Neurona debe ser el doble que el de la entrada :)");

                }
                else if (ValidarComboCompetencia() == true)
                {
                    if (!ValidacionCv(cv))
                    {
                        this.validacion = false;
                        MessageBox.Show("El numero de Neurona debe ser mayor que 0 y menor o igual que 1 :)");

                    }
                }

                else
                {
                    this.validacion = true;
                }
            }

        }

        public Boolean EsPrimo(int numero)
        {
            for (int i = 2; i < numero; i++)
            {
                if ((numero % i) == 0)
                {
                    // No es primo 
                    return false;
                }
            }
            // Es primo :)
            return true;
        }

        public Boolean TxtVacio(TextBox txt, string nombreTxt)
        {
            if (txt.Text.Equals(""))
            {
                MessageBox.Show("El txt " + nombreTxt + " esta vacio.");
                return false;
            }

            return true;
        }

        public Boolean ValidacionPromedio(int numeroPromedio)
        {

            if (numeroPromedio <= 0 || numeroPromedio > 1)
            {
                return false;
            }
            return true;

        }

        public Boolean ValidacionCv(double cv)
        {


            if (cv <= 0 || cv > 1)
            {
                return false;
            }
            return true;

        }
        public Boolean ValidarComboCompetencia()
        {
            if (cmbTipoCompetencia.SelectedItem.Equals("Blanda"))
            {

                return true;
            }
            return false;
        }

        //Metodos

        public void llenarTablaPesos()
        {
            this.numeroEntrada = Convert.ToInt32(dgvEntradas.ColumnCount.ToString());
            c = Convert.ToInt32(txtNeuronaMapa.Text);

            Random r = new Random();

            for (int i = 0; i < c; i++)
            {

                for (int j = 0; j < numeroEntrada; j++)
                {
                    // Filas 10
                    datosPesosMatriz[j, i] = (Math.Round(r.NextDouble(), 2));

                }

            }

        }
        public void MostrarTablaPesosP(DataGridView tabla, double[,] matriz)
        {
            c = Convert.ToInt32(txtNeuronaMapa.Text);
            tabla.RowCount = c;
            tabla.ColumnCount = numeroEntrada;
            //MessageBox.Show(numeroEntrada + " , " + numeroNeurona);
            Console.WriteLine("Neurona MAP " + Convert.ToInt32(txtNeuronaMapa.Text));
            for (int i = 0; i < c; i++)
            {

                for (int j = 0; j < numeroEntrada; j++)
                {

                    tabla.Rows[i].Cells[j].Value = matriz[j, i].ToString();

                }
            }
        }
        /*  public void MostrarTablaPesos(DataGridView tabla, double[,] matriz)
          {
              tabla.RowCount = numeroNeurona;
              tabla.ColumnCount = numeroEntrada;
              //MessageBox.Show(numeroEntrada + " , " + numeroNeurona);
              for (int i = 0; i < numeroNeurona; i++)
              {

                  for (int j = 0; j < numeroEntrada; j++)
                  {

                      tabla.Rows[i].Cells[j].Value = matriz[i, j].ToString();

                  }
              }
          }
          */
        int sumaEntrada = 0;
        public void PorPatrones()
        {
            this.numeroEntrada = Convert.ToInt32(dgvEntradas.ColumnCount.ToString());
            this.numeroNeurona = Convert.ToInt32(lbPatrones.Text);


            if (stop1 > stop2)
            {
                datosEntradasList.Clear();
                datosEntradasList = lis_patrones.GetRange(sumaEntrada, numeroEntrada);
                sumaEntrada = sumaEntrada + numeroEntrada;
                stop2++;
            }
            else
            {
                iteracion++;
                Ra();
                txtIteracion.Text = Convert.ToString(ra);
                txtIteracion.Text = Convert.ToString(iteracion);
                stop2 = 0;
                sumaEntrada = 0;
            }


            //Console.WriteLine(sumaEntrada);

            for (int i = 0; i < datosEntradasList.Count; i++)
            {
                // Console.WriteLine("Lista " + i + ": " + datosEntradasList[i]);
            }

        }


        public void LlenarEntrenar()
        {
            this.numeroEntrada = Convert.ToInt32(dgvEntradas.ColumnCount.ToString());

            c = Convert.ToInt32(txtNeuronaMapa.Text);

            Console.WriteLine("Entradas: " + numeroEntrada);
            Console.WriteLine("Neurona Mapa: " + c);
            double SumDi2, SumDiTotal = 0, datosEntradas = 0;

            Di.Clear();

            for (int i = 0; i < c; i++)
            {
                total = 0; SumDiTotal=0;
                for (int j = 0; j < numeroEntrada; j++)
                {
                  
                    datosEntradas = Convert.ToDouble(datosEntradasList[j]);
                    SumDi2 = datosEntradas - (datosPesosMatriz[j, i]);
                    SumDiTotal += Math.Pow(SumDi2, 2);
                    
                }

                total = Math.Round(Math.Sqrt(SumDiTotal), 4);
               
                Console.WriteLine(total);
                Di.Add(total);

            }

            MostrarEntrenarC(Di, dgvDistanciaNeurona);

            Ganadora(Di, txtDv);

            if (ValidarComboCompetencia())
            {
                Console.WriteLine("Entro a True");
                DtCalculo(dtList);
                Vecinas(vencedoraList);
                txtCantidadVecinas.Text = dgvVecinas.ColumnCount.ToString();

            } else
            {
                NuevoPesos(datosPesosMatriz, ra);
            }


            txtIteracion.Text = Convert.ToString(iteracion);
            DmCalculo(dmList);
            Graficar();


        }


        public void Ganadora(List<Double> Dis, TextBox txt)
        {

            ganadora = Dis[0];
            ganadoraPosicion = 0;
            for (int i = 0; i < Dis.Count; i++)
            {

                if (Dis[i] < ganadora)
                {

                    ganadoraPosicion = i;
                    ganadora = Dis[i];

                }

            }
            SumGanadora += ganadora;

            txt.Text = Convert.ToString(ganadora);
            Console.WriteLine("GANADORA POSICION: " + SumGanadora);
        }

        public void MostrarEntrenar(List<double> Dil, DataGridView dgv)
        {

            dgv.RowCount = numeroNeurona;

            //MessageBox.Show(numeroEntrada + " , " + numeroNeurona);


            for (int j = 0; j < numeroNeurona; j++)
            {

                dgv.Rows[j].Cells[0].Value = Dil[j];

            }

        }

        public void MostrarEntrenarC(List<double> Dil, DataGridView dgv)
        {

            dgv.RowCount = c;

            //MessageBox.Show(numeroEntrada + " , " + numeroNeurona);


            for (int j = 0; j < c; j++)
            {

                dgv.Rows[j].Cells[0].Value = Dil[j];

            }

        }
        public void DtCalculo(List<double> dtLists)
        {
            dtLists.Clear();
            dt = 0;
            dt = Convert.ToDouble(txtDv.Text) + Convert.ToDouble(txtVecindad.Text);

            dtLists.Add(dt);

            txtDt.Text = Convert.ToString(dt);
        }

        public void Vecinas(List<double> dil)
        {
            dil.Clear();
            
            for (int i = 0; i < Di.Count; i++)
            {
                if (Di[i] < dt)
                {
                    diPosicionList.Add(i);
                    dil.Add(Di[i]);

                }

            }
            MostrarColumna(dil, dgvVecinas);
        }

        public void MostrarColumna(List<double> Dil, DataGridView dgv)
        {

            dgv.ColumnCount = Dil.Count;

            for (int j = 0; j < Dil.Count; j++)
            {

                dgv.Rows[0].Cells[j].Value = Dil[j];

            }

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void txtCantidadDm_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void btnCagarPesos_Click(object sender, EventArgs e)
        {


            // abrir cuadro de dialogo


            dgvPesosCarga.AllowUserToAddRows = false;
            dgvPesosCarga.AutoGenerateColumns = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dgvPesosCarga.DataSource = this.cargarArchivoPesos(openFileDialog1.FileName);
            }


            this.LlenarMatrizPesosOptimos();
            lblNeuronas.Text = dgvPesosCarga.Rows.Count.ToString();
        }
        public object cargarArchivoPesos(string fileName)
        {
            DataTable datos = new DataTable();
            int countRow = 0;
            int countColumn = 0;
            numColmPO = 0;
            numFilaPO = 0;
            try
            {
                //leer el archivo
                FileInfo fileInfo = new FileInfo(fileName);
                StreamReader reader = new StreamReader(fileName, Encoding.UTF8);
                using (reader = fileInfo.OpenText())
                {
                    string line = string.Empty;
                    while ((line = reader.ReadLine()) != null)
                    {
                        numFilaPO++;
                        if (string.IsNullOrEmpty(line))
                        {
                            continue;
                        }
                        if (countRow == 0)
                        {
                            //Mostrar columnas
                            var getColumns = line.Split(';');
                            countColumn = getColumns.Length;
                            numColmPO = countColumn;
                            //MessageBox.Show(numColmPO.ToString());
                            int i = 0;
                            foreach (string item in getColumns)
                            {
                                datos.Columns.Add("W" + i);
                                i++;
                            }
                            countRow++;

                        }
                        //Mostrar filas
                        var getRow = line.Split(';');
                        listPatronesOptimos.Add(line);
                        if (string.IsNullOrEmpty(getRow[0].Split('\r')[0].Trim()))
                        {
                            continue;
                        }

                        DataRow drRow = datos.NewRow();
                        int colsCount = 0;
                        foreach (var item in getRow)
                        {
                            if (colsCount < countColumn)
                            {
                                drRow[colsCount] = item.Split('\r')[0].Trim();
                            }
                            colsCount++;
                        }
                        datos.Rows.Add(drRow);

                    }
                }
                return datos;
            }
            catch (Exception x)
            {

                throw new ApplicationException(x.Message, x);
            }

        }
        private void LlenarMatrizPesosOptimos()
        {
            matrizPesosOptimos = new double[(int)numFilaPO, (int)numColmPO];
            obtenerPesosO = new string[(int)numColmPO];
            for (int filas = 0; filas < numFilaPO; filas++)
            {
                obtenerPesosO = listPatronesOptimos[filas].Split(';');
                for (int col = 0; col < numColmPO; col++)
                {
                    matrizPesosOptimos[filas, col] = double.Parse(obtenerPesosO[col]);
                }
            }




            for (int filas = 0; filas < numFilaPO; filas++)
            {
                for (int col = 0; col < numColmPO; col++)
                {
                    Console.WriteLine(matrizPesosOptimos[filas, col]);
                }
            }
        }

        private void btnPatron_Click(object sender, EventArgs e)
        {
            dgvPatronSimulacion.AllowUserToAddRows = false;
            dgvPatronSimulacion.AutoGenerateColumns = true;
            cargarArchivoPatrones();
            lblPatrones.Text = dgvPatronSimulacion.ColumnCount.ToString();
        }
        public void cargarArchivoPatrones()
        {
            try
            {
                this.buscarDialog.ShowDialog();

                if (!string.IsNullOrEmpty(this.buscarDialog.FileName))
                {
                    archivo = this.buscarDialog.FileName;

                    leerArchivo(dgvPatronSimulacion, ';', archivo);
                    PasarDeDGVaListSimulacion(archivo, listaPatronesSimulacion);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        public void PasarDeDGVaListSimulacion(String fileName, List<double> lista)
        {

            lista.Clear();
            TextReader reader = new StreamReader(File.OpenRead(fileName));
            string fila;


            while ((fila = reader.ReadLine()) != null)
            {


                foreach (var item in fila.Split(';'))
                {

                    lista.Add(Convert.ToDouble(item.ToString()));

                }


            }
            for (int j = 0; j < lista.Count; j++)
            {
                Console.WriteLine("Lista Patrones " + lista[j]);
            }
        }

        private void txtVecindad_Click(object sender, EventArgs e)
        {

        }

        private void cmbTipoCompetencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ValidarComboCompetencia() == true)
            {
                txtVecindad.Enabled = true;
            }
            else
            {
                txtVecindad.Enabled = false;
            }
        }

        private void btnSimulacion_Click(object sender, EventArgs e)
        {
            double neurona = Convert.ToDouble(lblNeuronas.Text);
            double patrones = Convert.ToDouble(lblPatrones.Text);

            List<double> dils = new List<double>();


            double SumDi2, SumDiTotal = 0, datosEntradas = 0;

            dils.Clear();


            for (int i = 0; i < neurona; i++)
            {
                SumDiTotal = 0;
                for (int j = 0; j < patrones; j++)
                {
                    datosEntradas = Convert.ToDouble(listaPatronesSimulacion[j]);
                    SumDi2 = datosEntradas - (matrizPesosOptimos[i, j]);
                    SumDiTotal += Math.Pow((SumDi2), 2);

                }

                total2 = Math.Round(Math.Sqrt(SumDiTotal), 4);
                Console.WriteLine(total2);
                dils.Add(total2);

            }

            dgvDistanciaSimulacion.RowCount = Convert.ToInt32(neurona);

            //MessageBox.Show(numeroEntrada + " , " + numeroNeurona);


            for (int j = 0; j < neurona; j++)
            {

                dgvDistanciaSimulacion.Rows[j].Cells[0].Value = dils[j];

            }


            Ganadora(dils, txtDvSimulacion);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GuardarPesos();
        }

        public void GuardarPesos()
        {
            List<string> listPesosGanadores = new List<string>();
            this.numeroEntrada = Convert.ToInt32(dgvEntradas.ColumnCount.ToString());
            int posicionBorrarJ=0, posicionBorrarI = 0;

            c = Convert.ToInt32(txtNeuronaMapa.Text);

            //MessageBox.Show(txtNeuronaMapa.Text);

            for (int i = 0; i < c; i++)
            {
                string variable = "";

                for (int j = 0; j < numeroEntrada; j++)
                {
                    variable = variable + datosPesosMatriz[j, i].ToString() + ";";
                }
                //  Console.WriteLine(variable);
                listPesosGanadores.Add(variable);

            }

            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(saveFileDialog1.FileName))
                    {
                        string txt = saveFileDialog1.FileName;

                        StreamWriter textoaguardar = File.CreateText(txt);

                        for (int i = 0; i < c; i++)
                        {
                            posicionBorrarI = 0; posicionBorrarJ = 0;

                            for (int j = 0; j < numeroEntrada; j++)
                            {
                                posicionBorrarI = i;
                                posicionBorrarJ = j;
                               
                                textoaguardar.Write(datosPesosMatriz[j, i].ToString() + ";");

                            }
                            textoaguardar.Write(datosPesosMatriz[posicionBorrarJ, posicionBorrarI].ToString());
                            textoaguardar.Write("\n");

                        }

                        textoaguardar.Flush();
                        textoaguardar.Close();

                    }
                    else
                    {
                        string txt = saveFileDialog1.FileName;

                        StreamWriter textoaguardar = File.CreateText(txt);

                        for (int i = 0; i < c; i++)
                        {
                            posicionBorrarI = 0; posicionBorrarJ = 0;

                            for (int j = 0; j < numeroEntrada; j++)
                            {
                                posicionBorrarI = i;
                                posicionBorrarJ = j;

                                textoaguardar.Write(datosPesosMatriz[j, i].ToString() + ";");

                            }
                            textoaguardar.Write(datosPesosMatriz[posicionBorrarJ, posicionBorrarI].ToString());
                            textoaguardar.Write("\n");

                        }

                        textoaguardar.Flush();
                        textoaguardar.Close();
                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show("No se guardo correctamente");
            }


        }


        private void txtIteracion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEntrenarRedNuevo_Click(object sender, EventArgs e)
        {
          
            if (validar1() == false)
            {
                if (validar4() == false)
                {
                    
                    PorPatrones();
                    NuevoPesos(datosPesosMatriz, ra);
                    LlenarEntrenar();
                     
                    
                
                }
                else
                {
                    MessageBox.Show("Ya llego al limite de Dm");
                }
            }
            else
            {
                MessageBox.Show("Ya llego al limite de iteraciones");
            }
            /*
            if (Sigue() == true)
            {
                MessageBox.Show("Las iteraciones termino y Dm no va disminuyendo");
                llenarTablaPesos();
                MostrarTablaPesos(dgvPesos, datosPesosMatriz);
                btnEntrenar.Enabled = true;
                stop2 = 0;
                ra = 0;
                ganadora = 0;
                Array.Clear(datosPesosMatriz, 0, datosPesosMatriz.Length);
                dmList.Clear();
                Di.Clear();
            }*/
        }

        public void Graficar()
        {
            double dmMomento = Convert.ToDouble(txtCantidadDm.Text);
            double iteracionMomento = Convert.ToDouble(txtIteracion.Text);

                chart1.Series["Series1"].Points.AddXY(iteracionMomento, dmMomento);
            
        }

        //Validar EntrenarRedNuevo

        public Boolean validar1()
        {

            if (iteracion == Convert.ToDouble(txtIteraciones.Text))
            {
                return true;

            }
            return false;
        }
        public Boolean validar4()
        {
            if (dm <= 0.001)
            {
                return true;
            }
            return false;
        }

          public Boolean Sigue()
        {
            if (iteracion == Convert.ToDouble(txtIteraciones.Text) && dm > 0.01)
            {
                return true;
            }
            return false;

        }
        //Fin Validar EntrenarRedNuevo

        public void DmCalculo(List<double> dmList)
        {

            int numeroPatrones = Convert.ToInt32(lbPatrones.Text);

            dm = (SumGanadora / numeroPatrones);

            dmList.Add(dm);

            txtCantidadDm.Text = Convert.ToString(dm);
        }

        public void Ra()
        {
            ra = 1 / iteracion;
        }

        public void NuevoPesos(double[,] antiguoPesos, double ra)
        {
            this.numeroEntrada = Convert.ToInt32(dgvEntradas.ColumnCount.ToString());
            

            double nuevoPesos = 0;
            int neuronaMomento = 0;
            //Array.Clear(antiguoPesos,0,antiguoPesos.Length);

            //Actualizar los pesos de las neuronas vencedoras
            for (int j = 0; j < numeroEntrada; j++)
            {
                nuevoPesos = antiguoPesos[j, ganadoraPosicion] + ra * Di[ganadoraPosicion];
                antiguoPesos[j, ganadoraPosicion] = Math.Round(nuevoPesos, 2);

            }

            //Actualizar si es blanda los pesos de las vecinas
            if (ValidarComboCompetencia() == true)
            {
                c = Convert.ToInt32(txtNeuronaMapa.Text);
                nuevoPesos = 0;
                for (int i = 0; i < c; i++)
                {
                   neuronaMomento = (int)diPosicionList[i];
                    
                    for (int j = 0; j < numeroEntrada; j++)
                    {
                        nuevoPesos = antiguoPesos[neuronaMomento, j] + ra * Di[ganadoraPosicion];
                        antiguoPesos[neuronaMomento, j] = Math.Round(nuevoPesos, 2);
                    }
                }

               
            }

           

            MostrarTablaPesosP(dgvPesos, antiguoPesos);
        }



    }
}



