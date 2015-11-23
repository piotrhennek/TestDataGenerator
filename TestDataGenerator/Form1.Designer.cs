namespace TestDataGenerator
{
    partial class Form1
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
            this.connectionStringTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.testConnectionBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.employeesCountTxtBox = new System.Windows.Forms.TextBox();
            this.productsCountTxtBox = new System.Windows.Forms.TextBox();
            this.ordersCountTxtBox = new System.Windows.Forms.TextBox();
            this.generateTestDataBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // connectionStringTxtBox
            // 
            this.connectionStringTxtBox.Location = new System.Drawing.Point(207, 25);
            this.connectionStringTxtBox.Name = "connectionStringTxtBox";
            this.connectionStringTxtBox.Size = new System.Drawing.Size(207, 20);
            this.connectionStringTxtBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Put connection string to your database";
            // 
            // testConnectionBtn
            // 
            this.testConnectionBtn.Location = new System.Drawing.Point(444, 25);
            this.testConnectionBtn.Name = "testConnectionBtn";
            this.testConnectionBtn.Size = new System.Drawing.Size(134, 23);
            this.testConnectionBtn.TabIndex = 2;
            this.testConnectionBtn.Text = "Test connection";
            this.testConnectionBtn.UseVisualStyleBackColor = true;
            this.testConnectionBtn.Click += new System.EventHandler(this.testConnectionBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Employees count:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Products count:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Orders count:";
            // 
            // employeesCountTxtBox
            // 
            this.employeesCountTxtBox.Location = new System.Drawing.Point(207, 80);
            this.employeesCountTxtBox.Name = "employeesCountTxtBox";
            this.employeesCountTxtBox.Size = new System.Drawing.Size(92, 20);
            this.employeesCountTxtBox.TabIndex = 6;
            // 
            // productsCountTxtBox
            // 
            this.productsCountTxtBox.Location = new System.Drawing.Point(207, 110);
            this.productsCountTxtBox.Name = "productsCountTxtBox";
            this.productsCountTxtBox.Size = new System.Drawing.Size(92, 20);
            this.productsCountTxtBox.TabIndex = 7;
            // 
            // ordersCountTxtBox
            // 
            this.ordersCountTxtBox.Location = new System.Drawing.Point(207, 141);
            this.ordersCountTxtBox.Name = "ordersCountTxtBox";
            this.ordersCountTxtBox.Size = new System.Drawing.Size(92, 20);
            this.ordersCountTxtBox.TabIndex = 8;
            // 
            // generateTestDataBtn
            // 
            this.generateTestDataBtn.Location = new System.Drawing.Point(444, 141);
            this.generateTestDataBtn.Name = "generateTestDataBtn";
            this.generateTestDataBtn.Size = new System.Drawing.Size(134, 23);
            this.generateTestDataBtn.TabIndex = 9;
            this.generateTestDataBtn.Text = "Generate test data";
            this.generateTestDataBtn.UseVisualStyleBackColor = true;
            this.generateTestDataBtn.Click += new System.EventHandler(this.generateTestData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 177);
            this.Controls.Add(this.generateTestDataBtn);
            this.Controls.Add(this.ordersCountTxtBox);
            this.Controls.Add(this.productsCountTxtBox);
            this.Controls.Add(this.employeesCountTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.testConnectionBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.connectionStringTxtBox);
            this.Name = "Form1";
            this.Text = "Test data generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox connectionStringTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button testConnectionBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox employeesCountTxtBox;
        private System.Windows.Forms.TextBox productsCountTxtBox;
        private System.Windows.Forms.TextBox ordersCountTxtBox;
        private System.Windows.Forms.Button generateTestDataBtn;
    }
}

