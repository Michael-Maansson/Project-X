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


    }
}
