using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sample1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class about : ContentPage
    {
        public about()
        {
            InitializeComponent();
        }

        private void back_home_Clicked(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }
    }
}