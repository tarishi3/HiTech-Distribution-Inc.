namespace FinalProject.Gui
{
    partial class Accountant
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.OrderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Isbn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxCustID = new System.Windows.Forms.TextBox();
            this.textBoxisbn = new System.Windows.Forms.TextBox();
            this.textBoxmethod = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxprice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OrderID,
            this.Isbn,
            this.TotalPrice,
            this.Quantity,
            this.OrderType,
            this.CustomerID});
            this.listView1.Location = new System.Drawing.Point(12, 340);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1015, 558);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // OrderID
            // 
            this.OrderID.Text = "Order ID";
            this.OrderID.Width = 148;
            // 
            // Isbn
            // 
            this.Isbn.Text = "Isbn";
            this.Isbn.Width = 116;
            // 
            // TotalPrice
            // 
            this.TotalPrice.Text = "Total Price";
            this.TotalPrice.Width = 138;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            this.Quantity.Width = 138;
            // 
            // OrderType
            // 
            this.OrderType.Text = "Order Type";
            this.OrderType.Width = 159;
            // 
            // CustomerID
            // 
            this.CustomerID.Text = "Customer ID";
            this.CustomerID.Width = 133;
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(594, 137);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(129, 50);
            this.buttonPrint.TabIndex = 8;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(1099, 835);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(142, 63);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(45, 63);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(196, 31);
            this.textBoxId.TabIndex = 33;
            // 
            // textBoxCustID
            // 
            this.textBoxCustID.Location = new System.Drawing.Point(364, 63);
            this.textBoxCustID.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxCustID.Name = "textBoxCustID";
            this.textBoxCustID.Size = new System.Drawing.Size(196, 31);
            this.textBoxCustID.TabIndex = 34;
            // 
            // textBoxisbn
            // 
            this.textBoxisbn.Location = new System.Drawing.Point(45, 147);
            this.textBoxisbn.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxisbn.Name = "textBoxisbn";
            this.textBoxisbn.Size = new System.Drawing.Size(196, 31);
            this.textBoxisbn.TabIndex = 35;
            // 
            // textBoxmethod
            // 
            this.textBoxmethod.Location = new System.Drawing.Point(364, 147);
            this.textBoxmethod.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxmethod.Name = "textBoxmethod";
            this.textBoxmethod.Size = new System.Drawing.Size(196, 31);
            this.textBoxmethod.TabIndex = 36;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(45, 247);
            this.textBoxQuantity.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(196, 31);
            this.textBoxQuantity.TabIndex = 37;
            // 
            // textBoxprice
            // 
            this.textBoxprice.Location = new System.Drawing.Point(364, 247);
            this.textBoxprice.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxprice.Name = "textBoxprice";
            this.textBoxprice.Size = new System.Drawing.Size(196, 31);
            this.textBoxprice.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 39;
            this.label3.Text = "Order ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 40;
            this.label1.Text = "Book ISBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 216);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 41;
            this.label2.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 25);
            this.label4.TabIndex = 42;
            this.label4.Text = "Customer ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(359, 116);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 25);
            this.label5.TabIndex = 43;
            this.label5.Text = "Order Method";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(359, 216);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 25);
            this.label6.TabIndex = 44;
            this.label6.Text = "Total Price";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonSearch);
            this.groupBox2.Controls.Add(this.textBoxSearch);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(750, 32);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(608, 284);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order Search";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(31, 165);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(6);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(150, 44);
            this.buttonSearch.TabIndex = 9;
            this.buttonSearch.Text = "&Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(31, 96);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(258, 31);
            this.textBoxSearch.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 52);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(406, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Please Enter Customer ID to view Invoice";
            // 
            // Accountant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 910);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxprice);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.textBoxmethod);
            this.Controls.Add(this.textBoxisbn);
            this.Controls.Add(this.textBoxCustID);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.listView1);
            this.Name = "Accountant";
            this.Text = "Accountant";
            this.Load += new System.EventHandler(this.Accountant_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader OrderID;
        private System.Windows.Forms.ColumnHeader Isbn;
        private System.Windows.Forms.ColumnHeader TotalPrice;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader OrderType;
        private System.Windows.Forms.ColumnHeader CustomerID;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxCustID;
        private System.Windows.Forms.TextBox textBoxisbn;
        private System.Windows.Forms.TextBox textBoxmethod;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxprice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label8;
    }
}