using System;
using System.Diagnostics;
using System.Collections.Generic;
using ChIPseq.Models;
using Xamarin.Forms;

namespace ChIPseq.Views
{
    public partial class WelcomeView : ContentPage
    {
        public WelcomeView()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }

        async void OnStartExperimentClicked(object sender, EventArgs e)
        {
            Debug.WriteLine("Creating new experiment object");
            await Navigation.PushAsync(new NameView(new Experiment()));
        }

        async void OnReviewExperimentsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ReviewView());
        }
    }
}