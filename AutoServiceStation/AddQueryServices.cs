using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AutoServiceStation
{
    public partial class AddQueryServices : Form
    {
        string connectString = "Data Source=DESKTOP-AM6UN83\\SQLEXPRESS;Initial Catalog=AutoServiseStation;Integrated Security=True";

        string[] ServicesOld, ServicesNew;
        static string serviceID, serviceName, servicePrice;

        
        private void AddQueryServiceButton_Click(object sender, EventArgs e)
        {
            string index = ChooseServicesView1.CurrentRow.Cells["idServiceQueryAll"].Value.ToString();
            int ind = ChooseServicesView1.CurrentCell.RowIndex;

            bool found = false;

            for (int i = 0; i < ChooseServicesView2.Rows.Count; i++)
            {
                if (ChooseServicesView2.Rows.Count > 0 & ChooseServicesView2.Rows[i].Cells[0].Value.ToString() == index)
                {
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                string[] row = {ChooseServicesView1.CurrentRow.Cells["idServiceQueryAll"].Value.ToString(), ChooseServicesView1.CurrentRow.Cells["ServiceQueryAll"].Value.ToString(), ChooseServicesView1.CurrentRow.Cells["PriceServiceQueryAll"].Value.ToString()};
                ChooseServicesView2.Rows.Add(row);
            }

            UpdatePrice();
        }

        private void RemoveQueryServiceButton_Click(object sender, EventArgs e)
        {
            int index = ChooseServicesView2.CurrentCell.RowIndex;
            ChooseServicesView2.Rows.RemoveAt(index);

            UpdatePrice();
        }

        private void SumbitQueryServices_Click(object sender, EventArgs e)
        {
            string s = "";
            MainFormToAddServices.QueryServicesUpdate = new string[ChooseServicesView2.Rows.Count];
            for (int i = 0; i < ChooseServicesView2.Rows.Count; i++)
            {
                MainFormToAddServices.QueryServicesUpdate[i] = ChooseServicesView2.Rows[i].Cells["idServiceQueryAdd"].Value.ToString();
            }

            SqlConnection myconn = new SqlConnection(connectString);
            string query;
            SqlCommand command;
            SqlDataReader reader;
            myconn.Open();


            if (MainFormToAddServices.idQuery == "")
            {
                if (MainFormToAddServices.idClient == "")
                {
                    query = "select ModelCars.id from ModelCars where ModelCars.NameCar = '" + MainFormToAddServices.ModelCar + "'";
                    command = new SqlCommand(query, myconn);
                    try
                    {
                        reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            MainFormToAddServices.idCar = reader[0].ToString();
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    query = "insert into Cars(ModelCarID, RegisterSign) values(@ModelCarID, @RegisterSign)";
                    command = new SqlCommand(query, myconn);
                    command.Parameters.Add("@ModelCarID", MainFormToAddServices.idCar);
                    command.Parameters.Add("@RegisterSign", MainFormToAddServices.GRZCar);
                    command.ExecuteNonQuery();

                    query = "select top 1 Cars.id from Cars order by Cars.id desc";
                    command = new SqlCommand(query, myconn);
                    try
                    {
                        reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            MainFormToAddServices.LastCarID = reader[0].ToString();
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    query = "insert into Clients(CarID, Name, SurName, Birthday, Phone) values(@CarID, @Name, @SurName, @Birthday, @Phone)";
                    command = new SqlCommand(query, myconn);
                    command.Parameters.Add("@CarID", MainFormToAddServices.LastCarID);
                    command.Parameters.Add("@Name", MainFormToAddServices.ClientName);
                    command.Parameters.Add("@SurName", MainFormToAddServices.ClientSurName);
                    command.Parameters.Add("@Birthday", MainFormToAddServices.ClientBirthday);
                    command.Parameters.Add("@Phone", MainFormToAddServices.ClientPhone);
                    command.ExecuteNonQuery();

                    query = "select top 1 Clients.id from Clients order by Clients.id desc";
                    command = new SqlCommand(query, myconn);
                    try
                    {
                        reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            MainFormToAddServices.idClient = reader[0].ToString();
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    query = "insert into QueryAutoService(ClientID, DateVisit, Done) values(@ClientID, @DateVisit, 'В процессе')";
                    command = new SqlCommand(query, myconn);
                    command.Parameters.Add("@ClientID", MainFormToAddServices.idClient);
                    command.Parameters.Add("@DateVisit", DateTime.Now.ToShortDateString());
                    command.ExecuteNonQuery();

                    query = "select top 1 QueryAutoService.id from QueryAutoService order by QueryAutoService.id desc";
                    command = new SqlCommand(query, myconn);

                    try
                    {
                        reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            MainFormToAddServices.idQuery = reader[0].ToString();
                        }
                        reader.Close();
                        MessageBox.Show(MainFormToAddServices.idQuery);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    query = "insert into QueryAutoService(ClientID, DateVisit, Done) values(@ClientID, @DateVisit, 'В процессе')";
                    command = new SqlCommand(query, myconn);
                    command.Parameters.Add("@ClientID", MainFormToAddServices.idClient);
                    command.Parameters.Add("@DateVisit", DateTime.Now.ToShortDateString());
                    command.ExecuteNonQuery();

                    query = "select top 1 QueryAutoService.id from QueryAutoService order by QueryAutoService.id desc";
                    command = new SqlCommand(query, myconn);

                    try
                    {
                        reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            MainFormToAddServices.idQuery = reader[0].ToString();
                        }
                        reader.Close();
                        MessageBox.Show(MainFormToAddServices.idQuery);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                query = "delete from QueryToServices where QueryToServices.QueryID = '" + MainFormToAddServices.idQuery + "'";
                command = new SqlCommand(query, myconn);
                command.ExecuteNonQuery();
            }
            for (int i = 0; i < MainFormToAddServices.QueryServicesUpdate.Length; i++)
            {
                query = "insert into QueryToServices(QueryID, ServiceID) values(@QueryID, @ServiceID)";
                command = new SqlCommand(query, myconn);
                command.Parameters.Add("@QueryID", MainFormToAddServices.idQuery);
                command.Parameters.Add("@ServiceID", MainFormToAddServices.QueryServicesUpdate[i]);
                command.ExecuteNonQuery();
            }
            myconn.Close();
            MainFormToAddServices.Reset();
            if(Application.OpenForms.OfType<AllQueryesForm>().Count()>0)
            AllQueryesForm.SelfRef.LoadData("");
            AddQueryServices.ActiveForm.Close();

        }

        private void AddQueryServices_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (AutoServiceStation.SelfRef != null)
                AutoServiceStation.SelfRef.LoadData();
        }

        private void AddQueryServices_Load(object sender, EventArgs e)
        {

        }

        public AddQueryServices()
        {
            InitializeComponent();
            LoadData();
            UpdatePrice();
        } 

        private void LoadData()
        {
            ChooseServicesView1.Rows.Clear();
            SqlConnection myConnection = new SqlConnection(connectString);
            myConnection.Open();

            string query = "select Services.id ,Services.Name, Services.Price from Services";

            SqlCommand command = new SqlCommand(query, myConnection);
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

            foreach (string[] s in data)
                ChooseServicesView1.Rows.Add(s);

            if (MainFormToAddServices.idQuery == "")
                myConnection.Close();
            else
            {
                query = "select Services.id ,Services.Name, Services.Price from Services " +
                    "inner join QueryToServices on QueryToServices.ServiceID = Services.id where QueryToServices.QueryID = '" +
                    MainFormToAddServices.idQuery +
                    "'";

                command = new SqlCommand(query, myConnection);
                reader = command.ExecuteReader();

                data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[3]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                }

                reader.Close();
                myConnection.Close();

                foreach (string[] s in data)
                    ChooseServicesView2.Rows.Add(s);
            }
        }

        void UpdatePrice()
        {
            int price = 0;
            if(ChooseServicesView2.Rows.Count>0)
            {
                for (int i = 0; i < ChooseServicesView2.Rows.Count; i++)
                {
                    price += Convert.ToInt32(ChooseServicesView2.Rows[i].Cells["PriceServiceQueryAdd"].Value);
                }
            }
            AllServicesPriceBox.Text = price.ToString() + " ₽.";
        }
    }
}
