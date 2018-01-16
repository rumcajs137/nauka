using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace INotifyProperty
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        InkEditingModes editingmodes = new InkEditingModes();
        public MainWindow()
        {
            InitializeComponent();
            //this.DataContext = editingmodes;
        }

        private void selection_Click(object sender, RoutedEventArgs e)
        {
            //editingmodes.EditingMode = InkCanvasEditingMode.Select;
            (Application.Current.Resources["editingModes"] as InkEditingModes).EditingMode = InkCanvasEditingMode.Select ;
        }

        private void drawing_Click(object sender, RoutedEventArgs e)
        {
            //editingmodes.EditingMode = InkCanvasEditingMode.Ink;
            (Application.Current.Resources["editingModes"] as InkEditingModes).EditingMode = InkCanvasEditingMode.Ink;
        }
    }
}
