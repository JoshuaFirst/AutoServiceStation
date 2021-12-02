using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AutoServiceStation
{
    public partial class AutoServiceStation : Form
    {
        string connectString = "Data Source=DESKTOP-AM6UN83\\SQLEXPRESS;Initial Catalog=AutoServiseStation;Integrated Security=True";

        public static AutoServiceStation SelfRef { get; set;}
        public AutoServiceStation()
        {
            SelfRef = this;
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            QueryView.Rows.Clear();
            SqlConnection myConnection = new SqlConnection(connectString);
            myConnection.Open();

            string query = "select CONCAT(Clients.SurName,' ', Clients.Name), CONCAT(ModelCars.NameCar, ' ', " +
                "Cars.RegisterSign), Clients.Birthday, QueryAutoService.DateVisit, SUM(Services.Price), QueryAutoService.Done, QueryAutoService.id " +
                "FROM QueryAutoService " +
                "inner join Clients ON Clients.id = QueryAutoService.ClientID " +
                "inner join Cars ON Cars.id = Clients.CarID " +
                "inner join ModelCars ON ModelCars.id = Cars.ModelCarID " +
                "inner join QueryToServices ON QueryToServices.QueryID = QueryAutoService.id " +
                "inner join Services ON Services.id = QueryToServices.ServiceID " +
                "where QueryAutoService.Done = 'В процессе' "+
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

            LoadClientsQuery();
            FillCarSelect();
        }

        private void LoadClientsQuery()
        {
            ClientChooseQueyry.Rows.Clear();
            SqlConnection myConnection = new SqlConnection(connectString);
            myConnection.Open();

            string query = "select Clients.id, Cars.id, Clients.SurName, Clients.Name, Clients.Birthday, CONCAT(ModelCars.NameCar, ' ', Cars.RegisterSign), Clients.Phone from Clients " +
                "inner join Cars on Cars.id = Clients.CarID " +
                "inner join ModelCars on ModelCars.id = Cars.ModelCarID";
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
                ClientChooseQueyry.Rows.Add(s);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void QueryView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            QueryServicesView.Rows.Clear();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.QueryView.Rows[e.RowIndex];
                string QueryID = row.Cells["idЗаявки"].Value.ToString(), 
                       Price = row.Cells["Price"].Value.ToString()+ " ₽.";

                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();

                string query = "select Services.Name, Services.Price FROM Services " +
                    "inner join QueryToServices ON QueryToServices.ServiceID = Services.id " +
                    "inner join QueryAutoService ON QueryAutoService.id = QueryToServices.QueryID " +
                    "WHERE QueryToServices.QueryID = '" +
                    QueryID +"'";

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

                while(reader.Read())
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

        private void AddQueryButton_Click(object sender, EventArgs e)
        {
            string[] FI = FIOBox.Text.Split(' ');
            MainFormToAddServices.GRZCar = GRZBox.Text;
            MainFormToAddServices.ClientPhone = MobilePhoneBox.Text;
            MainFormToAddServices.ModelCar = CarSelect.Text;
            MainFormToAddServices.ClientBirthday = BirthdayDate.Text;
            if (FI.Length < 2 || MainFormToAddServices.GRZCar.Trim() == "" || MainFormToAddServices.ClientPhone == "" || MainFormToAddServices.ModelCar == "" || MainFormToAddServices.ClientBirthday == "")
                MessageBox.Show("Пожалуйста, заполните все поля и повторите запрос");
            else
            {
                MainFormToAddServices.ClientName = FI[1];
                MainFormToAddServices.ClientSurName = FI[0];

                MessageBox.Show(MainFormToAddServices.ClientSurName + "\n" + MainFormToAddServices.ClientName + "\n" + MainFormToAddServices.ClientPhone + "\n" + MainFormToAddServices.ClientBirthday + "\n" + MainFormToAddServices.ModelCar + "\n" + MainFormToAddServices.GRZCar);

                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open();
                string query = "";
                SqlCommand command = new SqlCommand(query, myConnection);

                AddQueryServices aqs = new AddQueryServices();

                aqs.Show();
            }
        }

        private void AddQueryButtonSecond_Click(object sender, EventArgs e)
        {
            MainFormToAddServices.idClient = ClientChooseQueyry.CurrentRow.Cells["idClient"].Value.ToString();
            MainFormToAddServices.idCar = ClientChooseQueyry.CurrentRow.Cells["ССid"].Value.ToString();
            MessageBox.Show("id клиента: " + MainFormToAddServices.idClient + "\nid Машины: " + MainFormToAddServices.idCar);

            AddQueryServices aqs = new AddQueryServices();
            aqs.Show();
        }

        private void ChangeQueryButton_Click(object sender, EventArgs e)
        {
            MainFormToAddServices.idQuery = QueryView.CurrentRow.Cells["idЗаявки"].Value.ToString();

            AddQueryServices aqs = new AddQueryServices();
            aqs.Show();
        }

        private void FinishQueryButton_Click(object sender, EventArgs e)
        {
            SqlConnection myconn = new SqlConnection(connectString);
            string query;
            SqlCommand command;
            myconn.Open();

            query = "update QueryAutoService set Done = 'Выполнено' where QueryAutoService.id = '" + QueryView.CurrentRow.Cells["idЗаявки"].Value.ToString() +"'";
            command = new SqlCommand(query, myconn);
            command.ExecuteNonQuery();

            myconn.Close();

            LoadData();
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

            LoadData();
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllClientsForm ac = new AllClientsForm();
            ac.Show();
        }

        private void автоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllAutoForm auf = new AllAutoForm();
            auf.Show();
        }

        private void маркиАвтоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllModelCarsForm amcf = new AllModelCarsForm();
            amcf.Show();
        }

        private void услугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllServicesForm asf = new AllServicesForm();
            asf.Show();
        }

        private void заявкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllQueryesForm aqf = new AllQueryesForm();
            aqf.Show();
        }
    }
}
