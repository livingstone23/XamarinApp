using XamarinAPP.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinAPP.Clases;

namespace XamarinAPP.ViewPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Categoria : ContentPage
    {

		//Creamos propiedad estatica de clase
		public static Categoria instance;

		public EntityCLS oEntityCLS { get; set; }

		private List<CategoriaCLS> lista;
		//public List<CategoriaCLS> listaCategoria { get; set; }


		//Crear un Metodo que nos devuelva la instancia
		public static Categoria GetInstance()
		{
			if (instance == null)
			{
				return new Categoria();

			}
			else return instance;
		}

		public Categoria()
        {
			instance = this;

			InitializeComponent();
			oEntityCLS = new EntityCLS();
			oEntityCLS.listaCategoria = new List<CategoriaCLS>();
			oEntityCLS.listaCategoria.Add(new CategoriaCLS
			{
				iidcategoria = 1,
				nombre = "Gaseosa",
				descripcion = "Una bebida carbonatada, denominada gaseosa, refresco, fresco o soda," +
				" dependiendo del país," +
				" es una bebida saborizada, hecha con agua carbonatada, edulcorantes naturales " +
				"como fructosa o sacarosa, o sintéticos como el ciclamato"
			});
			oEntityCLS.listaCategoria.Add(new CategoriaCLS
			{
				iidcategoria = 2,
				nombre = "Galleta",
				descripcion = "La galleta es una preparación culinaria de pequeño tamaño, dulce o salada," +
				" horneada y hecha normalmente a base de harina de trigo, huevos, azúcar," +
				" mantequilla o aceites vegetales o grasas animales."
			});
			//Nos sirve para que el codigo XAML conozca el valor de la propiedad "listaCategoria" 
			lista = oEntityCLS.listaCategoria;
			BindingContext = this;


		}

        private void lstCategoria_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
			CategoriaCLS objCategoria = (CategoriaCLS)e.SelectedItem;
			Navigation.PushAsync(new FormCategorias(objCategoria, "Editar Categoria"));
		}

        private void toolbarAgregar_Clicked(object sender, EventArgs e)
        {
			Navigation.PushAsync(new FormCategorias(new CategoriaCLS(), "Agregar Categoria"));
		}

        private void menuEliminar_Clicked(object sender, EventArgs e)
        {
			MenuItem oMenuItem = sender as MenuItem;
			CategoriaCLS oCategoriaCLS = (CategoriaCLS)oMenuItem.BindingContext;
			oEntityCLS.listaCategoria = oEntityCLS.listaCategoria.Where(p => p.iidcategoria != oCategoriaCLS.iidcategoria).ToList();
			//DisplayAlert("Aviso", oCategoriaCLS.nombre, "Cancelar");
		}

        private void searchCategoria_TextChanged(object sender, TextChangedEventArgs e)
        {
			string valor = e.NewTextValue;
			if (valor == "") oEntityCLS.listaCategoria = lista;
			else oEntityCLS.listaCategoria = lista.Where(p => p.nombre.Contains(valor)).ToList();
			//DisplayAlert("Valor", valor, "Cancelar");
		}
	}
}