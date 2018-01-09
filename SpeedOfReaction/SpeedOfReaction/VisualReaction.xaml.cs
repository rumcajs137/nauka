using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.DataVisualization.Charting;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SpeedOfReaction
{
    /// <summary>
    /// Logika interakcji dla klasy VisualReaction.xaml
    /// </summary>
    public partial class VisualReaction : Window
    {
        #region atrybuty
        Random r = new Random();
        int[] count = new int[10];
        Stopwatch stoper = new Stopwatch();
        int click = 0;
        int klik = 0;
        double czas = 0;
        double time = 0;
        ObservableCollection<KeyValuePair<int, double>> chart = new ObservableCollection<KeyValuePair<int, double>>();
        Change zmiana = new Change();
        #endregion atrybuty
        public VisualReaction()
        {
            InitializeComponent();
            CenterWindowOnScreen();
            losuj();
            this.DataContext = zmiana;
            this.DataContext = zmiana;
            zmiana.Color1=Colors.DarkRed;
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
        //Wykres
        private void McChart_Loaded(object sender, RoutedEventArgs e)
        {
            ZaladujDane();
            Dispatcher.BeginInvoke((Action)(() => chart.Add(new KeyValuePair<int, double>(0, 0))));
        }

        //Dane String i Int (Odpowiadajace wartościom CHART w XAML
        //     IndependentValueBinding="{Binding Path=Key}"
        //     DependentValueBinding="{Binding Path=Value}">
        private void ZaladujDane()
        {
            ((AreaSeries)mcChart.Series[0]).ItemsSource = chart;
        }
        //Obsluga przycisku
        private void przycisk_Click(object sender, RoutedEventArgs e)
        {
            
            if (button_xd.Content.ToString() == "Start")
            {
                button_xd.Content = "React!";
                logs.Text = "";
                infobox.Content = ("Próba: " + 1);
                StartThread();
            }
            else if (button_xd.Content.ToString() == "React!")
            {
                if (click < 10)
                {
                    zmiana.Color2 = Colors.DarkGreen;
                    klik = click + 1;
                    czas = ((float)stoper.ElapsedMilliseconds / 1000);
                    logs.Text += klik + ". " + czas + " s" + Environment.NewLine;
                    stoper.Reset();
                    Dispatcher.BeginInvoke((Action)(() => chart.Add(new KeyValuePair<int, double>(click, czas))));
                    time += czas;
                    double average = Math.Round((double)(time / klik), 2);
                    infobox.Content = ("Próba: " + klik + Environment.NewLine + "Średnia: " + average + " s");
                    StartThread();
                    click++;
                }

            }
        }
        //Metoda zmieniająca kolory sygnalizatora i uruchamiająca stoper
        private void lightreaction()
        {
            if (click < 10)
            {
                zmiana.Color1 = Colors.Red;
                Thread.Sleep(count[click]);
                zmiana.Color2 = Colors.Lime;
                zmiana.Color1 = Colors.DarkRed;
                stoper.Start();
            }
        }
//Uruchamiany nowy wątek obsługujący sygnalizator
        private void StartThread()
        {

            Thread th = new System.Threading.Thread(lightreaction);
            th.Start();
        }
        private void losuj()
        {
            for (int i = 0; i < 10; i++)
            {
                count[i] = 100 * r.Next(5, 25);
            }
        }
        private void button_ex_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }
    }
}
