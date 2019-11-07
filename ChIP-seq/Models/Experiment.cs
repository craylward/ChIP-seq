using System;

namespace ChIPseq.Models
{
    public class Experiment
    {
        public const string DateFormat = "MM/dd/yyyy HH:mm";

        public string Name { get; set; }
        public DateTime Date { get; set; } = DateTime.UtcNow;// Creation Date
        public int Sonication { get; set; }
        public int Incubation { get; set; }

        public override string ToString()
        {
            return string.Format("[Experiment: Name={0}, Date={1}, Sonication={2}, Incubation={3}]", Name, Date, Sonication, Incubation);
        }
    }
}