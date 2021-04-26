namespace DatabaseProjectSpring2021
{
    partial class ManagerView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblstatus = new System.Windows.Forms.Label();
            this.btntest1 = new System.Windows.Forms.Button();
            this.DropDownListSelection = new System.Windows.Forms.ComboBox();
            this.uxTabControl = new System.Windows.Forms.TabControl();
            this.uxCustomersPage = new System.Windows.Forms.TabPage();
            this.uxExcecuteCusButtn = new System.Windows.Forms.Button();
            this.uxDisplayQueryCusTB = new System.Windows.Forms.TextBox();
            this.uxSpecificDisplayCustomerGB = new System.Windows.Forms.GroupBox();
            this.uxDisplayUpcomingApptCusRB = new System.Windows.Forms.RadioButton();
            this.uxDisplayRepeatedRepairsCusRB = new System.Windows.Forms.RadioButton();
            this.uxDisplayPastRepairsCusRB = new System.Windows.Forms.RadioButton();
            this.uxGeneralCustomerDisplayGB = new System.Windows.Forms.GroupBox();
            this.uxSelectVehicleTB = new System.Windows.Forms.TextBox();
            this.uxSelectCusTB = new System.Windows.Forms.TextBox();
            this.uxDisplaySpecificVehicleRB = new System.Windows.Forms.RadioButton();
            this.uxDisplaySpecificCustomerRB = new System.Windows.Forms.RadioButton();
            this.uxDisplayAllCustomersRB = new System.Windows.Forms.RadioButton();
            this.uxEmployeesPage = new System.Windows.Forms.TabPage();
            this.uxExcecuteEmpBttn = new System.Windows.Forms.Button();
            this.uxSpecificEmployeeDisplayGB = new System.Windows.Forms.GroupBox();
            this.uxDisplayUpcomingApptEmpRB = new System.Windows.Forms.RadioButton();
            this.uxDisplayLocationEmpRB = new System.Windows.Forms.RadioButton();
            this.uxDisplayPastRepairsEmpRB = new System.Windows.Forms.RadioButton();
            this.uxDisplayRepairCountsEmpRB = new System.Windows.Forms.RadioButton();
            this.uxGeneralEmployeeDisplayGB = new System.Windows.Forms.GroupBox();
            this.uxSelectEmpTB = new System.Windows.Forms.TextBox();
            this.uxDisplaySpecificEmployeeRB = new System.Windows.Forms.RadioButton();
            this.uxDisplayAllEmployeesRB = new System.Windows.Forms.RadioButton();
            this.uxLocationsPage = new System.Windows.Forms.TabPage();
            this.uxExcecuteLocBttn = new System.Windows.Forms.Button();
            this.uxSpecificDisplayLoc = new System.Windows.Forms.GroupBox();
            this.uxDisplayUpcomingApptLocRB = new System.Windows.Forms.RadioButton();
            this.uxDisplaySalesLocRB = new System.Windows.Forms.RadioButton();
            this.uxDisplayInventoryLocRB = new System.Windows.Forms.RadioButton();
            this.uxGeneralDisplayLoc = new System.Windows.Forms.GroupBox();
            this.uxSelectLocTB = new System.Windows.Forms.TextBox();
            this.uxDisplaySpecificLocationRB = new System.Windows.Forms.RadioButton();
            this.uxDisplayAllLocationsRB = new System.Windows.Forms.RadioButton();
            this.uxPartsPage = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.uxReportsPage = new System.Windows.Forms.TabPage();
            this.RebuildDBBtn = new System.Windows.Forms.Button();
            this.uxDisplayQueryLoc = new System.Windows.Forms.ListView();
            this.uxDisplayQueryEmp = new System.Windows.Forms.ListView();
            this.uxTabControl.SuspendLayout();
            this.uxCustomersPage.SuspendLayout();
            this.uxSpecificDisplayCustomerGB.SuspendLayout();
            this.uxGeneralCustomerDisplayGB.SuspendLayout();
            this.uxEmployeesPage.SuspendLayout();
            this.uxSpecificEmployeeDisplayGB.SuspendLayout();
            this.uxGeneralEmployeeDisplayGB.SuspendLayout();
            this.uxLocationsPage.SuspendLayout();
            this.uxSpecificDisplayLoc.SuspendLayout();
            this.uxGeneralDisplayLoc.SuspendLayout();
            this.uxPartsPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(26, 852);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(148, 48);
            this.btnsearch.TabIndex = 1;
            this.btnsearch.Text = "search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Location = new System.Drawing.Point(201, 852);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(148, 48);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Location = new System.Drawing.Point(736, 169);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(0, 25);
            this.lblstatus.TabIndex = 7;
            // 
            // btntest1
            // 
            this.btntest1.Location = new System.Drawing.Point(786, 807);
            this.btntest1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btntest1.Name = "btntest1";
            this.btntest1.Size = new System.Drawing.Size(252, 112);
            this.btntest1.TabIndex = 8;
            this.btntest1.Text = "test query";
            this.btntest1.UseVisualStyleBackColor = true;
            this.btntest1.Click += new System.EventHandler(this.btntest1_Click);
            // 
            // DropDownListSelection
            // 
            this.DropDownListSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDownListSelection.FormattingEnabled = true;
            this.DropDownListSelection.Location = new System.Drawing.Point(417, 861);
            this.DropDownListSelection.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.DropDownListSelection.Name = "DropDownListSelection";
            this.DropDownListSelection.Size = new System.Drawing.Size(239, 33);
            this.DropDownListSelection.TabIndex = 9;
            this.DropDownListSelection.SelectedIndexChanged += new System.EventHandler(this.DropDownListSelectionBtn);
            // 
            // uxTabControl
            // 
            this.uxTabControl.Controls.Add(this.uxCustomersPage);
            this.uxTabControl.Controls.Add(this.uxEmployeesPage);
            this.uxTabControl.Controls.Add(this.uxLocationsPage);
            this.uxTabControl.Controls.Add(this.uxPartsPage);
            this.uxTabControl.Controls.Add(this.uxReportsPage);
            this.uxTabControl.ItemSize = new System.Drawing.Size(115, 35);
            this.uxTabControl.Location = new System.Drawing.Point(3, 12);
            this.uxTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxTabControl.Name = "uxTabControl";
            this.uxTabControl.SelectedIndex = 0;
            this.uxTabControl.Size = new System.Drawing.Size(1106, 759);
            this.uxTabControl.TabIndex = 10;
            // 
            // uxCustomersPage
            // 
            this.uxCustomersPage.Controls.Add(this.uxExcecuteCusButtn);
            this.uxCustomersPage.Controls.Add(this.uxDisplayQueryCusTB);
            this.uxCustomersPage.Controls.Add(this.uxSpecificDisplayCustomerGB);
            this.uxCustomersPage.Controls.Add(this.uxGeneralCustomerDisplayGB);
            this.uxCustomersPage.Location = new System.Drawing.Point(8, 43);
            this.uxCustomersPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxCustomersPage.Name = "uxCustomersPage";
            this.uxCustomersPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxCustomersPage.Size = new System.Drawing.Size(1090, 623);
            this.uxCustomersPage.TabIndex = 0;
            this.uxCustomersPage.Text = "Customers";
            this.uxCustomersPage.UseVisualStyleBackColor = true;
            // 
            // uxExcecuteCusButtn
            // 
            this.uxExcecuteCusButtn.Location = new System.Drawing.Point(791, 315);
            this.uxExcecuteCusButtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxExcecuteCusButtn.Name = "uxExcecuteCusButtn";
            this.uxExcecuteCusButtn.Size = new System.Drawing.Size(197, 69);
            this.uxExcecuteCusButtn.TabIndex = 12;
            this.uxExcecuteCusButtn.Text = "Excecute";
            this.uxExcecuteCusButtn.UseVisualStyleBackColor = true;
            this.uxExcecuteCusButtn.Click += new System.EventHandler(this.uxExcecuteCusButtn_Click);
            // 
            // uxDisplayQueryCusTB
            // 
            this.uxDisplayQueryCusTB.Location = new System.Drawing.Point(30, 401);
            this.uxDisplayQueryCusTB.Multiline = true;
            this.uxDisplayQueryCusTB.Name = "uxDisplayQueryCusTB";
            this.uxDisplayQueryCusTB.ReadOnly = true;
            this.uxDisplayQueryCusTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uxDisplayQueryCusTB.Size = new System.Drawing.Size(985, 191);
            this.uxDisplayQueryCusTB.TabIndex = 4;
            this.uxDisplayQueryCusTB.WordWrap = false;
            // 
            // uxSpecificDisplayCustomerGB
            // 
            this.uxSpecificDisplayCustomerGB.Controls.Add(this.uxDisplayUpcomingApptCusRB);
            this.uxSpecificDisplayCustomerGB.Controls.Add(this.uxDisplayRepeatedRepairsCusRB);
            this.uxSpecificDisplayCustomerGB.Controls.Add(this.uxDisplayPastRepairsCusRB);
            this.uxSpecificDisplayCustomerGB.Location = new System.Drawing.Point(563, 32);
            this.uxSpecificDisplayCustomerGB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxSpecificDisplayCustomerGB.Name = "uxSpecificDisplayCustomerGB";
            this.uxSpecificDisplayCustomerGB.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxSpecificDisplayCustomerGB.Size = new System.Drawing.Size(425, 232);
            this.uxSpecificDisplayCustomerGB.TabIndex = 3;
            this.uxSpecificDisplayCustomerGB.TabStop = false;
            this.uxSpecificDisplayCustomerGB.Text = "Specific Display";
            // 
            // uxDisplayUpcomingApptCusRB
            // 
            this.uxDisplayUpcomingApptCusRB.AutoSize = true;
            this.uxDisplayUpcomingApptCusRB.Location = new System.Drawing.Point(17, 164);
            this.uxDisplayUpcomingApptCusRB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxDisplayUpcomingApptCusRB.Name = "uxDisplayUpcomingApptCusRB";
            this.uxDisplayUpcomingApptCusRB.Size = new System.Drawing.Size(353, 29);
            this.uxDisplayUpcomingApptCusRB.TabIndex = 2;
            this.uxDisplayUpcomingApptCusRB.Tag = "DisplayUpcomingAppointments";
            this.uxDisplayUpcomingApptCusRB.Text = "Display Upcoming Appointments";
            this.uxDisplayUpcomingApptCusRB.UseVisualStyleBackColor = true;
            this.uxDisplayUpcomingApptCusRB.Visible = false;
            // 
            // uxDisplayRepeatedRepairsCusRB
            // 
            this.uxDisplayRepeatedRepairsCusRB.AutoSize = true;
            this.uxDisplayRepeatedRepairsCusRB.Location = new System.Drawing.Point(17, 51);
            this.uxDisplayRepeatedRepairsCusRB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxDisplayRepeatedRepairsCusRB.Name = "uxDisplayRepeatedRepairsCusRB";
            this.uxDisplayRepeatedRepairsCusRB.Size = new System.Drawing.Size(293, 29);
            this.uxDisplayRepeatedRepairsCusRB.TabIndex = 1;
            this.uxDisplayRepeatedRepairsCusRB.Tag = "DisplayRepeatedRepairs";
            this.uxDisplayRepeatedRepairsCusRB.Text = "Display Repeated Repairs";
            this.uxDisplayRepeatedRepairsCusRB.UseVisualStyleBackColor = true;
            // 
            // uxDisplayPastRepairsCusRB
            // 
            this.uxDisplayPastRepairsCusRB.AutoSize = true;
            this.uxDisplayPastRepairsCusRB.Location = new System.Drawing.Point(17, 106);
            this.uxDisplayPastRepairsCusRB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxDisplayPastRepairsCusRB.Name = "uxDisplayPastRepairsCusRB";
            this.uxDisplayPastRepairsCusRB.Size = new System.Drawing.Size(243, 29);
            this.uxDisplayPastRepairsCusRB.TabIndex = 0;
            this.uxDisplayPastRepairsCusRB.TabStop = true;
            this.uxDisplayPastRepairsCusRB.Tag = "DisplayPastRepairs";
            this.uxDisplayPastRepairsCusRB.Text = "Display Past Repairs";
            this.uxDisplayPastRepairsCusRB.UseVisualStyleBackColor = true;
            this.uxDisplayPastRepairsCusRB.Visible = false;
            // 
            // uxGeneralCustomerDisplayGB
            // 
            this.uxGeneralCustomerDisplayGB.Controls.Add(this.uxSelectVehicleTB);
            this.uxGeneralCustomerDisplayGB.Controls.Add(this.uxSelectCusTB);
            this.uxGeneralCustomerDisplayGB.Controls.Add(this.uxDisplaySpecificVehicleRB);
            this.uxGeneralCustomerDisplayGB.Controls.Add(this.uxDisplaySpecificCustomerRB);
            this.uxGeneralCustomerDisplayGB.Controls.Add(this.uxDisplayAllCustomersRB);
            this.uxGeneralCustomerDisplayGB.Location = new System.Drawing.Point(49, 32);
            this.uxGeneralCustomerDisplayGB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxGeneralCustomerDisplayGB.Name = "uxGeneralCustomerDisplayGB";
            this.uxGeneralCustomerDisplayGB.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxGeneralCustomerDisplayGB.Size = new System.Drawing.Size(425, 303);
            this.uxGeneralCustomerDisplayGB.TabIndex = 2;
            this.uxGeneralCustomerDisplayGB.TabStop = false;
            this.uxGeneralCustomerDisplayGB.Text = "General Display";
            // 
            // uxSelectVehicleTB
            // 
            this.uxSelectVehicleTB.Location = new System.Drawing.Point(52, 246);
            this.uxSelectVehicleTB.Name = "uxSelectVehicleTB";
            this.uxSelectVehicleTB.Size = new System.Drawing.Size(238, 31);
            this.uxSelectVehicleTB.TabIndex = 4;
            this.uxSelectVehicleTB.Text = "Enter Vin Number";
            this.uxSelectVehicleTB.Visible = false;
            // 
            // uxSelectCusTB
            // 
            this.uxSelectCusTB.Location = new System.Drawing.Point(52, 151);
            this.uxSelectCusTB.Name = "uxSelectCusTB";
            this.uxSelectCusTB.Size = new System.Drawing.Size(238, 31);
            this.uxSelectCusTB.TabIndex = 3;
            this.uxSelectCusTB.Text = "Enter Customer Name";
            this.uxSelectCusTB.Visible = false;
            // 
            // uxDisplaySpecificVehicleRB
            // 
            this.uxDisplaySpecificVehicleRB.AutoSize = true;
            this.uxDisplaySpecificVehicleRB.Location = new System.Drawing.Point(17, 203);
            this.uxDisplaySpecificVehicleRB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxDisplaySpecificVehicleRB.Name = "uxDisplaySpecificVehicleRB";
            this.uxDisplaySpecificVehicleRB.Size = new System.Drawing.Size(273, 29);
            this.uxDisplaySpecificVehicleRB.TabIndex = 2;
            this.uxDisplaySpecificVehicleRB.Tag = "DisplaySpecificVehicle";
            this.uxDisplaySpecificVehicleRB.Text = "Display Specific Vehicle";
            this.uxDisplaySpecificVehicleRB.UseVisualStyleBackColor = true;
            // 
            // uxDisplaySpecificCustomerRB
            // 
            this.uxDisplaySpecificCustomerRB.AutoSize = true;
            this.uxDisplaySpecificCustomerRB.Location = new System.Drawing.Point(17, 106);
            this.uxDisplaySpecificCustomerRB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxDisplaySpecificCustomerRB.Name = "uxDisplaySpecificCustomerRB";
            this.uxDisplaySpecificCustomerRB.Size = new System.Drawing.Size(294, 29);
            this.uxDisplaySpecificCustomerRB.TabIndex = 1;
            this.uxDisplaySpecificCustomerRB.Tag = "DisplaySpecificCustomer";
            this.uxDisplaySpecificCustomerRB.Text = "Display Specific Customer";
            this.uxDisplaySpecificCustomerRB.UseVisualStyleBackColor = true;
            // 
            // uxDisplayAllCustomersRB
            // 
            this.uxDisplayAllCustomersRB.AutoSize = true;
            this.uxDisplayAllCustomersRB.Location = new System.Drawing.Point(17, 42);
            this.uxDisplayAllCustomersRB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxDisplayAllCustomersRB.Name = "uxDisplayAllCustomersRB";
            this.uxDisplayAllCustomersRB.Size = new System.Drawing.Size(253, 29);
            this.uxDisplayAllCustomersRB.TabIndex = 0;
            this.uxDisplayAllCustomersRB.TabStop = true;
            this.uxDisplayAllCustomersRB.Tag = "DisplayAllCustomers";
            this.uxDisplayAllCustomersRB.Text = "Display All Customers";
            this.uxDisplayAllCustomersRB.UseVisualStyleBackColor = true;
            // 
            // uxEmployeesPage
            // 
            this.uxEmployeesPage.Controls.Add(this.uxDisplayQueryEmp);
            this.uxEmployeesPage.Controls.Add(this.uxExcecuteEmpBttn);
            this.uxEmployeesPage.Controls.Add(this.uxSpecificEmployeeDisplayGB);
            this.uxEmployeesPage.Controls.Add(this.uxGeneralEmployeeDisplayGB);
            this.uxEmployeesPage.Location = new System.Drawing.Point(8, 43);
            this.uxEmployeesPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxEmployeesPage.Name = "uxEmployeesPage";
            this.uxEmployeesPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxEmployeesPage.Size = new System.Drawing.Size(1090, 708);
            this.uxEmployeesPage.TabIndex = 1;
            this.uxEmployeesPage.Text = "Employees";
            this.uxEmployeesPage.UseVisualStyleBackColor = true;
            // 
            // uxExcecuteEmpBttn
            // 
            this.uxExcecuteEmpBttn.Location = new System.Drawing.Point(791, 315);
            this.uxExcecuteEmpBttn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxExcecuteEmpBttn.Name = "uxExcecuteEmpBttn";
            this.uxExcecuteEmpBttn.Size = new System.Drawing.Size(197, 69);
            this.uxExcecuteEmpBttn.TabIndex = 13;
            this.uxExcecuteEmpBttn.Text = "Excecute";
            this.uxExcecuteEmpBttn.UseVisualStyleBackColor = true;
            this.uxExcecuteEmpBttn.Click += new System.EventHandler(this.uxExcecuteEmpBttn_Click);
            // 
            // uxSpecificEmployeeDisplayGB
            // 
            this.uxSpecificEmployeeDisplayGB.Controls.Add(this.uxDisplayUpcomingApptEmpRB);
            this.uxSpecificEmployeeDisplayGB.Controls.Add(this.uxDisplayLocationEmpRB);
            this.uxSpecificEmployeeDisplayGB.Controls.Add(this.uxDisplayPastRepairsEmpRB);
            this.uxSpecificEmployeeDisplayGB.Controls.Add(this.uxDisplayRepairCountsEmpRB);
            this.uxSpecificEmployeeDisplayGB.Location = new System.Drawing.Point(563, 32);
            this.uxSpecificEmployeeDisplayGB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxSpecificEmployeeDisplayGB.Name = "uxSpecificEmployeeDisplayGB";
            this.uxSpecificEmployeeDisplayGB.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxSpecificEmployeeDisplayGB.Size = new System.Drawing.Size(425, 262);
            this.uxSpecificEmployeeDisplayGB.TabIndex = 4;
            this.uxSpecificEmployeeDisplayGB.TabStop = false;
            this.uxSpecificEmployeeDisplayGB.Text = "Specific Display";
            // 
            // uxDisplayUpcomingApptEmpRB
            // 
            this.uxDisplayUpcomingApptEmpRB.AutoSize = true;
            this.uxDisplayUpcomingApptEmpRB.Location = new System.Drawing.Point(17, 216);
            this.uxDisplayUpcomingApptEmpRB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxDisplayUpcomingApptEmpRB.Name = "uxDisplayUpcomingApptEmpRB";
            this.uxDisplayUpcomingApptEmpRB.Size = new System.Drawing.Size(353, 29);
            this.uxDisplayUpcomingApptEmpRB.TabIndex = 3;
            this.uxDisplayUpcomingApptEmpRB.Tag = "DisplayUpcomingAppointments";
            this.uxDisplayUpcomingApptEmpRB.Text = "Display Upcoming Appointments";
            this.uxDisplayUpcomingApptEmpRB.UseVisualStyleBackColor = true;
            this.uxDisplayUpcomingApptEmpRB.Visible = false;
            // 
            // uxDisplayLocationEmpRB
            // 
            this.uxDisplayLocationEmpRB.AutoSize = true;
            this.uxDisplayLocationEmpRB.Location = new System.Drawing.Point(17, 160);
            this.uxDisplayLocationEmpRB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxDisplayLocationEmpRB.Name = "uxDisplayLocationEmpRB";
            this.uxDisplayLocationEmpRB.Size = new System.Drawing.Size(202, 29);
            this.uxDisplayLocationEmpRB.TabIndex = 2;
            this.uxDisplayLocationEmpRB.Tag = "DisplayLocation";
            this.uxDisplayLocationEmpRB.Text = "Display Location";
            this.uxDisplayLocationEmpRB.UseVisualStyleBackColor = true;
            this.uxDisplayLocationEmpRB.Visible = false;
            // 
            // uxDisplayPastRepairsEmpRB
            // 
            this.uxDisplayPastRepairsEmpRB.AutoSize = true;
            this.uxDisplayPastRepairsEmpRB.Location = new System.Drawing.Point(17, 51);
            this.uxDisplayPastRepairsEmpRB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxDisplayPastRepairsEmpRB.Name = "uxDisplayPastRepairsEmpRB";
            this.uxDisplayPastRepairsEmpRB.Size = new System.Drawing.Size(243, 29);
            this.uxDisplayPastRepairsEmpRB.TabIndex = 1;
            this.uxDisplayPastRepairsEmpRB.Tag = "DisplayPastRepairs";
            this.uxDisplayPastRepairsEmpRB.Text = "Display Past Repairs";
            this.uxDisplayPastRepairsEmpRB.UseVisualStyleBackColor = true;
            // 
            // uxDisplayRepairCountsEmpRB
            // 
            this.uxDisplayRepairCountsEmpRB.AutoSize = true;
            this.uxDisplayRepairCountsEmpRB.Location = new System.Drawing.Point(17, 106);
            this.uxDisplayRepairCountsEmpRB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxDisplayRepairCountsEmpRB.Name = "uxDisplayRepairCountsEmpRB";
            this.uxDisplayRepairCountsEmpRB.Size = new System.Drawing.Size(257, 29);
            this.uxDisplayRepairCountsEmpRB.TabIndex = 0;
            this.uxDisplayRepairCountsEmpRB.TabStop = true;
            this.uxDisplayRepairCountsEmpRB.Tag = "DisplayRepairCounts";
            this.uxDisplayRepairCountsEmpRB.Text = "Display Repair Counts";
            this.uxDisplayRepairCountsEmpRB.UseVisualStyleBackColor = true;
            // 
            // uxGeneralEmployeeDisplayGB
            // 
            this.uxGeneralEmployeeDisplayGB.Controls.Add(this.uxSelectEmpTB);
            this.uxGeneralEmployeeDisplayGB.Controls.Add(this.uxDisplaySpecificEmployeeRB);
            this.uxGeneralEmployeeDisplayGB.Controls.Add(this.uxDisplayAllEmployeesRB);
            this.uxGeneralEmployeeDisplayGB.Location = new System.Drawing.Point(49, 32);
            this.uxGeneralEmployeeDisplayGB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxGeneralEmployeeDisplayGB.Name = "uxGeneralEmployeeDisplayGB";
            this.uxGeneralEmployeeDisplayGB.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxGeneralEmployeeDisplayGB.Size = new System.Drawing.Size(425, 232);
            this.uxGeneralEmployeeDisplayGB.TabIndex = 3;
            this.uxGeneralEmployeeDisplayGB.TabStop = false;
            this.uxGeneralEmployeeDisplayGB.Text = "General Display";
            // 
            // uxSelectEmpTB
            // 
            this.uxSelectEmpTB.Location = new System.Drawing.Point(52, 151);
            this.uxSelectEmpTB.Name = "uxSelectEmpTB";
            this.uxSelectEmpTB.Size = new System.Drawing.Size(238, 31);
            this.uxSelectEmpTB.TabIndex = 3;
            this.uxSelectEmpTB.Text = "Enter Employee Name";
            this.uxSelectEmpTB.Visible = false;
            // 
            // uxDisplaySpecificEmployeeRB
            // 
            this.uxDisplaySpecificEmployeeRB.AutoSize = true;
            this.uxDisplaySpecificEmployeeRB.Location = new System.Drawing.Point(17, 106);
            this.uxDisplaySpecificEmployeeRB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxDisplaySpecificEmployeeRB.Name = "uxDisplaySpecificEmployeeRB";
            this.uxDisplaySpecificEmployeeRB.Size = new System.Drawing.Size(297, 29);
            this.uxDisplaySpecificEmployeeRB.TabIndex = 1;
            this.uxDisplaySpecificEmployeeRB.Tag = "DisplaySpecificEmployee";
            this.uxDisplaySpecificEmployeeRB.Text = "Display Specific Employee";
            this.uxDisplaySpecificEmployeeRB.UseVisualStyleBackColor = true;
            // 
            // uxDisplayAllEmployeesRB
            // 
            this.uxDisplayAllEmployeesRB.AutoSize = true;
            this.uxDisplayAllEmployeesRB.Location = new System.Drawing.Point(17, 42);
            this.uxDisplayAllEmployeesRB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxDisplayAllEmployeesRB.Name = "uxDisplayAllEmployeesRB";
            this.uxDisplayAllEmployeesRB.Size = new System.Drawing.Size(256, 29);
            this.uxDisplayAllEmployeesRB.TabIndex = 0;
            this.uxDisplayAllEmployeesRB.TabStop = true;
            this.uxDisplayAllEmployeesRB.Tag = "DisplayAllEmployees";
            this.uxDisplayAllEmployeesRB.Text = "Display All Employees";
            this.uxDisplayAllEmployeesRB.UseVisualStyleBackColor = true;
            // 
            // uxLocationsPage
            // 
            this.uxLocationsPage.Controls.Add(this.uxDisplayQueryLoc);
            this.uxLocationsPage.Controls.Add(this.uxExcecuteLocBttn);
            this.uxLocationsPage.Controls.Add(this.uxSpecificDisplayLoc);
            this.uxLocationsPage.Controls.Add(this.uxGeneralDisplayLoc);
            this.uxLocationsPage.Location = new System.Drawing.Point(8, 43);
            this.uxLocationsPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxLocationsPage.Name = "uxLocationsPage";
            this.uxLocationsPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxLocationsPage.Size = new System.Drawing.Size(1090, 708);
            this.uxLocationsPage.TabIndex = 2;
            this.uxLocationsPage.Text = "Locations";
            this.uxLocationsPage.UseVisualStyleBackColor = true;
            // 
            // uxExcecuteLocBttn
            // 
            this.uxExcecuteLocBttn.Location = new System.Drawing.Point(791, 315);
            this.uxExcecuteLocBttn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxExcecuteLocBttn.Name = "uxExcecuteLocBttn";
            this.uxExcecuteLocBttn.Size = new System.Drawing.Size(197, 69);
            this.uxExcecuteLocBttn.TabIndex = 14;
            this.uxExcecuteLocBttn.Text = "Excecute";
            this.uxExcecuteLocBttn.UseVisualStyleBackColor = true;
            this.uxExcecuteLocBttn.Click += new System.EventHandler(this.uxExcecuteLocBttn_Click);
            // 
            // uxSpecificDisplayLoc
            // 
            this.uxSpecificDisplayLoc.Controls.Add(this.uxDisplayUpcomingApptLocRB);
            this.uxSpecificDisplayLoc.Controls.Add(this.uxDisplaySalesLocRB);
            this.uxSpecificDisplayLoc.Controls.Add(this.uxDisplayInventoryLocRB);
            this.uxSpecificDisplayLoc.Location = new System.Drawing.Point(563, 32);
            this.uxSpecificDisplayLoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxSpecificDisplayLoc.Name = "uxSpecificDisplayLoc";
            this.uxSpecificDisplayLoc.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxSpecificDisplayLoc.Size = new System.Drawing.Size(425, 232);
            this.uxSpecificDisplayLoc.TabIndex = 5;
            this.uxSpecificDisplayLoc.TabStop = false;
            this.uxSpecificDisplayLoc.Text = "Specific Display";
            // 
            // uxDisplayUpcomingApptLocRB
            // 
            this.uxDisplayUpcomingApptLocRB.AutoSize = true;
            this.uxDisplayUpcomingApptLocRB.Location = new System.Drawing.Point(17, 166);
            this.uxDisplayUpcomingApptLocRB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxDisplayUpcomingApptLocRB.Name = "uxDisplayUpcomingApptLocRB";
            this.uxDisplayUpcomingApptLocRB.Size = new System.Drawing.Size(353, 29);
            this.uxDisplayUpcomingApptLocRB.TabIndex = 3;
            this.uxDisplayUpcomingApptLocRB.Tag = "DisplayUpcomingAppointments";
            this.uxDisplayUpcomingApptLocRB.Text = "Display Upcoming Appointments";
            this.uxDisplayUpcomingApptLocRB.UseVisualStyleBackColor = true;
            this.uxDisplayUpcomingApptLocRB.Visible = false;
            // 
            // uxDisplaySalesLocRB
            // 
            this.uxDisplaySalesLocRB.AutoSize = true;
            this.uxDisplaySalesLocRB.Location = new System.Drawing.Point(17, 51);
            this.uxDisplaySalesLocRB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxDisplaySalesLocRB.Name = "uxDisplaySalesLocRB";
            this.uxDisplaySalesLocRB.Size = new System.Drawing.Size(174, 29);
            this.uxDisplaySalesLocRB.TabIndex = 1;
            this.uxDisplaySalesLocRB.Tag = "DisplaySales";
            this.uxDisplaySalesLocRB.Text = "Display Sales";
            this.uxDisplaySalesLocRB.UseVisualStyleBackColor = true;
            // 
            // uxDisplayInventoryLocRB
            // 
            this.uxDisplayInventoryLocRB.AutoSize = true;
            this.uxDisplayInventoryLocRB.Location = new System.Drawing.Point(17, 109);
            this.uxDisplayInventoryLocRB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxDisplayInventoryLocRB.Name = "uxDisplayInventoryLocRB";
            this.uxDisplayInventoryLocRB.Size = new System.Drawing.Size(208, 29);
            this.uxDisplayInventoryLocRB.TabIndex = 0;
            this.uxDisplayInventoryLocRB.TabStop = true;
            this.uxDisplayInventoryLocRB.Tag = "DisplayInventory";
            this.uxDisplayInventoryLocRB.Text = "Display Inventory";
            this.uxDisplayInventoryLocRB.UseVisualStyleBackColor = true;
            // 
            // uxGeneralDisplayLoc
            // 
            this.uxGeneralDisplayLoc.Controls.Add(this.uxSelectLocTB);
            this.uxGeneralDisplayLoc.Controls.Add(this.uxDisplaySpecificLocationRB);
            this.uxGeneralDisplayLoc.Controls.Add(this.uxDisplayAllLocationsRB);
            this.uxGeneralDisplayLoc.Location = new System.Drawing.Point(49, 32);
            this.uxGeneralDisplayLoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxGeneralDisplayLoc.Name = "uxGeneralDisplayLoc";
            this.uxGeneralDisplayLoc.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxGeneralDisplayLoc.Size = new System.Drawing.Size(425, 232);
            this.uxGeneralDisplayLoc.TabIndex = 4;
            this.uxGeneralDisplayLoc.TabStop = false;
            this.uxGeneralDisplayLoc.Text = "General Display";
            // 
            // uxSelectLocTB
            // 
            this.uxSelectLocTB.Location = new System.Drawing.Point(52, 151);
            this.uxSelectLocTB.Name = "uxSelectLocTB";
            this.uxSelectLocTB.Size = new System.Drawing.Size(238, 31);
            this.uxSelectLocTB.TabIndex = 3;
            this.uxSelectLocTB.Text = "Enter Location Name";
            this.uxSelectLocTB.Visible = false;
            // 
            // uxDisplaySpecificLocationRB
            // 
            this.uxDisplaySpecificLocationRB.AutoSize = true;
            this.uxDisplaySpecificLocationRB.Location = new System.Drawing.Point(17, 106);
            this.uxDisplaySpecificLocationRB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxDisplaySpecificLocationRB.Name = "uxDisplaySpecificLocationRB";
            this.uxDisplaySpecificLocationRB.Size = new System.Drawing.Size(284, 29);
            this.uxDisplaySpecificLocationRB.TabIndex = 1;
            this.uxDisplaySpecificLocationRB.Tag = "DisplaySpecificLocation";
            this.uxDisplaySpecificLocationRB.Text = "Display Specific Location";
            this.uxDisplaySpecificLocationRB.UseVisualStyleBackColor = true;
            // 
            // uxDisplayAllLocationsRB
            // 
            this.uxDisplayAllLocationsRB.AutoSize = true;
            this.uxDisplayAllLocationsRB.Location = new System.Drawing.Point(17, 42);
            this.uxDisplayAllLocationsRB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxDisplayAllLocationsRB.Name = "uxDisplayAllLocationsRB";
            this.uxDisplayAllLocationsRB.Size = new System.Drawing.Size(243, 29);
            this.uxDisplayAllLocationsRB.TabIndex = 0;
            this.uxDisplayAllLocationsRB.TabStop = true;
            this.uxDisplayAllLocationsRB.Tag = "DisplayAllLocations";
            this.uxDisplayAllLocationsRB.Text = "Display All Locations";
            this.uxDisplayAllLocationsRB.UseVisualStyleBackColor = true;
            // 
            // uxPartsPage
            // 
            this.uxPartsPage.Controls.Add(this.richTextBox1);
            this.uxPartsPage.Location = new System.Drawing.Point(8, 43);
            this.uxPartsPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxPartsPage.Name = "uxPartsPage";
            this.uxPartsPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxPartsPage.Size = new System.Drawing.Size(1090, 623);
            this.uxPartsPage.TabIndex = 3;
            this.uxPartsPage.Text = "Parts";
            this.uxPartsPage.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(68, 46);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(959, 436);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // uxReportsPage
            // 
            this.uxReportsPage.Location = new System.Drawing.Point(8, 43);
            this.uxReportsPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxReportsPage.Name = "uxReportsPage";
            this.uxReportsPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxReportsPage.Size = new System.Drawing.Size(1090, 623);
            this.uxReportsPage.TabIndex = 4;
            this.uxReportsPage.Text = "Reports";
            this.uxReportsPage.UseVisualStyleBackColor = true;
            // 
            // RebuildDBBtn
            // 
            this.RebuildDBBtn.Location = new System.Drawing.Point(29, 787);
            this.RebuildDBBtn.Margin = new System.Windows.Forms.Padding(4);
            this.RebuildDBBtn.Name = "RebuildDBBtn";
            this.RebuildDBBtn.Size = new System.Drawing.Size(145, 48);
            this.RebuildDBBtn.TabIndex = 11;
            this.RebuildDBBtn.Text = "Rebuild DB";
            this.RebuildDBBtn.UseVisualStyleBackColor = true;
            // 
            // uxDisplayQueryLoc
            // 
            this.uxDisplayQueryLoc.GridLines = true;
            this.uxDisplayQueryLoc.HideSelection = false;
            this.uxDisplayQueryLoc.Location = new System.Drawing.Point(6, 402);
            this.uxDisplayQueryLoc.Name = "uxDisplayQueryLoc";
            this.uxDisplayQueryLoc.Size = new System.Drawing.Size(1055, 287);
            this.uxDisplayQueryLoc.TabIndex = 15;
            this.uxDisplayQueryLoc.UseCompatibleStateImageBehavior = false;
            // 
            // uxDisplayQueryEmp
            // 
            this.uxDisplayQueryEmp.GridLines = true;
            this.uxDisplayQueryEmp.HideSelection = false;
            this.uxDisplayQueryEmp.Location = new System.Drawing.Point(15, 404);
            this.uxDisplayQueryEmp.Name = "uxDisplayQueryEmp";
            this.uxDisplayQueryEmp.Size = new System.Drawing.Size(1055, 287);
            this.uxDisplayQueryEmp.TabIndex = 16;
            this.uxDisplayQueryEmp.UseCompatibleStateImageBehavior = false;
            // 
            // ManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 919);
            this.Controls.Add(this.RebuildDBBtn);
            this.Controls.Add(this.uxTabControl);
            this.Controls.Add(this.DropDownListSelection);
            this.Controls.Add(this.btntest1);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnsearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManagerView";
            this.Text = "Manager View";
            this.uxTabControl.ResumeLayout(false);
            this.uxCustomersPage.ResumeLayout(false);
            this.uxCustomersPage.PerformLayout();
            this.uxSpecificDisplayCustomerGB.ResumeLayout(false);
            this.uxSpecificDisplayCustomerGB.PerformLayout();
            this.uxGeneralCustomerDisplayGB.ResumeLayout(false);
            this.uxGeneralCustomerDisplayGB.PerformLayout();
            this.uxEmployeesPage.ResumeLayout(false);
            this.uxSpecificEmployeeDisplayGB.ResumeLayout(false);
            this.uxSpecificEmployeeDisplayGB.PerformLayout();
            this.uxGeneralEmployeeDisplayGB.ResumeLayout(false);
            this.uxGeneralEmployeeDisplayGB.PerformLayout();
            this.uxLocationsPage.ResumeLayout(false);
            this.uxSpecificDisplayLoc.ResumeLayout(false);
            this.uxSpecificDisplayLoc.PerformLayout();
            this.uxGeneralDisplayLoc.ResumeLayout(false);
            this.uxGeneralDisplayLoc.PerformLayout();
            this.uxPartsPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Button btntest1;
        private System.Windows.Forms.ComboBox DropDownListSelection;
        private System.Windows.Forms.TabControl uxTabControl;
        private System.Windows.Forms.TabPage uxCustomersPage;
        private System.Windows.Forms.TabPage uxEmployeesPage;
        private System.Windows.Forms.TabPage uxLocationsPage;
        private System.Windows.Forms.TabPage uxPartsPage;
        private System.Windows.Forms.TabPage uxReportsPage;
        private System.Windows.Forms.RadioButton uxDisplayAllCustomersRB;
        private System.Windows.Forms.RadioButton uxDisplaySpecificCustomerRB;
        private System.Windows.Forms.GroupBox uxSpecificDisplayCustomerGB;
        private System.Windows.Forms.RadioButton uxDisplayUpcomingApptCusRB;
        private System.Windows.Forms.RadioButton uxDisplayRepeatedRepairsCusRB;
        private System.Windows.Forms.RadioButton uxDisplayPastRepairsCusRB;
        private System.Windows.Forms.GroupBox uxGeneralCustomerDisplayGB;
        private System.Windows.Forms.RadioButton uxDisplaySpecificVehicleRB;
        private System.Windows.Forms.Button RebuildDBBtn;
        private System.Windows.Forms.Button uxExcecuteCusButtn;
        private System.Windows.Forms.TextBox uxSelectCusTB;
        private System.Windows.Forms.TextBox uxDisplayQueryCusTB;
        private System.Windows.Forms.TextBox uxSelectVehicleTB;
        private System.Windows.Forms.Button uxExcecuteEmpBttn;
        private System.Windows.Forms.GroupBox uxSpecificEmployeeDisplayGB;
        private System.Windows.Forms.RadioButton uxDisplayLocationEmpRB;
        private System.Windows.Forms.RadioButton uxDisplayPastRepairsEmpRB;
        private System.Windows.Forms.RadioButton uxDisplayRepairCountsEmpRB;
        private System.Windows.Forms.GroupBox uxGeneralEmployeeDisplayGB;
        private System.Windows.Forms.TextBox uxSelectEmpTB;
        private System.Windows.Forms.RadioButton uxDisplaySpecificEmployeeRB;
        private System.Windows.Forms.RadioButton uxDisplayAllEmployeesRB;
        private System.Windows.Forms.RadioButton uxDisplayUpcomingApptEmpRB;
        private System.Windows.Forms.Button uxExcecuteLocBttn;
        private System.Windows.Forms.GroupBox uxSpecificDisplayLoc;
        private System.Windows.Forms.RadioButton uxDisplayUpcomingApptLocRB;
        private System.Windows.Forms.RadioButton uxDisplaySalesLocRB;
        private System.Windows.Forms.RadioButton uxDisplayInventoryLocRB;
        private System.Windows.Forms.GroupBox uxGeneralDisplayLoc;
        private System.Windows.Forms.TextBox uxSelectLocTB;
        private System.Windows.Forms.RadioButton uxDisplaySpecificLocationRB;
        private System.Windows.Forms.RadioButton uxDisplayAllLocationsRB;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ListView uxDisplayQueryLoc;
        private System.Windows.Forms.ListView uxDisplayQueryEmp;
    }
}
