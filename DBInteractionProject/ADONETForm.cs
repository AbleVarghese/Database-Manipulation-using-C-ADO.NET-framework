/*/++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
Name : Able Varghese
Student No: 300 806 936
Program: Database CRUD operations using ADO.NET framework
 * //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++*/
        

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

//This is the namespace **
namespace DBInteractionProject
{
    public partial class LearnerInformation : Form
    {
      

  
        SqlDataReader custReader;
        SqlConnection conn;



        public LearnerInformation()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {              

        }
        
        
//SQL connection function
        private static SqlConnection GetConnection()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            builder.ConnectionString=@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\AbleDB.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection conn = new SqlConnection(builder.ConnectionString);

            return conn;
        }

//Adding new row function
        private void addButton_Click(object sender, EventArgs e)
        {
           
            try
            {
                //create a connection with Northwind database
                SqlConnection conn = GetConnection();
                conn.Open();
                //insert the data
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT into AbleTB(learnerId,learnerName,favoriteTeacher,coursesRemaining,coursesCompleted) VALUES(@learnerId, @learnerName, @favoriteTeacher, @coursesRemaining, @coursesCompleted);"; 
               

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@learnerId", learnerId.Text));
                cmd.Parameters.Add(new SqlParameter("@learnerName", learnerName.Text));
                cmd.Parameters.Add(new SqlParameter("@favoriteTeacher", favoriteTeacher.Text));
                cmd.Parameters.Add(new SqlParameter("@coursesRemaining", coursesRemaining.Text));
                cmd.Parameters.Add(new SqlParameter("@coursesCompleted", coursesCompleted.Text));
                //
                cmd.ExecuteNonQuery();
                MessageBox.Show("Row inserted");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


//Clear fields
        private void clear_Click(object sender, EventArgs e)
        {
            clearBoxes();

        }


        private void clearBoxes()
        {
            learnerId.Text = "";
            learnerName.Text = "";
            favoriteTeacher.Text = "";
            coursesRemaining.Text = "";
            coursesCompleted.Text = "";
            learnerIdSearch.Text = "";
            learnerIdDelete.Text = "";
            learnerId.Focus();
            
        }


//Updare Application function
        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                //create a connection with Customer database
                SqlConnection conn = GetConnection();
                conn.Open();
                //update the data
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "Update AbleTB Set learnerId=@learnerId,learnerName=@learnerName,favoriteTeacher=@favoriteTeacher,coursesRemaining=@coursesRemaining,coursesCompleted=@coursesCompleted WHERE learnerId = @learnerId;"; 
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@learnerId", learnerId.Text));
                cmd.Parameters.Add(new SqlParameter("@learnerName", learnerName.Text));
                cmd.Parameters.Add(new SqlParameter("@favoriteTeacher", favoriteTeacher.Text));
                cmd.Parameters.Add(new SqlParameter("@coursesRemaining", coursesRemaining.Text));
                cmd.Parameters.Add(new SqlParameter("@coursesCompleted", coursesCompleted.Text));
                
                //
                cmd.ExecuteNonQuery();
                MessageBox.Show("Row Updated");
                conn.Close();
            }
            catch (Exception ex)
            {
                //System.Diagnostics.Debug.WriteLine(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }


//Exit application function
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

//Search Function
        private void searchButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Here");
            try
            {
                conn = GetConnection();
                conn.Open();

                // create an SQL command
                SqlCommand CustCmd = new SqlCommand();
                CustCmd.Connection = conn;
                //CustCmd.CommandText = "SELECT * from Customer";

                CustCmd.CommandText = "SELECT * from AbleTB where learnerId=@learnerId";
                int learnerIdVar = Convert.ToInt32(learnerIdSearch.Text); //just hard coded value
                //setting up the parameter
                CustCmd.Parameters.Add(new SqlParameter("@learnerId", learnerIdVar));
                // 
                // create a DataReader
                custReader = CustCmd.ExecuteReader();
                if(!custReader.Read()) //no rows in the reader object
                    clearBoxes();
                else

                // Display the first row
                {
                    learnerId.Text = custReader.GetInt32(0).ToString();
                    learnerName.Text = custReader.GetString(1);
                    favoriteTeacher.Text = custReader.GetString(2);
                    coursesRemaining.Text = custReader.GetInt32(3).ToString();
                    coursesCompleted.Text = custReader.GetInt32(4).ToString();

                }
                custReader.Close();
                conn.Close();
            }
                 
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                //create a connection with Customer database
                SqlConnection conn = GetConnection();
                conn.Open();
                //update the data
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "Delete from AbleTB WHERE learnerId = @learnerId;";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@learnerId", learnerIdDelete.Text));
            

                //
                cmd.ExecuteNonQuery();
                MessageBox.Show("Row Deleted");
                conn.Close();
            }
            catch (Exception ex)
            {
                //System.Diagnostics.Debug.WriteLine(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

}
}
