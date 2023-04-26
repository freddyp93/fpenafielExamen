using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace fpenafielExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class login : ContentPage
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Clicked(object sender, EventArgs e)
        {
            //Verifico los datos de login para pasar a otra pantalla

            //Declaro variables
            string usuario = txtusuario.Text;
            string clave = txtclave.Text;

            //Verificacion de Usuarios
            if(usuario == "estudiante2023" && clave == "uisrael2023")
            {
                //LLamo a la siguiente pantalla 
                Navigation.PushAsync(new registro(usuario)); //envio a la ventana registro la variable usuario
            }
            else
            {
                //muestro una alerta en el caso de usuario o contrasenia incorrecta
                DisplayAlert("ERROR", "DATOS INGRESADOS ERRONEOS", "Cerrar");

                //limpio los campos
                txtusuario.Text = "";
                txtclave.Text = "";
            }
        }
    }
}