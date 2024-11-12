using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Podgotovka
{
    public partial class Partners : Form
    {
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=students.accdb";

        private OleDbConnection connection;
        public Partners()
        {
            InitializeComponent();
            connection = new OleDbConnection(connectionString);
            connection.Open();
        }

        private void Partners_Load(object sender, EventArgs e)
        {
            OleDbCommand command = new OleDbCommand("SELECT * from Partners", connection);
            OleDbDataReader reader = command.ExecuteReader();
            Partners partners = new Partners();
            while (reader.Read()) 
            {
                FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel
                {
                    FlowDirection = FlowDirection.TopDown,
                    Size = new Size(400, 75),
                    BorderStyle = BorderStyle.FixedSingle
                };
                Label mainInfo = new Label
                {
                    Text = $"{reader[1]} | {reader[0]}",
                    Font = new Font("Segoe UI", 12, FontStyle.Regular),
                    AutoSize = true
                };
                int percent = Percent_Calc(reader[0].ToString());
                Label externalInfo = new Label
                {
                    Text = $"{reader[2]}\n+7 {reader[3]}                                        {percent}%\nрейтинг: {reader[8]}",
                    AutoSize = true,
                    Font = new Font("Segoe UI", 10, FontStyle.Regular),

                };
                Button historyBT = new Button
                {
                    Text = "Вывести историю",
                    Name = reader[0].ToString(),
                };
                historyBT.Click += new EventHandler(History_Form);
                flowLayoutPanel.Controls.Add(historyBT);
                flowLayoutPanel.Controls.Add(mainInfo);
                flowLayoutPanel.Controls.Add(externalInfo);
                partnersPanel.AutoScroll = true;
                partnersPanel.Controls.Add(flowLayoutPanel);

            }


        }

        public void History_Form(object? sender, EventArgs e)
        {
            Button historyBT = sender as Button;
            
            History history = new History(historyBT.Name);
            
            history.Show();
        }

        private int Percent_Calc(string name)
        {
            OleDbCommand command = new OleDbCommand($"SELECT [Количество продукции] FROM Partner_products WHERE [Наименование партнера] = '{name}'", connection);
            OleDbDataReader reader = command.ExecuteReader();
            int ammount = 0;
            while (reader.Read()) 
            {
                ammount += Convert.ToInt32(reader[0]);
            }
            int percent = 0;
            
            if (ammount < 10000)
            {
                percent = 0;
            }
            else if (ammount > 10000 && ammount < 50000)
            {
                percent = 5;
            }
            else if (ammount > 50000 && ammount < 300000)
            {
                percent = 10;
            }
            else if (ammount > 300000)
            {
                percent = 15;
            }
            return percent;
        }
    }
}
