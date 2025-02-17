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
    public partial class CreateAccount : Form
    {
        string connection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\M2300036\\OneDrive - Middlesbrough College\\my test document\\Test.mdf\";Integrated Security=True;Connect Timeout=30";

        Form OldForm;
        public CreateAccount(Form PreviousForm)
        {
            InitializeComponent();
            OldForm = PreviousForm;
        }



        private void btnReturn_Click(object sender, EventArgs e)
        {
            OldForm.Show();
            this.Close();

        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {

            string User = txtUsername.Text;
            string password=txtPassword.Text;

            SqlConnection sqlConnection = new SqlConnection(connection);
            sqlConnection.Open();
            string query = ($"INSERT INTO Login (Username,Password) VALUES (@User,@password)");
            using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
            {
                cmd.Parameters.AddWithValue("@User", User);
                cmd.Parameters.AddWithValue("@password", password);

                cmd.ExecuteNonQuery();

            }

            MessageBox.Show("Account created");


            txtUsername.Clear();
            txtPassword.Clear();
        }
    }
}
