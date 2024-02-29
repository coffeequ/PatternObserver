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

namespace PatternObserver
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionDisplay currentConditionDisplay = new CurrentConditionDisplay(weatherData);

            weatherData.setMeasurements(80, 20, 30.4f, true);
            weatherData.setMeasurements(82, 75, 29.2f, false);
            weatherData.setMeasurements(78, 90, 29.2f, true);
        }
    }
}
