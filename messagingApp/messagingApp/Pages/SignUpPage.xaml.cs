using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace messagingApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();
        }
        public void ShowPass(object sender, EventArgs args)
        {
            Password.IsPassword = Password.IsPassword ? false : true;
            if (Password.IsPassword == true)
            {
                show1.Text = "Show";
            }
            else
            {
                show1.Text = "Hide";
            }
        }
        public void ShowConfirm(object sender, EventArgs args)
        {
            Confirm.IsPassword = Confirm.IsPassword ? false : true;
            if (Confirm.IsPassword == true)
            {
                show2.Text = "Show";
            }
            else
            {
                show2.Text = "Hide";
            }
        }
        async void Create(object sender,EventArgs args)
        {
            if (Password.Text!=Confirm.Text&&!String.IsNullOrEmpty(Password.Text)&&!String.IsNullOrEmpty(Confirm.Text))
            {
                await DisplayAlert("", "Password does not match", "OK");
            }
            else if (String.IsNullOrEmpty(Name.Text) || String.IsNullOrEmpty(Email.Text))
            {
                await DisplayAlert("", "Fields incomplete", "OK");
            }
            else
            {
                await DisplayAlert("", "Account has been successfully created", "OK");
                await Navigation.PopToRootAsync();
            }
        }
        async void createSocial(Object sender, EventArgs args)
        {
            await DisplayAlert("", "Account has been successfully created", "OK");
            await Navigation.PopToRootAsync();
        }
    }
}