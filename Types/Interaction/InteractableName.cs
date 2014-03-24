using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Types.Interaction
{
    [Serializable]
    public class InteractableName : INotifyPropertyChanged
    {

        private string name, condition;

        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        public String Condition
        {
            get
            {
                return condition;
            }
            set
            {
                condition = value;
                //OnPropertyChanged("Condition");
            }
        }

        public InteractableName()
        {
            Name = "My Interactable";
            Condition = "return true";
        }

        public override string ToString()
        {
            return String.IsNullOrEmpty(Name) ? "" : Name;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        internal static InteractableName Default()
        {
            return new InteractableName(); // bit pointless but whatever
        }
    }
}
