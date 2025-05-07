namespace test
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
            txtCustomer = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtPop = new TextBox();
            txtWaterIndexLastMonth = new TextBox();
            btnCaculate = new Button();
            btnExport = new Button();
            btnClear = new Button();
            label5 = new Label();
            label6 = new Label();
            cbCustomer = new ComboBox();
            label7 = new Label();
            txtWaterIndexThisMonth = new TextBox();
            groupBox1 = new GroupBox();
            lbTotalAmount = new Label();
            lbWaterIndexThisMonth = new Label();
            lbWaterIndex = new Label();
            lbWaterIndexLastMonth = new Label();
            lbTypeCustomer = new Label();
            lbCustomer = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new Point(423, 250);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(489, 47);
            txtCustomer.TabIndex = 0;
            txtCustomer.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 237);
            label1.Name = "label1";
            label1.Size = new Size(223, 41);
            label1.TabIndex = 1;
            label1.Text = "Enter Customer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(335, 51);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(1429, 89);
            label2.TabIndex = 3;
            label2.Text = "Calculate the monthly water bill each month";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 335);
            label3.Name = "label3";
            label3.Size = new Size(256, 41);
            label3.TabIndex = 4;
            label3.Text = "Choose Customer";
            // 
            // txtPop
            // 
            txtPop.Location = new Point(423, 438);
            txtPop.Name = "txtPop";
            txtPop.Size = new Size(489, 47);
            txtPop.TabIndex = 6;
            // 
            // txtWaterIndexLastMonth
            // 
            txtWaterIndexLastMonth.Location = new Point(423, 530);
            txtWaterIndexLastMonth.Name = "txtWaterIndexLastMonth";
            txtWaterIndexLastMonth.Size = new Size(489, 47);
            txtWaterIndexLastMonth.TabIndex = 7;
            // 
            // btnCaculate
            // 
            btnCaculate.Location = new Point(495, 723);
            btnCaculate.Name = "btnCaculate";
            btnCaculate.Size = new Size(268, 79);
            btnCaculate.TabIndex = 8;
            btnCaculate.Text = "Caculate";
            btnCaculate.UseVisualStyleBackColor = true;
            btnCaculate.Click += button1_Click;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(360, 453);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(228, 83);
            btnExport.TabIndex = 9;
            btnExport.Text = "Export PDF";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(63, 453);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(215, 83);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(74, 533);
            label5.Name = "label5";
            label5.Size = new Size(325, 41);
            label5.TabIndex = 12;
            label5.Text = "Water index last month";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(74, 438);
            label6.Name = "label6";
            label6.Size = new Size(161, 41);
            label6.TabIndex = 13;
            label6.Text = "Population";
            label6.Click += label6_Click;
            // 
            // cbCustomer
            // 
            cbCustomer.FormattingEnabled = true;
            cbCustomer.Items.AddRange(new object[] { "Household customer", "Administrative agency, public services", "Production units", "Business services" });
            cbCustomer.Location = new Point(423, 335);
            cbCustomer.Name = "cbCustomer";
            cbCustomer.Size = new Size(489, 49);
            cbCustomer.TabIndex = 14;
            cbCustomer.Tag = "";
            cbCustomer.Text = "Select Type Of Customer";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(74, 634);
            label7.Name = "label7";
            label7.Size = new Size(327, 41);
            label7.TabIndex = 16;
            label7.Text = "Water index this month";
            label7.Click += label7_Click;
            // 
            // txtWaterIndexThisMonth
            // 
            txtWaterIndexThisMonth.Location = new Point(423, 628);
            txtWaterIndexThisMonth.Name = "txtWaterIndexThisMonth";
            txtWaterIndexThisMonth.Size = new Size(489, 47);
            txtWaterIndexThisMonth.TabIndex = 15;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbTotalAmount);
            groupBox1.Controls.Add(lbWaterIndexThisMonth);
            groupBox1.Controls.Add(lbWaterIndex);
            groupBox1.Controls.Add(lbWaterIndexLastMonth);
            groupBox1.Controls.Add(lbTypeCustomer);
            groupBox1.Controls.Add(lbCustomer);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnExport);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Location = new Point(1243, 237);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(914, 565);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Information";
            // 
            // lbTotalAmount
            // 
            lbTotalAmount.AutoSize = true;
            lbTotalAmount.Location = new Point(343, 369);
            lbTotalAmount.Name = "lbTotalAmount";
            lbTotalAmount.Size = new Size(91, 41);
            lbTotalAmount.TabIndex = 16;
            lbTotalAmount.Text = "None";
            // 
            // lbWaterIndexThisMonth
            // 
            lbWaterIndexThisMonth.AutoSize = true;
            lbWaterIndexThisMonth.Location = new Point(395, 241);
            lbWaterIndexThisMonth.Name = "lbWaterIndexThisMonth";
            lbWaterIndexThisMonth.Size = new Size(91, 41);
            lbWaterIndexThisMonth.TabIndex = 15;
            lbWaterIndexThisMonth.Text = "None";
            // 
            // lbWaterIndex
            // 
            lbWaterIndex.AutoSize = true;
            lbWaterIndex.Location = new Point(314, 309);
            lbWaterIndex.Name = "lbWaterIndex";
            lbWaterIndex.Size = new Size(91, 41);
            lbWaterIndex.TabIndex = 14;
            lbWaterIndex.Text = "None";
            // 
            // lbWaterIndexLastMonth
            // 
            lbWaterIndexLastMonth.AutoSize = true;
            lbWaterIndexLastMonth.Location = new Point(374, 188);
            lbWaterIndexLastMonth.Name = "lbWaterIndexLastMonth";
            lbWaterIndexLastMonth.Size = new Size(91, 41);
            lbWaterIndexLastMonth.TabIndex = 13;
            lbWaterIndexLastMonth.Text = "None";
            // 
            // lbTypeCustomer
            // 
            lbTypeCustomer.AutoSize = true;
            lbTypeCustomer.Location = new Point(283, 126);
            lbTypeCustomer.Name = "lbTypeCustomer";
            lbTypeCustomer.Size = new Size(91, 41);
            lbTypeCustomer.TabIndex = 12;
            lbTypeCustomer.Text = "None";
            // 
            // lbCustomer
            // 
            lbCustomer.AutoSize = true;
            lbCustomer.Location = new Point(283, 60);
            lbCustomer.Name = "lbCustomer";
            lbCustomer.Size = new Size(91, 41);
            lbCustomer.TabIndex = 11;
            lbCustomer.Text = "None";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(28, 369);
            label12.Name = "label12";
            label12.Size = new Size(322, 41);
            label12.TabIndex = 5;
            label12.Text = "Total Amount (VND) :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(28, 309);
            label11.Name = "label11";
            label11.Size = new Size(280, 41);
            label11.TabIndex = 4;
            label11.Text = "Water index (m3) :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(28, 250);
            label10.Name = "label10";
            label10.Size = new Size(367, 41);
            label10.TabIndex = 3;
            label10.Text = "Water index this month :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(28, 188);
            label9.Name = "label9";
            label9.Size = new Size(365, 41);
            label9.TabIndex = 2;
            label9.Text = "Water index last month :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(28, 126);
            label8.Name = "label8";
            label8.Size = new Size(245, 41);
            label8.TabIndex = 1;
            label8.Text = "Type Customer :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(28, 60);
            label4.Name = "label4";
            label4.Size = new Size(260, 41);
            label4.TabIndex = 0;
            label4.Text = "Name Customer :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2326, 939);
            Controls.Add(groupBox1);
            Controls.Add(label7);
            Controls.Add(txtWaterIndexThisMonth);
            Controls.Add(cbCustomer);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnCaculate);
            Controls.Add(txtWaterIndexLastMonth);
            Controls.Add(txtPop);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtCustomer);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCustomer;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPop;
        private TextBox txtWaterIndexLastMonth;
        private Button btnCaculate;
        private Button btnExport;
        private Button btnClear;
        private Label label5;
        private Label label6;
        private ComboBox cbCustomer;
        private Label label7;
        private TextBox txtWaterIndexThisMonth;
        private GroupBox groupBox1;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label4;
        private Label lbTotalAmount;
        private Label lbWaterIndexThisMonth;
        private Label lbWaterIndex;
        private Label lbWaterIndexLastMonth;
        private Label lbTypeCustomer;
        private Label lbCustomer;
    }
}
