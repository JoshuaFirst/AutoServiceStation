using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AutoServiceStation
{
    public partial class AllQueryesForm : Form
    {
        string connectString = "Data Source=DESKTOP-AM6UN83\\SQLEXPRESS;Initial Catalog=AutoServiseStation;Integrated Security=True";
        public static AllQueryesForm SelfRef { get; set; }
        public AllQueryesForm()
        {
            SelfRef = this;
            InitializeComponent();
        }

        public void LoadData(string a)
        {
            QueryView.Rows.Clear();
            SqlConnection myConnection = new SqlConnection(connectString);
            myConnection.Open();

            string query = a;

            if(a=="")
                query = "select CONCAT(Clients.SurName,' ', Clients.Name), CONCAT(ModelCars.NameCar, ' ', " +
                "Cars.RegisterSign), Clients.Birthday, QueryAutoService.DateVisit, SUM(Services.Price), QueryAutoService.Done, QueryAutoService.id " +
                "FROM QueryAutoService " +
                "inner join Clients ON Clients.id = QueryAutoService.ClientID " +
                "inner join Cars ON Cars.id = Clients.CarID " +
                "inner join ModelCars ON ModelCars.id = Cars.ModelCarID " +
                "inner join QueryToServices ON QueryToServices.QueryID = QueryAutoService.id " +
                "inner join Services ON Services.id = QueryToServices.ServiceID " +
                "GROUP BY Clients.Name, Clients.SurName, ModelCars.NameCar, Cars.RegisterSign, Clients.Birthday, QueryAutoService.DateVisit, QueryAutoService.Done, QueryAutoService.id";
            SqlCommand command = new SqlCommand(query, myConnection);
            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[7]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
            }

            reader.Close();

            myConnection.Close();

            foreach (string[] s in data)
                QueryView.Rows.Add(s);

            FillCarSelect();
        }

        void FillCarSelect()
        {
            CarSelect.Items.Clear();
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
                    CarSelect.Items.Add(Model);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            myConnection.Close();
        }

        private void AllQueryesForm_Load(object sender, EventArgs e)
        {
            LoadData("");
        }

        private void QueryView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            QueryServicesView.Rows.Clear();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.QueryView.Rows[e.RowIndex];
                string QueryID = row.Cells["idЗаявки"].Value.ToString(),
                       Price = row.Cells["Price"].Value.ToString() + " ₽.";

                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();

                string query = "select Services.Name, Services.Price FROM Services " +
                    "inner join QueryToServices ON QueryToServices.ServiceID = Services.id " +
                    "inner join QueryAutoService ON QueryAutoService.id = QueryToServices.QueryID " +
                    "WHERE QueryToServices.QueryID = '" +
                    QueryID + "'";

                SqlCommand command = new SqlCommand(query, myConnection);
                SqlDataReader reader = command.ExecuteReader();

                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[2]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                }

                reader.Close();

                myConnection.Close();

                foreach (string[] s in data)
                    QueryServicesView.Rows.Add(s);
                PriceBox.Text = Price;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            FIOBox.Text = "";
            GRZBox.Text = "";
            MobilePhoneBox.Text = "";
            DoneBox.Checked = false;
            CarSelect.Text = "";
            LoadData("");
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string[] FI = FIOBox.Text.Split(' ');
            string name="", surname="";
            if(FI.Length>1)
                name = FI[1];
            surname = FI[0];
            string query = "select CONCAT(Clients.SurName,' ', Clients.Name), CONCAT(ModelCars.NameCar, ' ', Cars.RegisterSign), Clients.Birthday, QueryAutoService.DateVisit, SUM(Services.Price), QueryAutoService.Done, QueryAutoService.id " +
                "FROM QueryAutoService inner join Clients ON Clients.id = QueryAutoService.ClientID " +
                "inner join Cars ON Cars.id = Clients.CarID " +
                "inner join ModelCars ON ModelCars.id = Cars.ModelCarID " +
                "inner join QueryToServices ON QueryToServices.QueryID = QueryAutoService.id " +
                "inner join Services ON Services.id = QueryToServices.ServiceID " +
                "where Clients.SurName like '%" + surname + "%' and Clients.Name like '%" + name + "%' and ModelCars.NameCar like '%" + CarSelect.Text + "%' and Clients.Phone like '%" + MobilePhoneBox.Text + "%' and Cars.RegisterSign like '%" + GRZBox.Text + "%' ";
            if (DoneBox.Checked)
                query += "and QueryAutoService.Done = 'Выполнено' ";
            query += "GROUP BY Clients.Name, Clients.SurName, ModelCars.NameCar, Cars.RegisterSign, Clients.Birthday, QueryAutoService.DateVisit, QueryAutoService.Done, QueryAutoService.id";
            LoadData(query);
        }

        private void DeleteQueryButton_Click(object sender, EventArgs e)
        {
            SqlConnection myconn = new SqlConnection(connectString);
            string query;
            SqlCommand command;
            myconn.Open();

            query = "delete from QueryToServices where QueryToServices.QueryID = '" + QueryView.CurrentRow.Cells["idЗаявки"].Value.ToString() + "'";
            command = new SqlCommand(query, myconn);
            command.ExecuteNonQuery();

            query = "delete from QueryAutoService where QueryAutoService.id = '" + QueryView.CurrentRow.Cells["idЗаявки"].Value.ToString() + "'";
            command = new SqlCommand(query, myconn);
            command.ExecuteNonQuery();

            myconn.Close();

            LoadData("");
        }

        private void ChangeQueryButton_Click(object sender, EventArgs e)
        {
            if (QueryView.CurrentRow.Cells["State"].Value.ToString() == "В процессе")
            {
                MainFormToAddServices.idQuery = QueryView.CurrentRow.Cells["idЗаявки"].Value.ToString();

                AddQueryServices aqs = new AddQueryServices();
                aqs.Show();
            }
            else
                MessageBox.Show("Нельзя редактировать выполненные заявки!");
        }

        private void FinishQueryButton_Click(object sender, EventArgs e)
        {
            SqlConnection myconn = new SqlConnection(connectString);
            string query;
            SqlCommand command;
            myconn.Open();

            query = "update QueryAutoService set Done = 'Выполнено' where QueryAutoService.id = '" + QueryView.CurrentRow.Cells["idЗаявки"].Value.ToString() + "'";
            command = new SqlCommand(query, myconn);
            command.ExecuteNonQuery();

            myconn.Close();

            LoadData("");
        }
    }
}
