using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AutoServiceStation
{
    public partial class ReductClientForm : Form
    {
        string connectString = "Data Source=DESKTOP-AM6UN83\\SQLEXPRESS;Initial Catalog=AutoServiseStation;Integrated Security=True";
        public ReductClientForm()
        {
            InitializeComponent();
        }

        private void UpdateCar()
        {
            ClientCar.Rows.Clear();
            string query = "select Cars.id, ModelCars.NameCar, Cars.RegisterSign from Clients " +
                "inner join Cars on Cars.id = Clients.id " +
                "inner join ModelCars on ModelCars.id = Cars.ModelCarID where Clients.id = '" + AllClientsToReductClient.ClientCarID +"'";

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
            {
                ClientCar.Rows.Add(s);
            }
        }
        void FillCarSelect()
        {
            ModelCarsBox.Items.Clear();
            string query = "select * from ModelCars";
            SqlConnection myConnection = new SqlConnection(connectString);
            SqlCommand command = new SqlCommand(query, myConnection);
            SqlDataReader reader;

            try
            {
                myConnection.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string Model = reader[1].ToString();
                    ModelCarsBox.Items.Add(Model);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            myConnection.Close();
        }

        private void LoadForm()
        {
            ClientSurNameBox.Text = AllClientsToReductClient.ClientSurName;
            ClientNameBox.Text = AllClientsToReductClient.ClientName;
            ClientBirthdayPicker.Text = AllClientsToReductClient.ClientDate;
            ClientPhoneBox.Text = AllClientsToReductClient.ClientPhone;
            ClientSurNameBox.Text = AllClientsToReductClient.ClientSurName;
            ClientSurNameBox.Text = AllClientsToReductClient.ClientSurName;
            ClientSurNameBox.Text = AllClientsToReductClient.ClientSurName;

            UpdateCar();

            FillCarSelect();
        }

        private void ReductClientForm_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void ChangeClientAutoButton_Click(object sender, EventArgs e)
        {
            if(ModelCarsBox.SelectedItem.ToString()!=AllClientsToReductClient.ClientCarModel||ClientCarGRZBox.Text!=AllClientsToReductClient.ClientCarGRZ)
            {
                string query;
                SqlConnection myConnection;
                SqlCommand command;
                if (ModelCarsBox.SelectedItem.ToString() != AllClientsToReductClient.ClientCarModel)
                {
                    
                    query = "select ModelCars.id from ModelCars where ModelCars.NameCar = '" + ModelCarsBox.SelectedItem.ToString() + "'";
                    myConnection = new SqlConnection(connectString);
                    command = new SqlCommand(query, myConnection);
                    SqlDataReader reader;
                    string carid="";
                    try
                    {
                        myConnection.Open();
                        reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            carid = reader[0].ToString();
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    query = "update Cars set ModelCarID = '"+ carid + "' where Cars.id = '" + AllClientsToReductClient.ClientCarID + "'";
                    command = new SqlCommand(query, myConnection);
                    command.ExecuteNonQuery();

                    myConnection.Close();

                }
                    if (ClientCarGRZBox.Text != AllClientsToReductClient.ClientCarGRZ)
                    {
                    query = "update Cars set RegisterSign = '" + ClientCarGRZBox.Text + "' where Cars.id = '" + AllClientsToReductClient.ClientCarID + "'";
                    myConnection = new SqlConnection(connectString);
                    myConnection.Open();
                    command = new SqlCommand(query, myConnection);
                    command.ExecuteNonQuery();
                    myConnection.Close();
                }
                UpdateCar();
            }
        }

        private void ChangeClientInfo(string a, string b)
        {
            string query = "update Clients set " + a + " = '"+ b + "' where Clients.id = '" + AllClientsToReductClient.ClientID + "'";
            SqlConnection myConnection = new SqlConnection(connectString);
            myConnection.Open();
            SqlCommand command = new SqlCommand(query, myConnection);
            command.ExecuteNonQuery();
            myConnection.Close();
        }

        private void ClienFIOChangeButton_Click(object sender, EventArgs e)
        {
            if (ClientNameBox.Text != AllClientsToReductClient.ClientName)
            {
                ChangeClientInfo("Name", ClientNameBox.Text);
                AllClientsToReductClient.ClientName = ClientNameBox.Text;
            }
            if (ClientSurNameBox.Text != AllClientsToReductClient.ClientSurName)
            {
                ChangeClientInfo("SurName", ClientSurNameBox.Text);
                AllClientsToReductClient.ClientSurName = ClientSurNameBox.Text;
            }
            if (ClientPhoneBox.Text != AllClientsToReductClient.ClientPhone)
            {
                ChangeClientInfo("Phone", ClientPhoneBox.Text);
                AllClientsToReductClient.ClientPhone = ClientPhoneBox.Text;
            }
            if (ClientBirthdayPicker.Text != AllClientsToReductClient.ClientDate)
            {
                ChangeClientInfo("Birthday", ClientBirthdayPicker.Text);
                AllClientsToReductClient.ClientDate = ClientBirthdayPicker.Text;
            }
        }

        private void ReductClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AllClientsForm.SelfRef.LoadData("");
        }
    }
}
