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

namespace SpeedOfReaction
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CenterWindowOnScreen();
        }
        private void CenterWindowOnScreen()
        {
            double screenWidth = System.Windows.SystemParameters.PrimaryScreenWidth;
            double screenHeight = System.Windows.SystemParameters.PrimaryScreenHeight;
            double windowWidth = this.Width;
            double windowHeight = this.Height;
            this.Left = (screenWidth / 2) - (windowWidth / 2);
            this.Top = (screenHeight / 2) - (windowHeight / 2);
        }


        #region Przyciski
        private void Tutorial(object sender, RoutedEventArgs e)
        {
            Tutorial tutorial = new Tutorial();
            tutorial.Show();
            this.Close();
        }

        private void VisualReaction(object sender, RoutedEventArgs e)
        {
            VisualReaction visualReaction = new VisualReaction();
            visualReaction.Show();
            this.Close();
        }

        private void VoiceReaction(object sender, RoutedEventArgs e)
        {
            VoiceReaction voiceReaction = new VoiceReaction();
            voiceReaction.Show();
            this.Close();
        }
        #endregion Przyciski
    }
}
