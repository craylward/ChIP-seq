using System;
using Xamarin.Forms;

namespace ChIPseq.Data
{
    public class FirebaseUtility
    {
        IFirebaseDelegate firebaseDel;

        static FirebaseUtility Instance = new FirebaseUtility(DependencyService.Get<IFirebaseDelegate>());

        public FirebaseUtility(IFirebaseDelegate firebaseDel)
        {
            this.firebaseDel = firebaseDel;
        }

        void AddExperiment(Experiment exp)
        {
            firebaseDel.Set("chip-seq/records/" + exp.Name + "sonicate_min", exp.Sonication);
            firebaseDel.Set("chip-seq/records/" + exp.Name + "incubate_hr", exp.Incubation);
        }

    }
}
