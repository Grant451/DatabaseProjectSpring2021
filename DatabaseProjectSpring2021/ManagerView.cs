using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseProjectSpring2021
{
    public partial class ManagerView : Form
    {
        Controller master;

        public ManagerView()
        {
            master = new Controller();//set up the controller
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
        }

        private void btntest1_Click(object sender, EventArgs e)
        {
            master.test();
        }
    }
}
