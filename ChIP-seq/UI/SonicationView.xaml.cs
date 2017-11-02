using System;
using System.Collections.Generic;
using ChIPseq.Data;
using Xamarin.Forms;

namespace ChIPseq.UI
{
    public partial class SonicationView : ContentPage
    {
        SonicationViewModel viewModel;
        Experiment exp;

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
                await Navigation.PushAsync(new IncubationView(exp));
            }
            else {
                // TODO Add alert display to correct the entry
            }
        }
    }
}
