using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AutoServiceStation
{
    public partial class AllClientsForm : Form
    {
        public static AllClientsForm SelfRef { get; set; }

        string connectString = "Data Source=DESKTOP-AM6UN83\\SQLEXPRESS;Initial Catalog=AutoServiseStation;Integrated Security=True";
        public AllClientsForm()
        {
            InitializeComponent();
            SelfRef = this;
        }

        
        private void AllClients_Load(object sender, EventArgs e)
        {
            LoadData("");
        }

        public void LoadData(string query)
        {
            AllClientsView.Rows.Clear();
            SqlConnection myConnection = new SqlConnection(connectString);
            myConnection.Open();

            if(query == "")
            query = "select Clients.id, Clients.SurName, Clients.Name, Clients.Birthday, Clients.Phone from Clients";

            SqlCommand command = new SqlCommand(query, myConnection);
            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[5]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
            }

            reader.Close();

            myConnection.Close();

            foreach (string[] s in data)
                AllClientsView.Rows.Add(s);
        }

        private void AllClientsView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ClientsCarView.Rows.Clear();
            string index = AllClientsView.CurrentRow.Cells["ClientID"].Value.ToString();

            string query = "select Cars.id, ModelCars.NameCar, Cars.RegisterSign from Clients " +
                "inner join Cars on Cars.id = Clients.CarID " +
                "inner join ModelCars on ModelCars.id = Cars.ModelCarID where Clients.id = '" + index + "'";

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
                ClientsCarView.Rows.Add(s);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string query = "";
            query = "select Clients.id, Clients.SurName, Clients.Name, Clients.Birthday, Clients.Phone from Clients where Phone like '%" + textBox1.Text + "%'";

            LoadData(query);
        }

        private void SendClientValues()
        {
            AllClientsToReductClient.ClientID = AllClientsView.CurrentRow.Cells["ClientID"].Value.ToString();
            AllClientsToReductClient.ClientSurName = AllClientsView.CurrentRow.Cells["SurName"].Value.ToString();
            AllClientsToReductClient.ClientName = AllClientsView.CurrentRow.Cells["ClientName"].Value.ToString();
            AllClientsToReductClient.ClientDate = AllClientsView.CurrentRow.Cells["ClientBirthday"].Value.ToString();
            AllClientsToReductClient.ClientPhone = AllClientsView.CurrentRow.Cells["ClientPhoneNumber"].Value.ToString();
            AllClientsToReductClient.ClientCarID = ClientsCarView.CurrentRow.Cells["CarID"].Value.ToString();
            AllClientsToReductClient.ClientCarModel = ClientsCarView.CurrentRow.Cells["ModelCar"].Value.ToString();
            AllClientsToReductClient.ClientCarGRZ = ClientsCarView.CurrentRow.Cells["RegisterSign"].Value.ToString();
        }

        private void ReductClientButton_Click(object sender, EventArgs e)
        {
            SendClientValues();
            ReductClientForm rcf = new ReductClientForm();
                rcf.Show();
        }

        private void AllClientsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AutoServiceStation.SelfRef.LoadData();
        }
    }
}
