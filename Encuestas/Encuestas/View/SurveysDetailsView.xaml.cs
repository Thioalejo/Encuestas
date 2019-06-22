using Encuestas.Core.Model;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Encuestas.Core
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SurveysDetailsView : ContentPage
    {
        public SurveysDetailsView()
        {
            InitializeComponent();
        }

        private readonly string[] teams =
        {
            "Alianza Lima",
            "America",
            "Boca juniors",
            "Caracas FC",
            "Colo-colo",
            "Peñorol",
            "Real Madrid",
            "Saprissa"
        };

        private async void FavoriteTeamButton_Clicked(object sender, EventArgs e)
        {
            var favoriteTeam = await DisplayActionSheet(Literals.FavoriteTeamTitle, null, null, teams);
            if(!string.IsNullOrWhiteSpace(favoriteTeam))
            {
                FavoriteTeamLabel.Text = favoriteTeam;
            }
        }

        private async void OkButton_Clicked(object sender, EventArgs e)
        {
            //Evaluamos si los datos estan completos
            if(string.IsNullOrWhiteSpace(NameEntry.Text) || string.IsNullOrWhiteSpace(FavoriteTeamLabel.Text))
            {
                await DisplayAlert("Alerta", "No has llenado todos los datos", "OK");
                return;
            }

            //Creaos el nuevo obeto de tipo survey
            var newSurvey = new Model.Survery()
            {
                Name = NameEntry.Text,
                Birthdate = BirthdatePicker.Date,
                FavoriteTeam = FavoriteTeamLabel.Text
            };

            //publicamos el mensaje con el objeto de la encuesta como argumento

            MessagingCenter.Send((ContentPage)this, Messages.NewSurveyComplete, newSurvey);

            //Removemos la pagina de la pila de navegacion para regresar inmediatamente
            await Navigation.PopAsync();
        }
    }
}