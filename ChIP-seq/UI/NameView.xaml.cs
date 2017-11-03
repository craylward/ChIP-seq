using System;
using System.Collections.Generic;
using System.Diagnostics;
using ChIPseq.Data;
using Xamarin.Forms;

namespace ChIPseq.UI
{
    public partial class NameView : ContentPage
    {
        NameViewModel viewModel;
        Experiment exp;

        public NameView() { InitializeComponent(); }

        public NameView(Experiment exp)
        {
            InitializeComponent();
            viewModel = new NameViewModel();
            this.exp = exp;
        }

        async void OnContinueClicked(object sender, EventArgs e)
        {
            if (viewModel.ValidateName(ExperimentName.Text))
            {
                exp.Name = ExperimentName.Text;
                Debug.WriteLine($"Experiment Name: {exp.Name}");
                await Navigation.PushAsync(new SonicationView(exp));
            }
            else
            {
                // TODO Add alert display to correct the entry
            }
        }
    }
}
