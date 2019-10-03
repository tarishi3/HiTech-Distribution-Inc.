using FinalProject.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.Gui
{
    public partial class MIS_Manager : Form
    {
        public MIS_Manager()
        {
            InitializeComponent();
        }

        private void MIS_Manager_Load(object sender, EventArgs e)
        {
            textBoxId.Enabled = false;
        }

        private void tabUsers_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxFn.Text == "" || textBoxLn.Text == "" || txtRole.Text == "")
            {
                MessageBox.Show("Your information cannot be saved", "Error");
            }
            else
            {
                Employee emp = new Employee();
                emp.FirstName = textBoxFn.Text;
                emp.LastName = textBoxLn.Text;
                emp.Designation = txtRole.Text;
                if (emp.SaveRecord(emp))
                {
                    MessageBox.Show("Your information has been saved", "Confirmation");
                }
                else
                {
                    MessageBox.Show("Your information cannot be saved", "Error");
                }
            }
            refresh();
        }

        private void refresh() {

            Employee emp = new Employee();
            dataGridView1.DataSource = emp.ReadEmployee();
            textBoxFn.Clear();
            textBoxId.Clear();
            textBoxLn.Clear();
            txtRole.Clear();
            textBoxSearch.Clear();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxFn.Text == "" || textBoxLn.Text == "" || txtRole.Text == "")
            {
                MessageBox.Show("Cannot Update.... Something went Wrong");
            }
            else
            {
                Employee emp = new Employee();
                emp.EmployeeId = Convert.ToInt32(textBoxId.Text);
                emp.FirstName = textBoxFn.Text;
                emp.LastName = textBoxLn.Text;
                emp.Designation = txtRole.Text;

                if (emp.UpdateRecord(emp))
                {
                    MessageBox.Show("The Selected Row is now Updated......");
                }
                else
                {
                    MessageBox.Show("Something went wrong......");
                }
            }
            refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBoxId.Text = row.Cells["EmployeeID"].Value.ToString();
                textBoxFn.Text = row.Cells["FirstName"].Value.ToString();
                textBoxLn.Text = row.Cells["LastName"].Value.ToString();
                txtRole.Text = row.Cells["Designation"].Value.ToString();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxFn.Text == "" || textBoxLn.Text == "" || txtRole.Text == "" || textBoxId.Text == "")
            {
                MessageBox.Show("Cannot Update.... Something went Wrong");
            }
            else
            {
                Employee emp = new Employee();
                emp.EmployeeId = Convert.ToInt32(textBoxId.Text);

                if (emp.DeleteRecord(emp))
                {
                    MessageBox.Show("The Selected Row is now Updated......");
                }
                else
                {
                    MessageBox.Show("Something went wrong......");
                }
            }
            refresh();
        }

        private void ButtonList_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            dataGridView1.DataSource = emp.ReadEmployee();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "")
            {
                MessageBox.Show("Enter information first.");
            }
            else
            {
                Employee emp = new Employee();
                emp.FirstName = textBoxSearch.Text;
                var dt = emp.SearchEmployee(emp);
                if (dt.Rows.Count > 0)
                {
                    dataGridView2.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Employee is not Present.............");
                }
                textBoxSearch.Text = "";
            }
        }
    }
}
