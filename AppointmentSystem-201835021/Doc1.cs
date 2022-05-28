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
    public partial class Doc1 : Form
    {
        public Doc1()
        {
            InitializeComponent();
        }

        private void Doc1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            Staff stf = new Staff();
            stf.Show();
            this.Hide();
        }
    }
}
