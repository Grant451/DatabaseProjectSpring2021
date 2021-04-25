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
        private RadioButton selectedrbGeneral;
        private RadioButton selectedrbSpecific;
        private string currentView = "Customers";
        private TextBox textBox;

        public ManagerView()
        {
            master = new Controller();//set up the controller
            master.SetQueries();
            InitializeComponent();
            InitializeRadioButtons();
            InitializeTextBox();

            //textBox = uxDisplayQueryCusTB
        }

        private void InitializeComboBox()
        {
        }

        private void InitializeRadioButtons()
        {
            // General Customer RB
            this.uxDisplayAllCustomersRB.CheckedChanged += new EventHandler(radioButtonG_CheckedChanged);
            this.uxDisplaySpecificCustomerRB.CheckedChanged += new EventHandler(radioButtonG_CheckedChanged);
            this.uxDisplaySpecificVehicleRB.CheckedChanged += new EventHandler(radioButtonG_CheckedChanged);
            // Specific Customer RB
            this.uxDisplayPastRepairsCusRB.CheckedChanged += new EventHandler(radioButtonS_CheckedChanged);
            this.uxDisplayRepeatedRepairsCusRB.CheckedChanged += new EventHandler(radioButtonS_CheckedChanged);
            this.uxDisplayUpcomingApptCusRB.CheckedChanged += new EventHandler(radioButtonS_CheckedChanged);

        }

        private void InitializeTextBox()
        {
            this.uxTabControl.Selected += new TabControlEventHandler(textBox_Changed);
        }

        private void radioButtonG_CheckedChanged(object sender, EventArgs e)
        {
            // Empty query result text box
            uxDisplayQueryCusTB.Text = "";
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                selectedrbGeneral = rb;

                if (selectedrbGeneral.Name == "uxDisplaySpecificCustomerRB")
                {
                    uxSelectCusTB.Visible = true;
                    uxDisplayPastRepairsCusRB.Visible = true;
                }
                else if (selectedrbGeneral.Name == "uxDisplaySpecificVehicleRB")
                {
                    uxDisplayPastRepairsCusRB.Visible = true;
                }
                else
                {
                    uxSelectCusTB.Visible = false;
                    uxDisplayPastRepairsCusRB.Visible = false ;
                }

            }
        }

        private void radioButtonS_CheckedChanged(object sender, EventArgs e)
        {
            // Empty query result text box
            uxDisplayQueryCusTB.Text = "";
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                selectedrbSpecific = rb;

            }
        }

        private void textBox_Changed(object sender, TabControlEventArgs e)
        {
            int index = e.TabPageIndex;
            switch (index)
            {
                case 0:
                    textBox = uxDisplayQueryCusTB;
                    break;
            }     
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

        private void uxExcecuteCusButtn_Click(object sender, EventArgs e)
        {
            // Empty query result text box
            uxDisplayQueryCusTB.Text = "";
            string rb1 = "";
            string rb2 = "";
            if (selectedrbGeneral != null)
                 rb1 = selectedrbGeneral.Tag.ToString();

            if (selectedrbSpecific != null)
                rb2 = selectedrbSpecific.Tag.ToString();

            // the list returned by the query
            //List<String> result = new List<string>();
            String queryResult = "";

            switch (currentView)
            {
                case ("Customers"):
                    queryResult = master.CustomerTabQueries(rb1, rb2).ToString();
                    break;
            }

            uxDisplayQueryCusTB.AppendText(queryResult);
            /*
            string display = "";
            foreach (var res in result)
            {
                //display += res;
                //display += "\n";
                uxDisplayQueryCusTB.AppendText(res);
                uxDisplayQueryCusTB.AppendText(Environment.NewLine);
            }
            //uxDisplayQueryCusTB.Text = display;
            //= result.ToArray()
            //Console.WriteLine(selectedrbLeft.Name);
            */
        }

    }
}
