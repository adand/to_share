using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        // Make a new read-only connection between the application and the database
        // @connString the string that represents the local path of the database
        public void ReadingTheDatabase()
        {
            string connString =
                @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\adand\Projects\ABM\to_share\StartKoinoxristaProject\kinoxrista.mdf;Integrated Security=True";

            set_connectionString(connString);
            set_connection();
            OpenTheDatabase(get_connection());

        }

    }

    // reading from a database

}
