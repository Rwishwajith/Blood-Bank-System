using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
namespace WindowsFormsApplication22
{
    public partial class Form2 : MetroForm
    {
        public Form2()
        {
            InitializeComponent();
        }
        //SqlConnection con = new SqlConnection("Data Source=DESKTOP-ILP1A2F\\YOMAL;Initial Catalog=bloodbank;Integrated Security=True");
        MySqlConnection con = new MySqlConnection("server=localhost;database=bloodmanagement;username=root;password=");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pnlblood.Hide();
           // pnlmessage.Hide();
        }

        private void btnabout_Click(object sender, EventArgs e)
        {
            pnlblood.Show();
            pnlblood.BackColor = Color.FromArgb(100, Color.Black);
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();

        }

        private void btnhome_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM insert_data",con);
                MySqlDataAdapter dr = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dr.Fill(dt);
                dgvsearch.DataSource = dt;
                con.Close();
                
            }catch(Exception ex) { }
          
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            pnlblood.Hide();
           // pnlmessage.Hide();
        }

        private void btnbackblood_Click(object sender, EventArgs e)
        {
            pnlblood.Hide();
            //pnlmessage.Hide();
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            Form7 form = new Form7();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select COUNT(Type_Of_Blood) from insert_data where Type_Of_Blood='A' ", con);
                MySqlDataAdapter dr = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dr.Fill(dt);
                dgvsearch.DataSource = dt;
                con.Close();

            }
            catch (Exception ex) { }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btncheckcount_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select COUNT(Type_Of_Blood) from insert_data where Type_Of_Blood='A+'", con);
                MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
                MySqlCommand cme = new MySqlCommand("select COUNT(Type_Of_Blood) from insert_data where Type_Of_Blood='A-'", con);
                MySqlDataAdapter ae = new MySqlDataAdapter(cme);
                MySqlCommand cmf = new MySqlCommand("select COUNT(Type_Of_Blood) from insert_data where Type_Of_Blood='B+'", con);
                MySqlDataAdapter af = new MySqlDataAdapter(cmf);
                MySqlCommand cmg = new MySqlCommand("select COUNT(Type_Of_Blood) from insert_data where Type_Of_Blood='B-'", con);
                MySqlDataAdapter ag = new MySqlDataAdapter(cmg);
                MySqlCommand cmh = new MySqlCommand("select COUNT(Type_Of_Blood) from insert_data where Type_Of_Blood='AB+'", con);
                MySqlDataAdapter ah = new MySqlDataAdapter(cmh);
                MySqlCommand cmi = new MySqlCommand("select COUNT(Type_Of_Blood) from insert_data where Type_Of_Blood='AB-'", con);
                MySqlDataAdapter ai = new MySqlDataAdapter(cmi);
                MySqlCommand cmj = new MySqlCommand("select COUNT(Type_Of_Blood) from insert_data where Type_Of_Blood='O+'", con);
                MySqlDataAdapter aj = new MySqlDataAdapter(cmj);
                MySqlCommand cmk = new MySqlCommand("select COUNT(Type_Of_Blood) from insert_data where Type_Of_Blood='O-'", con);
                MySqlDataAdapter ak = new MySqlDataAdapter(cmk);
                DataTable dt = new DataTable();
                DataTable de = new DataTable();
                DataTable df = new DataTable();
                DataTable dh = new DataTable();
                DataTable dj = new DataTable();
                DataTable dk = new DataTable();
                DataTable dl = new DataTable();
                DataTable du = new DataTable();
                ad.Fill(dt);
                ae.Fill(de);
                af.Fill(df);
                ag.Fill(dh);
                ah.Fill(dj);
                ai.Fill(dk);
                aj.Fill(dl);
                ak.Fill(du);
                dgvaplus.DataSource = dt;
                dgvaminus.DataSource = de;
                dgvbplus.DataSource = df;
                dgvbminus.DataSource = dh;
                dgvabplus.DataSource = dj;
                dgvabminus.DataSource = dk;
                dgvoplus.DataSource = dl;
                dgvominus.DataSource = du;
                con.Close();
            }
            catch(Exception ex) { }
        }

        private void pnlblood_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnext_Click(object sender, EventArgs e)
        {
            Form8 form = new Form8();
            form.Show();
            this.Hide();
        }
    }
}
