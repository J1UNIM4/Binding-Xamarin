using Ap_cV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Xamarin.Essentials.Permissions;

namespace App5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            var curriculo = new Curriculum()
            {
                Fname = Fname.Text,
                Lname = Lname.Text,
                phone = phone.Text,
                country = country.Text,

            };
            var Pag2 = new Page2();
            Pag2.BindingContext = curriculo;
            Navigation.PushAsync(Pag2);
        }
    }
}