using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace DataBase
{

    class DatabaseTier
    {
        private readonly String connectionString = "Persist Security Info=False;database=voiceappdb;server=voiceappdb.mysql.uic.edu;port=3306;Connect Timeout=30;user id=aguerrr2; pwd=plz;";
        
        public bool TestDataBaseConnection()
        {

            bool isOpen = false;
            MySqlConnection db = new MySqlConnection(connectionString);
            try {
                db.Open();
                isOpen = (db.State == ConnectionState.Open);
            }
            catch(MySqlException err)
            {
                throw err;
            }
            finally
            {
                if (db != null)
                    db.Close();
            }

            return isOpen;
        }
        public Object ExecuteScalerQuery(String query)
        {
            MySqlConnection db = new MySqlConnection(connectionString);
            Object result = new Object();
            try
            {
                db.Open(); // open the connection to the query
                MySqlCommand command = new MySqlCommand(query, db); // Send in the query and sets the database connection
                result = command.ExecuteScalar(); // Get the object that is returned
            }
            catch (MySqlException err)
            {
                throw err; // If something happen within the database, throw the error.
            }
            finally
            {
                if (db != null) // If there is a connection to the database, close the connection to the database
                    db.Close();
            }
            return result;
        }
        public DataSet ExecuteNonScalerQuery(String query)
        {


            MySqlConnection db = new MySqlConnection(connectionString);
            DataSet data = new DataSet(); // data set that is returned from query
            
            try
            {
                db.Open(); // open the connection to the query
                MySqlCommand cmd = new MySqlCommand(query, db); // create a command for query 
                MySqlDataAdapter dt = new MySqlDataAdapter(cmd); // execute the command
                dt.Fill(data); // fill in the data from the tables
            }
            catch (MySqlException err) 
            {
                throw err; // If something happen within the database, throw the error.
            }
            finally
            {
                if (db != null) // If there is a connection to the database, close the connection to the database
                    db.Close();
            }
            return data;

        }
        public int ExecuteActionQuery(String query)
        {
            MySqlConnection db = new MySqlConnection(connectionString);
            int numberOfRowsAffected = -1; // 
            try
            {
                db.Open(); // open the connection to the query
                MySqlCommand cmd = new MySqlCommand(query, db); // create a command for query 
                numberOfRowsAffected = cmd.ExecuteNonQuery();
            }
            catch (MySqlException err)
            {
                throw err; // If something happen within the database, throw the error.
            }
            finally
            {
                if (db != null) // If there is a connection to the database, close the connection to the database
                    db.Close();
            }
            return numberOfRowsAffected;
        }
    }
}
