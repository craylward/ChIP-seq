using System;
using System.Collections.Generic;
using ChIPseq.Data;
using Xamarin.Forms;

namespace ChIPseq.UI
{
    public partial class IncubationView : ContentPage
    {
        IncubationViewModel viewModel;
        Experiment exp;

        public IncubationView(Experiment exp)
        {
            InitializeComponent();
            viewModel = new IncubationViewModel();
            BindingContext = viewModel;
            this.exp = exp;
        }


        async void OnEnterClicked(object sender, EventArgs e)
        {
            if (viewModel.ValidateIncubationTime(IncubationTime.Text))
            {
                exp.Incubation = Convert.ToInt32(IncubationTime.Text);
                await Navigation.PushAsync(new ReviewView());
            }
            else {
                // TODO Add alert display to correct the entry
            }
        }
    }
}
