using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WeatherStation
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(@"Data Source=USER-PC;Initial Catalog=users;Integrated Security=True");
            sqlconn.Open();
            string query = "SELECT * FROM Users WHERE FirstName = @FirstName and UserPassword = @UserPassword";
            SqlCommand command = new SqlCommand();
            command.Connection = sqlconn;
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            command.Parameters.AddWithValue("@FirstName", txtBoxUsername.Text);
            command.Parameters.AddWithValue("@UserPassword", txtBoxPassword.Text);
            command.ExecuteNonQuery();

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read() == true)
            {
                MessageBox.Show("Success! You will Login as " + txtBoxUsername.Text + ".");
                FormWeather station = new FormWeather();
                this.Hide();
                station.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Username or/and Password is/are invalid. Please try again!");
            }

            sqlconn.Close();
        }

        private void lnklblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm reg = new RegistrationForm();
            this.Hide();
            reg.ShowDialog();
            this.Close();
        }
    }
}