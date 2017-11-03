using System;
using System.Collections.Generic;
using System.Diagnostics;
using ChIPseq.Models;
using ChIPseq.ViewModels;
using Xamarin.Forms;

namespace ChIPseq.Views
{
    public partial class SonicationView : ContentPage
    {
        SonicationViewModel viewModel;
        Experiment exp;

        public SonicationView() { InitializeComponent(); } // Used for previewing

        public SonicationView(Experiment exp)
        {
            InitializeComponent();
            viewModel = new SonicationViewModel();
            BindingContext = viewModel;
            this.exp = exp;
        }


        async void OnContinueClicked(object sender, EventArgs e)
        {
            if (viewModel.ValidateSonicationTime(SonicationTime.Text))
            {
                exp.Sonication = Convert.ToInt32(SonicationTime.Text);
                Debug.WriteLine($"Experiment Sonication Time: {exp.Sonication}");
                await Navigation.PushAsync(new IncubationView(exp));
            }
            else {
                // TODO Add alert display to correct the entry
            }
        }
    }
}
