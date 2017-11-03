using System;
using ChIPseq.Data;

namespace ChIPseq.Droid
{
    public class FirebaseAndroid : IFirebaseDelegate
    {
        public FirebaseAndroid()
        {
            Firebase.Database.FirebaseDatabase.Instance.SetPersistenceEnabled(true);
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
