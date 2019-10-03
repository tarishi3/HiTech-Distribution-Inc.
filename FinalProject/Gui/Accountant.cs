using FinalProject.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.Gui
{
    public partial class Accountant : Form
    {
        public Accountant()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                textBoxId.Text = item.SubItems[0].Text;
                textBoxisbn.Text = item.SubItems[1].Text;
                textBoxprice.Text = item.SubItems[2].Text;
                textBoxQuantity.Text = item.SubItems[3].Text;
                textBoxmethod.Text = item.SubItems[4].Text;
                textBoxCustID.Text = item.SubItems[5].Text;
            }
            else { refresh(); }
        }

        private void refresh() {
            textBoxId.Clear();
            textBoxQuantity.Clear();
            textBoxprice.Clear();
            textBoxmethod.Clear();
            textBoxisbn.Clear();
            textBoxCustID.Clear();
            textBoxSearch.Clear();

        }

        private void disableTextBox() {
            textBoxId.Enabled = false;
            textBoxCustID.Enabled = false;
            textBoxisbn.Enabled = false;
            textBoxmethod.Enabled = false;
            textBoxprice.Enabled = false;
            textBoxQuantity.Enabled = false;
        }

        private void Accountant_Load(object sender, EventArgs e)
        {
            disableTextBox();
            var context = new HiTechDBEntities1();
            var query1 = from c in context.Orders
                         select c;

            listView1.Items.Clear();
            foreach (var o1 in query1)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(o1.OrderID));
                item.SubItems.Add(Convert.ToString(o1.Isbn));
                item.SubItems.Add(Convert.ToString(o1.TotalPrice));
                item.SubItems.Add(Convert.ToString(o1.Quantity));
                item.SubItems.Add(o1.OrderType);
                item.SubItems.Add(Convert.ToString(o1.CustomerID));
                listView1.Items.Add(item);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxSearch.Text != "")
                {
                    int id = Convert.ToInt32(textBoxSearch.Text);
                    var context = new HiTechDBEntities1();
                    var query1 = from c in context.Orders
                                 where c.CustomerID == id
                                 select c;

                    listView1.Items.Clear();
                    foreach (var o1 in query1)
                    {
                        ListViewItem item = new ListViewItem(Convert.ToString(o1.OrderID));
                        item.SubItems.Add(Convert.ToString(o1.Isbn));
                        item.SubItems.Add(Convert.ToString(o1.TotalPrice));
                        item.SubItems.Add(Convert.ToString(o1.Quantity));
                        item.SubItems.Add(o1.OrderType);
                        item.SubItems.Add(Convert.ToString(o1.CustomerID));
                        listView1.Items.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter customer id to search invoice");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            try
            {
                var time = DateTime.Now;
                string formattedTime = time.ToString("yyyy, MM, dd, hh, mm, ss");
                String txtFilePath = @"../../Invoices/" + textBoxCustID.Text + "_" + textBoxId.Text + "_" + formattedTime + ".txt";

                using (StreamWriter writer = File.CreateText(txtFilePath))
                {
                    string write = "Customer ID: " + textBoxCustID.Text + ", Order ID: " +
                        textBoxId.Text + ", Book ISBN: " + textBoxisbn.Text + ", Quantity: " + textBoxQuantity.Text +
                        ", Order Method: " + textBoxmethod.Text + ", Total Price: $" + textBoxprice.Text;
                    writer.WriteLine(write);
                }
                MessageBox.Show("Succesfull");
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }
    }
}
