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
        private RadioButton selectedrb;
        private TextBox textBox;

        public ManagerView()
        {
            master = new Controller();//set up the controller
            master.SetQueries();
            InitializeComponent();
            InitializeRadioButtons();

            //textBox = uxDisplayQueryCusTB
        }

        private void InitializeComboBox()
        {
        }

        private void InitializeRadioButtons()
        {
            this.uxDisplayUpcomingApptCustRB.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
        }

        private void InitializeTextBox()
        {
            //this.uxTabControl.Selected += new EventHandler(textBox_Changed);
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                selectedrb = rb;

            }
        }

        private void textBox_Changed(object sender, TabControlEventArgs e)
        {
            Console.WriteLine(e.TabPageIndex);
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

        private void uxExcecuteCusBttn_Click(object sender, EventArgs e)
        {
            master.test();
        }
    }
}
