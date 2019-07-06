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
    public partial class Form3 : MetroForm
    {
        public Form3()
        {
            InitializeComponent();
        }
        /* SqlConnection con = new SqlConnection("Data Source=DESKTOP-ILP1A2F\\YOMAL;Initial Catalog=bloodbank;Integrated Security=True");*/
        MySqlConnection con = new MySqlConnection("server=localhost;database=bloodmanagement;username=root;password=");
        private void label5_Click(object sender, EventArgs e)
        {

            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {


        }
        public void click4()
        {
            dtpdate.Text = "";
            txtnic.Text = "";
            txtfirstname.Text = "";
            txtlstname.Text = "";
            dtpbirthday.Text = "";
            radmale.Checked = false;
            radfemale.Checked = false; ;
            txtaddress.Text = "";
            cmbblod.Text = "";
            radnegative.Checked = false; ;
            radpositive.Checked = false; ;
            txtweight.Text = "";
            txtteleno.Text="";
            txtdiscrip.Text = "";

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO insert_data(Date,NIC_Number,First_Name,Last_Name,Birthday,Gender,Address,Type_Of_Blood,Rh_factor,Weight,Telephone_Number,Description) VALUES('" + dtpdate.Text + "','" + txtnic.Text+"','" +txtfirstname.Text +"','" +txtlstname.Text +"','" +dtpbirthday.Text +"','" +radfemale.Checked +"','" +txtaddress.Text +"','" +cmbblod.Text +"','" +radnegative.Checked +"','" +txtweight.Text +"','" +txtteleno.Text +"','" +txtdiscrip.Text +"')",con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Has Been Enterd");
                click4();

                con.Close(); 
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
           }
           /*try
            //{
                con.Open();
                SqlCommand cmd=new SqlCommand("insert into doner values('"+dtpdate.Value.Date+"','"+txtfirstname.Text+"','"+dtpbirthday.Value.Date + "','"+cmbs.SelectedItem+"','"+txtaddress.Text+"','"+cmbblod.SelectedItem+"',"+txtweight.Text+","+txtteleno.Text+",'"+txtdiscrip.Text+ "','" + txtnic.Text + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Inserted");

           // }catch(Exception ex)
           // {
            //    MessageBox.Show(ex.Message);
            //}*/
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void dtpdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
