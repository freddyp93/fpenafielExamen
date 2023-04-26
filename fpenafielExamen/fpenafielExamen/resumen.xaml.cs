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
    public partial class resumen : ContentPage
    {
        public resumen(String cliente, double total)
        {
            InitializeComponent();

            //muestro los resultados de la pantalla registro
            lblNomb_cliente.Text = cliente;
            lblTotal.Text = Convert.ToString(total);
        }
    }
}