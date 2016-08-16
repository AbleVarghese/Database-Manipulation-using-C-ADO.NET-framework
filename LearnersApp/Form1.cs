using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace StudentInfoDbFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {


            using (var dbContext = new AbleDBEntities())
            {
                var query = from a in dbContext.AbleTBs
                            orderby a.learnerName
                            select new
                            {
                                learnerIdVar = a.learnerId,
                                learnerNameVar = a.learnerName,
                                favoriteTeacherVar = a.favoriteTeacher,
                                coursesRemainingVar = a.coursesRemaining,
                                coursesCompletedVar = a.coursesCompleted,
                            };




                lstDisplay.Items.Clear(); //clear the list
         
                foreach (var item in query)
                {
                  
                    lstDisplay.Items.Add(item.learnerIdVar + "      " + item.learnerNameVar
                      + "      " + item.favoriteTeacherVar + "      " + item.favoriteTeacherVar
                      + "      " + item.coursesRemainingVar + "      " + item.coursesCompletedVar);
                }
            }
        }
    

    //Search from the database -- Fully Working 
    private void btnSearch_Click(object sender, EventArgs e)
    {
        using (var dbContext = new AbleDBEntities())
        {
            int xyz = Convert.ToInt32(learnerIdTextbox.Text);
            var query = from a in dbContext.AbleTBs

                        where a.learnerId == xyz
                        select new
                        {

                            learnerIdVar = a.learnerId,
                            learnerNameVar = a.learnerName,
                            favoriteTeacherVar = a.favoriteTeacher,
                            coursesRemainingVar = a.coursesRemaining,
                            coursesCompletedVar = a.coursesCompleted,



                        };


            foreach (var item in query)
            {
                learnerIdTextbox.Text = item.learnerIdVar.ToString();
                learnerNameTextbox.Text = item.learnerNameVar;
                favoriteTeacherTextbox.Text = item.favoriteTeacherVar;
                coursesRemainingTextbox.Text = item.coursesRemainingVar.ToString();
                coursesCompletedTextbox.Text = item.coursesCompletedVar.ToString();
            }
        }
    }




    //Add item to the database -- fully working
    private void btnAdd_Click(object sender, EventArgs e)
    {
        using (var dbContext = new AbleDBEntities())
        {
            //create an instance of the entity object
            AbleTB student = new AbleTB
            {
                learnerId = Convert.ToInt32(learnerIdTextbox.Text),
                learnerName = learnerNameTextbox.Text,
                favoriteTeacher = favoriteTeacherTextbox.Text,
                coursesRemaining = Convert.ToInt32(coursesRemainingTextbox.Text),
                coursesCompleted = Convert.ToInt32(coursesCompletedTextbox.Text),


            };
            //add the entity to the data context
            dbContext.AbleTBs.Add(student);
            dbContext.AbleTBs.Attach(student);
            dbContext.Entry(student).State = EntityState.Added;
            dbContext.SaveChanges();          
            MessageBox.Show("Saved");
        }
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        AbleTB student;

        //Get customer for the given customerId
        using (var dbContext = new AbleDBEntities())
        {
            int xyz = Convert.ToInt32(learnerIdTextbox.Text);
            student = dbContext.AbleTBs.Where(s => s.learnerId == xyz).FirstOrDefault<AbleTB>();
        }

        // Update customer info in disconnected mode (out of dbContext scope)
        if (student != null)
        {
            student.learnerName = learnerNameTextbox.Text;
            //  student.lastName = tbLastName.Text;
        }

        // Save modified entity using new Context
        using (var dbContext = new AbleDBEntities())
        {
            // Mark entity as modified
            dbContext.Entry(student).State = EntityState.Modified;

            // Save changes to database
            dbContext.SaveChanges();
        }
        MessageBox.Show("Updated");
    }



    private void btnDelete_Click(object sender, EventArgs e)
    {
        AbleTB studentToDelete;
        //Get student for the given studentId
        using (var dbContext = new AbleDBEntities())
        {
            int xyz = Convert.ToInt32(learnerIdTextbox.Text);
            studentToDelete = dbContext.AbleTBs.Where(s => s.learnerId == xyz).FirstOrDefault<AbleTB>();
        }

        //Create new context for disconnected scenario
        using (var newContext = new AbleDBEntities())
        {
            newContext.Entry(studentToDelete).State = EntityState.Deleted;

            newContext.SaveChanges();
        }
    }


}
}
