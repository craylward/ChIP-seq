using System;
namespace ChIPseq.Models
{
    public class Experiment
    {
        public string Name { get; set; }
        public int Sonication { get; set; }
        public int Incubation { get; set; }

        public override string ToString()
        {
            return string.Format("[Experiment: Name={0}, Sonication={1}, Incubation={2}]", Name, Sonication, Incubation);
        }
    }
}