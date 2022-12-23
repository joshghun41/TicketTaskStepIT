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

namespace TicketTaskWithCodeFirst
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            TicketDataClassesDataContext dtx = new TicketDataClassesDataContext();


            var result = (from c in dtx.Cities
                          select c.CityName);
            
            citycombobox.ItemsSource = result;

            
            //var result2 = (from a in dtx.Airplanes from c in dtx.Cities
            //              where a.Id == c.AirplaneId
            //              select a.PlaneName);
            //airplanecombobox.ItemsSource = result2;

        }

        private void citycombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TicketDataClassesDataContext dtx = new TicketDataClassesDataContext();

            var city = citycombobox.SelectedItem as string;

            var result = (from c in dtx.Cities from a in dtx.Airplanes
                          where c.CityName == city && c.AirplaneId == a.Id
                          select a.PlaneName);

            airplanecombobox.ItemsSource= result;

            var result2 = (from c in dtx.Cities
                          from s in dtx.Schedules
                          where c.CityName == city && s.Id == c.ScheduleId
                          select s.Date);

            schedulecombobox.ItemsSource = result2;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var city = citycombobox.SelectedItem as string;
            var airplane = airplanecombobox.SelectedItem as string;
            var schedule = schedulecombobox.SelectedItem as string;

            MessageBox.Show($@"Congratulations! You have purchased a ticket." +
                             $@"Ticket INFO:
                                City => {city}
                                Airplane => {airplane}
                                Schedule => {schedule}
                                Total => 15$."
                             
                                 );


        }
    }
}
