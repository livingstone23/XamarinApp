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
    public partial class FormProducto : ContentPage
    {

        //Fuente de datos
        public string titulo { get; set; }
        public ProductoCLS oProductoCLS { get; set; }
        public List<string> listacategoria { get; set; }

        public FormProducto(ProductoCLS obj, string nombretitulo)
        {
            InitializeComponent();
            listacategoria = new List<string>();
            listacategoria.Add("Gaseosas");
            listacategoria.Add("Galleta");
            oProductoCLS = obj;
            titulo = nombretitulo;
            //oProductoCLS = new ProductoCLS();
            //oProductoCLS.nombrecategoria = "Galleta";
            BindingContext = this;
        }

        private void btnGuardarProducto_Clicked(object sender, EventArgs e)
        {
            Producto obj = Producto.GetInstance();
            List<ProductoCLS> l = obj.oEntityCLS.listaProducto.ToList();

            if (titulo == "Agregar Producto")
            {
                //Agregar
                l.Add(oProductoCLS);
                obj.oEntityCLS.listaProducto = l;

            }
            else
            {
                //Editar
                int indice = l.FindIndex(p => p.iidproducto == oProductoCLS.iidproducto);
                l[indice] = oProductoCLS;
                obj.oEntityCLS.listaProducto = l;

            }


            Navigation.PopAsync();
        }

        private void btnRegresarProducto_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}