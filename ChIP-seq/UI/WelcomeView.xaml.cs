using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ChIPseq.UI
{
    public partial class WelcomeView : ContentPage
    {
        public WelcomeView()

        {
            InitializeComponent();
        }

        async void OnStartExperimentClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StartView());
        }

        async void OnReviewExperimentsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ReviewView());
        }
    }
}