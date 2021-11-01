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
    }
}