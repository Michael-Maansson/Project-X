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
            string connectionString = "Server=ealdb1.eal.local; User ID=ejl15_usr; Password=Baz1nga15; Database=EJL15_DB";
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query =
                    "UPDATE aspnet_PersonalInformation Set P_Name=@personName, P_CPRNR=@cprPerson";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@personName", nameBox);
                    cmd.Parameters.AddWithValue("@cprPerson", cprBox);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    
                }
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}
