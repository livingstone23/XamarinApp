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
    public partial class Producto : ContentPage
    {

		//Propiedad estatica
		public static Producto instance;
		public EntityCLS oEntityCLS { get; set; }
		//public List<ProductoCLS> listaProducto { get; set; }
		public string nombreproducto { get; set; }
		
		private List<ProductoCLS> lista;

		public static Producto GetInstance()
		{
			if (instance == null)
			{
				return new Producto();

			}
			else return instance;
		}

		public List<ProductoCLS> listaProducto { get; set; }
		public Producto()
		{
			instance = this;

			InitializeComponent();
			oEntityCLS = new EntityCLS();
			oEntityCLS.listaProducto = new List<ProductoCLS>();

			//listaProducto = new List<ProductoCLS>();
			oEntityCLS.listaProducto.Add(new ProductoCLS { nombre = "Inka Kola", precio = 8.5, stock = 20, nombrecategoria = "Gaseosas" });
			oEntityCLS.listaProducto.Add(new ProductoCLS { nombre = "Coca Kola", precio = 7.3, stock = 11, nombrecategoria = "Gaseosas" });
			oEntityCLS.listaProducto.Add(new ProductoCLS { nombre = "Soda", precio = 1.3, stock = 35, nombrecategoria = "Galleta" });
			oEntityCLS.listaProducto.Add(new ProductoCLS { nombre = "Botella de Agua", precio = 1, stock = 8, nombrecategoria = "Gaseosas" });
			BindingContext = this;
			lista = oEntityCLS.listaProducto;
		}

        private void searchProducto_SearchButtonPressed(object sender, EventArgs e)
        {
			SearchBar obj = sender as SearchBar;
			string texto = obj.Text;
			if (texto != "")
				oEntityCLS.listaProducto = lista.Where(p => p.nombre.Contains(texto)).ToList();
			else
				oEntityCLS.listaProducto = lista;
		}

        private void toolbarAgregarProducto_Clicked(object sender, EventArgs e)
        {
			Navigation.PushAsync(new FormProducto(new ProductoCLS(), "Agregar Producto"));
		}

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
			ProductoCLS objProducto = (ProductoCLS)e.SelectedItem;
			Navigation.PushAsync(new FormProducto(objProducto, "Editar Producto"));
		}
    }
}