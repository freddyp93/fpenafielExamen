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
    public partial class registro : ContentPage
    {
        public registro(String nombre)
        {
            InitializeComponent();

            //bienvenida + nombre del usuario traido del login
            lblSaludo.Text = "Bienvenido " + nombre;
        }


        private void btnLimpiar_Clicked(object sender, EventArgs e)
        {
            // Limpiar los campos de la pantalla

            txtNombre.Text = "";
            txtmontoin.Text = "";
            txtPago.Text = "";
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            // Calculo los pagos del curso

            //defino las variables
            double monto_inicial = Convert.ToDouble(txtmontoin.Text);

            //incremento del 5% del valor a las cuotas mensuales
            double incremento = 3000 * 0.05;
            
            //Control de excepciones
            try
            {
                //evaluo que se ingresen valores menores a 3000
                if(monto_inicial>=3000)
                {
                    DisplayAlert("ATENCION", "Debe ingresar valores menores a 3000", "Cerrar");
                    txtmontoin.Text = "";
                    txtPago.Text = ""; 
                }
                else
                {
                    //Proceso
                    double pago_mensual = ((3000 - monto_inicial) / 3) + incremento;

                    //muestro resultado
                    //
                    txtPago.Text = pago_mensual.ToString();
                }

            }
            catch(Exception ex)
            {
                DisplayAlert("ERROR", ex.Message, "cerrar");
            }
        }

        private void btnGuardar_Clicked_1(object sender, EventArgs e)
        {
            // guardo los datos para pasar a otra ventana
            //envio los parametros de monto inicial y pago mensual
            String nombre_alumno = txtNombre.Text;

            double inicial = Convert.ToDouble(txtmontoin.Text);
            double aumento = 3000 * 0.05;
            double pago_total = ((((3000 - inicial) / 3) + aumento) * 3)+inicial;

            Navigation.PushAsync(new resumen(nombre_alumno,pago_total));
        }
    }
}