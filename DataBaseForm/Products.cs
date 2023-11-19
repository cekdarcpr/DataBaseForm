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
    public partial class Products : Form
    {
        string vs_ConnStr = "Server = 94.73.144.17 ; Database = u7173324_NWind; user id=u7173324_NWind;password=Na79=YX2az@Co7-_; Trusted_Connection = False;Encrypt=false;";
        string vs_SQLCommand;
        public Products()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Products_Load(object sender, EventArgs e)
        {
            Baglantı();
        }
        private void Baglantı()
        {
            vs_SQLCommand = "SELECT * FROM Products";

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

                            dataGridView1.DataSource = dataSet.Tables[0];
                        }
                    }
                }
            }
        }

  
    }
}
