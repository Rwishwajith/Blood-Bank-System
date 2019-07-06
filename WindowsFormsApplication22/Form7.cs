using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication22
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("server=localhost;database=bloodmanagement;username=root;password=");
        private void pnlmessage_Paint(object sender, PaintEventArgs e)
        {

        }
        public void getcombo()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT NIC_Number FROM insert_data", con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    comboBox1.Items.Add(dr[0]);
                }
                con.Close();
            }catch(Exception ex) { }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string s = comboBox1.Text;
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM insert_data WHERE NIC_Number='" + s + "'", con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    textBox1.Text = dr.GetValue(7).ToString();
                   txtname.Text = dr.GetValue(2).ToString();
                    txtteleno.Text = dr.GetValue(10).ToString();
                }
                con.Close();

            }catch(Exception ex) { }
            
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            getcombo();
        }
        public void click2()
        {
            comboBox1.Text = "";
            textBox1.Text = "";
            txtname.Text = "";
            txtteleno.Text = "";
            txtmessage.Text = "";

        }
        private void btnsendmessage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Message has been sent");
            click2();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
