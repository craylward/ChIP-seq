using System;
using System.Diagnostics;
using System.Collections.Generic;
using ChIPseq.Data;
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
            Debug.WriteLine("Creating new experiment object");
            await Navigation.PushAsync(new NameView(new Experiment()));
        }

        async void OnReviewExperimentsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ReviewView());
        }
    }
}