using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
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
                var sortedExperiments = experiments.OrderByDescending(i => i.Date);
                foreach (var exp in sortedExperiments)
                {
                    Experiments.Add(exp);
                }
            });
        }
    }
}
