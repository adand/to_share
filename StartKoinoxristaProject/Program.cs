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
            Application.Run(new Form1());
        }
    }

    // @connectionString the string that represents the local path of the database
    // @connection the object that is being used in order to make a communication between the application and the database.
    public class AccessTheDatabase
    {
        private string connectionString;
        private SqlConnection connection;
        
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
        public SqlDataAdapter DataAdapterInitialization(SqlCommand myCommd)
        {
            SqlDataAdapter myDataAdapter = new SqlDataAdapter();
            myDataAdapter.SelectCommand = myCommd;

            return myDataAdapter;
        }

        // Creating a data set and it's data tables.
        // @dataTables the number of DataTables that DataSet will store
        // @return the array of DataTables that was created
        public DataTable[] DataSetInitialization(int dataTables)
        {
            DataSet myDataSet = new DataSet();

            // Declare an array that will store DataTables
            DataTable[] myDataTables = new DataTable[dataTables];

            // fill the array
            for (int i = 0; i < dataTables; i++)
            {
                myDataTables[i] = new DataTable();
                myDataSet.Tables.Add(myDataTables[i]);
            }

            return myDataTables;
        }

    }

    // reading from a database

}
