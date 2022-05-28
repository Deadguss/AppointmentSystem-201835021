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
    public partial class Staff : Form
    {
        SqlConnection con;
        SqlDataReader rdr;
        SqlCommand cmd;
        public Staff()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

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

        private void button3_Click(object sender, EventArgs e)
        {
            string uname = textBox1.Text;
            string pw = textBox2.Text;
            con = new SqlConnection("Data Source =.\\SQLEXPRESS; Initial Catalog = Appointment; Integrated Security = True");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select * from sLog where uname ='" + textBox1.Text + "'And pw='" + textBox2.Text + "'";
            rdr = cmd.ExecuteReader();
            if (textBox1.Text == "aPenny")
            {
                if (rdr.Read())
                {
                    MessageBox.Show("Access accepted");
                    Form1 pen = new Form1();
                    pen.Show();
                    this.Hide();

                }
                else
                {   
                    MessageBox.Show("Access denied");
                }
            }
            if(textBox1.Text=="jGordon"){ 
                if (rdr.Read())
                {
                    MessageBox.Show("Access accepted");
                    Doc1 jg = new Doc1();
                    jg.Show();
                    this.Hide();

                }
            else
            {
                MessageBox.Show("Access denied");
            }
            con.Close();
            }
            

        }
    }
}
