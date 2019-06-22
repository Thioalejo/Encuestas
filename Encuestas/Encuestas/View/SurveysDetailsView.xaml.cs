using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        private void OkButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}