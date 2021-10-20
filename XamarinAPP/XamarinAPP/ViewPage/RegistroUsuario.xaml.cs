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
    public partial class RegistroUsuario : ContentPage
    {
        public RegistroUsuario()
        {
            InitializeComponent();
        }

        private async void btnVolverLogin_Clicked(object sender, EventArgs e)
        {
            //Como si se regresase a la pantalla anterior.
            await Navigation.PopAsync();
        }

        private void btnRegistrarUsuario_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Valores", "Nombre : " + txtnombre.Text + " Apellido paterno:" + txtapellidopaterno.Text +
                "Apellido materno : " + txtapellidomaterno.Text + " Telefono : " + txttelefono.Text +
                "Email " + txtemail.Text + " Fecha " + txtfechanacimiento.Date + " Descripcion " +
                txtdescripcion.Text + " Usuario: " + txtusuario.Text + " Contraseña: " + txtcontra.Text, "Cancelar");
        }
    }
}