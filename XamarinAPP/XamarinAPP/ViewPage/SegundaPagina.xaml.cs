using XamarinAPP.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinAPP.ViewPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SegundaPagina : ContentPage
    {
        //Propiedades
        public UsuarioCLS ousuarioCLS { get; set; } = new UsuarioCLS();
        public SegundaPagina()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private async void btnRegistrar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegistroUsuario());
        }

        private async void toolbarAgregar_Clicked(object sender, EventArgs e)
        {

            //Navega con flecha de atras
            await Navigation.PushAsync(new RegistroUsuario());
        }

        private void btnIngresar_Clicked(object sender, EventArgs e)
        {
            if (ousuarioCLS.nombreusuario == "q" && ousuarioCLS.contra == "q")
            {
                //Navega Sin flecha de atras
                Application.Current.MainPage = new PPrincipal();
            }
            else
            {
                DisplayAlert("Error", "Contraseña o usuario incorrecto", "Cancelar");
            }
        }

        private void btnAsignar_Clicked(object sender, EventArgs e)
        {
            ousuarioCLS.nombreusuario = "q";
            ousuarioCLS.contra = "q";
        }
    }
}