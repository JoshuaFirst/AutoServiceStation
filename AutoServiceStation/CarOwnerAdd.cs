using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AutoServiceStation
{
    public partial class CarOwnerAdd : Form
    {
        string connectString = "Data Source=DESKTOP-AM6UN83\\SQLEXPRESS;Initial Catalog=AutoServiseStation;Integrated Security=True";

        public static CarOwnerAdd SelfRef { get; set; }
        public CarOwnerAdd()
        {
            SelfRef = this;
            InitializeComponent();
        }

        public void LoadData()
        {
            CarOwnersView.Rows.Clear();
            SqlConnection myConnection = new SqlConnection(connectString);
            myConnection.Open();

            string query = "select Clients.Name, Clients.SurName, Clients.Birthday, Clients.Phone from Clients where Clients.CarID = '" + AllCarsToOwners.CarID + "'";

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
                CarOwnersView.Rows.Add(s);

            ModelCarBox.Text = AllCarsToOwners.ModelCar;
            GRZBox.Text = AllCarsToOwners.GRZCar;
        }

        private void CarOwnerAdd_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (NameBox.Text != "" || SurNameBox.Text != "" || PhoneBox.Text != "" || BirthdayPicker.Value.ToString() != "")
            {
                string query = "insert into Clients(CarID, Name, SurName, Birthday, Phone) values(@CarID, @Name, @SurName, @Birthday, @Phone)";
                SqlConnection myconn = new SqlConnection(connectString);
                SqlCommand command;
                myconn.Open();
                command = new SqlCommand(query, myconn);

                command.Parameters.Add("@CarID", AllCarsToOwners.CarID);
                command.Parameters.Add("@Name", NameBox.Text);
                command.Parameters.Add("@SurName", SurNameBox.Text);
                command.Parameters.Add("@Birthday", BirthdayPicker.Value.ToString());
                command.Parameters.Add("@Phone", PhoneBox.Text);

                command.ExecuteNonQuery();

                myconn.Close();

                LoadData();
            }
            else
                MessageBox.Show("Пожалуйста, заполните все данные!");
        }

        private void button1_Click(object sender, EventArgs e)
        {


            NewOldCarOwner noco = new NewOldCarOwner(AllCarsToOwners.CarID);
            noco.Show();
        }
    }
}
