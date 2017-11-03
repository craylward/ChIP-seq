using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ChIPseq.Models;
using Xamarin.Forms;

namespace ChIPseq.Services
{
    public interface IFirebaseDelegate
    {
        void Set(List<string> path, int val);
        void Set(List<string> path, bool val);
        void Set(List<string> path, string val);

        void Get(List<string> path, Action<int> handler);
        void Get(List<string> path, Action<bool> handler);
        void Get(List<string> path, Action<string> handler);

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
            firebaseDel.Set(new List<string> { "records", exp.Name, "sonicate_min" }, exp.Sonication);
            firebaseDel.Set(new List<string> { "records", exp.Name, "incubate_hr" }, exp.Incubation);
        }

        public void GetExperiments(Action<List<Experiment>> handler)
        {
            firebaseDel.GetExperiments(handler);
        }

    }

}
