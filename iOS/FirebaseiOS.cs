using System;
using ChIPseq.Data;
using Firebase.Database;
using Foundation;

namespace ChIPseq.iOS
{
    public class FirebaseiOS : IFirebaseDelegate
    {
        DatabaseReference rootNode = Database.DefaultInstance.GetRootReference();

        public FirebaseiOS()
        {
            
        }

        public void Get(int path, int val)
        {
            throw new NotImplementedException();
        }

        public void Get(bool path, int val)
        {
            throw new NotImplementedException();
        }

        public void Get(string path, int val)
        {
            throw new NotImplementedException();
        }

        public void Set(string path, int val)
        {
            var reference = rootNode;
            var nodes = path.Split('/');
            foreach (var node in nodes)
            {
                reference = reference.GetChild(node);
            }
            reference.SetValue(new NSNumber(val));
        }

        public void Set(string path, bool val)
        {
            var reference = rootNode;
            var nodes = path.Split('/');
            foreach (var node in nodes)
            {
                reference = reference.GetChild(node);
            }
            reference.SetValue(new NSNumber(val));
        }

        public void Set(string path, string val)
        {
            var reference = rootNode;
            var nodes = path.Split('/');
            foreach (var node in nodes)
            {
                reference = reference.GetChild(node);
            }
            reference.SetValue(new NSString(val));
        }
    }
}
