using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace StartKoinoxristaProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Dapanes());
        }
    }

    // @connectionString the string that represents the local path of the database
    // @connection the object that is being used in order to make a communication between the application and the database.
    public class AccessTheDatabase
    {
        private string connectionString;
        private SqlConnection connection;
        private SqlDataAdapter myDataAdapter;
        private SqlCommand myCommand;
        private DataSet myDataSet;
        private DataTable myDataTable;
        
        // @connString the connection string
        public void set_connectionString(string connString)
        {
            connectionString = connString;
        }

        public void set_connection()
        {
            connection = new SqlConnection(connectionString);
        }

        public SqlConnection get_connection()
        {
            return connection;
        }

        public SqlDataAdapter get_myDataAdapter()
        {
            return myDataAdapter;
        }

        public DataTable get_myDataTable()
        {
            return myDataTable;
        }

        // Open the communication channel between the application and the database
        // @myConn the connection that was used to establish the communication
        public void OpenTheDatabase(SqlConnection myConn)
        {
            try
            {
                myConn.Open();
            }
            catch (Exception eOpen)
            {
                Console.WriteLine(eOpen.ToString());
            }
        }

        // Close the communication channel between the application and the database
        // @myConn the connection that was used to establish the communication
        public void CloseTheDatabase(SqlConnection myConn)
        {
            try
            {
                myConn.Close();
            }
            catch (Exception eClose)
            {
                Console.WriteLine(eClose.ToString());
            }
        }

        // Make a new read-only communication channel between the application and the database
        // @connString the string that represents the local path of the database
        public void CommunicateWithDatabase()
        {
            string connString =
                @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\adand\Projects\ABM\to_share\StartKoinoxristaProject\kinoxrista.mdf;Integrated Security=True";

            set_connectionString(connString);
            set_connection();
            OpenTheDatabase(get_connection());
        }

        // Create a new DataAdapter object and define which command will use
        // @myCommd the command that DataAdapter will use
        // @return the DataAdapter that was created
        public void DataAdapterInitialization(SqlCommand myCommd)
        {
            myDataAdapter = new SqlDataAdapter();
            myDataAdapter.SelectCommand = myCommd;
        }

        // Creating a data set and it's data tables.
        // @dataTables the number of DataTables that DataSet will store
        // @return the array of DataTables that was created
        public void DataSetInitialization()
        {
            myDataSet = new DataSet();
            myDataTable = new DataTable();
            myDataSet.Tables.Add(myDataTable);
        }

        public void CommandDefinition()
        {

        }

        // This is one of the overloaded versions of the AccessingProcess method.
        // This spesific version adds data to the database
        // It takes as arguments the data of each row. It inserts into the database one row at a time.
        // @BuildingID the string that contains the data that user wants to insert into that column of the database table.
        // @Address the string that contains the data that user wants to insert into that column of the database table.
        // @Area the string that contains the data that user wants to insert into that column of the database table.
        // @query the string that contains the SQL query that user wants to execute onto the database table.
        public void AccessingProcess(string BuildingID, string Address, string Area, string query)
        {
            // Call the communication method of the database by using the object that has been declared above
            CommunicateWithDatabase();

            // Command initialization
            myCommand = new SqlCommand(query);

            myCommand.Parameters.AddWithValue("@BuildingID", BuildingID);
            myCommand.Parameters.AddWithValue("@Address", Address);
            myCommand.Parameters.AddWithValue("@Area", Area);

            // set the communication between Command and Connection
            myCommand.Connection = connection;

            // Initialize DataAdapter and set it's communication with Command
            DataAdapterInitialization(myCommand);

            DataSetInitialization();
        }

        // This is one of the overloaded versions of the AccessingProcess method.
        // This spesific version deletes data from database table.
        // @query the string that contains the SQL query that user wants to execute onto the database table.
        public void AccessingProcess(string query)
        {
            // Call the communication method of the database by using the object that has been declared above
            CommunicateWithDatabase();

            // Command initialization
            myCommand = new SqlCommand(query);

            // set the communication between Command and Connection
            myCommand.Connection = connection;

            // Initialize DataAdapter and set it's communication with Command
            DataAdapterInitialization(myCommand);

            DataSetInitialization();

            /*
             * //Fill the DataTable with the required data
            myDataAdapter.Fill(myDataTable);
             * 
             */

            /*
             * // Calling the method that will close the connection between the application and the database
            CloseTheDatabase(get_connection());
             * 
             */
        }

    }
}
