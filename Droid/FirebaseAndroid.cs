using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ChIPseq.Models;
using ChIPseq.Services;

namespace ChIPseq.Droid
{
    public class FirebaseAndroid : IFirebaseDelegate
    {
        public FirebaseAndroid()
        {
            Firebase.Database.FirebaseDatabase.Instance.SetPersistenceEnabled(true);
        }

        public void Get(string path, Action<int> handler)
        {
            throw new NotImplementedException();
        }

        public void Get(string path, Action<bool> handler)
        {
            throw new NotImplementedException();
        }

        public void Get(string path, Action<string> handler)
        {
            throw new NotImplementedException();
        }

        public void Get(List<string> path, Action<int> handler)
        {
            throw new NotImplementedException();
        }

        public void Get(List<string> path, Action<bool> handler)
        {
            throw new NotImplementedException();
        }

        public void Get(List<string> path, Action<string> handler)
        {
            throw new NotImplementedException();
        }

        public void GetExperiments(Action<List<Experiment>> handler)
        {
            throw new NotImplementedException();
        }

        public void Set(string path, int val)
        {
            throw new NotImplementedException();
        }

        public void Set(string path, bool val)
        {
            throw new NotImplementedException();
        }

        public void Set(string path, string val)
        {
            throw new NotImplementedException();
        }

        public void Set(List<string> path, int val)
        {
            throw new NotImplementedException();
        }

        public void Set(List<string> path, bool val)
        {
            throw new NotImplementedException();
        }

        public void Set(List<string> path, string val)
        {
            throw new NotImplementedException();
        }
    }
}
