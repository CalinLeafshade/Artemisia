using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Types.Interaction
{
    [Serializable]
    public class Interaction : INotifyPropertyChanged, ICloneable
    {
        public enum InteractionType { Examine, Take, Use, Talk, Item }


        private string tooltipText;
        private string condition;
        private string customItem;
        private InteractionType type;

        public InteractionType Type
        {
            get { return type; }
            set { type = value; OnPropertyChanged("Type"); }
        }
        public string CustomItem
        {
            get { return customItem; }
            set { customItem = value; OnPropertyChanged("CustomItem"); }
        }

        public string Condition
        {
            get { return condition; }
            set { condition = value; OnPropertyChanged("Condition"); }
        }
        private string action;

        public string Action
        {
            get { return action; }
            set { action = value; OnPropertyChanged("Action"); }
        }

        public string ToolTipText
        {
            get { return tooltipText; }
            set 
            { 
                tooltipText = value;
                OnPropertyChanged("ToolTipText");
            }
        }
        

        
  

        public Interaction()
        {
            ToolTipText = "New Interaction";
            Condition = "return true";
            CustomItem = "";
            Action = "";
        }

        public override string ToString()
        {
            return String.Format("[{0}]: {1}", Type.ToString(), Types.Utils.GetScriptHeader(Action));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public static Interaction Default()
        {
            Interaction i = new Interaction();
            i.ToolTipText = "";
            i.Action = "--* Interaction";
            return i;
        }

        public object Clone()
        {
            Interaction i = new Interaction();
            i.ToolTipText = this.ToolTipText;
            i.Type = this.Type;
            i.Condition = this.Condition;
            i.Action = this.Action;
            i.CustomItem = this.CustomItem;
            return i;
        }
    }
}
