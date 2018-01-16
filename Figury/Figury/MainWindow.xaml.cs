using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Figury
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    
    {
        ObservableCollection<OpisFigur> listaFigur = new ObservableCollection<OpisFigur>();
        public MainWindow()
        {
            InitializeComponent();
            datagrid.ItemsSource = listaFigur;
            listaFigur.Add(new OpisFigur()
            {
                Nazwa = "figura1",
                Opis = "koleczko",
                
                Typ = OpisFigur.Shapes.Rectangle
            }
                );
        }
        private bool _mouseDown = false;
        private Rectangle _current;
        private Point _initialPoint;
        
        

        private void Canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            _mouseDown = (e.ButtonState == MouseButtonState.Pressed)
                                         && (e.ChangedButton == MouseButton.Left);
            if (!_mouseDown)
                return;
            MyCanvas.Children.Clear();
            var figura = datagrid.SelectedItem as OpisFigur;

            _current = new Rectangle {
                Fill = figura.Kolor,
            
            };
            _current = new Rectangle();
            _initialPoint = e.MouseDevice.GetPosition(MyCanvas);
            _current.Fill = new SolidColorBrush(Colors.Blue);
            MyCanvas.Children.Add(_current);
        }
        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_mouseDown)
                return;

            Point position = e.MouseDevice.GetPosition(MyCanvas);
            _current.SetValue(Canvas.LeftProperty,
                                             Math.Min(position.X, _initialPoint.X));
            _current.SetValue(Canvas.TopProperty,
                                             Math.Min(position.Y, _initialPoint.Y));
            _current.Width = Math.Abs(position.X - _initialPoint.X);
            _current.Height = Math.Abs(position.Y - _initialPoint.Y);
        }
        private void Canvas_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                _mouseDown = false;
                
            }
        }
    }
}
