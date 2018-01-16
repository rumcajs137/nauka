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

namespace DataGrid
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<PersonData> listOfPeople = new ObservableCollection<PersonData>();
        public MainWindow()
        {
            InitializeComponent();

            listOfPeople.Add(new PersonData()
            {
                Name = "Filip",
                Age = 27,
                Email = "filipklos@gmail.com",
                isSubscribedToNewsletter = true,
                Website=new Uri("http://www.wykop.pl"),
                Description="adasadasdasda"
            }
                );
            listOfPeople.Add(new PersonData()
            {
                Name = "Mysza",
                Age = 22,
                Email = "m.manthey53616@gmail.com",
                GenderType = PersonData.Gender.Female,
                Image = "mysza.jpg",
                Description = "adasadasdasda"
            }
                 );
            listOfPeople.Add(new PersonData()
            {
                Name = "Mateusz",
                Age = 13,
                Email = "m.mantheyXD@gmail.com",
                Description = "adasadasdasda"
            }
                 );
            listOfPeople.Add(new PersonData()
            {
                Name = "Marta",
                Age = 24,
                Email = "gula@gmail.com",
                Description = "adasadasdasda"
            }
                 );
            dataGridOfPeople.ItemsSource = listOfPeople;
            ComboBoxColumnSex.ItemsSource = Enum.GetValues(typeof(PersonData.Gender));
        }
    }
}
