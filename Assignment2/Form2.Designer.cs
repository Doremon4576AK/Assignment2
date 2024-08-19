namespace Assignment2
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            button1 = new Button();
            labelcustomername = new Label();
            labeltypeofcustomer = new Label();
            labelnumberofpeople = new Label();
            labellastmonth = new Label();
            labelthismonth = new Label();
            labelconsumption = new Label();
            labeltotalwater = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(324, 30);
            label1.Name = "label1";
            label1.Size = new Size(255, 50);
            label1.TabIndex = 0;
            label1.Text = "WATER BILL";
            label1.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(249, 162);
            label4.Name = "label4";
            label4.Size = new Size(165, 28);
            label4.TabIndex = 3;
            label4.Text = "Customer name:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(249, 212);
            label5.Name = "label5";
            label5.Size = new Size(189, 28);
            label5.TabIndex = 4;
            label5.Text = "Type of customer: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(249, 267);
            label6.Name = "label6";
            label6.Size = new Size(190, 28);
            label6.TabIndex = 5;
            label6.Text = "Number of people:";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.Location = new Point(249, 325);
            label7.Name = "label7";
            label7.Size = new Size(184, 28);
            label7.TabIndex = 6;
            label7.Text = "Last month water:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.Location = new Point(249, 377);
            label8.Name = "label8";
            label8.Size = new Size(185, 28);
            label8.TabIndex = 7;
            label8.Text = "This month water:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label9.Location = new Point(124, 424);
            label9.Name = "label9";
            label9.Size = new Size(142, 28);
            label9.TabIndex = 8;
            label9.Text = "Consumption:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label10.Location = new Point(124, 467);
            label10.Name = "label10";
            label10.Size = new Size(160, 28);
            label10.TabIndex = 9;
            label10.Text = "Total water bill:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 255, 192);
            button1.Location = new Point(822, 12);
            button1.Name = "button1";
            button1.Size = new Size(49, 29);
            button1.TabIndex = 10;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseLeave += button1_MouseLeave;
            button1.MouseHover += button1_MouseHover;
            // 
            // labelcustomername
            // 
            labelcustomername.AutoSize = true;
            labelcustomername.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelcustomername.Location = new Point(483, 162);
            labelcustomername.Name = "labelcustomername";
            labelcustomername.Size = new Size(70, 28);
            labelcustomername.TabIndex = 11;
            labelcustomername.Text = "label2";
            // 
            // labeltypeofcustomer
            // 
            labeltypeofcustomer.AutoSize = true;
            labeltypeofcustomer.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labeltypeofcustomer.Location = new Point(483, 212);
            labeltypeofcustomer.Name = "labeltypeofcustomer";
            labeltypeofcustomer.Size = new Size(70, 28);
            labeltypeofcustomer.TabIndex = 12;
            labeltypeofcustomer.Text = "label3";
            // 
            // labelnumberofpeople
            // 
            labelnumberofpeople.AutoSize = true;
            labelnumberofpeople.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelnumberofpeople.Location = new Point(483, 267);
            labelnumberofpeople.Name = "labelnumberofpeople";
            labelnumberofpeople.Size = new Size(82, 28);
            labelnumberofpeople.TabIndex = 13;
            labelnumberofpeople.Text = "label11";
            // 
            // labellastmonth
            // 
            labellastmonth.AutoSize = true;
            labellastmonth.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labellastmonth.Location = new Point(483, 325);
            labellastmonth.Name = "labellastmonth";
            labellastmonth.Size = new Size(82, 28);
            labellastmonth.TabIndex = 14;
            labellastmonth.Text = "label12";
            // 
            // labelthismonth
            // 
            labelthismonth.AutoSize = true;
            labelthismonth.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelthismonth.Location = new Point(483, 377);
            labelthismonth.Name = "labelthismonth";
            labelthismonth.Size = new Size(82, 28);
            labelthismonth.TabIndex = 15;
            labelthismonth.Text = "label13";
            // 
            // labelconsumption
            // 
            labelconsumption.AutoSize = true;
            labelconsumption.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelconsumption.Location = new Point(313, 424);
            labelconsumption.Name = "labelconsumption";
            labelconsumption.Size = new Size(82, 28);
            labelconsumption.TabIndex = 16;
            labelconsumption.Text = "label14";
            // 
            // labeltotalwater
            // 
            labeltotalwater.AutoSize = true;
            labeltotalwater.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labeltotalwater.Location = new Point(313, 467);
            labeltotalwater.Name = "labeltotalwater";
            labeltotalwater.Size = new Size(82, 28);
            labeltotalwater.TabIndex = 17;
            labeltotalwater.Text = "label15";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 140);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 265);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(883, 586);
            Controls.Add(pictureBox1);
            Controls.Add(labeltotalwater);
            Controls.Add(labelconsumption);
            Controls.Add(labelthismonth);
            Controls.Add(labellastmonth);
            Controls.Add(labelnumberofpeople);
            Controls.Add(labeltypeofcustomer);
            Controls.Add(labelcustomername);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button button1;
        private Label labelcustomername;
        private Label labeltypeofcustomer;
        private Label labelnumberofpeople;
        private Label labellastmonth;
        private Label labelthismonth;
        private Label labelconsumption;
        private Label labeltotalwater;
        private PictureBox pictureBox1;
    }
}