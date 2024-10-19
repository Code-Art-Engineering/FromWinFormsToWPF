using System.ComponentModel;

namespace MvvmWpf
{
    internal class PersonViewModel : INotifyPropertyChanged
    {
        private Person _person;
        private string? _feedbackMessage;

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

        // FeedbackMessage is used to demonstrate OneWay binding
        public string FeedbackMessage
        {
            get { return _feedbackMessage; }
            set
            {
                _feedbackMessage = value;
                OnPropertyChanged("FeedbackMessage");
            }
        }

        // Method to simulate some operation and update FeedbackMessage
        public void SubmitData()
        {
            FeedbackMessage = $"Data Submitted for {Name}, Age {Age}.";
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
