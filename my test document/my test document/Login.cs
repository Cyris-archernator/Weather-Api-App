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

namespace my_test_document
{
    public partial class Login : Form
    {
        string connection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\M2300036\\OneDrive - Middlesbrough College\\my test document\\Test.mdf\";Integrated Security=True;Connect Timeout=30";

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username, password;
            username = txtUsername.Text;
            password = txtPassword.Text;

            
            
                SqlConnection conn = new SqlConnection(connection);
                string query = ("SELECT * FROM Login WHERE Username = '" + txtUsername.Text + "' AND Password ='" + txtPassword.Text + "'");
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = txtUsername.Text;
                    password = txtPassword.Text;

                    MainTab MT = new MainTab(this);
                    this.Hide();
                    MT.ShowDialog();
                    
                    txtUsername.Clear();
                    txtPassword.Clear();




                }


                else
                {

                    MessageBox.Show("invalid inputs");
                    txtUsername.Clear();
                    txtPassword.Clear();
                }


           

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateAccount CA =new CreateAccount(this);
            this.Hide();
            CA.Show();
        }
    }
}
