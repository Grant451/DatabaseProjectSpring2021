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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblstatus = new System.Windows.Forms.Label();
            this.btntest1 = new System.Windows.Forms.Button();
            this.DropDownListSelection = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(13, 52);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(74, 25);
            this.btnsearch.TabIndex = 1;
            this.btnsearch.Text = "search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "please enter a location:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Location = new System.Drawing.Point(146, 52);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(74, 25);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Location = new System.Drawing.Point(368, 88);
            this.lblstatus.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(0, 13);
            this.lblstatus.TabIndex = 7;
            // 
            // btntest1
            // 
            this.btntest1.Location = new System.Drawing.Point(13, 158);
            this.btntest1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btntest1.Name = "btntest1";
            this.btntest1.Size = new System.Drawing.Size(126, 59);
            this.btntest1.TabIndex = 8;
            this.btntest1.Text = "test query";
            this.btntest1.UseVisualStyleBackColor = true;
            this.btntest1.Click += new System.EventHandler(this.btntest1_Click);
            // 
            // DropDownListSelection
            // 
            this.DropDownListSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDownListSelection.FormattingEnabled = true;
            this.DropDownListSelection.Location = new System.Drawing.Point(13, 80);
            this.DropDownListSelection.Name = "DropDownListSelection";
            this.DropDownListSelection.Size = new System.Drawing.Size(121, 21);
            this.DropDownListSelection.TabIndex = 9;
            this.DropDownListSelection.SelectedIndexChanged += new System.EventHandler(this.DropDownListSelectionBtn);
            // 
            // ManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 312);
            this.Controls.Add(this.DropDownListSelection);
            this.Controls.Add(this.btntest1);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsearch);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "ManagerView";
            this.Text = "Manager View";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Button btntest1;
        private System.Windows.Forms.ComboBox DropDownListSelection;
    }
}

