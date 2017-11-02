using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace ChIPseq.UI
{
    public class IncubationViewModel
    {
        string inputString = "";
        string displayText = "";
        char[] specialChars = { '*', '#' };

        public event PropertyChangedEventHandler PropertyChanged;

        public IncubationViewModel()
        {
            //AddCharCommand = new Command<string>((key) =>
            //{
            //    // Add the key to the input string.
            //    InputString += key;
            //});

            //DeleteCharCommand = new Command(() =>
            //{
            //    // Strip a character from the input string.
            //    InputString = InputString.Substring(0, InputString.Length - 1);
            //},
                //() =>
                //{
                //    // Return true if there's something to delete.
                //    return InputString.Length > 0;
                //});
        }

        // ICommand implementations
        public ICommand AddCharCommand { protected set; get; }

        public ICommand DeleteCharCommand { protected set; get; }

        public bool ValidateIncubationTime(string entry)
        {
            // TODO
            return true;
        }
    }
}
