using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AutoServiceStation
{
    public partial class AllAutoForm : Form
    {
        string connectString = "Data Source=DESKTOP-AM6UN83\\SQLEXPRESS;Initial Catalog=AutoServiseStation;Integrated Security=True";
        public AllAutoForm()
        {
            InitializeComponent();
        }

        private void LoadCars(string a)
        {
            AllModelCarsView.Rows.Clear();

            string query=a;

            if (a == "")
            {
                query = "select Cars.id, ModelCars.NameCar, Cars.RegisterSign from Cars inner join ModelCars on ModelCars.id = Cars.ModelCarID";
            }

            SqlConnection myconn = new SqlConnection(connectString);
            myconn.Open();

            SqlCommand command = new SqlCommand(query, myconn);
            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[3]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
            }

            reader.Close();

            myconn.Close();

            foreach (string[] s in data)
                AllModelCarsView.Rows.Add(s);
        }

        private void AllAutoForm_Load(object sender, EventArgs e)
        {
            LoadCars("");
        }

        private void AllModelCarsView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AllCarOwners.Rows.Clear();
            string index = AllModelCarsView.CurrentRow.Cells["CarID"].Value.ToString();

            string query = "select Clients.SurName, Clients.Name, Clients.Birthday, Clients.Phone from Clients where Clients.CarID = '"+ index + "'";

            SqlConnection myconn = new SqlConnection(connectString);
            myconn.Open();

            SqlCommand command = new SqlCommand(query, myconn);
            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[4]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
            }

            reader.Close();

            myconn.Close();

            foreach (string[] s in data)
                AllCarOwners.Rows.Add(s);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string query = "";
            query = "select Cars.id, ModelCars.NameCar, Cars.RegisterSign from Cars inner join ModelCars on ModelCars.id = Cars.ModelCarID where Cars.RegisterSign like '%" + textBox1.Text + "%'";

            LoadCars(query);
        }

        private void SendCarInfo()
        {
            AllCarsToOwners.CarID = AllModelCarsView.CurrentRow.Cells["CarID"].Value.ToString();
            AllCarsToOwners.ModelCar = AllModelCarsView.CurrentRow.Cells["ModelCar"].Value.ToString();
            AllCarsToOwners.GRZCar = AllModelCarsView.CurrentRow.Cells["GRZ"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendCarInfo();

            CarOwnerAdd coa = new CarOwnerAdd();
            coa.Show();
        }
    }
}
