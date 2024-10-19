using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MvvmWinForms
{

    internal class PersonViewModel : INotifyPropertyChanged
    {
        private Person _person;
        private string _feedbackMessage;
        private string _inputMessage;

        public PersonViewModel()
        {
            _person = new Person { Name = "John Doe", Age = 30 };
        }

        public string Name
        {
            get { return _person.Name; }
            set
            {
                if (_person.Name != value)
                {
                    _person.Name = value;
                    OnPropertyChanged("Name");
                }
            }
        }

        public int Age
        {
            get { return _person.Age; }
            set
            {
                if (_person.Age != value)
                {
                    _person.Age = value;
                    OnPropertyChanged("Age");
                }
            }
        }

        // FeedbackMessage is for OneWay binding simulation
        public string FeedbackMessage
        {
            get { return _feedbackMessage; }
            set
            {
                _feedbackMessage = value;
                OnPropertyChanged("FeedbackMessage");
            }
        }

        // InputMessage is for OneWayToSource binding simulation
        public string InputMessage
        {
            get { return _inputMessage; }
            set
            {
                _inputMessage = value;
                OnPropertyChanged("InputMessage");
            }
        }

        public void SubmitData()
        {
            FeedbackMessage = $"Data Submitted for {Name}, Age {Age}.";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
