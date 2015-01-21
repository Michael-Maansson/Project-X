using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Project_X
{
    class Controller
    {
        public void tilføjPerson(string inputCPRNR, string inputName)
        {
            string connectionString = "Server=ealdb1.eal.local; User ID=ejl15_usr; Password=Baz1nga15; Database=EJL15_DB";
            try
            {
                SqlConnection conn = new SqlConnection(connectionString); 

                SqlCommand tilføjPerson = new SqlCommand("SetPerson", conn);
                tilføjPerson.CommandType = System.Data.CommandType.StoredProcedure;

                tilføjPerson.Parameters.Add(new SqlParameter("@CPRNR", inputCPRNR));
                tilføjPerson.Parameters.Add(new SqlParameter("@Name", inputName));

                conn.Open();
                tilføjPerson.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
                
            finally
            {
             


            }
            
            
            

        }
        public void tilføjSensor(string inputSensorID, string inputCPRNR, string inputModel, DateTime inputBatteryLastCharged)
        {
            string connectionString = "Server=ealdb1.eal.local; User ID=ejl15_usr; Password=Baz1nga15; Database=EJL15_DB";
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand tilføjSensor = new SqlCommand("SetSensor", conn);
                tilføjSensor.CommandType = System.Data.CommandType.StoredProcedure;

                tilføjSensor.Parameters.Add(new SqlParameter("@SensorID", inputSensorID));
                tilføjSensor.Parameters.Add(new SqlParameter("@CPRNR", inputCPRNR));
                tilføjSensor.Parameters.Add(new SqlParameter("@Model", inputModel));
                tilføjSensor.Parameters.Add(new SqlParameter("@BatteryLastChanged", inputBatteryLastCharged));

                conn.Open();
                tilføjSensor.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            finally
            {

            }
        }
        //public List<Battery> hentBatteryTime = new List<Battery>();

        public List<_Sensor> hentBatteryTime()
        {
            List<_Sensor> hentBatteryTime = new List<_Sensor>();
            _Sensor hentBattery = new _Sensor();


            string connectionString = "Server=ealdb1.eal.local; User ID=ejl15_usr; Password=Baz1nga15; Database=EJL15_DB";
            try
            {
             
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("GetSensorFromSensorID", conn);
                cmd.Parameters.Add(new SqlParameter("@SensorID",""));
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    hentBattery.batteryLastChanged = Convert.ToDateTime(sdr["BatteryLastChanged"]);
                    hentBatteryTime.Add(hentBattery);
                }
                
            }
            catch (SqlException)
            {

            }
            finally
            {
            }

            return hentBatteryTime;
                
            }
        }

                

        
    }

