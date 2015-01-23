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
using System.Windows.Shapes;

namespace Project_X
{
    /// <summary>
    /// Interaction logic for Sensor.xaml
    /// </summary>
    public partial class Sensor : Window
    {
        public Sensor()
        {
            InitializeComponent();
        }

        private void Model_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void SensorID_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CprNr_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BatteryLastChanged_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void SaveSensor_Click(object sender, RoutedEventArgs e)
        {
            Controller controller = new Controller();
            controller.tilføjSensor(SensorID.Text, CprNr.Text, Model.Text, Convert.ToDateTime(BatteryLastChanged.Text));
            MessageBox.Show("Sensor Tilføjet");
            Close();
        }

        private void vælgSensor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

       

        private void batteriUdskiftet_Click(object sender, RoutedEventArgs e)
        {
            Controller controller = new Controller();
            
            controller.tilføjSensor("", "", "", Convert.ToDateTime(BatteryLastChanged.Text));
        }

        private void dagensDato_TextChanged(object sender, TextChangedEventArgs e)
        {
            //DateTime now = DateTime.Now;
            
            //dagensDato.Text = DateTime.Now();
        }

    }
}
