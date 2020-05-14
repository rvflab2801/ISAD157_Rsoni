using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SOFT562Week18
{
    public partial class DatabaseForm : Form
    {
        public DatabaseForm()
        {
            InitializeComponent();
        }

        private void comboBoxQueryChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxQueryChoice.SelectedIndex == 0)
            {
                /////////////////////////////////////////////////////////////////
                //
                // The basic format of a connection string consists of a series
                // of keyword/value pairs separated by semicolons. The equal
                // sign (=) connects each keyword and its value. Specifically,
                // our connection string MUST refer to 
                // proj-mysql.uopnet.plymouth.ac.uk as the server, and
                // to our username and password to access
                // proj-mysql.uopnet.plymouth.ac.uk.
                //
                /////////////////////////////////////////////////////////////////

                string connectionString = "SERVER=" + DBConnect.SERVER + ";" +
                    "DATABASE=" + DBConnect.DATABASE_NAME + ";" + "UID=" +
                    DBConnect.USER_NAME + ";" + "PASSWORD=" +
                    DBConnect.PASSWORD + ";" + "SslMode=" +
                    DBConnect.SslMode + ";";

                ///////////////////////////////////////////////////////////////
                //
                // Create an open connection to a MySQL Server database. In our
                // case, the connection allows us to interact with
                // proj-mysql.uopnet.plymouth.ac.uk.
                //
                ///////////////////////////////////////////////////////////////

                using (MySqlConnection connection =
                    new MySqlConnection(connectionString))
                {
                    ///////////////////////////////////////////////////////////
                    //
                    // The query which retrieves all the records in the
                    // customers table.
                    //
                    ///////////////////////////////////////////////////////////
                    string query = "SELECT * FROM isad157_rsoni.fbusers";

                    ///////////////////////////////////////////////////////////
                    //
                    // Opens a database connection with the property settings
                    // specified by the ConnectionString.
                    //
                    ///////////////////////////////////////////////////////////
                    connection.Open();

                    ///////////////////////////////////////////////////////////
                    //
                    // Submit the SQL statement to be executed against the
                    // MySQL database.
                    //
                    ///////////////////////////////////////////////////////////
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    ///////////////////////////////////////////////////////////
                    //
                    // The MySqlDataAdapter represents a set of data commands
                    // and a database connection that are used to fill a
                    // dataset and update a MySQL database.
                    //
                    ///////////////////////////////////////////////////////////
                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable fbusersDataTable = new DataTable();
                    sqlDA.Fill(fbusersDataTable);

                    ///////////////////////////////////////////////////////////
                    //
                    // Bind the Facebook fbusers table to the Data Grid View.
                    //
                    ///////////////////////////////////////////////////////////
                    dataGridViewFbusers.DataSource = fbusersDataTable;

                } // End of using (MySqlConnection connection = ...
            }
            else if (comboBoxQueryChoice.SelectedIndex == 1)
            {

                string connectionString = "SERVER=" + DBConnect.SERVER + ";" +
                    "DATABASE=" + DBConnect.DATABASE_NAME + ";" + "UID=" +
                    DBConnect.USER_NAME + ";" + "PASSWORD=" +
                    DBConnect.PASSWORD + ";" + "SslMode=" +
                    DBConnect.SslMode + ";";

                using (MySqlConnection connection =
                    new MySqlConnection(connectionString))
                {

                    string query = "SELECT * FROM fbfriends ORDER BY UserId asc";
                    connection.Open();

                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable FbfriendsDataTable = new DataTable();
                    sqlDA.Fill(FbfriendsDataTable);

                    dataGridViewMessages.DataSource = FbfriendsDataTable;
                }
            }
            else if (comboBoxQueryChoice.SelectedIndex == 2)
            {


                string connectionString = "SERVER=" + DBConnect.SERVER + ";" +
                    "DATABASE=" + DBConnect.DATABASE_NAME + ";" + "UID=" +
                    DBConnect.USER_NAME + ";" + "PASSWORD=" +
                    DBConnect.PASSWORD + ";" + "SslMode=" +
                    DBConnect.SslMode + ";";

                using (MySqlConnection connection =
                    new MySqlConnection(connectionString))
                {

                    string query = "SELECT* FROM messages ORDER BY sender_id asc";

                    connection.Open();

                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable MessagesDataTable = new DataTable();
                    sqlDA.Fill(MessagesDataTable);

                    dataGridViewMessages.DataSource = MessagesDataTable;
                }
            }
            else if (comboBoxQueryChoice.SelectedIndex == 3)
            {

                string connectionString = "SERVER=" + DBConnect.SERVER + ";" +
                    "DATABASE=" + DBConnect.DATABASE_NAME + ";" + "UID=" +
                    DBConnect.USER_NAME + ";" + "PASSWORD=" +
                    DBConnect.PASSWORD + ";" + "SslMode=" +
                    DBConnect.SslMode + ";";


                using (MySqlConnection connection =
                    new MySqlConnection(connectionString))
                {

                    string query = "SELECT Universities.Student_Id,universities.University, fbusers.Firstname, fbusers.LastName FROM ((universities INNER JOIN fbusers ON Universities.Student_Id = fbusers.UserId)); ";

                  
                    connection.Open();

                
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                  
                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable UniversitiesDataTable = new DataTable();
                    sqlDA.Fill(UniversitiesDataTable);

                   
                    dataGridViewMessages.DataSource = UniversitiesDataTable;
                }
            }
            else
            {
       

                string connectionString = "SERVER=" + DBConnect.SERVER + ";" +
                    "DATABASE=" + DBConnect.DATABASE_NAME + ";" + "UID=" +
                    DBConnect.USER_NAME + ";" + "PASSWORD=" +
                    DBConnect.PASSWORD + ";" + "SslMode=" +
                    DBConnect.SslMode + ";";

         

                using (MySqlConnection connection =
                    new MySqlConnection(connectionString))
                {
     
                    string query = "SELECT Workplace.UserId,Workplace.workplace, fbusers.Firstname, fbusers.LastName FROM((Workplace INNER JOIN fbusers ON Workplace.UserId = fbusers.UserId)); ";

                    connection.Open();

                    MySqlCommand cmd = new MySqlCommand(query, connection);

         
                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable WorkplaceDataTable = new DataTable();
                    sqlDA.Fill(WorkplaceDataTable);

                    dataGridViewMessages.DataSource = WorkplaceDataTable;
                }

            } // End of else...
        } // End of private void comboBoxQueryChoice_SelectedIndexChanged

        private void DatabaseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
