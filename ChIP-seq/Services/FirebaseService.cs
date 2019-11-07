using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ChIPseq.Models;
using Xamarin.Forms;

namespace ChIPseq.Services
{
    public interface IFirebaseDelegate
    {
        void Set(string path, int val);
        void Set(string path, bool val);
        void Set(string path, string val);

        void Get(string path, Action<int> handler);
        void Get(string path, Action<bool> handler);
        void Get(string path, Action<string> handler);

        void GetExperiments(Action<List<Experiment>> handler);
    }

    public class FirebaseService
    {
        IFirebaseDelegate firebaseDel;

        public static FirebaseService Instance = new FirebaseService(DependencyService.Get<IFirebaseDelegate>());

        FirebaseService(IFirebaseDelegate firebaseDel)
        {
            this.firebaseDel = firebaseDel;
        }

        public void AddExperiment(Experiment exp)
        {
            firebaseDel.Set("records/{exp.Name}/date", exp.Date.ToString(Experiment.DateFormat));
            firebaseDel.Set("records/{exp.Name}/sonicate_min", exp.Sonication);
            firebaseDel.Set("records/{exp.Name}/incubate_hr", exp.Incubation);
        }

        public void GetExperiments(Action<List<Experiment>> handler)
        {
            firebaseDel.GetExperiments(handler);
        }
    }
}