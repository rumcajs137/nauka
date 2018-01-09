using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace SpeedOfReaction
{
    class Change : INotifyPropertyChanged
    {

        private Color _Color1;
        public Color Color1
        {
            get { return _Color1; }
            set { _Color1 = value; NotifyPropertyChanged1("Color1"); }
        }
        private void NotifyPropertyChanged1(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private Color _Color2;
        public Color Color2

        {
            get { return _Color2; }
            set { _Color2 = value; NotifyPropertyChanged2("Color2"); }
        }
        private void NotifyPropertyChanged2(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
       // public event PropertyChangedEventHandler PropertyChanged;

    }
}
