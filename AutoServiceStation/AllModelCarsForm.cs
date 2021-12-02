using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AutoServiceStation
{
    public partial class AllModelCarsForm : Form
    {
        string connectString = "Data Source=DESKTOP-AM6UN83\\SQLEXPRESS;Initial Catalog=AutoServiseStation;Integrated Security=True";
        public AllModelCarsForm()
        {
            InitializeComponent();
        }

        public void LoadData(string a)
        {
            AllCarModelsView.Rows.Clear();
            string query=a;
            if (a == "")
            {
                query = "select ModelCars.NameCar from ModelCars";
            }
            SqlConnection myConnection = new SqlConnection(connectString);
            SqlCommand command = new SqlCommand(query, myConnection);
            myConnection.Open();
            SqlDataReader reader = command.ExecuteReader();

            List<string> data = new List<string>();

            while (reader.Read())
            {
                data.Add(reader[0].ToString());
            }

            reader.Close();

            myConnection.Close();

            foreach (string s in data)
                AllCarModelsView.Rows.Add(s);

        }

        private void AllModelCarsForm_Load(object sender, EventArgs e)
        {
            LoadData("");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string query = "";
            query = "select ModelCars.NameCar from ModelCars where NameCar like '%" + textBox1.Text + "%'";

            LoadData(query);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NewModelCarBox.Text != "")
            {
                string query = "insert into ModelCars(NameCar) values(@NameCar)";
                SqlConnection myconn = new SqlConnection(connectString);
                SqlCommand command;
                myconn.Open();
                command = new SqlCommand(query, myconn);

                command.Parameters.Add("@NameCar", NewModelCarBox.Text);

                command.ExecuteNonQuery();

                myconn.Close();

                LoadData("");
            }
            else
                MessageBox.Show("Пожалуйста, заполните поле и повторите запрос!");
        }

        private void AllModelCarsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AutoServiceStation.SelfRef.LoadData();
        }
    }
}
