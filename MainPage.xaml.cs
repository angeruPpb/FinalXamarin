using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace confe
{
    public partial class MainPage : ContentPage 
    {
        public MainPage()
        {
            InitializeComponent();

        }

        private void Btniniciar_Clicked(object sender, EventArgs e)
        {
            string name = Name.Text;
            string ocupation = Ocupacion.Text;
            string birthday = Birthday.Text;
            string email = Email.Text;
            string phone = Phone.Text;
            string nacionalidad = Nacionalidad.Text;
            string level = Level.Text;
            string perfil = Perfil.Text;
            Navigation.PushAsync(new Curriculum(name, ocupation, birthday, email, phone, 
                                                nacionalidad, level, perfil));
        }
    }
}
