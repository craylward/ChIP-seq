using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using ChIPseq.Models;
using ChIPseq.Services;
using Firebase.Database;
using Foundation;

namespace ChIPseq.iOS
{
    public class FirebaseDelegate : IFirebaseDelegate
    {
        DatabaseReference rootNode;

        public FirebaseDelegate()
        {
            Database.DefaultInstance.PersistenceEnabled = true;
            rootNode = Database.DefaultInstance.GetRootReference();
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
                    var firebaseExp = (NSDictionary)entry.Value;

                    Debug.WriteLine($"{firebaseExp}");
                    experiment.Name = (NSString)entry.Key;
                    var date = (string)(firebaseExp["date"] as NSString);
                    experiment.Date = DateTime.ParseExact(date, Experiment.DateFormat, CultureInfo.InvariantCulture);
                    experiment.Sonication = (int)(firebaseExp["sonicate_min"] as NSNumber);
                    experiment.Incubation = (int)(firebaseExp["incubate_hr"] as NSNumber);
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
    }
}
