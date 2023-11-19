using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseForm
{
    public partial class Orders : Form
    {
        string vs_ConnStr = "Server = 94.73.144.17 ; Database = u7173324_NWind; user id=u7173324_NWind;password=Na79=YX2az@Co7-_; Trusted_Connection = False;Encrypt=false;";
        string vs_SQLCommand;
        public Orders()
        {
            InitializeComponent();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            //Baglantı();
        }
        private void Baglantı()
        {
            vs_SQLCommand = "SELECT * FROM Orders";

            using (SqlConnection connection = new SqlConnection(vs_ConnStr))
            {
                using (SqlCommand command = new SqlCommand(vs_SQLCommand, connection))
                {

                    command.CommandType = CommandType.Text;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        using (DataSet dataSet = new DataSet())
                        {
                            adapter.Fill(dataSet);

                            dataOrder.DataSource = dataSet.Tables[0];
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Baglantı();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // string sorgu = textBox1.Text;
            // sorgu = Convert.ToString(Console.ReadLine());

        }
        private void BaglantıS()
        {
            string sorgu = textBox1.Text;


            vs_SQLCommand = $"SELECT {sorgu} FROM Orders";

            using (SqlConnection connection = new SqlConnection(vs_ConnStr))
            {
                using (SqlCommand command = new SqlCommand(vs_SQLCommand, connection))
                {

                    command.CommandType = CommandType.Text;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        using (DataSet dataSet = new DataSet())
                        {
                            adapter.Fill(dataSet);

                            dataOrder.DataSource = dataSet.Tables[0];
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BaglantıS();
        }
    }
}
