using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AutoServiceStation
{
    public partial class NewOldCarOwner : Form
    {
        string connectString = "Data Source=DESKTOP-AM6UN83\\SQLEXPRESS;Initial Catalog=AutoServiseStation;Integrated Security=True";
        string carID = "";
        public NewOldCarOwner(string a)
        {
            carID = a;
            InitializeComponent();
        }

        public void LoadData()
        {
            AllClientsView.Rows.Clear();
            SqlConnection myConnection = new SqlConnection(connectString);
            myConnection.Open();

            string query = "select Clients.Name, Clients.SurName, Clients.Birthday, Clients.Phone from Clients";

            SqlCommand command = new SqlCommand(query, myConnection);
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

            myConnection.Close();

            foreach (string[] s in data)
                AllClientsView.Rows.Add(s);
        }

        private void NewOldCarOwner_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "insert into Clients(CarID, Name, SurName, Birthday, Phone) values(@CarID, @Name, @SurName, @Birthday, @Phone)";
            string[] Client = new string[4];

            Client[0] = AllClientsView.CurrentRow.Cells["SurName"].Value.ToString();
            Client[1] = AllClientsView.CurrentRow.Cells["ClientName"].Value.ToString();
            Client[2] = AllClientsView.CurrentRow.Cells["ClientBirthday"].Value.ToString();
            Client[3] = AllClientsView.CurrentRow.Cells["ClientPhoneNumber"].Value.ToString();

            SqlConnection myconn = new SqlConnection(connectString);
            SqlCommand command;
            myconn.Open();
            command = new SqlCommand(query, myconn);

            command.Parameters.Add("@CarID", carID);
            command.Parameters.Add("@Name", Client[1]);
            command.Parameters.Add("@SurName", Client[0]);
            command.Parameters.Add("@Birthday", Client[2]);
            command.Parameters.Add("@Phone", Client[3]);

            command.ExecuteNonQuery();
            myconn.Close();

            CarOwnerAdd.SelfRef.LoadData();
            NewOldCarOwner.ActiveForm.Close();
        }
    }
}
