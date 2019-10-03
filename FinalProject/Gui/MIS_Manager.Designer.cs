namespace FinalProject.Gui
{
    partial class MIS_Manager
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ButtonList = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxLn = new System.Windows.Forms.TextBox();
            this.textBoxFn = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 369);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(778, 190);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonSearch);
            this.groupBox3.Controls.Add(this.textBoxSearch);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(839, 52);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(608, 284);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Employee Search";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(365, 77);
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
            this.textBoxSearch.Location = new System.Drawing.Point(36, 91);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(258, 31);
            this.textBoxSearch.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Please Enter First Name\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRole);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.ButtonList);
            this.groupBox1.Controls.Add(this.buttonDelete);
            this.groupBox1.Controls.Add(this.buttonUpdate);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxLn);
            this.groupBox1.Controls.Add(this.textBoxFn);
            this.groupBox1.Controls.Add(this.textBoxId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(33, 36);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(778, 300);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Information";
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(49, 168);
            this.txtRole.Margin = new System.Windows.Forms.Padding(6);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(258, 31);
            this.txtRole.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 124);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 25);
            this.label9.TabIndex = 31;
            this.label9.Text = "Role";
            // 
            // ButtonList
            // 
            this.ButtonList.Location = new System.Drawing.Point(535, 236);
            this.ButtonList.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonList.Name = "ButtonList";
            this.ButtonList.Size = new System.Drawing.Size(150, 44);
            this.ButtonList.TabIndex = 30;
            this.ButtonList.Text = "&List";
            this.ButtonList.UseVisualStyleBackColor = true;
            this.ButtonList.Click += new System.EventHandler(this.ButtonList_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(351, 236);
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
            this.buttonUpdate.Location = new System.Drawing.Point(535, 161);
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
            this.buttonSave.Location = new System.Drawing.Point(351, 161);
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
            // textBoxLn
            // 
            this.textBoxLn.Location = new System.Drawing.Point(522, 63);
            this.textBoxLn.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxLn.Name = "textBoxLn";
            this.textBoxLn.Size = new System.Drawing.Size(234, 31);
            this.textBoxLn.TabIndex = 23;
            // 
            // textBoxFn
            // 
            this.textBoxFn.Location = new System.Drawing.Point(307, 63);
            this.textBoxFn.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxFn.Name = "textBoxFn";
            this.textBoxFn.Size = new System.Drawing.Size(194, 31);
            this.textBoxFn.TabIndex = 22;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(49, 63);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(196, 31);
            this.textBoxId.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(592, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Employee ID";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(839, 369);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.Size = new System.Drawing.Size(690, 190);
            this.dataGridView2.TabIndex = 9;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(1379, 605);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(6);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(150, 44);
            this.buttonExit.TabIndex = 31;
            this.buttonExit.Text = "&Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // MIS_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1568, 683);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MIS_Manager";
            this.Text = "MIS Manager";
            this.Load += new System.EventHandler(this.MIS_Manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ButtonList;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxLn;
        private System.Windows.Forms.TextBox textBoxFn;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button buttonExit;
    }
}