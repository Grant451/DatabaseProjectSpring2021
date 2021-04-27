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

        public ManagerView()
        {
            master = new Controller(); // set up the controller
            master.SetQueries();
            InitializeComponent();
            InitializeRadioButtons();
            InitializeTextBox();

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

            // General Location RB
            this.uxDisplayAllLocationsRB.CheckedChanged += new EventHandler(radioButtonG_CheckedChanged);
            this.uxDisplaySpecificLocationRB.CheckedChanged += new EventHandler(radioButtonG_CheckedChanged);
            // Specific Location RB
            this.uxDisplayInventoryLocRB.CheckedChanged += new EventHandler(radioButtonS_CheckedChanged);
            this.uxDisplaySalesLocRB.CheckedChanged += new EventHandler(radioButtonS_CheckedChanged);
            this.uxDisplayUpcomingApptLocRB.CheckedChanged += new EventHandler(radioButtonS_CheckedChanged);

            // General Repairs RB
            this.uxDisplayPart.CheckedChanged += new EventHandler(radioButtonG_CheckedChanged);
            this.uxDisplayRepair.CheckedChanged += new EventHandler(radioButtonG_CheckedChanged);
            //Specific Repairs RB
            this.uxDisplayPrice.CheckedChanged += new EventHandler(radioButtonS_CheckedChanged);
            this.uxDisplayQuantity.CheckedChanged += new EventHandler(radioButtonS_CheckedChanged);

            // Report RB
            this.uxDisplayPopApptTimes.CheckedChanged += new EventHandler(radioButtonReport_CheckedChanged);
            this.uxDisplayUpcomingAppt.CheckedChanged += new EventHandler(radioButtonReport_CheckedChanged);
            this.uxDisplayPastAppt.CheckedChanged += new EventHandler(radioButtonReport_CheckedChanged);
        }

        private void InitializeTextBox()
        {
            this.uxTabControl.Selected += new TabControlEventHandler(textBox_Changed);
        }

        private void radioButtonG_CheckedChanged(object sender, EventArgs e)
        {
            ClearTB();
            
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                selectedrbGeneral = rb;

                selectedrbSpecific = null;

                ClearSpecificRB();


                if (currentView == "Customers")
                {

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
                else if (currentView == "Locations")
                { 

                    if (selectedrbGeneral.Tag.ToString() == "DisplaySpecificLocation")
                    {
                        uxSelectLocTB.Visible = true;
                    }
                    else
                    {
                        uxSelectLocTB.Visible = false;
                    }
                }
                else if (currentView == "Repairs")
                {
                    if (selectedrbGeneral.Tag.ToString() == "DisplayPart")
                    {
                        uxSelectPartTB.Visible = true;
                        uxDisplayPrice.Visible = true;
                        uxDisplayQuantity.Visible = true;
                        uxSelectRepairTB.Visible = false;
                    }
                    else
                    {
                        uxSelectRepairTB.Visible = true;
                        uxSelectPartTB.Visible = false;
                        uxDisplayPrice.Visible = false;
                        uxDisplayQuantity.Visible = false;
                    }
                }
            }
        }

        private void radioButtonS_CheckedChanged(object sender, EventArgs e)
        {
            // Empty query result text box
            uxDisplayQueryCus.Clear();
            uxDisplayQueryEmp.Clear();
            uxDisplayQueryLoc.Clear();

            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                selectedrbSpecific = rb;

            }
        }

        private void radioButtonReport_CheckedChanged(object sender, EventArgs e)
        {
            uxDisplayQueryReport.Cear();
        }

        private void textBox_Changed(object sender, TabControlEventArgs e)
        {
            // Uncheck all buttons and clear all text boxes
            // Customer
            ClearGeneralRB();
            ClearSpecificRB();
            ClearTB();
            
            int index = e.TabPageIndex;
            switch (index)
            {
                case 0:
                    currentView = "Customers";
                    break;
                case 1:
                    currentView = "Employees";
                    break;
                case 2:
                    currentView = "Locations";
                    break;
                case 3:
                    currentView = "Repairs";
                    break;
            }     
        }

        private void ClearGeneralRB()
        {
            // Customer
            uxDisplayAllCustomersRB.Checked = false;
            uxDisplaySpecificCustomerRB.Checked = false;

            // Employee
            uxDisplayAllEmployeesRB.Checked = false;
            uxDisplaySpecificEmployeeRB.Checked = false;

            //Location
            uxDisplayAllLocationsRB.Checked = false;
            uxDisplaySpecificLocationRB.Checked = false;

            // Repair
            uxDisplayPart.Checked = false;
            uxDisplayRepair.Checked = false;
        }

        private void ClearSpecificRB()
        {
            // Customer
            uxDisplayPastRepairsCusRB.Checked = false;
            uxDisplayRepeatedRepairsCusRB.Checked = false;

            // Employee 
            uxDisplayPastRepairsEmpRB.Checked = false;
            uxDisplayLocationEmpRB.Checked = false;
            uxDisplayRepairCountsEmpRB.Checked = false;

            // Location 
            uxDisplayInventoryLocRB.Checked = false;
            uxDisplaySalesLocRB.Checked = false;
            uxDisplayUpcomingApptLocRB.Checked = false;

            //Repair
            uxDisplayPrice.Checked = false;
            uxDisplayQuantity.Checked = false;
        }

        private void ClearTB()
        {
            // Customer
            uxDisplayQueryCus.Clear();
            uxSelectCusTB.Text = "";
            uxSelectVehicleTB.Text = "";

            // Employee
            uxDisplayQueryEmp.Clear();
            uxSelectEmpTB.Text = "";

            // Location
            uxDisplayQueryLoc.Clear();
            uxSelectLocTB.Text = "";

            // Repair
            uxDisplayQueryRep.Clear();
            uxSelectPartTB.Text = "";
            uxSelectRepairTB.Text = "";
        }


        private void btntest1_Click(object sender, EventArgs e)
        {

            master.test();
        }

        private void DropDownListSelectionBtn(object sender, EventArgs e)
        {
            
        }

        private void uxExcecuteCusButtn_Click(object sender, EventArgs e)
        {
            // Empty query result text box
            uxDisplayQueryCus.Clear();
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

            uxDisplayQueryCus.View = View.Details;

            string[][] queryResult;
            queryResult = master.CustomerTabQueries(rb1, rb2, input);

            if (queryResult[0] == null)
                return;

            // calculate col width based on number of headings
            int colWidth = (1055 / 2) / queryResult[0].Length;
            // set columns
            for (int i = 0; i < queryResult[0].Length; i++)
            {
                uxDisplayQueryCus.Columns.Add(queryResult[0][i], colWidth);
            }

            foreach (string[] arr in queryResult.Skip(1))
            {
                ListViewItem itm = new ListViewItem(arr);
                uxDisplayQueryCus.Items.Add(itm);
            }

        }

        private void uxExcecuteEmpBttn_Click(object sender, EventArgs e)
        {
            // Empty query result text box
            uxDisplayQueryEmp.Clear();
            string rb1 = "";
            string rb2 = "";
            string input = "";

            if (selectedrbGeneral != null)
                rb1 = selectedrbGeneral.Tag.ToString();
            if (selectedrbSpecific != null)
                rb2 = selectedrbSpecific.Tag.ToString();

            if (uxSelectEmpTB.Text != "")
                input = uxSelectEmpTB.Text;

            uxDisplayQueryEmp.View = View.Details;

            string[][] queryResult;
            queryResult = master.EmployeeTabQueries(rb1, rb2, input);

            if (queryResult[0] != null)
            {
                // calculate col width based on number of headings
                int colWidth = (1055 / 2) / queryResult[0].Length;
                // set columns
                for (int i = 0; i < queryResult[0].Length; i++)
                {
                    uxDisplayQueryEmp.Columns.Add(queryResult[0][i], colWidth);
                }
            }

            foreach (string[] arr in queryResult.Skip(1))
            {
                ListViewItem itm = new ListViewItem(arr);
                uxDisplayQueryEmp.Items.Add(itm);
            }
        }

        private void uxExcecuteLocBttn_Click(object sender, EventArgs e)
        {
            // Empty query result text box
            uxDisplayQueryLoc.Clear();
            string rb1 = "";
            string rb2 = "";
            string input = "";

            if (selectedrbGeneral != null)
                rb1 = selectedrbGeneral.Tag.ToString();
            if (selectedrbSpecific != null)
                rb2 = selectedrbSpecific.Tag.ToString();

            if (uxSelectLocTB.Text != "")
                input = uxSelectLocTB.Text;

            uxDisplayQueryLoc.View = View.Details;

            string[][] queryResult;
            queryResult = master.LocationTabQueries(rb1, rb2, input);

            if (queryResult[0] != null)
            {
                // calculate col width based on number of headings
                int colWidth = (1055 / 2) / queryResult[0].Length;
                // set columns
                for (int i = 0; i < queryResult[0].Length; i++)
                {
                    uxDisplayQueryLoc.Columns.Add(queryResult[0][i], colWidth);
                }
            }
            
            foreach (string[] arr in queryResult.Skip(1))
            {
                ListViewItem itm = new ListViewItem(arr);
                uxDisplayQueryLoc.Items.Add(itm);
            }
            
        }

        private void uxExcecuteRepBttn_Click(object sender, EventArgs e)
        {
            // Empty query result text box
            uxDisplayQueryRep.Clear();
            string rb1 = "";
            string rb2 = "";
            string input = "";

            if (selectedrbGeneral != null)
                rb1 = selectedrbGeneral.Tag.ToString();
            if (selectedrbSpecific != null)
                rb2 = selectedrbSpecific.Tag.ToString();

            if (uxSelectPartTB.Text != "")
                input = uxSelectPartTB.Text;
            else if (uxSelectRepairTB.Text != "")
                input = uxSelectRepairTB.Text;

            uxDisplayQueryRep.View = View.Details;

            string[][] queryResult;
            queryResult = master.RepairTabQueries(rb1, rb2, input);

            if (queryResult[0] != null)
            {
                // calculate col width based on number of headings
                int colWidth = (1055 / 2) / queryResult[0].Length;
                // set columns
                for (int i = 0; i < queryResult[0].Length; i++)
                {
                    uxDisplayQueryRep.Columns.Add(queryResult[0][i], colWidth);
                }
            }
            
            foreach (string[] arr in queryResult.Skip(1))
            {
                ListViewItem itm = new ListViewItem(arr);
                uxDisplayQueryRep.Items.Add(itm);
            }

            
        }
    }
}
