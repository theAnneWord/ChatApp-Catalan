using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace messagingApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
        private async void SignUpClick(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUpPage());
        }
        private async void SignInClick(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Email.Text) && !String.IsNullOrEmpty(Password.Text))
            {
                Application.Current.MainPage = new Profile();
                await Navigation.PopToRootAsync();
            }
            else
            {
                await DisplayAlert("", "Fields incomplete", "OK");
            }
        }
        private async void signInSocial(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Profile();
            await Navigation.PopToRootAsync();
        }
        public void ShowPassMain(object sender, EventArgs args)
        {
            Password.IsPassword = Password.IsPassword ? false : true;
            if (Password.IsPassword == true)
            {
                show.Text = "Show";
            }
            else
            {
                show.Text = "Hide";
            }
        }

    }
}
