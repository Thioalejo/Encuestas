using Encuestas.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Encuestas.Core.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonaView : ContentPage
    {
        public PersonaView()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var persona1 = (Persona)Resources["persona1"];
            persona1.Nombre = "Diego";
            persona1.Pais = "Colombia";
        }
    }
}