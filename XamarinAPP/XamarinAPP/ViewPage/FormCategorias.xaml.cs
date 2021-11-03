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
    public partial class FormCategorias : ContentPage
    {
        public CategoriaCLS oCategoriaCLS { get; set; } = new CategoriaCLS();
        public string titulo { get; set; }
        public FormCategorias(CategoriaCLS obj, string nombretitulo)
        {
            InitializeComponent();
            oCategoriaCLS = obj;
            titulo = nombretitulo;
            BindingContext = this;
        }

        private void btnGuardarCategoria_Clicked(object sender, EventArgs e)
        {
            Categoria obj = Categoria.GetInstance();
            List<CategoriaCLS> l = obj.oEntityCLS.listaCategoria.ToList();

            if (titulo == "Agregar Categoria")
            {
                //Agregar
                l.Add(oCategoriaCLS);
                obj.oEntityCLS.listaCategoria = l;

            }
            else
            {
                //Editar
                int indice = l.FindIndex(p => p.iidcategoria == oCategoriaCLS.iidcategoria);
                l[indice] = oCategoriaCLS;
                obj.oEntityCLS.listaCategoria = l;

            }

            //Para retornar a la posterior pantalla.
            Navigation.PopAsync();
        }

        private void btnRegresarCategoria_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}