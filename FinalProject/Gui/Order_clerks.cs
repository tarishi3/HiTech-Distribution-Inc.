using FinalProject.Business;
using FinalProject.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.Gui
{
    public partial class Order_clerks : Form
    {
        HiTechDBEntities1 dBEntities1 = new HiTechDBEntities1();
        public Order_clerks()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ButtonList_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtRole_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void refresh() {

            textBoxSearch.Clear();
            textBoxId.Clear();
            textBoxQuantity.Clear();
            comboBoxCustomer.SelectedItem = "";
            comboBoxIsbn.SelectedItem = "";
            comboBoxType.SelectedItem = "";
        
        }

        private void Order_clerks_Load(object sender, EventArgs e)
        {
            textBoxId.Enabled = false;
            listView1.FullRowSelect = true;

            comboBoxType.Items.Add("Fax");
            comboBoxType.Items.Add("Email");
            comboBoxType.Items.Add("Phone");

            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand();
            if (connDB.State == ConnectionState.Closed)
            {
                connDB = UtilityDB.ConnectDB();
            }
            cmd.Connection = connDB;
            cmd.CommandText = "select CustomerID from Customers";
            SqlDataReader value = cmd.ExecuteReader();

            var context = new HiTechDBEntities1();
            var query1 = from c in context.Books
                         select c.ISBN;

            foreach (var book in query1)
            {
                comboBoxIsbn.Items.Add(book);
            }
            while(value.Read())
            {
                comboBoxCustomer.Items.Add(value.GetValue(0).ToString());
            }

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Order o1 = new Order();
            o1.Isbn = Convert.ToInt32(comboBoxIsbn.SelectedItem.ToString());

            var context = new HiTechDBEntities1();
            var query1 = from c in context.Books
                         where c.ISBN == o1.Isbn
                         select c.QOH;

            int q = 0;
            foreach (var item in query1)
            {
                q = Convert.ToInt32(item.ToString());
            }
            if (q < Convert.ToInt32(textBoxQuantity.Text))
            {
                string msg = "There are only " + q + " books left order less than or equal to that please.";
                MessageBox.Show(msg);
                textBoxQuantity.Clear();
                textBoxQuantity.Focus();
                return;
                
            }
            else
            {
                o1.Quantity = Convert.ToInt32(textBoxQuantity.Text);
            }

            o1.OrderType = comboBoxType.SelectedItem.ToString();
            o1.CustomerID = Convert.ToInt32(comboBoxCustomer.SelectedItem.ToString());

            var query2 = from c in context.Books
                         where c.ISBN == o1.Isbn
                         select c.UnitPrice;

            double price = 0.0;
            foreach (var item in query2)
            {
                price = Convert.ToDouble(item.ToString());
            }
            double total = price * o1.Quantity;
            o1.TotalPrice = Convert.ToDecimal(total);
            dBEntities1.Orders.Add(o1);
            dBEntities1.SaveChanges();
            MessageBox.Show("Saved Succesfully");
            refresh();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Order o1 = new Order();
            int id = Convert.ToInt32(comboBoxIsbn.SelectedItem.ToString());
            
            o1 = dBEntities1.Orders.Find(id);
            if(o1 != null)
            {
                o1.Isbn = id;
                var context = new HiTechDBEntities1();
                var query1 = from c in context.Books
                             where c.ISBN == o1.Isbn
                             select c.QOH;

                int q = 0;
                foreach (var item in query1)
                {
                    q = Convert.ToInt32(item.ToString());
                }
                if (q < Convert.ToInt32(textBoxQuantity.Text))
                {
                    string msg = "There are only " + q + " books left order less than or equal to that please.";
                    MessageBox.Show(msg);
                    textBoxQuantity.Clear();
                    textBoxQuantity.Focus();
                    return;

                }
                else
                {
                    o1.Quantity = Convert.ToInt32(textBoxQuantity.Text);
                }

                o1.OrderType = comboBoxType.SelectedItem.ToString();
                o1.CustomerID = Convert.ToInt32(comboBoxCustomer.SelectedItem.ToString());

                var query2 = from c in context.Books
                             where c.ISBN == o1.Isbn
                             select c.UnitPrice;

                double price = 0.0;
                foreach (var item in query2)
                {
                    price = Convert.ToDouble(item.ToString());
                }
                double total = price * o1.Quantity;
                o1.TotalPrice = Convert.ToDecimal(total);
                dBEntities1.SaveChanges();
                MessageBox.Show("Updated Succesfully");
                refresh();
            }
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                textBoxId.Text = item.SubItems[0].Text;
                comboBoxIsbn.SelectedItem = item.SubItems[1].Text;
                textBoxQuantity.Text = item.SubItems[3].Text;
                comboBoxType.SelectedItem = item.SubItems[4].Text;
                comboBoxCustomer.SelectedItem = item.SubItems[5].Text;
            }
            else
            {
                refresh();
            }
        }

        private void ButtonList_Click_1(object sender, EventArgs e)
        {
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Order o1 = new Order();
            int id = Convert.ToInt32(textBoxId.Text);
            o1 = dBEntities1.Orders.Find(id);
            if (o1 != null)
            {
                dBEntities1.Orders.Remove(o1);
                dBEntities1.SaveChanges();
                MessageBox.Show("Deleted Succesfully");
                refresh();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "")
            {
                MessageBox.Show("Enter information first.");
            }
            else
            {
                int isbn = Convert.ToInt32(textBoxSearch.Text);
                var context = new HiTechDBEntities1();
                var query1 = from c in context.Orders
                             where c.Isbn == isbn
                             select c;
                listView2.Items.Clear();
                foreach (var o1 in query1)
                {
                    ListViewItem item = new ListViewItem(Convert.ToString(o1.OrderID));
                    item.SubItems.Add(Convert.ToString(o1.Isbn));
                    item.SubItems.Add(Convert.ToString(o1.TotalPrice));
                    item.SubItems.Add(Convert.ToString(o1.Quantity));
                    item.SubItems.Add(o1.OrderType);
                    item.SubItems.Add(Convert.ToString(o1.CustomerID));
                    listView2.Items.Add(item);
                }
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
