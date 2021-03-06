﻿using System;
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
using System.Data.SqlClient;

namespace Project_X {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        public void saveButton_Click(object sender, RoutedEventArgs e)
        {
            Controller controller = new Controller();
            controller.tilføjPerson(cprBox.Text, nameBox.Text);
            MessageBox.Show("Person tilføjet");
        }

        private void nameBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void cprBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tilføjSensor_Click(object sender, RoutedEventArgs e)
        {
            //this.Close();
            new Sensor().Show();
        }

        private void tjekBatteri_Click(object sender, RoutedEventArgs e)
        {
            Controller controller = new Controller();
            controller.hentBatteryTime();

        }
    }
}
