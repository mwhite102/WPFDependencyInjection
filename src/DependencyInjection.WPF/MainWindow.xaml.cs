using DependencyInjection.WPF.Models;
using DependencyInjection.WPF.Services;
using System.Collections.ObjectModel;
using System.Windows;

namespace DependencyInjection.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IDataService _dataService;
        private readonly ObservableCollection<PersonModel> _people = new ObservableCollection<PersonModel>();

        /// <summary>
        /// MainWindow Constructor
        /// </summary>
        /// <remarks>
        /// ****** Be sure to remove StartupUri="MainWindow.xaml" fromApp.xaml ******
        /// </remarks>
        /// <param name="dataService"></param>
        public MainWindow(IDataService dataService)
        {
            InitializeComponent();
            this._dataService = dataService;
            this.DataContext = this;
        }

        public ObservableCollection<PersonModel> People => _people;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (_dataService != null)
            {
                foreach (var person in _dataService.GetAll())
                {
                    People.Add(person);
                }
            }
        }
    }
}
