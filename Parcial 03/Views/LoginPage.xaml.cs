using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Parcial_03.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        

             private void SignUp_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegisterPage());
        }

        private void Forgot_pass(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ForgotPass());
        }

        private void Ingresar(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Profile());
        }
    }
}