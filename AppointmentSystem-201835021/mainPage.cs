using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointmentSystem_201835021
{
    public partial class mainPage : Form
    {
        public mainPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Appointment a = new Appointment();
            a.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Staff s = new Staff();
            s.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
