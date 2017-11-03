using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using ChIPseq.Models;
using ChIPseq.Services;

namespace ChIPseq.ViewModels
{
    public class ReviewViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Experiment> Experiments { get; set; }

        public ReviewViewModel()
        {
            // Bug fix: https://github.com/xamarin/Xamarin.Forms/pull/1244

            Experiments = new ObservableCollection<Experiment>();
            FirebaseService.Instance.GetExperiments((List<Experiment> experiments) =>
            {
                foreach (var exp in experiments)
                {
                    Experiments.Add(exp);
                }
            });
        }
    }
}
