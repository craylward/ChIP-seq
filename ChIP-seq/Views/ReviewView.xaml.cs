using System;
using System.Collections.Generic;
using ChIPseq.Models;
using ChIPseq.ViewModels;
using Xamarin.Forms;

namespace ChIPseq.Views
{
    public partial class ReviewView : ContentPage
    {
        ReviewViewModel viewModel;

        public ReviewView()
        {
            BindingContext = viewModel = new ReviewViewModel();
            InitializeComponent();
        }

        void OnExperimentSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (Experiment)e.SelectedItem;

            // now you can reference item.Name, item.Location, etc

            DisplayAlert("ItemSelected", item.Name, "Ok");
        }
    }
}
