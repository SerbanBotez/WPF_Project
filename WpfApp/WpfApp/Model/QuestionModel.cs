using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace WpfApp.Model
{
    public class QuestionModel { }

    public class Question : INotifyPropertyChanged
    {
        private string difficulty;
        private string description;
        private List<String> correctResponses = new List<string>();
        private List<String> responses = new List<string>();

        public string Difficulty
        {
            get
            {
                return difficulty;
            }

            set
            {
                if (difficulty != value)
                {
                    difficulty = value;
                    RaisePropertyChanged("Difficulty");
                }
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                if (description != value)
                {
                    description = value;
                    RaisePropertyChanged("Description");
                }
            }
        }

        public void AddResponse(string response)
        {
            responses.Add(response);
        }

        public void AddCorrectResponse(string response)
        {
            correctResponses.Add(response);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
