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
        //private TextBox textBox;

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

            // General Employee RB
            this.uxDisplayAllEmployeesRB.CheckedChanged += new EventHandler(radioButtonG_CheckedChanged);
            this.uxDisplaySpecificEmployeeRB.CheckedChanged += new EventHandler(radioButtonG_CheckedChanged);
            // Specific Employee RB
            this.uxDisplayPastRepairsEmpRB.CheckedChanged += new EventHandler(radioButtonS_CheckedChanged);
            this.uxDisplayRepairCountsEmpRB.CheckedChanged += new EventHandler(radioButtonS_CheckedChanged);
            this.uxDisplayLocationEmpRB.CheckedChanged += new EventHandler(radioButtonS_CheckedChanged);
            this.uxDisplayUpcomingApptEmpRB.CheckedChanged += new EventHandler(radioButtonS_CheckedChanged);
        }

        private void InitializeTextBox()
        {
            this.uxTabControl.Selected += new TabControlEventHandler(textBox_Changed);
        }

        private void radioButtonG_CheckedChanged(object sender, EventArgs e)
        {
            // Empty query result text box
            uxDisplayQueryCusTB.Text = "";
            uxDisplayQueryEmpTB.Text = "";
            // Empty customer name text box
            uxSelectCusTB.Text = "";
            // Empty vin Number text box
            uxSelectVehicleTB.Text = "";

            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                selectedrbGeneral = rb;


                if(currentView == "Customers")
                {
                    selectedrbSpecific = null;
                    uxDisplayPastRepairsCusRB.Checked = false;
                    uxDisplayRepeatedRepairsCusRB.Checked = false;

                    if (selectedrbGeneral.Tag.ToString() == "DisplaySpecificCustomer")
                    {
                        uxSelectCusTB.Visible = true;
                        uxSelectVehicleTB.Visible = false;
                        uxDisplayPastRepairsCusRB.Visible = true;
                        uxDisplayRepeatedRepairsCusRB.Visible = true;
                    }
                    else if (selectedrbGeneral.Tag.ToString() == "DisplaySpecificVehicle")
                    {
                        uxSelectVehicleTB.Visible = true;
                        uxSelectCusTB.Visible = false;
                        uxDisplayPastRepairsCusRB.Visible = true;
                        uxDisplayRepeatedRepairsCusRB.Visible = false;

                        if (selectedrbSpecific != null)
                        {
                            if (selectedrbSpecific.Tag.ToString() == "DisplayRepeatedRepairs")
                                selectedrbSpecific = null;
                        }
                    }
                    else
                    {
                        uxDisplayRepeatedRepairsCusRB.Visible = true;
                        uxSelectVehicleTB.Visible = false;
                        uxSelectCusTB.Visible = false;
                        uxDisplayPastRepairsCusRB.Visible = false;

                    }
                }
                
                else if (currentView == "Employees")
                {
                    selectedrbSpecific = null;
                    uxDisplayPastRepairsEmpRB.Checked = false;
                    uxDisplayLocationEmpRB.Checked = false;
                    uxDisplayRepairCountsEmpRB.Checked = false;

                    if (selectedrbGeneral.Tag.ToString() == "DisplayAllEmployees")
                    {
                        uxDisplayRepairCountsEmpRB.Visible = true;
                        uxSelectEmpTB.Visible = false;
                        uxDisplayLocationEmpRB.Visible = false;
                        uxDisplayPastRepairsEmpRB.Visible = false;
                        

                    }
                    else if (selectedrbGeneral.Tag.ToString() == "DisplaySpecificEmployee")
                    {
                        uxSelectEmpTB.Visible = true;
                        uxDisplayLocationEmpRB.Visible = true;
                        uxDisplayRepairCountsEmpRB.Visible = true;
                        uxDisplayPastRepairsEmpRB.Visible = true;
                    }
                }
            }
        }

        private void radioButtonS_CheckedChanged(object sender, EventArgs e)
        {
            // Empty query result text box
            uxDisplayQueryCusTB.Text = "";
            uxDisplayQueryEmpTB.Text = "";
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
                    //textBox = uxDisplayQueryCusTB;
                    currentView = "Customers";
                    break;
                case 1:
                    currentView = "Employees";
                    break;
                case 2:
                    currentView = "Locations";
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
            string input = "";

            if (selectedrbGeneral != null)
                 rb1 = selectedrbGeneral.Tag.ToString();
            if (selectedrbSpecific != null)
                rb2 = selectedrbSpecific.Tag.ToString();

            if (uxSelectCusTB.Text != "")
                input = uxSelectCusTB.Text;
            else if (uxSelectVehicleTB.Text != "")
                input = uxSelectVehicleTB.Text;

            // the string returned by the query
            String queryResult = "";

            queryResult = master.CustomerTabQueries(rb1, rb2, input).ToString();
            uxDisplayQueryCusTB.AppendText(queryResult);

        }

        private void uxExcecuteEmpBttn_Click(object sender, EventArgs e)
        {
            // Empty query result text box
            uxDisplayQueryEmpTB.Text = "";
            string rb1 = "";
            string rb2 = "";
            string input = "";

            if (selectedrbGeneral != null)
                rb1 = selectedrbGeneral.Tag.ToString();
            if (selectedrbSpecific != null)
                rb2 = selectedrbSpecific.Tag.ToString();

            if (uxSelectEmpTB.Text != "")
                input = uxSelectEmpTB.Text;

            // the string returned by the query
            List<string> queryResult = new List<string>();

            queryResult = master.EmployeeTabQueries(rb1, rb2, input);

            foreach (string s in queryResult)
            {
                uxDisplayQueryEmpTB.AppendText(s);

            }
        }

        private void uxExcecuteLocBttn_Click(object sender, EventArgs e)
        {
            // Empty query result text box
            uxDisplayQueryLocTB.Text = "";
            string rb1 = "";
            string rb2 = "";
            string input = "";

            if (selectedrbGeneral != null)
                rb1 = selectedrbGeneral.Tag.ToString();
            if (selectedrbSpecific != null)
                rb2 = selectedrbSpecific.Tag.ToString();

            if (uxSelectEmpTB.Text != "")
                input = uxSelectEmpTB.Text;

            // the string returned by the query
            string queryResult = "";

            queryResult = master.LocationTabQueries(rb1, rb2, input).ToString();

            uxDisplayQueryLocTB.AppendText(queryResult);
        }
    }
}
