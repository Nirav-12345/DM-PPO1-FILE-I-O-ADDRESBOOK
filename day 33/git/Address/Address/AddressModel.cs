using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address
{
    public class AddressModel
    {
        public static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Address_Book_service;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);

        public bool AddEmployee(address employee)
        {
            try
            {
                using (this.connection)
                {
                    SqlCommand command = new SqlCommand("SpAddEmployeeDetails4", this.connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@EmployeeId", employee.EmpId);
                    command.Parameters.AddWithValue("@EmployeeFirstName", employee.empFirstName);
                    command.Parameters.AddWithValue("@EmployeeSecondName", employee.empLastName);
                    command.Parameters.AddWithValue("@Address", employee.Address);
                    command.Parameters.AddWithValue("@city", employee.city);
                    command.Parameters.AddWithValue("@state", employee.state);
                    command.Parameters.AddWithValue("@zip", employee.Zip);
                    command.Parameters.AddWithValue("@email", employee.email);
                    this.connection.Open();

                    var result = command.ExecuteNonQuery();
                    this.connection.Close();

                    if (result != 0)
                    {
                        return true;
                    }
                    return false;

                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                this.connection.Close();
            }

        }

    }
}




    

