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
    public partial class Profile : TabbedPage
    {
        public Profile()
        {
            InitializeComponent();
        }
        async void signOut(Object sender, EventArgs args)
        {
            Application.Current.MainPage = new MainPage();
        }
    }
}