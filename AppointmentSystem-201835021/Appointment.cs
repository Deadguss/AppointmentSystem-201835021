using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AppointmentSystem_201835021
{
    public partial class Appointment : Form
    {
        public Appointment()
        {
            InitializeComponent();
        }

        static string conString = "Data Source = .\\SQLEXPRESS;Initial Catalog = Appointment; Integrated Security = True"; 
        SqlConnection con = new SqlConnection(conString);
        
        
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                  
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Customer(nam,surname,pNumber,ıdNumber,doc,appo) values (@nam,@surname,@pNumber,@ıdNumber,@doc,@appo)", con);

                    cmd.Parameters.AddWithValue("@nam", textBox1.Text);
                    cmd.Parameters.AddWithValue("@surname", textBox2.Text);
                    cmd.Parameters.AddWithValue("@pNumber", textBox3.Text);
                    cmd.Parameters.AddWithValue("@ıdNumber", textBox4.Text);
                    cmd.Parameters.AddWithValue("@appo", dateTimePicker1.Value.Date);

                    if (radioButton1.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("@doc", "General Practitioner");
                    }
                    if (radioButton2.Checked== true){
                        cmd.Parameters.AddWithValue("@doc", "Dermatologist");
                    }
                    cmd.ExecuteNonQuery();
                    cmd.ToString();
                    MessageBox.Show("Appointment accepted");
                    con.Close();
                    
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Check the answers plase "+error.Message);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainPage f = new mainPage();
            f.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}




//public void save(Student students)
//{

//    try
//    {
//        Connection connection = StudentDb.getConnection();
//        String sql = "İnsert into students(fname , course , price) VALUES (?,?,?)";
//        PreparedStatement ps = connection.prepareStatement(sql);
//        ps.setString(1, students.getFname());
//        ps.setString(2, students.getCourse());
//        ps.setInt(3, students.getPrice());

//        ps.executeUpdate();
//        JOptionPane.showMessageDialog(null, "SAVED ");

//    }
//    catch (Exception e)
//    {
//        JOptionPane.showMessageDialog(null, "ERROR !");
//    }