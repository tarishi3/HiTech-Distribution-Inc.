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
    public partial class Inventory : Form
    {
        HiTechDBEntities1 dBEntities1 = new HiTechDBEntities1();
        public static SqlConnection connDB = UtilityDB.ConnectDB();
        public static SqlCommand cmd = new SqlCommand();
        public Inventory()
        {
            InitializeComponent();
        }

        private void fillCategory()
        {
            comboCategory.Items.Add("Fiction");
            comboCategory.Items.Add("Comedy");
            comboCategory.Items.Add("Romantic");
            comboCategory.Items.Add("Non-Fiction");
            comboCategory.Items.Add("Documentry");
            comboCategory.Items.Add("Science");
            comboCategory.Items.Add("Horror");
        }

        private void fillPublisher()
        {
            comboPublisher.Items.Add("Wrox");
            comboPublisher.Items.Add("Premier Press");
            comboPublisher.Items.Add("Prentice Hall");
            comboPublisher.Items.Add("Murach");
        }

        private void fillIsbn()
        {
            var context = new HiTechDBEntities1();
            var query1 = from c in context.Books
                         select c.ISBN;

            foreach (var item in query1)
            {
                comboIsbn.Items.Add(item);
            }
        }

        private void fillAuthor()
        {
            var context = new HiTechDBEntities1();
            var query1 = from c in context.Authors
                         select c.AuthorID;

            foreach (var item in query1)
            {
                comboID.Items.Add(item);
            }
        }

        private void fillSearch() {
            comboBoxSearch.Items.Add("ISBN");
            comboBoxSearch.Items.Add("AuthorID");
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            fillCategory();
            fillPublisher();
            fillAuthor();
            fillIsbn();
            fillSearch();
            listView1.FullRowSelect = true;
            listView2.FullRowSelect = true;
            listView3.FullRowSelect = true;
            listView4.FullRowSelect = true;

            txtIsbn.Enabled = false;
            txtAuthorId.Enabled = false;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearTextBox()
        {
            txtAuthorFName.Clear();
            txtAuthorId.Clear();
            txtAuthorLName.Clear();
            txtAuthorSearch.Clear();
            txtEmail.Clear();
            txtIsbn.Clear();
            txtPrice.Clear();
            txtPublishYear.Clear();
            txtQoh.Clear();
            txtSearch.Clear();
            txtTitle.Clear();
            comboCategory.SelectedItem = "";
            comboID.SelectedItem = "";
            comboIsbn.SelectedItem = "";
            comboPublisher.SelectedItem = "";
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Book b1 = new Book();
                b1.Title = txtTitle.Text;
                b1.YearPublished = Convert.ToInt32(txtPublishYear.Text);
                b1.QOH = Convert.ToInt32(txtQoh.Text);
                b1.Publisher = comboPublisher.SelectedItem.ToString();
                b1.Genre = comboCategory.SelectedItem.ToString();
                b1.UnitPrice = Convert.ToDecimal(txtPrice.Text);
                dBEntities1.Books.Add(b1);
                dBEntities1.SaveChanges();
                MessageBox.Show("Saved Succesfully");
                clearTextBox();
                buttonDisplay_Click(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Book b1 = new Book();
                int id = Convert.ToInt32(txtIsbn.Text);
                b1 = dBEntities1.Books.Find(id);
                if (b1 != null)
                {
                    b1.ISBN = id;
                    b1.Title = txtTitle.Text;
                    b1.YearPublished = Convert.ToInt32(txtPublishYear.Text);
                    b1.QOH = Convert.ToInt32(txtQoh.Text);
                    b1.Publisher = comboPublisher.SelectedItem.ToString();
                    b1.Genre = comboCategory.SelectedItem.ToString();
                    b1.UnitPrice = Convert.ToDecimal(txtPrice.Text);
                    MessageBox.Show("Updated Succesfully");
                    clearTextBox();
                }
                buttonDisplay_Click(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            var context = new HiTechDBEntities1();
            var query1 = from c in context.Books
                         select c;

            listView1.Items.Clear();
            foreach (var book in query1)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(book.ISBN));
                item.SubItems.Add(book.Title);
                item.SubItems.Add(Convert.ToString(book.UnitPrice));
                item.SubItems.Add(Convert.ToString(book.YearPublished));
                item.SubItems.Add(Convert.ToString(book.QOH));
                item.SubItems.Add(book.Publisher);
                item.SubItems.Add(book.Genre);
                listView1.Items.Add(item);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                txtIsbn.Text = item.SubItems[0].Text;
                txtTitle.Text = item.SubItems[1].Text;
                txtPrice.Text = item.SubItems[2].Text;
                txtPublishYear.Text = item.SubItems[3].Text;
                txtQoh.Text = item.SubItems[4].Text;
                comboPublisher.SelectedItem = item.SubItems[5].Text;
                comboCategory.SelectedItem = item.SubItems[6].Text;
            }
            else
            {
                clearTextBox();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Book b1 = new Book();
                int id = Convert.ToInt32(txtIsbn.Text);
                b1 = dBEntities1.Books.Find(id);
                if (b1 != null)
                {
                    dBEntities1.Books.Remove(b1);
                    dBEntities1.SaveChanges();
                    MessageBox.Show("Deleted Succesfully");
                    clearTextBox();
                }
                buttonDisplay_Click(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string title = txtSearch.Text.Trim();
            var query1 = from c in dBEntities1.Books
                         where c.Title == title
                         select c;
            listView2.Items.Clear();
            foreach (var book in query1)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(book.ISBN));
                item.SubItems.Add(book.Title);
                item.SubItems.Add(Convert.ToString(book.UnitPrice));
                item.SubItems.Add(Convert.ToString(book.YearPublished));
                item.SubItems.Add(Convert.ToString(book.QOH));
                item.SubItems.Add(book.Publisher);
                item.SubItems.Add(book.Genre);
                listView2.Items.Add(item);
            }
        }

        private void buttonAuthorAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Author a1 = new Author();

                a1.FirstName = txtAuthorFName.Text;
                a1.LastName = txtAuthorLName.Text;
                a1.Email = txtEmail.Text;
                dBEntities1.Authors.Add(a1);
                dBEntities1.SaveChanges();
                MessageBox.Show("Saved Succesfully");
                clearTextBox();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void buttonAuthorUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Author a1 = new Author();
                int id = Convert.ToInt32(txtAuthorId.Text);
                a1 = dBEntities1.Authors.Find(id);
                if (a1 != null)
                {
                    a1.AuthorID = id;
                    a1.FirstName = txtAuthorFName.Text;
                    a1.LastName = txtAuthorLName.Text;
                    a1.Email = txtEmail.Text;
                    dBEntities1.SaveChanges();
                    MessageBox.Show("Updated Succesfully");
                    clearTextBox();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void buttonAuthorExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAuthorDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Author a1 = new Author();
                int id = Convert.ToInt32(txtAuthorId.Text);
                a1 = dBEntities1.Authors.Find(id);
                if (a1 != null)
                {
                    dBEntities1.Authors.Remove(a1);
                    dBEntities1.SaveChanges();
                    MessageBox.Show("Deleted Succesfully");
                    clearTextBox();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void buttonAuthorDisplay_Click(object sender, EventArgs e)
        {
            var context = new HiTechDBEntities1();
            var query1 = from c in context.Authors
                         select c;

            listView3.Items.Clear();
            foreach (var a1 in query1)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(a1.AuthorID));
                item.SubItems.Add(a1.FirstName);
                item.SubItems.Add(a1.LastName);
                item.SubItems.Add(a1.Email);
                listView3.Items.Add(item);
            }
        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView3.SelectedItems.Count > 0)
            {
                ListViewItem item = listView3.SelectedItems[0];
                txtAuthorId.Text = item.SubItems[0].Text;
                txtAuthorFName.Text = item.SubItems[1].Text;
                txtAuthorLName.Text = item.SubItems[2].Text;
                txtEmail.Text = item.SubItems[3].Text;
                
            }
            else
            {
                clearTextBox();
            }
        }

        private void listView4_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonAuthorSearch_Click(object sender, EventArgs e)
        {
            string fname = txtAuthorSearch.Text.Trim();
            var query1 = from c in dBEntities1.Authors
                         where c.FirstName == fname
                         select c;
            listView4.Items.Clear();
            foreach (var a1 in query1)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(a1.AuthorID));
                item.SubItems.Add(a1.FirstName);
                item.SubItems.Add(a1.LastName);
                item.SubItems.Add(a1.Email);
                listView4.Items.Add(item);
            }
        }

        private void buttonIsbnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                if (connDB.State == ConnectionState.Closed)
                {
                    connDB = UtilityDB.ConnectDB();
                    cmd = new SqlCommand();
                }
                int isbn = Convert.ToInt32(comboIsbn.SelectedItem.ToString());
                int id = Convert.ToInt32(comboID.SelectedItem.ToString());
                cmd.Connection = connDB;
                cmd.CommandText = string.Format("Insert into BookAuthor values({0},{1})", isbn, id);
                cmd.ExecuteNonQuery();
                connDB.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                comboID.Text = row.Cells["AuthorID"].Value.ToString();
                comboIsbn.Text = row.Cells["ISBN"].Value.ToString();
            }
        }

        private void buttonIsbnDisplay_Click(object sender, EventArgs e)
        {
            if (connDB.State == ConnectionState.Closed)
            {
                connDB = UtilityDB.ConnectDB();
                cmd = new SqlCommand();
            }
            cmd.Connection = connDB;
            cmd.CommandText = "select * from BookAuthor";
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            reader.Close();
            cmd.Dispose();
            connDB.Close();
            dataGridView1.DataSource = dt;
        }

        private void buttonIsbnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (connDB.State == ConnectionState.Closed)
                {
                    connDB = UtilityDB.ConnectDB();
                    cmd = new SqlCommand();
                }
                int isbn = Convert.ToInt32(comboIsbn.SelectedItem.ToString());
                int id = Convert.ToInt32(comboID.SelectedItem.ToString());
                cmd.Connection = connDB;
                cmd.CommandText = string.Format("Update BookAuthor set AuthorID = {0} where ISBN = {1}", id, isbn);
                cmd.ExecuteNonQuery();
                connDB.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void buttonIsbnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (connDB.State == ConnectionState.Closed)
                {
                    connDB = UtilityDB.ConnectDB();
                    cmd = new SqlCommand();
                }
                int isbn = Convert.ToInt32(comboIsbn.SelectedItem.ToString());
                int id = Convert.ToInt32(comboID.SelectedItem.ToString());
                cmd.Connection = connDB;
                cmd.CommandText = string.Format("Delete from BookAuthor where ISBN = {0} and AuthorID = {1}",isbn, id);
                cmd.ExecuteNonQuery();
                connDB.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void buttonIsbnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text != "")
            {
                var items = comboBoxSearch.Text;
                if (items == "ISBN")
                {

                    int isbn = Convert.ToInt32(textBoxSearch.Text);
                    if (connDB.State == ConnectionState.Closed)
                    {
                        connDB = UtilityDB.ConnectDB();
                        cmd = new SqlCommand();
                    }
                    cmd.Connection = connDB;
                    cmd.CommandText = string.Format("select * from BookAuthor where ISBN = {0}", isbn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    reader.Close();
                    cmd.Dispose();
                    connDB.Close();
                    //dataGridView2.Rows.Clear();
                    dataGridView2.DataSource = dt;
                }
                else
                {
                    int id = Convert.ToInt32(textBoxSearch.Text);
                    if (connDB.State == ConnectionState.Closed)
                    {
                        connDB = UtilityDB.ConnectDB();
                        cmd = new SqlCommand();
                    }
                    cmd.Connection = connDB;
                    cmd.CommandText = string.Format("select * from BookAuthor where AuthorID = {0}", id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    reader.Close();
                    cmd.Dispose();
                    connDB.Close();
                    dataGridView2.DataSource = dt;
                }
            }
            else
            {
                MessageBox.Show("Please enter information.");
            }
        }

        private void buttonExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
