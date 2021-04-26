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
            this.uxSelectCusTB = new System.Windows.Forms.TextBox();
            this.uxDisplaySpecificVehicleRB = new System.Windows.Forms.RadioButton();
            this.uxDisplaySpecificCustomerRB = new System.Windows.Forms.RadioButton();
            this.uxDisplayAllCustomersRB = new System.Windows.Forms.RadioButton();
            this.uxEmployeesPage = new System.Windows.Forms.TabPage();
            this.uxLocationsPage = new System.Windows.Forms.TabPage();
            this.uxPartsPage = new System.Windows.Forms.TabPage();
            this.uxReportsPage = new System.Windows.Forms.TabPage();
            this.RebuildDBBtn = new System.Windows.Forms.Button();
            this.uxSelectVehicleTB = new System.Windows.Forms.TextBox();
            this.uxTabControl.SuspendLayout();
            this.uxCustomersPage.SuspendLayout();
            this.uxSpecificDisplayCustomerGB.SuspendLayout();
            this.uxGeneralCustomerDisplayGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(27, 801);
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
            this.btnSubmit.Location = new System.Drawing.Point(202, 801);
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
            this.btntest1.Location = new System.Drawing.Point(787, 756);
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
            this.DropDownListSelection.Location = new System.Drawing.Point(418, 810);
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
            this.uxTabControl.Size = new System.Drawing.Size(1069, 674);
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
            this.uxCustomersPage.Size = new System.Drawing.Size(1053, 623);
            this.uxCustomersPage.TabIndex = 0;
            this.uxCustomersPage.Text = "Customers";
            this.uxCustomersPage.UseVisualStyleBackColor = true;
            // 
            // uxExcecuteCusButtn
            // 
            this.uxExcecuteCusButtn.Location = new System.Drawing.Point(791, 298);
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
            this.uxDisplayQueryCusTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uxDisplayQueryCusTB.Size = new System.Drawing.Size(985, 191);
            this.uxDisplayQueryCusTB.TabIndex = 4;
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
            this.uxEmployeesPage.Location = new System.Drawing.Point(8, 43);
            this.uxEmployeesPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxEmployeesPage.Name = "uxEmployeesPage";
            this.uxEmployeesPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxEmployeesPage.Size = new System.Drawing.Size(1053, 623);
            this.uxEmployeesPage.TabIndex = 1;
            this.uxEmployeesPage.Text = "Employees";
            this.uxEmployeesPage.UseVisualStyleBackColor = true;
            // 
            // uxLocationsPage
            // 
            this.uxLocationsPage.Location = new System.Drawing.Point(8, 43);
            this.uxLocationsPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxLocationsPage.Name = "uxLocationsPage";
            this.uxLocationsPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxLocationsPage.Size = new System.Drawing.Size(1053, 623);
            this.uxLocationsPage.TabIndex = 2;
            this.uxLocationsPage.Text = "Locations";
            this.uxLocationsPage.UseVisualStyleBackColor = true;
            // 
            // uxPartsPage
            // 
            this.uxPartsPage.Location = new System.Drawing.Point(8, 43);
            this.uxPartsPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxPartsPage.Name = "uxPartsPage";
            this.uxPartsPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxPartsPage.Size = new System.Drawing.Size(1053, 623);
            this.uxPartsPage.TabIndex = 3;
            this.uxPartsPage.Text = "Parts";
            this.uxPartsPage.UseVisualStyleBackColor = true;
            // 
            // uxReportsPage
            // 
            this.uxReportsPage.Location = new System.Drawing.Point(8, 43);
            this.uxReportsPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxReportsPage.Name = "uxReportsPage";
            this.uxReportsPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxReportsPage.Size = new System.Drawing.Size(1053, 623);
            this.uxReportsPage.TabIndex = 4;
            this.uxReportsPage.Text = "Reports";
            this.uxReportsPage.UseVisualStyleBackColor = true;
            // 
            // RebuildDBBtn
            // 
            this.RebuildDBBtn.Location = new System.Drawing.Point(30, 736);
            this.RebuildDBBtn.Margin = new System.Windows.Forms.Padding(4);
            this.RebuildDBBtn.Name = "RebuildDBBtn";
            this.RebuildDBBtn.Size = new System.Drawing.Size(145, 48);
            this.RebuildDBBtn.TabIndex = 11;
            this.RebuildDBBtn.Text = "Rebuild DB";
            this.RebuildDBBtn.UseVisualStyleBackColor = true;
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
            // ManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 880);
            this.Controls.Add(this.RebuildDBBtn);
            this.Controls.Add(this.uxTabControl);
            this.Controls.Add(this.DropDownListSelection);
            this.Controls.Add(this.btntest1);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnsearch);
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
    }
}
