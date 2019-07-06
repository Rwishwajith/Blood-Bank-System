using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication22
{
    public partial class Form8 : MetroForm
    {
        public Form8()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("server=localhost;database=bloodmanagement;username=root;password=");
        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bloodmanagementDataSet.insert_data' table. You can move, or remove it, as needed.
            this.insert_dataTableAdapter.Fill(this.bloodmanagementDataSet.insert_data);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM insert_data", con);
            MySqlDataReader yreader;
            try
            {
                yreader = cmd.ExecuteReader();
                while(yreader.Read())
                {
                    this.chart1.Series["Type_Of_Blood"].Points.AddXY(yreader.GetInt32("Date"), yreader.GetInt32("Type_Of_Blood"));
                    con.Close();
                }
            }catch(Exception ex) { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 form = new Form7();
            form.Show();
            this.Hide();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }
    }
}
