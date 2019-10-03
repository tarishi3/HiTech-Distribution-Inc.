namespace FinalProject.Gui
{
    partial class Order_clerks
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxCustomer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxIsbn = new System.Windows.Forms.ComboBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonList = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.OrderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Isbn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonSearch);
            this.groupBox2.Controls.Add(this.textBoxSearch);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(881, 55);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(608, 284);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order Search";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(360, 82);
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
            this.label8.Size = new System.Drawing.Size(236, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Please Enter Book Isbn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxCustomer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxType);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBoxIsbn);
            this.groupBox1.Controls.Add(this.textBoxId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ButtonList);
            this.groupBox1.Controls.Add(this.buttonDelete);
            this.groupBox1.Controls.Add(this.buttonUpdate);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxQuantity);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(47, 39);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(641, 300);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Information";
            // 
            // comboBoxCustomer
            // 
            this.comboBoxCustomer.FormattingEnabled = true;
            this.comboBoxCustomer.Location = new System.Drawing.Point(144, 253);
            this.comboBoxCustomer.Name = "comboBoxCustomer";
            this.comboBoxCustomer.Size = new System.Drawing.Size(196, 33);
            this.comboBoxCustomer.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 253);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 36;
            this.label2.Text = "Customer ID";
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(144, 192);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(196, 33);
            this.comboBoxType.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 197);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 34;
            this.label4.Text = "Order Type";
            // 
            // comboBoxIsbn
            // 
            this.comboBoxIsbn.FormattingEnabled = true;
            this.comboBoxIsbn.Location = new System.Drawing.Point(144, 94);
            this.comboBoxIsbn.Name = "comboBoxIsbn";
            this.comboBoxIsbn.Size = new System.Drawing.Size(196, 33);
            this.comboBoxIsbn.TabIndex = 33;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(144, 49);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(196, 31);
            this.textBoxId.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "Order ID";
            // 
            // ButtonList
            // 
            this.ButtonList.Location = new System.Drawing.Point(425, 243);
            this.ButtonList.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonList.Name = "ButtonList";
            this.ButtonList.Size = new System.Drawing.Size(150, 44);
            this.ButtonList.TabIndex = 30;
            this.ButtonList.Text = "&List";
            this.ButtonList.UseVisualStyleBackColor = true;
            this.ButtonList.Click += new System.EventHandler(this.ButtonList_Click_1);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(425, 187);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(6);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(150, 44);
            this.buttonDelete.TabIndex = 29;
            this.buttonDelete.Text = "&Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(425, 121);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(6);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(150, 44);
            this.buttonUpdate.TabIndex = 28;
            this.buttonUpdate.Text = "&Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(425, 49);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(6);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(150, 44);
            this.buttonSave.TabIndex = 27;
            this.buttonSave.Text = "&Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-107, 96);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "(4 Digits)";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(144, 140);
            this.textBoxQuantity.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(196, 31);
            this.textBoxQuantity.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 140);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Book ISBN";
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
            this.listView1.Location = new System.Drawing.Point(21, 366);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(838, 245);
            this.listView1.TabIndex = 6;
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
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView2.Location = new System.Drawing.Point(881, 366);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(608, 245);
            this.listView2.TabIndex = 7;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Order ID";
            this.columnHeader1.Width = 148;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Isbn";
            this.columnHeader2.Width = 116;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Total Price";
            this.columnHeader3.Width = 138;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Quantity";
            this.columnHeader4.Width = 138;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Order Type";
            this.columnHeader5.Width = 159;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Customer ID";
            this.columnHeader6.Width = 133;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(1339, 637);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(6);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(150, 44);
            this.buttonExit.TabIndex = 29;
            this.buttonExit.Text = "&Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Order_clerks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1511, 706);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Order_clerks";
            this.Text = "Order_clerks";
            this.Load += new System.EventHandler(this.Order_clerks_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxIsbn;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonList;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader OrderID;
        private System.Windows.Forms.ColumnHeader Isbn;
        private System.Windows.Forms.ColumnHeader TotalPrice;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader OrderType;
        private System.Windows.Forms.ComboBox comboBoxCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader CustomerID;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button buttonExit;
    }
}