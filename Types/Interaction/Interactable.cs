using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Types.Interaction
{
    [Serializable]
    public class Interactable : INotifyPropertyChanged
    {

        private BindingList<InteractableName> names = new BindingList<InteractableName>();
        private BindingList<Interaction> interactions = new BindingList<Interaction>();

        public BindingList<Interaction> Interactions
        {
            get { return interactions; }
            set { interactions = value; }
        }

        public BindingList<InteractableName> Names
        {
            get { return names; }
            set { names = value; }
        }

        private string scriptAlias;

        public string ScriptAlias
        {
            get { return scriptAlias; }
            set { 
                scriptAlias = value;
                OnPropertyChanged("ScriptAlias");
            }
        
        }

        public static Interactable Default()
        {
            var i = new Interactable();
            i.Names.Add(InteractableName.Default());
            i.Interactions.Add(Interaction.Default());
            i.ScriptAlias = "MyInteractable";
            return i;
        }

        public Interactable()
        {
            
        }

        public override string ToString()
        {
            return ScriptAlias;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
