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
    public partial class PPrincipal : MasterDetailPage
    {
        public PPrincipal()
        {
            InitializeComponent();
            //Propiedad vinculada al menu para navegar
            //Debe generarse tambien en el App.xaml.
            App.Navigate = Navigation;
            App.MenuApp = this;
        }
    }
}