using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinAPP
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaPrincipal : ContentPage
    {
        public PaginaPrincipal()
        {
            InitializeComponent();
        }

        private void btnVerMas_Clicked(object sender, EventArgs e)
        {
            string value = lblTexto.Text;

            //Alerta llamado larga
            //Application.Current.MainPage.DisplayAlert("Alerta", "Saludos", "Salir");

            //Alerta llamado corta
            //DisplayAlert("Alerta", $"Saludos de LCANO, {value}", "Salir");
            
            //1.Ocultar boton
            btnVermas.IsVisible = false;

            //2.Mostar todo el texto
            lblTexto.LineBreakMode = LineBreakMode.WordWrap;
        }
    }
}