using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AutoServiceStation
{
    public partial class ReductServiceForm : Form
    {
        string connectString = "Data Source=DESKTOP-AM6UN83\\SQLEXPRESS;Initial Catalog=AutoServiseStation;Integrated Security=True";
        public ReductServiceForm()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            PriceBox.Text = AllServicesToReduct.price;
            NameBox.Text = AllServicesToReduct.name;
        }

        private void ReductServiceForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ChangeValueButton_Click(object sender, EventArgs e)
        {
            if ((NameBox.Text != AllServicesToReduct.name&& PriceBox.Text != AllServicesToReduct.price) || (PriceBox.Text != ""&&NameBox.Text != ""))
            {
                string query = "update Services set Name = '" + NameBox.Text +"', Price = '" + PriceBox.Text + "' where Services.id = '" + AllServicesToReduct.id + "'";

                SqlConnection myconn = new SqlConnection(connectString);
                SqlCommand command;
                myconn.Open();
                command = new SqlCommand(query, myconn);

                command.ExecuteNonQuery();

                myconn.Close();
                AllServicesForm.SelfRef.LoadData("");
                ReductServiceForm.ActiveForm.Close();
            }
            else
                MessageBox.Show("Заполните все поля и повторите попытку!");
        }
    }
}
