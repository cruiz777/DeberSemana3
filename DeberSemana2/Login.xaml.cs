using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DeberSemana2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void Ingresar_Clicked(object sender, EventArgs e)
        {

            string usuario = txtusuario.Text;
            string clave=txtclave.Text;
            if (usuario == "estudiante2022" && clave== "uisrael2022")
            {
                await Navigation.PushAsync(new MainPage(usuario));
            }
            else
            {
                _ = DisplayAlert("Advertencia", "Usuario o Clave Incorrecta", "Ok");
            }

            
        }
    }
}