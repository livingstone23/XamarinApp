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
    public partial class Producto : ContentPage
    {
		public List<ProductoCLS> listaProducto { get; set; }
		public Producto()
		{
			InitializeComponent();
			listaProducto = new List<ProductoCLS>();
			listaProducto.Add(new ProductoCLS { nombre = "Inka Kola", precio = 8.5, stock = 20, nombrecategoria = "Gaseosas" });
			listaProducto.Add(new ProductoCLS { nombre = "Coca Kola", precio = 7.3, stock = 11, nombrecategoria = "Gaseosas" });
			listaProducto.Add(new ProductoCLS { nombre = "Soda", precio = 1.3, stock = 35, nombrecategoria = "Galleta" });
			listaProducto.Add(new ProductoCLS { nombre = "Galleta de Agua", precio = 1, stock = 8, nombrecategoria = "Gaseosas" });
			BindingContext = this;
		}
	}
}