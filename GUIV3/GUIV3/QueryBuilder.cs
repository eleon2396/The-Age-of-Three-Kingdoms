using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    class QueryBuilder
    {
        private readonly DatabaseTier database = new DatabaseTier();

        /* This function needs to be fixed, it should return a player class! For now, it checks if the user is fixe*/
        public Boolean checkAccountQuery(String email, String password)
        {
            Boolean isValidUser = false;
            try
            {
                String checkForUser = String.Format(@"Select userName from USERS where email = '{0}' and password = '{1}'; ", email,password);
                String user = Convert.ToString(database.ExecuteScalerQuery(checkForUser));
                if (user != "") // if something is converted then its true
                    isValidUser = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }


            return isValidUser;
        }
        
        public Boolean buildAccountQuery(String first,String last,String email, String password,String user)
        {
            Boolean isCreated = false;
            // This query checks if the user name is available
            try
            {
                String checkForUser = String.Format(@"Select userName from USERS where username = '{0}'; ", user);
                Boolean isValidUser = Convert.ToBoolean(database.ExecuteScalerQuery(checkForUser));
                if (isValidUser)
                {
                    Console.WriteLine("Created user Name");
                }
            }catch(Exception ex)
            {
                throw ex;
            }
            try
            {

                String account = String.Format(@"INSERT INTO `USERS`(`UID`, `FirstName`, `LastName`, `Email`, `Password`, `UserName`) VALUES(NULL,'{0}','{1}','{2}','{3}','{4}')", first, last, email, password, user);
                int result = database.ExecuteActionQuery(account);
                isCreated = result == 1 ? true : false;
            }catch(Exception ex)
            {
                throw ex;
            }
            return isCreated;
        }
        
    }
}
