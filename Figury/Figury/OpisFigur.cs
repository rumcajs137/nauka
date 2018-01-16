using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Figury
{
    public class OpisFigur
    {
        //public enum Brushes
        //{
        //    Blue
        //    Red,
        //    Green
        //}
        public enum Shapes
        {
            Rectangle,
            Elipse,
        }
        
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public Brush Kolor { get; set; }
        public Shapes Typ { get; set; }
        

    }
}
