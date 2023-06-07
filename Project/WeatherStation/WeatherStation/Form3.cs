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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(@"Data Source=USER-PC;Initial Catalog=users;Integrated Security=True");
            if (txtBoxConfirmPassword.Text != txtBoxPassword.Text)
            {
                MessageBox.Show("Passwords do not match!");
                txtBoxConfirmPassword.Clear();
                return;
            }
            else if (txtBoxPassword.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long!");
                txtBoxConfirmPassword.Clear();
                return;
            }
            else if (txtBoxFirstName.Text != "" && txtBoxLastName.Text != "" && txtBoxEmail.Text != "" && txtBoxPassword.Text != "" && txtBoxConfirmPassword.Text != "" && (rdBtnUser1.Checked || rdBtnUser2.Checked || rdBtnUser3.Checked))
            {
                string sqlquery = "INSERT INTO Users VALUES (@FirstName, @LastName, @UserEmail, @UserPassword, @ConfirmPassword, @UserLevel)";
                sqlconn.Open();
                SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
                sqlcomm.Parameters.AddWithValue("@FirstName", txtBoxFirstName.Text);
                sqlcomm.Parameters.AddWithValue("@LastName", txtBoxLastName.Text);
                sqlcomm.Parameters.AddWithValue("@UserEmail", txtBoxEmail.Text);
                sqlcomm.Parameters.AddWithValue("@UserPassword", txtBoxPassword.Text);
                sqlcomm.Parameters.AddWithValue("@ConfirmPassword", txtBoxConfirmPassword.Text);
                sqlcomm.Parameters.AddWithValue("@UserLevel", GetRadioValue());
                sqlcomm.ExecuteNonQuery();
                sqlconn.Close();
                MessageBox.Show("User " + txtBoxFirstName.Text + " " + txtBoxLastName.Text + " Is Successfully Registered!");
                ClearForm();
            }
            else if (txtBoxFirstName.Text == "" || txtBoxLastName.Text == "" || txtBoxEmail.Text == "" || txtBoxPassword.Text == "" || txtBoxConfirmPassword.Text == "" || rdBtnUser1.Checked == false || rdBtnUser2.Checked == false || rdBtnUser3.Checked == false)
            {
                MessageBox.Show("There are Blank Fields!");
            }
            else
            {
                
            }
        }

        private string GetRadioValue()
        {
            if (rdBtnUser1.Checked) return "ordinary user";
            else if (rdBtnUser2.Checked) return "advanced user";
            else return "moderator";
        }

        private void ClearForm()
        {
            txtBoxFirstName.Clear();
            txtBoxLastName.Clear();
            txtBoxEmail.Clear();
            txtBoxPassword.Clear();
            txtBoxConfirmPassword.Clear();
            rdBtnUser1.Checked = false;
            rdBtnUser2.Checked = false;
            rdBtnUser3.Checked = false;
        }

        private void lnklblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm log = new LoginForm();
            this.Hide();
            log.ShowDialog();
            this.Close();
        }
    }
}