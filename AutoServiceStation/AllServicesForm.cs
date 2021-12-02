using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AutoServiceStation
{
    public partial class AllServicesForm : Form
    {
        public static AllServicesForm SelfRef { get; set; }

        string connectString = "Data Source=DESKTOP-AM6UN83\\SQLEXPRESS;Initial Catalog=AutoServiseStation;Integrated Security=True";
        bool CombinedSearchButton = false,
             More = false,
             Less = false,
             Equally = false;
        public AllServicesForm()
        {
            SelfRef = this;
            InitializeComponent();
        }

        public void LoadData(string a)
        {
            AllServicesView.Rows.Clear();
            string query = a;

            if (query == "")
                query = "select Services.id ,Services.Name, Services.Price from Services";

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
                AllServicesView.Rows.Add(s);
        }

        private void AllServicesForm_Load(object sender, EventArgs e)
        {
            LoadData("");
        }

        private void AllServicesView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PriceLabel.Text = AllServicesView.CurrentRow.Cells["Price"].Value.ToString() + " ₽.";
        }

        private string Search()
        {
            string query = "";
            if(CombinedSearchButton)
            {
                if(More)
                {
                    query = "select Services.id ,Services.Name, Services.Price from Services where Name like '%" + ServiceNameBox.Text + "%' and Price >= '" + ServicePriceBox.Text + "'";
                }
                else
                    if (Less)
                    {
                    query = "select Services.id ,Services.Name, Services.Price from Services where Name like '%" + ServiceNameBox.Text + "%' and Price <= '" + ServicePriceBox.Text + "'";
                    }
                    else
                        if(Equally)
                        {
                        query = "select Services.id ,Services.Name, Services.Price from Services where Name like '%" + ServiceNameBox.Text + "%' and Price = '" + ServicePriceBox.Text + "'";
                        }
                        else
                        query = "select Services.id ,Services.Name, Services.Price from Services where Name like '%" + ServiceNameBox.Text + "%' and Price like '%" + ServicePriceBox.Text + "%'";
            }
            else
            {

            }
            return query;
        }

        private void MoreButton_Click(object sender, EventArgs e)
        {
            if (More)
            {
                MoreButton.BackColor = Color.White;
                More = false;
            }
            else
            {
                MoreButton.BackColor = Color.Green;
                EqButton.BackColor = Color.White;
                LessButton.BackColor = Color.White;
                More = true;
                Less = false;
                Equally = false;
            }
        }

        private void EqButton_Click(object sender, EventArgs e)
        {
            if (Equally)
            {
                EqButton.BackColor = Color.White;
                Equally = false;
            }
            else
            {
                EqButton.BackColor = Color.Green;
                LessButton.BackColor = Color.White;
                MoreButton.BackColor = Color.White;
                Equally = true;
                More = false;
                Less = false;
            }
        }

        private void LessButton_Click(object sender, EventArgs e)
        {
            if (Less)
            {
                LessButton.BackColor = Color.White;
                Less = false;
            }
            else
            {
                LessButton.BackColor = Color.Green;
                MoreButton.BackColor = Color.White;
                EqButton.BackColor = Color.White;
                Less = true;
                Equally = false;
                More = false;
            }
        }

        private void NewServiceAdd_Click(object sender, EventArgs e)
        {
            if (NewServiceNameBox.Text != "" && NewServicePriceBox.Text != "")
            {
                string query = "insert into Services(Name, Price) values(@Name, @Price)";
                
                SqlConnection myconn = new SqlConnection(connectString);
                SqlCommand command;
                myconn.Open();
                command = new SqlCommand(query, myconn);

                command.Parameters.Add("@Name", NewServiceNameBox.Text);
                command.Parameters.Add("@Price", NewServicePriceBox.Text);

                command.ExecuteNonQuery();

                myconn.Close();

                LoadData("");
            }
            else
                MessageBox.Show("Заполните все поля и повторите запрос!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AllServicesToReduct.id = AllServicesView.CurrentRow.Cells["id"].Value.ToString();
            AllServicesToReduct.name = AllServicesView.CurrentRow.Cells["Service"].Value.ToString();
            AllServicesToReduct.price = AllServicesView.CurrentRow.Cells["Price"].Value.ToString();

            ReductServiceForm rsf = new ReductServiceForm();
            rsf.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string query = "";
            if (CombinedSearchButton)
            {
                query = Search();
            }
            else
            query = "select Services.id ,Services.Name, Services.Price from Services where Name like '%" + ServiceNameBox.Text + "%'";

            LoadData(query);
        }

        private void ServicePriceBox_TextChanged(object sender, EventArgs e)
        {
            string query = "";
            if (CombinedSearchButton)
            {
                query = Search();
            }
            else
                query = "select Services.id ,Services.Name, Services.Price from Services where Price like '%" + ServicePriceBox.Text + "%'";

            LoadData(query);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(CombinedSearchButton)
            {
                ComboButton.BackColor = Color.Red;
                CombinedSearchButton = false;
            }
            else
            {
                ComboButton.BackColor = Color.Green;
                CombinedSearchButton = true;
            }
        }
    }
}
