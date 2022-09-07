using FireSharp.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alquiler
{
    public partial class FormUtilidad : Form
    {
        public FormUtilidad()
        {
            InitializeComponent();
        }

        private void FormUtilidad_Load(object sender, EventArgs e)
        {

        }

        public void updateLista(string lista, string id, object objeto)
        {
            //Funcion utilizada para actualizar los datos de una lista de datos en firebase.
            try 
            {
                IFirebaseConfig ifc = new Connection().ifc;
                IFirebaseClient client = new FireSharp.FirebaseClient(ifc);

                var message = client.UpdateAsync(lista + "/" + id, objeto);
            }
            catch(Exception) {
                MessageBox.Show("Error al conectar a la base de datos!");
            }
        }

        public async Task<Dictionary<string, Alquilado>> getListaAlquileres()
        {
            //Funcion que retornara la lista de alquileres traida de Firebase en formato de diccionario.
            Dictionary<string, Alquilado> datos = null;
            try
            {
                IFirebaseConfig ifc = new Connection().ifc;
                IFirebaseClient client = new FireSharp.FirebaseClient(ifc);
                var data = await client.GetAsync(path: "listaAlquiler");
                await Task.Run(() => {
                    datos = data.ResultAs<Dictionary<string, Alquilado>>();
                });
            }
            catch
            {
                MessageBox.Show("Error al conectar a la base de datos!");
            }
            return datos;
        }

        public async Task<Dictionary<string, Herramienta>> getListaHerramientas()
        {
            //Funcion que retornara la lista de herramientas traida de Firebase en formato de diccionario.
            Dictionary<string, Herramienta> datos = null;
            try
            {
                IFirebaseConfig ifc = new Connection().ifc;
                IFirebaseClient client = new FireSharp.FirebaseClient(ifc);
                var data = await client.GetAsync(path: "listaHerramientas");
                //await utilizado para ejecutar la funcion Run de la clase Task.
                //Task.Run() lo utilizamos porque las funciones async necesita que el dato retornado sea de tipo task.
                await Task.Run(() => {
                    //Run() precisa de una funcion de callback, en este caso es una funcion de flecha.
                    datos = data.ResultAs<Dictionary<string, Herramienta>>();
                });
            }
            catch
            {
                MessageBox.Show("Error al conectar a la base de datos!");
            }
            return datos;
        }

        private void FormUtilidad_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormAcceso form = new FormAcceso();
            form.Show();
        }

        private void btnListarAlquiler_Click(object sender, EventArgs e)
        {
            mostrarListaAlquileres();
            ocultarAgregarHerramienta();
            ocultarCambioEstado();
            ocultarAgregarAlquiler();
        }

        public void mostrarListaAlquileres() {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            comboTipoLista.Visible = true;
            txtAnioLista.Visible = true;
            txtMesLista.Visible = true;
            btnGrid.Visible = true;
        }

        public void ocultarListaAlquileres() {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            comboTipoLista.Visible = false;
            txtAnioLista.Visible = false;
            txtMesLista.Visible = false;
            btnGrid.Visible = false;
            gridAlquileres.Visible = false;
        }

        public void mostrarAgregarHerramienta() {
            txtStock.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            comboTipo.Visible = true;
            comboEstado.Visible = true;
            txtMarca.Visible = true;
            btnAgregarH.Visible = true;
        }

        public void ocultarAgregarHerramienta()
        {
            txtStock.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            comboTipo.Visible = false;
            comboEstado.Visible = false;
            txtMarca.Visible = false;
            btnAgregarH.Visible = false;
        }

        public void mostrarCambioEstado() {
            txtCambioEstado.Visible = true;
            label8.Visible = true;
            btnFuncionEstado.Visible = true;
            label16.Visible = true;
            txtContratoEstado.Visible = true;
        }
        public void ocultarCambioEstado()
        {
            txtCambioEstado.Visible = false;
            label8.Visible = false;
            btnFuncionEstado.Visible = false;
            label16.Visible = false;
            txtContratoEstado.Visible = false;
        }

        public void mostrarAgregarAlquiler() { 
            btnFuncionAgregar.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            txtNombre.Visible = true;
            txtApellido.Visible = true;
            txtCedula.Visible = true;
            txtDiasAlquilado.Visible = true;
            dateTimeFecha.Visible = true;
            txtStockAlquiler.Visible = true;
            txtContrato.Visible = true;
            label15.Visible = true;
        }

        public void ocultarAgregarAlquiler()
        {
            txtContrato.Visible = false;
            btnFuncionAgregar.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            txtNombre.Visible = false;
            txtApellido.Visible = false;
            txtCedula.Visible = false;
            txtDiasAlquilado.Visible = false;
            dateTimeFecha.Visible = false;
            txtStockAlquiler.Visible = false;
            label15.Visible = false;
        }

        private void btnAgregarHerramienta_Click(object sender, EventArgs e)
        {
            ocultarListaAlquileres();
            mostrarAgregarHerramienta();
            ocultarCambioEstado();
            ocultarAgregarAlquiler();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            mostrarCambioEstado();
            ocultarListaAlquileres();
            ocultarAgregarHerramienta();
            ocultarAgregarAlquiler();
        }

        private void btnAgregarAlquiler_Click(object sender, EventArgs e)
        {
            mostrarAgregarAlquiler();
            ocultarAgregarHerramienta();
            ocultarCambioEstado();
            ocultarListaAlquileres();
        }

        private async void btnGrid_Click(object sender, EventArgs e)
        {
            //Funcion que agregara los datos a un dataGridView
            gridAlquileres.Rows.Clear();
            gridAlquileres.Visible = false;
            if (txtAnioLista.Text != String.Empty && comboTipoLista.Text != String.Empty && txtMesLista.Text != String.Empty) {
                //Usamos un try catch por si los datos ingresados en el anio y el mes son textos
                //que no se puedan pasar a entero.
                try {
                    int mes = Int32.Parse(txtMesLista.Text);
                    int anio = Int32.Parse(txtAnioLista.Text);

                    var listaAlquileres = await getListaAlquileres();
                    
                    //textInfo sera usado para poner en mayusculas la primera letra de una palabra
                    TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
                    if (listaAlquileres != null)
                    {
                        foreach (var alquiler in listaAlquileres)
                        {

                            if (alquiler.Value.fechaAlquiler.Month == mes && alquiler.Value.fechaAlquiler.Year == anio && alquiler.Value.herramienta.tipoHerramienta == (comboTipoLista.Text).ToLower())
                            {
                                //Agregando los datos al dataGridView, el estado de la herramienta es alquilado se asigna un true, de otro modo se asigna un false
                                if (alquiler.Value.herramienta.estado == false)
                                {
                                    gridAlquileres.Rows.Add(alquiler.Value.herramienta.nroStock, alquiler.Value.herramienta.tipoHerramienta, textInfo.ToTitleCase(alquiler.Value.herramienta.marca), alquiler.Value.fechaAlquiler.Day + "/" + alquiler.Value.fechaAlquiler.Month + "/" + alquiler.Value.fechaAlquiler.Year, textInfo.ToTitleCase(alquiler.Value.nombre) + " " + textInfo.ToTitleCase(alquiler.Value.apellido), alquiler.Value.cedula, alquiler.Value.diasAlquilado, "Devuelto");
                                }
                                else
                                {
                                    gridAlquileres.Rows.Add(alquiler.Value.herramienta.nroStock, alquiler.Value.herramienta.tipoHerramienta, textInfo.ToTitleCase(alquiler.Value.herramienta.marca), alquiler.Value.fechaAlquiler.Day + "/" + alquiler.Value.fechaAlquiler.Month + "/" + alquiler.Value.fechaAlquiler.Year, textInfo.ToTitleCase(alquiler.Value.nombre) + " " + textInfo.ToTitleCase(alquiler.Value.apellido), alquiler.Value.cedula, alquiler.Value.diasAlquilado, "Alquilado");
                                }

                            }
                        }
                        gridAlquileres.Visible = true;
                    }

                } catch(FormatException) {
                    //catch para verificar que en anio y mes se ingresen valores validos.
                    MessageBox.Show("Ingrese valores validos.");
                }
            }    
        }

        private async void btnAgregarH_Click(object sender, EventArgs e)
        {
            if (txtMarca.Text != String.Empty && txtStock.Text != String.Empty && comboTipo.Text != String.Empty && comboEstado.Text != String.Empty) {
                var datos = await getListaHerramientas();
                bool estado = false;
                if (comboEstado.Text == "Alquilado") {
                    estado = true;
                }
                bool existe = false;
                if (datos != null) 
                {
                    //Verificando que la herramienta no haya sido alquilada anteriormente.
                    foreach (var herr in datos)
                    {
                        if (herr.Value.nroStock == (txtStock.Text).ToLower())
                        {
                            existe = true;
                            MessageBox.Show("El numero de stock ya fue registrado");
                            break;
                        }
                    }
                
                }
                if (existe == false) {
                        Herramienta herramienta = new Herramienta((txtMarca.Text).ToLower(), (txtStock.Text).ToLower(), estado, (comboTipo.Text).ToLower());
                        FormAcceso form = new FormAcceso();
                        
                        //Si no esta en la lista de herramientas se registra.
                        form.setLista("listaHerramientas", herramienta, txtStock.Text);
                        MessageBox.Show("Herramienta agregada");
                    }
               
            }
        }

        private async void btnFuncionEstado_Click(object sender, EventArgs e)
        {
            //Funcion que cambia el estado de una herramienta, es decir que si esta alquilada
            //dejara de estarlo, y viceversa
            if (txtCambioEstado.Text != String.Empty && txtContratoEstado.Text != String.Empty) {
                var datosHerr = await getListaHerramientas();
                bool existe = false;

                foreach (var herr in datosHerr) 
                {
                    //Buscando la herramienta y validando que estuviera alquilada.
                    if (herr.Value.estado == true && (txtCambioEstado.Text).ToLower() == herr.Value.nroStock) 
                    {
                        existe = true;
                        Herramienta herramienta = new Herramienta(herr.Value.marca, herr.Value.nroStock, false, herr.Value.tipoHerramienta);
                        //Actualizando la listaHerramientas con los nuevos datos.
                        updateLista("listaHerramientas", herr.Value.nroStock, herramienta);
                        //Actualizando la lista alquiler con los nuevos datos.
                        updateLista("listaAlquiler", txtContratoEstado.Text + "/herramienta", herramienta);
                        MessageBox.Show("Alquiler terminado");
                    }
                }
                if (existe == false) {
                    MessageBox.Show("La herramienta no esta alquilada!");
                }
            }
        }

        private async void btnFuncionAgregar_Click(object sender, EventArgs e)
        {
            if (txtContrato.Text != String.Empty && txtNombre.Text != String.Empty && txtApellido.Text != String.Empty && txtCedula.Text != String.Empty && txtStockAlquiler.Text != String.Empty && txtDiasAlquilado.Text != String.Empty)
            {
                Herramienta herramienta = null;
                //Trayendo los datos de ambas listas
                var datosHerramientas = await getListaHerramientas();
                var datos = await getListaAlquileres();
                bool alquilado = false;
                bool res = false;

                if (datos != null) {
                    foreach (var i in datos)
                    {
                        //Verificando que el contrato no existiera antes
                        if (i.Value.nroContrato == (txtContrato.Text).ToLower())
                        {
                            res = true;
                            MessageBox.Show("El contrato ya fue registrado anteriormente!");
                        }
                    }
                }
                
                if (res == false) {
                    if (datosHerramientas != null)
                    {
                        foreach (var herr in datosHerramientas)
                        {
                            //Si esta alquilada entonces no puede volver a alquilarse
                            if (herr.Value.nroStock == (txtStockAlquiler.Text).ToLower() && herr.Value.estado == true)
                            {
                                alquilado = true;
                                MessageBox.Show("La herramienta esta actualemente alquilada!");
                                break;
                            }
                            //Si no esta alquilada puede alquilarse pero primero creamos el objeto
                            else if (herr.Value.nroStock == (txtStockAlquiler.Text).ToLower() && herr.Value.estado == false)
                            {
                                herramienta = new Herramienta(herr.Value.marca, herr.Value.nroStock, true, herr.Value.tipoHerramienta);
                                //Y actualizamos la listaHerramientas para que la herramienta quede como alquilada.
                                updateLista("listaHerramientas", herr.Value.nroStock, herramienta);
                            }
                        }
                        if (alquilado == false)
                        {
                            //Una vez creado el objeto herramienta, creamos el alquiler con la herramienta en el
                            int dias = Int32.Parse(txtDiasAlquilado.Text);
                            Alquilado alquiler = new Alquilado((txtContrato.Text).ToLower(), (txtNombre.Text).ToLower(), (txtApellido.Text).ToLower(), txtCedula.Text, herramienta, dateTimeFecha.Value, dias);
                            FormAcceso form = new FormAcceso();
                            //Agregamos la herramienta a la listaAlquiler de la base de datos.
                            form.setLista("listaAlquiler", alquiler, txtContrato.Text);
                            MessageBox.Show("Alquiler agregado a la lista!");                
                        }
                    }
                } 
            }
        }

        private void gridAlquileres_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
