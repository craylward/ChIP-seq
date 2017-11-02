using System;
using System.Collections.Generic;
using ChIPseq.Data;
using Xamarin.Forms;

namespace ChIPseq.UI
{
    public partial class NameView : ContentPage
    {
        NameViewModel viewModel;
        Experiment exp;

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
                await Navigation.PushAsync(new SonicationView(exp));
            }
            else
            {
                // TODO Add alert display to correct the entry
            }
        }
    }
}
