using FinalProject.DataAccess;
using FinalProject.Gui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }

        User user1 = new User();
        string userName, password;
        string xmlLocation = Application.StartupPath + @"xmlUser.xml";

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void linkForget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Reset_Password r1 = new Reset_Password();
            r1.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if (txtUser.Text == "" || txtPass.Text == "")
            {

                MessageBox.Show("Please Enter Username or Password");
            }
            else
            {
                DataTable dt = user1.Tables["UserLogin"];
                dt.ReadXml(xmlLocation);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    userName = dt.Rows[i]["UserName"].ToString();
                    password = dt.Rows[i]["Password"].ToString();
                
                    string user1 = txtUser.Text;
                    string pass = txtPass.Text;
                    if (user1 == userName && pass == password)
                    {
                        if (user1 == "HBrown")
                        {
                            this.Hide();
                            MIS_Manager m1 = new MIS_Manager();
                            m1.Show();
                        }
                        else if (user1 == "TMoore")
                        {
                            this.Hide();
                            Sales_Manager s1 = new Sales_Manager();
                            s1.Show();
                        }
                        else if (user1 == "MBrown" || user1 == "JBouchard")
                        {
                            this.Hide();
                            Order_clerks o1 = new Order_clerks();
                            o1.Show();
                        }
                        else if (user1 == "KHoa")
                        {
                            this.Hide();
                            Inventory i1 = new Inventory();
                            i1.Show();
                        }
                        else if (user1 == "PWang")
                        {
                            this.Hide();
                            Accountant a1 = new Accountant();
                            a1.Show();
                        }
                    }
                }
            }
        }
    }
}
