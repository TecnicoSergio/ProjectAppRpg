using AppRpgEtec.ViewModels.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppRpgEtec.Views.Usuarios
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginView : ContentPage
    {
        UsuarioViewModel usuarioViewModel;
        public LoginView()
        {
            InitializeComponent();
            usuarioViewModel = new UsuarioViewModel();
            BindingContext = usuarioViewModel;
        }
    }
}