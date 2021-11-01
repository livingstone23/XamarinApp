using MiPrimeraAplicacionEnXamarinForm.Clases;
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
    public partial class Categoria : ContentPage
    {
        public List<CategoriaCLS> listaCategoria { get; set; }
        public Categoria()
        {
            InitializeComponent();
			listaCategoria = new List<CategoriaCLS>();
			listaCategoria.Add(new CategoriaCLS
			{
				iidcategoria = 1,
				nombre = "Gaseosa",
				descripcion = "Una bebida carbonatada, denominada gaseosa, refresco, fresco o soda," +
				" dependiendo del país," +
				" es una bebida saborizada, hecha con agua carbonatada, edulcorantes naturales " +
				"como fructosa o sacarosa, o sintéticos como el ciclamato"
			});
			listaCategoria.Add(new CategoriaCLS
			{
				iidcategoria = 2,
				nombre = "Galleta",
				descripcion = "La galleta es una preparación culinaria de pequeño tamaño, dulce o salada," +
				" horneada y hecha normalmente a base de harina de trigo, huevos, azúcar," +
				" mantequilla o aceites vegetales o grasas animales."
			});
			//Nos sirve para que el codigo XAML conozca el valor de la propiedad "listaCategoria" 
			BindingContext = this;


		}

        private void lstCategoria_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
			CategoriaCLS objCategoria = (CategoriaCLS)e.SelectedItem;
			Navigation.PushAsync(new FormCategorias(objCategoria,"Detalle de Categoria"));
		}

        private void toolbarAgregar_Clicked(object sender, EventArgs e)
        {
			Navigation.PushAsync(new FormCategorias(new CategoriaCLS(), "Agregar Categoria"));
		}
    }
}