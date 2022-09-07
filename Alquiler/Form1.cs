using FireSharp.Interfaces;
using FireSharp.Config;
using FireSharp.Response;
using Microsoft.VisualBasic.ApplicationServices;

namespace Alquiler
{
    public partial class FormAcceso : Form
    {
        public FormAcceso()
        {
            InitializeComponent();
        }


        public async Task<Dictionary<string, Usuario>> getListaUsuario()
        {
            Dictionary<string, Usuario> datosAdmin = null;
            try
            {
                IFirebaseConfig ifc = new Connection().ifc;
                IFirebaseClient client = new FireSharp.FirebaseClient(ifc);
                var data = await client.GetAsync(path: "listaAdmin");
                await Task.Run(() => {
                    datosAdmin = data.ResultAs<Dictionary<string, Usuario>>();
                });
            }
            catch 
            {
                MessageBox.Show("Error al conectar con la base de datos");
            }
            return datosAdmin;
        }

        public void setLista(string lista, object objeto, string id) {

            IFirebaseConfig ifc = new Connection().ifc;
            IFirebaseClient client = new FireSharp.FirebaseClient(ifc);

            var message = client.Set(path: lista+"/"+id, objeto);
        }

        private async void btnRegistrarse_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != String.Empty && txtPass.Text != String.Empty)
            {
                Usuario user = new Usuario(txtUser.Text, txtPass.Text);
                bool usuario = false;
                var datosAdmin = await getListaUsuario();

                if (datosAdmin != null)
                {
                    //Validando que no este registrado
                    foreach (var i in datosAdmin)
                    {
                        if (i.Value.usuario == user.usuario)
                        {
                            MessageBox.Show("Usuario no disponible");
                            usuario = true;
                        }
                    }
                }
                if (usuario == false)
                {
                    //Enviando datos del admin a la base de datos.
                    setLista("listaAdmin", user, txtUser.Text);
                    MessageBox.Show("Usuario registrado");
                    mostrarFormIngreso();
                }
            }
            else
            {
                MessageBox.Show("Llene los datos necesarios");
            }

        }

        public void mostrarFormRegistro() {
            btnIngresar.Visible = false;
            lblRegistro.Visible = false;
            btnRegistrarse.Visible = true;
            lblIngresar.Visible = true;
        }

        public void mostrarFormIngreso() {
            btnRegistrarse.Visible = false;
            lblIngresar.Visible = false;
            btnIngresar.Visible = true;
            lblRegistro.Visible = true;
        }

        private void lblIngresar_Click(object sender, EventArgs e)
        {
            mostrarFormIngreso();
        }

        private void lblRegistro_Click(object sender, EventArgs e)
        {
            mostrarFormRegistro();
        }

        private async void btnIngresar_Click(object sender, EventArgs e)
        {

            if (txtUser.Text != String.Empty && txtPass.Text != String.Empty)
            {
                Usuario user = new Usuario(txtUser.Text, txtPass.Text);
                bool usuario = false;
                var datosAdmin = await getListaUsuario();

                if (datosAdmin != null)
                {
                    //Verificando que los datos sean correctos.
                    foreach (var i in datosAdmin)
                    {
                        if (i.Value.usuario == user.usuario && i.Value.password == user.password)
                        {
                            MessageBox.Show("Ingreso exitoso!");
                            usuario = true;
                            FormUtilidad form = new FormUtilidad();
                            form.Show();
                            Hide();
                        }
                    }
                }
                if (usuario == false)
                {
                    MessageBox.Show("Usuario no registrado.");
                }
            }
            else {
                MessageBox.Show("Llene los datos necesarios");
            }
        }

        private void FormAcceso_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}