namespace asm1_db
{
    partial class Statistics
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbQuantity = new System.Windows.Forms.TabPage();
            this.tbSales = new System.Windows.Forms.TabPage();
            this.tbProfit = new System.Windows.Forms.TabPage();
            this.btnProducts = new System.Windows.Forms.Button();
            this.lbID = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbDay = new System.Windows.Forms.Label();
            this.lbMonth = new System.Windows.Forms.Label();
            this.lbYear = new System.Windows.Forms.Label();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.btnSales = new System.Windows.Forms.Button();
            this.btbProfitData = new System.Windows.Forms.Button();
            this.lbSelectProduct = new System.Windows.Forms.Label();
            this.lbSelectEmployee = new System.Windows.Forms.Label();
            this.cbProductList = new System.Windows.Forms.ComboBox();
            this.cbEmployeeList = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tbQuantity.SuspendLayout();
            this.tbSales.SuspendLayout();
            this.tbProfit.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbQuantity);
            this.tabControl1.Controls.Add(this.tbSales);
            this.tabControl1.Controls.Add(this.tbProfit);
            this.tabControl1.Location = new System.Drawing.Point(12, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(793, 433);
            this.tabControl1.TabIndex = 0;
            // 
            // tbQuantity
            // 
            this.tbQuantity.Controls.Add(this.txtName);
            this.tbQuantity.Controls.Add(this.txtID);
            this.tbQuantity.Controls.Add(this.lbName);
            this.tbQuantity.Controls.Add(this.lbID);
            this.tbQuantity.Controls.Add(this.btnProducts);
            this.tbQuantity.Location = new System.Drawing.Point(4, 25);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Padding = new System.Windows.Forms.Padding(3);
            this.tbQuantity.Size = new System.Drawing.Size(785, 404);
            this.tbQuantity.TabIndex = 0;
            this.tbQuantity.Text = "Number of products imported";
            this.tbQuantity.UseVisualStyleBackColor = true;
            // 
            // tbSales
            // 
            this.tbSales.Controls.Add(this.btnSales);
            this.tbSales.Controls.Add(this.txtYear);
            this.tbSales.Controls.Add(this.txtMonth);
            this.tbSales.Controls.Add(this.txtDay);
            this.tbSales.Controls.Add(this.lbYear);
            this.tbSales.Controls.Add(this.lbMonth);
            this.tbSales.Controls.Add(this.lbDay);
            this.tbSales.Location = new System.Drawing.Point(4, 25);
            this.tbSales.Name = "tbSales";
            this.tbSales.Padding = new System.Windows.Forms.Padding(3);
            this.tbSales.Size = new System.Drawing.Size(785, 404);
            this.tbSales.TabIndex = 1;
            this.tbSales.Text = "Statistics on sales revenue over time";
            this.tbSales.UseVisualStyleBackColor = true;
            this.tbSales.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tbProfit
            // 
            this.tbProfit.Controls.Add(this.cbEmployeeList);
            this.tbProfit.Controls.Add(this.cbProductList);
            this.tbProfit.Controls.Add(this.lbSelectEmployee);
            this.tbProfit.Controls.Add(this.lbSelectProduct);
            this.tbProfit.Controls.Add(this.btbProfitData);
            this.tbProfit.Location = new System.Drawing.Point(4, 25);
            this.tbProfit.Name = "tbProfit";
            this.tbProfit.Padding = new System.Windows.Forms.Padding(3);
            this.tbProfit.Size = new System.Drawing.Size(785, 404);
            this.tbProfit.TabIndex = 2;
            this.tbProfit.Text = "Profit statistics";
            this.tbProfit.UseVisualStyleBackColor = true;
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(66, 175);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(166, 23);
            this.btnProducts.TabIndex = 0;
            this.btnProducts.Text = "Get Imported Products";
            this.btnProducts.UseVisualStyleBackColor = true;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(63, 67);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(20, 16);
            this.lbID.TabIndex = 4;
            this.lbID.Text = "ID";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(63, 111);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(44, 16);
            this.lbName.TabIndex = 5;
            this.lbName.Text = "Name";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(148, 66);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(84, 22);
            this.txtID.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(145, 110);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(86, 22);
            this.txtName.TabIndex = 10;
            // 
            // lbDay
            // 
            this.lbDay.AutoSize = true;
            this.lbDay.Location = new System.Drawing.Point(44, 84);
            this.lbDay.Name = "lbDay";
            this.lbDay.Size = new System.Drawing.Size(32, 16);
            this.lbDay.TabIndex = 0;
            this.lbDay.Text = "Day";
            // 
            // lbMonth
            // 
            this.lbMonth.AutoSize = true;
            this.lbMonth.Location = new System.Drawing.Point(35, 126);
            this.lbMonth.Name = "lbMonth";
            this.lbMonth.Size = new System.Drawing.Size(43, 16);
            this.lbMonth.TabIndex = 1;
            this.lbMonth.Text = "Month";
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Location = new System.Drawing.Point(35, 173);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(36, 16);
            this.lbYear.TabIndex = 2;
            this.lbYear.Text = "Year";
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(152, 84);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(100, 22);
            this.txtDay.TabIndex = 3;
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(152, 126);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(100, 22);
            this.txtMonth.TabIndex = 4;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(152, 170);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 22);
            this.txtYear.TabIndex = 5;
            // 
            // btnSales
            // 
            this.btnSales.Location = new System.Drawing.Point(81, 249);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(171, 23);
            this.btnSales.TabIndex = 6;
            this.btnSales.Text = "Get Sales Revenue";
            this.btnSales.UseVisualStyleBackColor = true;
            // 
            // btbProfitData
            // 
            this.btbProfitData.Location = new System.Drawing.Point(86, 211);
            this.btbProfitData.Name = "btbProfitData";
            this.btbProfitData.Size = new System.Drawing.Size(154, 23);
            this.btbProfitData.TabIndex = 0;
            this.btbProfitData.Text = "Get Profit Data";
            this.btbProfitData.UseVisualStyleBackColor = true;
            // 
            // lbSelectProduct
            // 
            this.lbSelectProduct.AutoSize = true;
            this.lbSelectProduct.Location = new System.Drawing.Point(52, 73);
            this.lbSelectProduct.Name = "lbSelectProduct";
            this.lbSelectProduct.Size = new System.Drawing.Size(94, 16);
            this.lbSelectProduct.TabIndex = 1;
            this.lbSelectProduct.Text = "Select Product";
            // 
            // lbSelectEmployee
            // 
            this.lbSelectEmployee.AutoSize = true;
            this.lbSelectEmployee.Location = new System.Drawing.Point(51, 134);
            this.lbSelectEmployee.Name = "lbSelectEmployee";
            this.lbSelectEmployee.Size = new System.Drawing.Size(110, 16);
            this.lbSelectEmployee.TabIndex = 2;
            this.lbSelectEmployee.Text = "Select Employee";
            // 
            // cbProductList
            // 
            this.cbProductList.FormattingEnabled = true;
            this.cbProductList.Location = new System.Drawing.Point(185, 73);
            this.cbProductList.Name = "cbProductList";
            this.cbProductList.Size = new System.Drawing.Size(121, 24);
            this.cbProductList.TabIndex = 3;
            // 
            // cbEmployeeList
            // 
            this.cbEmployeeList.FormattingEnabled = true;
            this.cbEmployeeList.Location = new System.Drawing.Point(185, 126);
            this.cbEmployeeList.Name = "cbEmployeeList";
            this.cbEmployeeList.Size = new System.Drawing.Size(121, 24);
            this.cbEmployeeList.TabIndex = 4;
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.tabControl1.ResumeLayout(false);
            this.tbQuantity.ResumeLayout(false);
            this.tbQuantity.PerformLayout();
            this.tbSales.ResumeLayout(false);
            this.tbSales.PerformLayout();
            this.tbProfit.ResumeLayout(false);
            this.tbProfit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbQuantity;
        private System.Windows.Forms.TabPage tbSales;
        private System.Windows.Forms.TabPage tbProfit;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.Label lbMonth;
        private System.Windows.Forms.Label lbDay;
        private System.Windows.Forms.ComboBox cbEmployeeList;
        private System.Windows.Forms.ComboBox cbProductList;
        private System.Windows.Forms.Label lbSelectEmployee;
        private System.Windows.Forms.Label lbSelectProduct;
        private System.Windows.Forms.Button btbProfitData;
    }
}