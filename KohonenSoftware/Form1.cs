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

        double ganadora = 9999999;
        double dt = 0, dm = 0, iteracion = 1, ra ;

        double[,] datosEntradasMatriz = new double[1000, 1000];
        double[,] datosPesosMatriz = new double[1000, 1000];
        List<double> datosEntradasList = new List<double>();
        List<double> lis_patrones = new List<double>();
        List<double> vencedoraList = new List<double>();
        List<double> Di = new List<double>();
        List<double> diPosicionList = new List<double>();
        List<double> dmList = new List<double>();

        int numeroEntrada, numeroNeurona, ganadoraPosicion;
        int stop1, stop2 = 0;
        public Form1()
        {
            InitializeComponent();
            txtRataAprendizaje.Text = "1";
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
           
            MostrarTablaPesos(dgvPesos, datosPesosMatriz);
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
                        dgvEntradas.ColumnCount = sLine.Split(caracter).Length;
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

                    

                   
                    /*
                    for (int i = 0; i < lis_patrones.Count; i++)
                    {
                        Console.WriteLine(lis_patrones[i]);
                    }*/

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
                    Console.WriteLine(i +" "+ j + " " +datosEntradasMatriz[i, j]);
                }
            }
        }
        //Validaciones
        public void validacionNumerosNeurona()
        {

            if (TxtVacio(txtNeuronaMapa, "Neurona Mapa") == true && TxtVacio(txtVecindad, "Vecindad") == true && TxtVacio(txtIteraciones, "Iteraciones") == true)
            {
                int numero = Convert.ToInt32(txtNeuronaMapa.Text),
                    numeroEntradasDobles = dgvEntradas.ColumnCount;
                   double cv = Convert.ToDouble(txtVecindad.Text);

                if (!EsPrimo(numero) || numeroEntradasDobles >= numero * 2)
                {
                    this.validacion = false;
                    MessageBox.Show("El numero de Neurona debe ser primo o el numero de Neurona debe ser el doble que el de la entrada :)");

                }

                else if (!ValidacionCv(cv))
                {
                    this.validacion = false;
                    MessageBox.Show("El numero de Neurona debe ser mayor que 0 y menor o igual que 1 :)");

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
                    // No es primo :(
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
            this.numeroNeurona = Convert.ToInt32(lbPatrones.Text);

            Random r = new Random();

            for (int i = 0; i < numeroNeurona; i++)
            {
                //Columnas 11
                for (int j = 0; j < numeroEntrada; j++)
                {
                    // Filas 10
                    datosPesosMatriz[i, j] = (Math.Round(r.NextDouble(), 2));

                }

            }

        }
        public void MostrarTablaPesos(DataGridView tabla, double[,] matriz)
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
        int sumaEntrada = 0;
        public void PorPatrones()
        {
            this.numeroEntrada = Convert.ToInt32(dgvEntradas.ColumnCount.ToString());
            this.numeroNeurona = Convert.ToInt32(lbPatrones.Text);
       
           
            if (stop1>stop2)
            {
                datosEntradasList.Clear();
                datosEntradasList = lis_patrones.GetRange(sumaEntrada, numeroEntrada);
                sumaEntrada = sumaEntrada + numeroEntrada;
                stop2++;
            }
            else
            {
                MessageBox.Show("Recorrio todos los patrones");
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
            this.numeroNeurona = Convert.ToInt32(lbPatrones.Text);
            Di.Clear();
            Console.WriteLine("Entradas: " + numeroEntrada);
            Console.WriteLine("Neurona: " + numeroNeurona);
            double SumDi2 = 0, SumDiTotal = 0, exponenciar=0, datosEntradas=0;
          
            for (int i = 0; i < numeroNeurona; i++)
            {
                
                for (int j = 0; j < numeroEntrada; j++)
                {
                    datosEntradas = Convert.ToDouble(datosEntradasList[j]);
                    SumDi2 = datosEntradas - (datosPesosMatriz[i, j]);

                    exponenciar = Math.Pow((SumDi2), 2);
                    SumDiTotal = Math.Round(Math.Sqrt(exponenciar), 4);
                    Di.Add(SumDiTotal);
                }

                
               
            }

            MostrarEntrenar(Di, dgvDistanciaNeurona);
            Ra();
            Ganadora();
            txtDv.Text = Convert.ToString(ganadora);
            if (ValidarComboCompetencia() == true)
            {
              
                DtCalculo();
                txtDt.Text = Convert.ToString(dt);
                Vecinas(vencedoraList);
                MostrarColumna(vencedoraList, dgvVecinas);
                txtCantidadVecinas.Text = dgvVecinas.ColumnCount.ToString();
              

            }
            else if(ValidarComboCompetencia() == false)
            {
                Ganadora();
                NuevoPesos(datosPesosMatriz, ra);
            }

            DtCalculo();
            txtIteracion.Text = Convert.ToString(iteracion);
            DmCalculo(dmList);


            /*   for (int i = 0; i < dmList.Count; i++)
            {
                Console.WriteLine(">>>" + dmList[i]);
            }*/

        }

        public void Ganadora()
        {

            for (int i = 0; i < Di.Count; i++)
            {
                if (Di[i] < ganadora)
                {
                    ganadoraPosicion = i;
                    ganadora = Di[i];

                }
            }
           // Console.WriteLine("GANADORA POSICION: " + ganadoraPosicion);
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

        public void DtCalculo()
        {
            dt = 0;
            dt = ganadora + Convert.ToDouble(txtVecindad.Text.ToString());
        }

        public void Vecinas(List<double> dil)
        {
            dil.Clear();
            diPosicionList.Clear();
            for (int i = 0; i < Di.Count; i++)
            {
                if (Di[i] < dt)
                {
                    diPosicionList.Add(i);
                    dil.Add(Di[i]);
                    //Console.WriteLine("Di: " + i);
                }

            }

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
                    LlenarEntrenar();
                    NuevoPesos(datosPesosMatriz, ra);
                    DmCalculo(dmList);
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
            if (dm < 0.01)
            {
                return true;
            }
            return false;
        }

        //Fin Validar EntrenarRedNuevo

        public void DmCalculo(List<double> dmList)
        {

            dmList.Clear();
            int numeroPatrones = Convert.ToInt32(lbPatrones.Text);

            dm = dm + ((ganadora) / numeroPatrones);

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
            this.numeroNeurona = Convert.ToInt32(lbPatrones.Text);

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
                nuevoPesos = 0;
                for (int i = 0; i < diPosicionList.Count; i++)
                {
                    neuronaMomento = (int)diPosicionList[i];
                    for (int j = 0; j < numeroEntrada; j++)
                    {
                        nuevoPesos = antiguoPesos[j, neuronaMomento] + ra * Di[neuronaMomento];
                        antiguoPesos[j, neuronaMomento] = Math.Round(nuevoPesos, 2);
                    }
                }

                MostrarTablaPesos(dgvPesos, antiguoPesos);
            }

            iteracion++;
            txtIteracion.Text = Convert.ToString(iteracion);
        }



    }
}



