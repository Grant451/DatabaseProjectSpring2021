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
            master.SetQueries();
            InitializeComponent();
        }

        private void InitializeComboBox()
        {
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully submitted: " + DropDownListSelection.SelectedItem.ToString());
        }

        private void btntest1_Click(object sender, EventArgs e)
        {
            master.test();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            //this.DropDownListSelectionBtn.
            DropDownListSelection.Items.AddRange(master.GetLocation());

            

            btnSubmit.Enabled = true;
        }

        private void DropDownListSelectionBtn(object sender, EventArgs e)
        {
            
        }
    }
}
