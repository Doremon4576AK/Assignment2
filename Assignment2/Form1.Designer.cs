namespace Assignment2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FormLoad = new GroupBox();
            buttonCalculator = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cboTypeOfCustomer = new ComboBox();
            txtThisMonthWater = new TextBox();
            txtLastMonthWater = new TextBox();
            txtNumberOfPeople = new TextBox();
            txtCustomerName = new TextBox();
            lvInvoice = new ListView();
            txtSearch = new TextBox();
            label6 = new Label();
            FormLoad.SuspendLayout();
            SuspendLayout();
            // 
            // FormLoad
            // 
            FormLoad.BackColor = Color.CornflowerBlue;
            FormLoad.Controls.Add(buttonCalculator);
            FormLoad.Controls.Add(label5);
            FormLoad.Controls.Add(label4);
            FormLoad.Controls.Add(label3);
            FormLoad.Controls.Add(label2);
            FormLoad.Controls.Add(label1);
            FormLoad.Controls.Add(cboTypeOfCustomer);
            FormLoad.Controls.Add(txtThisMonthWater);
            FormLoad.Controls.Add(txtLastMonthWater);
            FormLoad.Controls.Add(txtNumberOfPeople);
            FormLoad.Controls.Add(txtCustomerName);
            FormLoad.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormLoad.ForeColor = Color.White;
            FormLoad.Location = new Point(23, 37);
            FormLoad.Name = "FormLoad";
            FormLoad.Size = new Size(275, 396);
            FormLoad.TabIndex = 0;
            FormLoad.TabStop = false;
            FormLoad.Text = "Calculator";
            FormLoad.Enter += FormLoad1_Enter;
            // 
            // buttonCalculator
            // 
            buttonCalculator.ForeColor = Color.Black;
            buttonCalculator.Location = new Point(33, 352);
            buttonCalculator.Name = "buttonCalculator";
            buttonCalculator.Size = new Size(94, 29);
            buttonCalculator.TabIndex = 11;
            buttonCalculator.Text = "Calculator";
            buttonCalculator.UseVisualStyleBackColor = true;
            buttonCalculator.Click += buttonCalculator_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 280);
            label5.Name = "label5";
            label5.Size = new Size(179, 20);
            label5.TabIndex = 10;
            label5.Text = "This month water meter";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 223);
            label4.Name = "label4";
            label4.Size = new Size(179, 20);
            label4.TabIndex = 9;
            label4.Text = "Last month water meter";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 158);
            label3.Name = "label3";
            label3.Size = new Size(137, 20);
            label3.TabIndex = 8;
            label3.Text = "Number of people";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 97);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 7;
            label2.Text = "Type of customer";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 29);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 6;
            label1.Text = "Customer name";
            label1.Click += label1_Click;
            // 
            // cboTypeOfCustomer
            // 
            cboTypeOfCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTypeOfCustomer.FormattingEnabled = true;
            cboTypeOfCustomer.Location = new Point(33, 117);
            cboTypeOfCustomer.Name = "cboTypeOfCustomer";
            cboTypeOfCustomer.Size = new Size(205, 28);
            cboTypeOfCustomer.TabIndex = 5;
            cboTypeOfCustomer.SelectedIndexChanged += cboTypeOfCustomer_SelectedIndexChanged;
            // 
            // txtThisMonthWater
            // 
            txtThisMonthWater.Location = new Point(34, 304);
            txtThisMonthWater.Name = "txtThisMonthWater";
            txtThisMonthWater.PlaceholderText = "Enter this month water";
            txtThisMonthWater.Size = new Size(204, 27);
            txtThisMonthWater.TabIndex = 4;
            txtThisMonthWater.TextChanged += txtThisMonthWater_TextChanged;
            // 
            // txtLastMonthWater
            // 
            txtLastMonthWater.Location = new Point(33, 245);
            txtLastMonthWater.Name = "txtLastMonthWater";
            txtLastMonthWater.PlaceholderText = "Enter last month water";
            txtLastMonthWater.Size = new Size(205, 27);
            txtLastMonthWater.TabIndex = 3;
            txtLastMonthWater.TextChanged += txtLastMonthWater_TextChanged;
            // 
            // txtNumberOfPeople
            // 
            txtNumberOfPeople.Location = new Point(33, 181);
            txtNumberOfPeople.Name = "txtNumberOfPeople";
            txtNumberOfPeople.PlaceholderText = "Enter number of people";
            txtNumberOfPeople.Size = new Size(203, 27);
            txtNumberOfPeople.TabIndex = 2;
            txtNumberOfPeople.TextChanged += TypeOfCustomer_TextChanged;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(33, 52);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.PlaceholderText = "Enter Name of Customer";
            txtCustomerName.Size = new Size(205, 27);
            txtCustomerName.TabIndex = 0;
            txtCustomerName.TextChanged += txtCustomerName_TextChanged;
            // 
            // lvInvoice
            // 
            lvInvoice.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lvInvoice.FullRowSelect = true;
            lvInvoice.Location = new Point(320, 75);
            lvInvoice.Name = "lvInvoice";
            lvInvoice.Size = new Size(1245, 358);
            lvInvoice.TabIndex = 1;
            lvInvoice.UseCompatibleStateImageBehavior = false;
            lvInvoice.SelectedIndexChanged += lvInvoice_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(379, 35);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(526, 27);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.KeyPress += txtSearch_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(320, 37);
            label6.Name = "label6";
            label6.Size = new Size(59, 20);
            label6.TabIndex = 3;
            label6.Text = "Search:";
            label6.Click += label6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(1577, 474);
            Controls.Add(label6);
            Controls.Add(txtSearch);
            Controls.Add(lvInvoice);
            Controls.Add(FormLoad);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            FormLoad.ResumeLayout(false);
            FormLoad.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox FormLoad;
        private TextBox txtThisMonthWater;
        private TextBox txtLastMonthWater;
        private TextBox txtNumberOfPeople;
        private TextBox txtCustomerName;
        private ComboBox cboTypeOfCustomer;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button buttonCalculator;
        private ListView lvInvoice;
        private TextBox txtSearch;
        private Label label6;
    }
}
