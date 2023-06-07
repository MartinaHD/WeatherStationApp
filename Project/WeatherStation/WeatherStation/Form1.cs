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
    public partial class FormWeather : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=USER-PC\SQLEXPRESS;Initial Catalog=weather_station_inf;Integrated Security=True");
        public FormWeather()
        {
            InitializeComponent();
            FormVisible();
        }

        public void FormVisible()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=USER-PC;Initial Catalog=users;Integrated Security=True");
            conn.Open();
            SqlCommand command = conn.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT UserLevel FROM Users";
            command.ExecuteNonQuery();
            SqlDataReader da = command.ExecuteReader();
            while (da.Read())
            {
                if (da.GetValue(0).ToString() == "ordinary user")
                {
                    lblStationID.Visible = false;
                    txtBoxStationID.Visible = false;
                    lblCity.Visible = false;
                    txtBoxCity.Visible = false;
                    lblPercentID.Visible = false;
                    txtBoxPercentID.Visible = false;
                    txtBoxMeasurementHour.Visible = false;
                    txtBoxTemperature.Visible = false;
                    txtBoxRainPercent.Visible = false;
                    txtBoxPressure.Visible = false;
                    dataGridViewWeather.Visible = false;
                    groupBoxTables.Visible = false;
                    btnInsert.Visible = false;
                    btnDelete.Visible = false;
                    btnUpdate.Visible = false;
                    btnSearch.Visible = false;

                    /*SqlCommand cmd1 = new SqlCommand("SELECT MeasurementDate, DayLength FROM WeatherStation WHERE MeasurementID = @MeasurementID", conn);
                    SqlCommand cmd2 = new SqlCommand("SELECT WindSpeedMS, CloudCoverPercentage, Rain FROM MeasurementDetailsDay WHERE DateID = @DateID", conn);
                    SqlCommand cmd3 = new SqlCommand("MIN(TemperatureCelsius), MAX(TemperatureCelsius), AVG(ChanceOfRainPercent) FROM MeasurementDetailsHour WHERE MeasurementID = @MeasurementID", conn);
                    cmd1.Parameters.AddWithValue("@MeasurementID", txtBoxMeasurementID.Text);
                    cmd2.Parameters.AddWithValue("@DateID", txtBoxDateID.Text);
                    cmd3.Parameters.AddWithValue("@MeasurementID", txtBoxMeasurementID.Text);
                    SqlDataReader da1 = cmd1.ExecuteReader();
                    SqlDataReader da2 = cmd2.ExecuteReader();
                    SqlDataReader da3 = cmd3.ExecuteReader();
                    while (da1.Read())
                    {
                        txtBoxDate.Text = da1.GetValue(0).ToString();
                        txtBoxDayLength.Text = da1.GetValue(1).ToString();
                    }
                    while (da2.Read())
                    {
                        txtBoxWindSpeed.Text = da2.GetValue(0).ToString();
                        txtBoxClouds.Text = da2.GetValue(1).ToString();
                        txtBoxRain.Text = da2.GetValue(2).ToString();
                    }
                    while (da3.Read())
                    {
                        txtBoxMinTemp.Text = da3.GetValue(0).ToString();
                        txtBoxMaxTemp.Text = da3.GetValue(1).ToString();
                        txtBoxRainPercent.Text = da3.GetValue(2).ToString();
                    }*/
                }
                else if (da.GetValue(0).ToString() == "advanced user")
                {
                    lblStationID.Visible = true;
                    txtBoxStationID.Visible = true;
                    lblCity.Visible = true;
                    txtBoxCity.Visible = true;
                    lblPercentID.Visible = true;
                    txtBoxPercentID.Visible = true;
                    txtBoxMeasurementHour.Visible = true;
                    txtBoxTemperature.Visible = true;
                    txtBoxRainPercent.Visible = true;
                    txtBoxPressure.Visible = true;
                    dataGridViewWeather.Visible = true;
                    groupBoxTables.Visible = true;
                    btnDisplay.Visible = true;
                    btnSearch.Visible = true;
                }
                else
                {
                    btnInsert.Visible = true;
                    btnDelete.Visible = true;
                    btnUpdate.Visible = true;
                }
            }
            conn.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = connect.CreateCommand();

            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO WeatherStation VALUES('" + txtBoxStationID.Text + "','" + txtBoxCity.Text + "','" + txtBoxDate.Text + "','" + txtBoxDayLength.Text + "')"
                                + "INSERT INTO MeasurementDetailsDay VALUES('" + txtBoxPercentID.Text + "', CAST('" + txtBoxWindSpeed.Text + "' AS VARCHAR), CAST('" + txtBoxClouds.Text + "' AS VARCHAR),'" + txtBoxRain.Text + "')"
                                + "INSERT INTO MeasurementDetailsHour VALUES('" + txtBoxDateID.Text + "','" + txtBoxMeasurementID.Text + "','" + txtBoxMeasurementHour.Text + "', CAST('" + txtBoxTemperature.Text + "' AS VARCHAR), CAST('" + txtBoxPercentRain.Text + "' AS VARCHAR), CAST('" + txtBoxPressure.Text + "' AS VARCHAR))";
            command.ExecuteNonQuery();
            connect.Close();

            MessageBox.Show("Record inserted successfully!");
        }

        public void display_data_table1()
        {
            connect.Open();

            SqlCommand command = connect.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM WeatherStation";
            command.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            dataGridViewWeather.DataSource = dt;

            connect.Close();
        }

        public void display_data_table2()
        {
            connect.Open();

            SqlCommand command = connect.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM MeasurementDetailsDay";
            command.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            dataGridViewWeather.DataSource = dt;

            connect.Close();
        }

        public void display_data_table3()
        {
            connect.Open();

            SqlCommand command = connect.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM MeasurementDetailsHour";
            command.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            dataGridViewWeather.DataSource = dt;

            connect.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = connect.CreateCommand();

            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM WeatherStation WHERE MeasurementID = '" + txtBoxMeasurementID.Text + "'"
                                + "DELETE FROM MeasurementDetailsDay WHERE DateID = '" + txtBoxDateID.Text + "'"
                                + "DELETE FROM MeasurementDetailsHour WHERE DateID = '" + txtBoxDateID.Text + "'";
            command.ExecuteNonQuery();
            connect.Close();

            display_data_table1();
            display_data_table2();
            display_data_table3();

            MessageBox.Show("Record deleted successfully!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = connect.CreateCommand();

            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE WeatherStation SET CityStation = '" + txtBoxCity.Text + "'"
                                + "UPDATE MeasurementDetailsDay SET CAST(WindSpeedMS as VARCHAR) = '" + txtBoxWindSpeed.Text + "'"
                                + "UPDATE MeasurementDetailsHour SET CAST(TemperatureCelsius as VARCHAR) = '" + txtBoxTemperature.Text + "'";
            command.ExecuteNonQuery();
            connect.Close();

            display_data_table1();
            display_data_table2();
            display_data_table3();

            MessageBox.Show("Record updated successfully!");
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            if (radioBtnT1.Checked)
                display_data_table1();
            else if (radioBtnT2.Checked)
                display_data_table2();
            else display_data_table3();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = connect.CreateCommand();

            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM WeatherStation WHERE CityStation = '" + txtBoxCity.Text + "'"
                                + "SELECT * FROM MeasurementDetailsDay WHERE PercentID = '" + txtBoxPercentID.Text + "'"
                                + "SELECT * FROM MeasurementDetailsHour WHERE CAST(TemperatureCelsius as VARCHAR) = '" + txtBoxTemperature.Text + "'";
            command.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            dataGridViewWeather.DataSource = dt;

            connect.Close();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = connect.CreateCommand();

            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT MIN(TemperatureCelsius), MAX(TemperatureCelsius), AVG(ChanceOfRainPercent) FROM MeasurementDetailsHour WHERE MeasurementID = '" + txtBoxMeasurementID.Text + "'";
            command.ExecuteNonQuery();

            SqlDataReader da = command.ExecuteReader();
            while (da.Read())
            {
                txtBoxMaxTemp.Text = da.GetValue(0).ToString();
                txtBoxMinTemp.Text = da.GetValue(1).ToString();
                txtBoxRainPercent.Text = da.GetValue(2).ToString();
            }
            connect.Close();
        }
    }
}