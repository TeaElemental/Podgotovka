using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Podgotovka
{
    public partial class History : Form
    {
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=students.accdb";
        OleDbConnection connection;
        string name;
        public History(string name)
        {
            InitializeComponent();
            this.name = name;
            this.Size = new System.Drawing.Size(historyDV.Width, historyDV.Height);


            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();
            OleDbCommand sqlCommand = new OleDbCommand($"select [Продукция], [Количество продукции], [Дата продажи] from Partner_products WHERE [Наименование партнера] = '{name}';", connection);
            OleDbDataReader reader = sqlCommand.ExecuteReader();


            using (DataTable history = new DataTable())
            {
                history.Columns.Add("Продукция", typeof(string));
                history.Columns.Add("Количество продукции", typeof(int));
                history.Columns.Add("Дата продажи", typeof(DateTime));
                while (reader.Read())
                {
                    history.Rows.Add(reader[0].ToString(), Convert.ToInt32(reader[1]), Convert.ToDateTime(reader[2]));
                }

                historyDV.DataSource = history;
            }




        }

        private void History_Load(object sender, EventArgs e)
        {
            OleDbCommand command = new OleDbCommand($"SELECT * FROM Partner_products WHERE [Наименование партнера] = '{name}'", connection);
            //OleDbDataReader reader = command.ExecuteReader();

            //while (reader.Read())
            //{

            //}

        }

        private void historyDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
