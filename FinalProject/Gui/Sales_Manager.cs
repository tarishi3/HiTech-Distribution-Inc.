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
    public partial class Sales_Manager : Form
    {
        public Sales_Manager()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBoxId.Text = row.Cells["CustomerID"].Value.ToString();
                textBoxFn.Text = row.Cells["FirstName"].Value.ToString();
                textBoxLn.Text = row.Cells["LastName"].Value.ToString();
                textBoxStreet.Text = row.Cells["Street"].Value.ToString();
                textBoxCity.Text = row.Cells["City"].Value.ToString();
                textBoxPnumber.Text = row.Cells["Phone"].Value.ToString();
                textBoxPostal.Text = row.Cells["Postal"].Value.ToString();
                textBoxFax.Text = row.Cells["FaxNumber"].Value.ToString();
                textBoxCredit.Text = row.Cells["CreditLimit"].Value.ToString();
            }
        }

        private void Sales_Manager_Load(object sender, EventArgs e)
        {
            textBoxId.Enabled = false;
            Customer c1 = new Customer();
            c1.ReadCustomer();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxFn.Text == "" || textBoxLn.Text == "" || textBoxStreet.Text == "" || textBoxCredit.Text == "" || textBoxCity.Text == "" || textBoxFax.Text == "" || textBoxPnumber.Text == "" || textBoxPostal.Text == "")
            {
                MessageBox.Show("Your information cannot be saved", "Error");
            }
            else
            {
                Customer c1 = new Customer();
                c1.FirstName = textBoxFn.Text;
                c1.LastName = textBoxLn.Text;
                c1.Street = textBoxStreet.Text;
                c1.City = textBoxCity.Text;
                c1.Postal = textBoxPostal.Text;
                c1.Phone = textBoxPnumber.Text;
                c1.FaxNumber = textBoxFax.Text;
                c1.CreditLimit = Convert.ToDouble(textBoxCredit.Text);

                if (c1.SaveRecord(c1))
                {
                    MessageBox.Show("Your information has been saved", "Confirmation");
                }
                else
                {
                    MessageBox.Show("Your information cannot be saved", "Error");
                }
                refresh();
                ButtonList_Click(sender, e);
            }
        }

        private void refresh()
        {

            textBoxCity.Clear();
            textBoxCredit.Clear();
            textBoxFax.Clear();
            textBoxFn.Clear();
            textBoxId.Clear();
            textBoxLn.Clear();
            textBoxPnumber.Clear();
            textBoxPostal.Clear();
            textBoxStreet.Clear();
        }

        private void ButtonList_Click(object sender, EventArgs e)
        {
            Customer c1 = new Customer();
            dataGridView1.DataSource = c1.ReadCustomer();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxFn.Text == "" || textBoxLn.Text == "" || textBoxStreet.Text == "" || textBoxCredit.Text == "" || textBoxCity.Text == "" || textBoxFax.Text == "" || textBoxPnumber.Text == "" || textBoxPostal.Text == "")
            {
                MessageBox.Show("Your information cannot be saved", "Error");
            }
            else
            {
                Customer c1 = new Customer();
                c1.CustomerId = Convert.ToInt32(textBoxId.Text);
                c1.FirstName = textBoxFn.Text;
                c1.LastName = textBoxLn.Text;
                c1.Street = textBoxStreet.Text;
                c1.City = textBoxCity.Text;
                c1.Postal = textBoxPostal.Text;
                c1.Phone = textBoxPnumber.Text;
                c1.FaxNumber = textBoxFax.Text;
                c1.CreditLimit = Convert.ToDouble(textBoxCredit.Text);

                if (c1.UpdateRecord(c1))
                {
                    MessageBox.Show("Your information has been updated", "Confirmation");
                }
                else
                {
                    MessageBox.Show("Your information cannot be updated", "Error");
                }
                refresh();
                ButtonList_Click(sender, e);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxFn.Text == "" || textBoxLn.Text == "" || textBoxStreet.Text == "" || textBoxCredit.Text == "" || textBoxCity.Text == "" || textBoxFax.Text == "" || textBoxPnumber.Text == "" || textBoxPostal.Text == "")
            {
                MessageBox.Show("Your information cannot be deleted", "Error");
            }
            else
            {
                Customer c1 = new Customer();
                c1.CustomerId = Convert.ToInt32(textBoxId.Text);

                if (c1.DeleteRecord(c1))
                {
                    MessageBox.Show("Your information has been deleted", "Confirmation");
                }
                else
                {
                    MessageBox.Show("Your information cannot be deleted", "Error");
                }
                refresh();
                ButtonList_Click(sender, e);
            }
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
                Customer customer = new Customer();
                customer.FirstName = textBoxSearch.Text;
                var dt = customer.SearchCustomer(customer);
                if (dt.Rows.Count > 0)
                {
                    dataGridView2.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Customer is not Present.............");
                }
                textBoxSearch.Text = "";
            }
        }
    }
}
