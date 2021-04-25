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
            this.uxDisplayQueryCusTB = new System.Windows.Forms.TextBox();
            this.uxSpecificDisplayCustomerGB = new System.Windows.Forms.GroupBox();
            this.uxDisplayUpcomingApptCustRB = new System.Windows.Forms.RadioButton();
            this.uxDisplayRepeatedRepairsCusRB = new System.Windows.Forms.RadioButton();
            this.uxDisplayPastRepairsCusRB = new System.Windows.Forms.RadioButton();
            this.uxGeneralCustomerDisplayGB = new System.Windows.Forms.GroupBox();
            this.uxDisplaySpecificVehicleRB = new System.Windows.Forms.RadioButton();
            this.uxDisplaySpecificCustomerRB = new System.Windows.Forms.RadioButton();
            this.uxDisplayAllCustomersRB = new System.Windows.Forms.RadioButton();
            this.uxEmployeesPage = new System.Windows.Forms.TabPage();
            this.uxLocationsPage = new System.Windows.Forms.TabPage();
            this.uxPartsPage = new System.Windows.Forms.TabPage();
            this.uxReportsPage = new System.Windows.Forms.TabPage();
            this.uxExcecuteCusBttn = new System.Windows.Forms.Button();
            this.uxTabControl.SuspendLayout();
            this.uxCustomersPage.SuspendLayout();
            this.uxSpecificDisplayCustomerGB.SuspendLayout();
            this.uxGeneralCustomerDisplayGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(14, 679);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(111, 38);
            this.btnsearch.TabIndex = 1;
            this.btnsearch.Text = "search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Location = new System.Drawing.Point(188, 679);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(111, 38);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Location = new System.Drawing.Point(552, 135);
            this.lblstatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(0, 20);
            this.lblstatus.TabIndex = 7;
            // 
            // btntest1
            // 
            this.btntest1.Location = new System.Drawing.Point(773, 634);
            this.btntest1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btntest1.Name = "btntest1";
            this.btntest1.Size = new System.Drawing.Size(252, 113);
            this.btntest1.TabIndex = 8;
            this.btntest1.Text = "test query";
            this.btntest1.UseVisualStyleBackColor = true;
            this.btntest1.Click += new System.EventHandler(this.btntest1_Click);
            // 
            // DropDownListSelection
            // 
            this.DropDownListSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDownListSelection.FormattingEnabled = true;
            this.DropDownListSelection.Location = new System.Drawing.Point(404, 688);
            this.DropDownListSelection.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.DropDownListSelection.Name = "DropDownListSelection";
            this.DropDownListSelection.Size = new System.Drawing.Size(180, 28);
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
            this.uxTabControl.Location = new System.Drawing.Point(2, 10);
            this.uxTabControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxTabControl.Name = "uxTabControl";
            this.uxTabControl.SelectedIndex = 0;
            this.uxTabControl.Size = new System.Drawing.Size(1069, 552);
            this.uxTabControl.TabIndex = 10;
            // 
            // uxCustomersPage
            // 
            this.uxCustomersPage.Controls.Add(this.uxExcecuteCusBttn);
            this.uxCustomersPage.Controls.Add(this.uxDisplayQueryCusTB);
            this.uxCustomersPage.Controls.Add(this.uxSpecificDisplayCustomerGB);
            this.uxCustomersPage.Controls.Add(this.uxGeneralCustomerDisplayGB);
            this.uxCustomersPage.Location = new System.Drawing.Point(4, 39);
            this.uxCustomersPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxCustomersPage.Name = "uxCustomersPage";
            this.uxCustomersPage.Padding = new System.Windows.Forms.Padding(3);
            this.uxCustomersPage.Size = new System.Drawing.Size(1053, 501);
            this.uxCustomersPage.TabIndex = 0;
            this.uxCustomersPage.Text = "Customers";
            this.uxCustomersPage.UseVisualStyleBackColor = true;
            // 
            // uxEmployeesPage
            // 
            this.uxEmployeesPage.Location = new System.Drawing.Point(8, 39);
            this.uxEmployeesPage.Name = "uxEmployeesPage";
            this.uxEmployeesPage.Padding = new System.Windows.Forms.Padding(3);
            this.uxEmployeesPage.Size = new System.Drawing.Size(1053, 505);
            this.uxEmployeesPage.TabIndex = 1;
            this.uxEmployeesPage.Text = "Employees";
            this.uxEmployeesPage.UseVisualStyleBackColor = true;
            // 
            // uxLocationsPage
            // 
            this.uxLocationsPage.Location = new System.Drawing.Point(8, 39);
            this.uxLocationsPage.Name = "uxLocationsPage";
            this.uxLocationsPage.Padding = new System.Windows.Forms.Padding(3);
            this.uxLocationsPage.Size = new System.Drawing.Size(1053, 505);
            this.uxLocationsPage.TabIndex = 2;
            this.uxLocationsPage.Text = "Locations";
            this.uxLocationsPage.UseVisualStyleBackColor = true;
            // 
            // uxPartsPage
            // 
            this.uxPartsPage.Location = new System.Drawing.Point(8, 39);
            this.uxPartsPage.Name = "uxPartsPage";
            this.uxPartsPage.Padding = new System.Windows.Forms.Padding(3);
            this.uxPartsPage.Size = new System.Drawing.Size(1053, 505);
            this.uxPartsPage.TabIndex = 3;
            this.uxPartsPage.Text = "Parts";
            this.uxPartsPage.UseVisualStyleBackColor = true;
            // 
            // uxReportsPage
            // 
            this.uxReportsPage.Location = new System.Drawing.Point(8, 39);
            this.uxReportsPage.Name = "uxReportsPage";
            this.uxReportsPage.Padding = new System.Windows.Forms.Padding(3);
            this.uxReportsPage.Size = new System.Drawing.Size(1053, 505);
            this.uxReportsPage.TabIndex = 4;
            this.uxReportsPage.Text = "Reports";
            this.uxReportsPage.UseVisualStyleBackColor = true;
            // 
            // uxDisplayAllCustomersRB
            // 
            this.uxDisplayAllCustomersRB.AutoSize = true;
            this.uxDisplayAllCustomersRB.Location = new System.Drawing.Point(17, 43);
            this.uxDisplayAllCustomersRB.Name = "uxDisplayAllCustomersRB";
            this.uxDisplayAllCustomersRB.Size = new System.Drawing.Size(253, 29);
            this.uxDisplayAllCustomersRB.TabIndex = 0;
            this.uxDisplayAllCustomersRB.TabStop = true;
            this.uxDisplayAllCustomersRB.Text = "Display All Customers";
            this.uxDisplayAllCustomersRB.UseVisualStyleBackColor = true;
            // 
            // uxDisplaySpecificCustomerRB
            // 
            this.uxDisplaySpecificCustomerRB.AutoSize = true;
            this.uxDisplaySpecificCustomerRB.Location = new System.Drawing.Point(17, 106);
            this.uxDisplaySpecificCustomerRB.Name = "uxDisplaySpecificCustomerRB";
            this.uxDisplaySpecificCustomerRB.Size = new System.Drawing.Size(294, 29);
            this.uxDisplaySpecificCustomerRB.TabIndex = 1;
            this.uxDisplaySpecificCustomerRB.Text = "Display Specific Customer";
            this.uxDisplaySpecificCustomerRB.UseVisualStyleBackColor = true;
            // 
            // uxGeneralCustomerDisplayGB
            // 
            this.uxGeneralCustomerDisplayGB.Controls.Add(this.uxDisplaySpecificVehicle);
            this.uxGeneralCustomerDisplayGB.Controls.Add(this.uxDisplaySpecificCustomerRB);
            this.uxGeneralCustomerDisplayGB.Controls.Add(this.uxDisplayAllCustomersRB);
            this.uxGeneralCustomerDisplayGB.Location = new System.Drawing.Point(49, 32);
            this.uxGeneralCustomerDisplayGB.Name = "uxGeneralCustomerDisplayGB";
            this.uxGeneralCustomerDisplayGB.Size = new System.Drawing.Size(425, 233);
            this.uxGeneralCustomerDisplayGB.TabIndex = 2;
            this.uxGeneralCustomerDisplayGB.TabStop = false;
            this.uxGeneralCustomerDisplayGB.Text = "General Display";
            // 
            // uxDisplaySpecificVehicle
            // 
            this.uxDisplaySpecificVehicle.AutoSize = true;
            this.uxDisplaySpecificVehicle.Location = new System.Drawing.Point(17, 164);
            this.uxDisplaySpecificVehicle.Name = "uxDisplaySpecificVehicle";
            this.uxDisplaySpecificVehicle.Size = new System.Drawing.Size(273, 29);
            this.uxDisplaySpecificVehicle.TabIndex = 2;
            this.uxDisplaySpecificVehicle.Text = "Display Specific Vehicle";
            this.uxDisplaySpecificVehicle.UseVisualStyleBackColor = true;
            // 
            // uxSpecificDisplayCustomerGB
            // 
            this.uxSpecificDisplayCustomerGB.Controls.Add(this.radioButton1);
            this.uxSpecificDisplayCustomerGB.Controls.Add(this.radioButton2);
            this.uxSpecificDisplayCustomerGB.Controls.Add(this.uxDisplayPastRepairsCustomer);
            this.uxSpecificDisplayCustomerGB.Location = new System.Drawing.Point(562, 32);
            this.uxSpecificDisplayCustomerGB.Name = "uxSpecificDisplayCustomerGB";
            this.uxSpecificDisplayCustomerGB.Size = new System.Drawing.Size(425, 233);
            this.uxSpecificDisplayCustomerGB.TabIndex = 3;
            this.uxSpecificDisplayCustomerGB.TabStop = false;
            this.uxSpecificDisplayCustomerGB.Text = "Specific Display";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(17, 164);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(353, 29);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.Text = "Display Upcoming Appointments";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(17, 106);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(293, 29);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Display Repeated Repairs";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // uxDisplayPastRepairsCustomer
            // 
            this.uxDisplayPastRepairsCustomer.AutoSize = true;
            this.uxDisplayPastRepairsCustomer.Location = new System.Drawing.Point(17, 43);
            this.uxDisplayPastRepairsCustomer.Name = "uxDisplayPastRepairsCustomer";
            this.uxDisplayPastRepairsCustomer.Size = new System.Drawing.Size(243, 29);
            this.uxDisplayPastRepairsCustomer.TabIndex = 0;
            this.uxDisplayPastRepairsCustomer.TabStop = true;
            this.uxDisplayPastRepairsCustomer.Text = "Display Past Repairs";
            this.uxDisplayPastRepairsCustomer.UseVisualStyleBackColor = true;
            // 
            // ManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 758);
            this.Controls.Add(this.uxTabControl);
            this.Controls.Add(this.DropDownListSelection);
            this.Controls.Add(this.btntest1);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnsearch);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManagerView";
            this.Text = "Manager View";
            this.uxTabControl.ResumeLayout(false);
            this.uxCustomersPage.ResumeLayout(false);
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
        private System.Windows.Forms.RadioButton uxDisplayUpcomingApptCustRB;
        private System.Windows.Forms.RadioButton uxDisplayRepeatedRepairsCusRB;
        private System.Windows.Forms.RadioButton uxDisplayPastRepairsCusRB;
        private System.Windows.Forms.GroupBox uxGeneralCustomerDisplayGB;
        private System.Windows.Forms.RadioButton uxDisplaySpecificVehicle;
    }
}

