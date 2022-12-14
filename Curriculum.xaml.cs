using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Xamarin.Essentials.Permissions;

namespace confe
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Curriculum : ContentPage
	{
		public Curriculum (string name, string ocupation, string birthday, string email, 
						string phone, string nacionalidad, string level, string perfil)
		{
			InitializeComponent ();
            F_nombre.Text = name;
            F_ocupacion.Text = ocupation;
            F_edad.Text = "|| " + birthday + " || " + name;
			F_email.Text = "E-mail: " + email;
			F_telefono.Text = "Telefono: " + phone;
			F_pais.Text = "Nacionalidad: " + nacionalidad;
			F_level.Text = "Ingles: " + level;
			F_perfil.Text = perfil;
        }

        private void btnregresar_Clicked(object sender, EventArgs e)
        {
			Navigation.PopAsync();
        }

        private async void btnenviar_Clicked(object sender, EventArgs e)
        {
			string texto = "Curriculum Vitae\n\n" +
				F_nombre.Text + "\n" +
				F_ocupacion.Text + "\n\n" +
				"Informacion de contacto\n\n" +
				F_email.Text + "\n" +
				F_telefono.Text + "\n" +
				F_pais.Text + "\n\n" +
				"Perfil profesional\n\n" +
				F_level.Text + "\n" +
				F_perfil.Text;

			var mensaje = new EmailMessage("Curriculum", texto, "makako1234@ucsp.edu.pe");
			mensaje.BodyFormat = EmailBodyFormat.PlainText;
			await Email.ComposeAsync(mensaje);
        }
    }
}