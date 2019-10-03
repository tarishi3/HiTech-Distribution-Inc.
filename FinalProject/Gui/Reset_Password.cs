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
using System.Xml;

namespace FinalProject.Gui
{
    public partial class Reset_Password : Form
    {
        public Reset_Password()
        {
            InitializeComponent();
           
        }

        User user1 = new User();
        string xmlLocation = Application.StartupPath + @"xmlUser.xml";

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtPass.Text == "" || textBoxRepass.Text == "")
            {

                MessageBox.Show("Please Enter all Information");
            }
            else
            {
                
                string username = txtUser.Text;
                string password = txtPass.Text;
                string repass = textBoxRepass.Text;
                DataTable dt = user1.Tables["UserLogin"];
                dt.ReadXml(xmlLocation);
                DataRow dr = dt.Rows.Find(username);
                    
                if (password == repass)
                {
                    dr["Password"] = password;
                    dt.WriteXml(xmlLocation);
                    MessageBox.Show("Password changed and saved succesfully. \n Click on link below to go back and login.");
                    
                }
                else
                {
                    MessageBox.Show("Your passwords do not match.");
                    txtPass.Clear();
                    textBoxRepass.Clear();
                    txtPass.Focus();
                }
                    
            }
        }

        private void linkForget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login l1 = new Login();
            l1.Show();
        }

        private void Reset_Password_Load(object sender, EventArgs e)
        {
            
        }
    }
}
