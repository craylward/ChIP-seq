using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using ChIPseq.Models;
using ChIPseq.Services;
using Firebase.Database;
using Foundation;

namespace ChIPseq.iOS
{
    public class FirebaseiOS : IFirebaseDelegate
    {
        DatabaseReference rootNode;

        public FirebaseiOS()
        {
            Database.DefaultInstance.PersistenceEnabled = true;
            rootNode = Database.DefaultInstance.GetRootReference();
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
            var reference = rootNode;
            var recordsNode = rootNode.GetChild("records");
            recordsNode.ObserveSingleEvent(DataEventType.Value, (snapshot) =>
            {
                var experiments = new List<Experiment>();
                var dic = snapshot.GetValue<NSDictionary>();
                foreach (var entry in dic)
                {
                    var experiment = new Experiment();
                    experiment.Name = (NSString)entry.Key;
                    experiment.Sonication = (int)(((NSDictionary)entry.Value)["sonicate_min"] as NSNumber);
                    experiment.Incubation = (int)(((NSDictionary)entry.Value)["incubate_hr"] as NSNumber);
                    //Debug.WriteLine($"{experiment}");
                    experiments.Add(experiment);
                }
                handler(experiments);
            });
        }

        public void Set(List<string> path, int val)
        {
            var reference = rootNode;
            foreach (var node in path)
            {
                reference = reference.GetChild(node);
            }
            reference.SetValue(new NSNumber(val));
        }

        public void Set(List<string> path, bool val)
        {
            var reference = rootNode;
            foreach (var node in path)
            {
                reference = reference.GetChild(node);
            }
            reference.SetValue(new NSNumber(val));
        }

        public void Set(List<string> path, string val)
        {
            var reference = rootNode;
            foreach (var node in path)
            {
                reference = reference.GetChild(node);
            }
            reference.SetValue(new NSString(val));
        }
    }
}
