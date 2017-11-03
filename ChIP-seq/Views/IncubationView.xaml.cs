using System;
using System.Collections.Generic;
using System.Diagnostics;
using ChIPseq.ViewModels;
using ChIPseq.Models;
using Xamarin.Forms;
using ChIPseq.Services;

namespace ChIPseq.Views
{
    public partial class IncubationView : ContentPage
    {
        IncubationViewModel viewModel;
        Experiment exp;

        public IncubationView() { InitializeComponent(); }

        public IncubationView(Experiment exp)
        {
            InitializeComponent();
            viewModel = new IncubationViewModel();
            BindingContext = viewModel;
            this.exp = exp;
        }


        async void OnContinueClicked(object sender, EventArgs e)
        {
            if (viewModel.ValidateIncubationTime(IncubationTime.Text))
            {
                exp.Incubation = Convert.ToInt32(IncubationTime.Text);
                Debug.WriteLine($"Experiment Incubation Time: {exp.Incubation}");
                FirebaseService.Instance.AddExperiment(exp);
                await Navigation.PopToRootAsync();
            }
            else {
                // TODO Add alert display to correct the entry
            }
        }
    }
}
