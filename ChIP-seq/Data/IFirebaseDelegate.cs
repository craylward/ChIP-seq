using System;
namespace ChIPseq.Data
{
    public interface IFirebaseDelegate
    {
        void Set(string path, int val);
        void Set(string path, bool val);
        void Set(string path, string val);

        void Get(int path, int val);
        void Get(bool path, int val);
        void Get(string path, int val);
    }
}
