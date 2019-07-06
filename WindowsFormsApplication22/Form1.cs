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
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace WindowsFormsApplication22
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("server=localhost;database=bloodmanagement;username=root;password=");
        // con = new SqlConnection("Data Source=DESKTOP-ILP1A2F\\YOMAL;Initial Catalog=bloodbank;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            pnladmin.Hide();
            pnlhome.BackColor = Color.FromArgb(100, Color.Black);
            pnlfeedback.Hide();
            pnluser.Hide();

        }

        public void click4()
        {
            txtusername.Text = "";
            txtPassword.Text = "";
        }   

        private void btnLog_Click(object sender, EventArgs e)
        {
            try
            {
                string user_name = null, password = null;
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT User_Name,Password FROM admin where User_Name='"+txtusername.Text+"' and Password='"+txtPassword.Text+"'", con);

                MySqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    user_name = dr["User_Name"].ToString();
                    password = dr["Password"].ToString();
                }
                if(user_name==txtusername.Text && password==txtPassword.Text)
                {
                    Form2 form = new Form2();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please Check Your Username Or Password");
                }
                con.Close();
              
                
                
            }catch(Exception ex) { }
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnladmin.Show();
            pnladmin.BackColor = Color.FromArgb(100, Color.Black);
            pnlhome.Hide();
            pnlfeedback.Hide();
            pnluser.Hide();
        }

        private void btnknowledge_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void btnfeedback_Click(object sender, EventArgs e)
        {
            pnlfeedback.Show();
            pnlfeedback.BackColor = Color.FromArgb(100, Color.Black);
            pnladmin.Hide();
            pnlhome.Hide();
            pnluser.Hide();

        }

        private void btnuser_Click(object sender, EventArgs e)
        {
            pnluser.Show();
            pnluser.BackColor = Color.FromArgb(100, Color.Black);
            pnlhome.Hide();
            pnladmin.Hide();
            pnlfeedback.Hide();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            pnlhome.Show();
            pnladmin.Hide();
            pnlfeedback.Hide();
            pnluser.Hide();
        }

        private void btnback_Click_1(object sender, EventArgs e)
        {
            pnlhome.Show();
            pnladmin.Hide();
            pnlfeedback.Hide();
            pnluser.Hide();

        }

        private void btnbackfeedback_Click(object sender, EventArgs e)
        {
            pnlhome.Show();
            pnladmin.Hide();
            pnlfeedback.Hide();
            pnluser.Hide();
        }

        private void btnbackuser_Click(object sender, EventArgs e)
        {
            pnlhome.Show();
            pnladmin.Hide();
            pnlfeedback.Hide();
            pnluser.Hide();
        }
        public void click3()
        {
            txtname.Text = "";
            txtlast.Text = "";
            txtaddress.Text = "";
            txtnic.Text = "";
            dtpdateofbirth.Text = "";
            radmale.Checked = false;
            radfemale.Checked = false;
            txtteleno.Text = "";
        }
            private void btninsert_Click(object sender, EventArgs e)
        {
          
            try
            {
                con.Open();
               MySqlCommand cmd = new MySqlCommand("insert into user(First_Name,Last_Name,Address,NIC,Date_Of_Birth,Gender,Telephone_Number) values('" + txtname.Text+ "','" + txtlast.Text + "','" + txtaddress.Text + "','" + txtnic.Text + "','" + dtpdateofbirth.Text + "','"+radmale.Checked+"','"+txtteleno.Text+"')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("DATA INSERTED");
                click3();
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pnlfeedback_Paint(object sender, PaintEventArgs e)
        {

        }
        public void click2()
        {
            txtfeedbackid.Text = "";
            txtnamefeed.Text = "";
            txtfeedback.Text = "";
        }
        private void btninsertfeed_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO feedback(NIC,Name,Feedback) VALUES('"+txtfeedbackid.Text+"','"+txtnamefeed.Text+"','"+txtfeedback.Text+"')",con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("DATA INSERT");
                click2();
                con.Close();
            }catch(Exception ex) { }
           /* try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into feedback('" + txtnamefeed.Text + "','" + txtfeedback.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("inserted");
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void pnluser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnladmin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void txtfeedbackid_Validated(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtfeedbackid.Text))
            {
                txtfeedbackid.Focus();
                errorProvider1.SetError(txtfeedbackid, "PLEASE ENTER USER ID");
            }
            else
            {
                errorProvider1.SetError(txtfeedbackid, null);
            }
        }

        private void txtnamefeed_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtnamefeed.Text))
            {
                txtfeedbackid.Focus();
                errorProvider1.SetError(txtnamefeed, "PLEASE ENTER NAME");
            }
            else
            {
                errorProvider1.SetError(txtnamefeed, null);
            }
        }

        private void txtfeedback_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtfeedback.Text))
            {
                txtfeedback.Focus();
                errorProvider1.SetError(txtfeedback, "PLEASE WRITE CORRECT WORD");
            }
            else
            {
                errorProvider1.SetError(txtfeedback, null);
            }
        }

        private void txtname_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtname.Text))
            {
                txtname.Focus();
                errorProvider1.SetError(txtname, "PLEASE WRITE NAME");
            }
            else
            {
                errorProvider1.SetError(txtname, null);
            }
        }

        private void txtlast_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtlast.Text))
            {
                txtlast.Focus();
                errorProvider1.SetError(txtlast, "PLEASE WRITE LAST NAME");
            }
            else
            {
                errorProvider1.SetError(txtlast, null);
            }
        }

        private void txtaddress_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtaddress.Text))
            {
                txtaddress.Focus();
                errorProvider1.SetError(txtaddress, "PLEASE WRITE ADDRESS");
            }
            else
            {
                errorProvider1.SetError(txtaddress, null);
            }
        }

        private void txtnic_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtnic.Text))
            {
                txtnic.Focus();
                errorProvider1.SetError(txtnic, "PLEASE WRITE NIC");
            }
            else
            {
                errorProvider1.SetError(txtnic, null);
            }
        }

        private void txtteleno_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtteleno.Text))
            {
                txtteleno.Focus();
                errorProvider1.SetError(txtteleno, "PLEASE WRITE TELEPHONE");
            }
            else
            {
                errorProvider1.SetError(txtteleno, null);
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ruchirawishwajith8.wixsite.com/bloodbankmanagement"); 
        }
    }
}
