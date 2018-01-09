using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SpeedOfReaction
{
    /// <summary>
    /// Logika interakcji dla klasy Tutorial.xaml
    /// </summary>
    public partial class Tutorial : Window
    {
        #region atrybuty
        Random r = new Random();
        Change zmiana = new Change();
        //int count;
        #endregion atrybuty

        public Tutorial()
        {
            InitializeComponent();
            CenterWindowOnScreen();
            this.DataContext = zmiana;
            zmiana.Color1 = Colors.DarkRed;
            zmiana.Color2 = Colors.DarkGreen;
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void button_xd_Click(object sender, RoutedEventArgs e)
        {
            if (button_xd.Content.ToString() == "Start")
            {
                button_xd.Content = "React!";
                StartThread1();
            }
            else if (button_xd.Content.ToString() == "React!")
            {
                    StartThread1();            
            }
        }

        private void beepreaction()
        {
           
                Thread.Sleep(100 * r.Next(7, 15));

                Console.Beep(2000, 500);
        }

        private void StartThread1()
        {
            Thread th = new System.Threading.Thread(beepreaction);
            th.Start();
        }

        private void button_dx_Click(object sender, RoutedEventArgs e)
        {
            if (button_dx.Content.ToString() == "Start")
            {
                button_dx.Content = "React!";
                StartThread();
            }
            else if (button_dx.Content.ToString() == "React!")
            {
                    zmiana.Color2 = Colors.DarkGreen;
                    StartThread();
               
            }
        }
        //Metoda zmieniająca kolory sygnalizatora i uruchamiająca stoper
        private void lightreaction()
        {
                zmiana.Color1 = Colors.Red;
                Thread.Sleep(100 * r.Next(7, 15));
                zmiana.Color2 = Colors.Lime;
                zmiana.Color1 = Colors.DarkRed;
        }
        //Uruchamiany nowy wątek obsługujący sygnalizator
        private void StartThread()
        {

            Thread th = new System.Threading.Thread(lightreaction);
            th.Start();
        }
    }
}
