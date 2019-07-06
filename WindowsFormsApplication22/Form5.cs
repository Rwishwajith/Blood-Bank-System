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

namespace WindowsFormsApplication22
{
    public partial class Form5 : MetroForm
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnwhatblood_Click(object sender, EventArgs e)
        {
            
            txtblood.Visible = true;
            txtfacts.Visible = false;
            txtregister.Visible = false;
            txtmedical.Visible = false;
            txthowtodonate.Visible = false;
            txtafterdonation.Visible = false;

        }

        private void Form5_Load(object sender, EventArgs e)
        {
        }

        private void btnfacts_Click(object sender, EventArgs e)
        {
            txtblood.Visible = false;
            txtfacts.Visible = true;
            txtregister.Visible = false;
            txtmedical.Visible = false;
            txthowtodonate.Visible = false;
            txtafterdonation.Visible = false;



        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            txtblood.Visible = false;
            txtfacts.Visible = false;
            txtregister.Visible = true;
            txtmedical.Visible = false;
            txthowtodonate.Visible = false;
            txtafterdonation.Visible = false;

        }

        private void btnmedical_Click(object sender, EventArgs e)
        {
            txtblood.Visible = false;
            txtfacts.Visible = false;
            txtregister.Visible = false;
            txtmedical.Visible = true;
            txthowtodonate.Visible = false;
            txtafterdonation.Visible = false;

        }

        private void btndonate_Click(object sender, EventArgs e)
        {
            txtblood.Visible = false;
            txtfacts.Visible = false;
            txtregister.Visible = false;
            txtmedical.Visible = false;
            txthowtodonate.Visible = true;
            txtafterdonation.Visible = false;
        }

        private void btnafterdonation_Click(object sender, EventArgs e)
        {
            txtblood.Visible = false;
            txtfacts.Visible = false;
            txtregister.Visible = false;
            txtmedical.Visible = false;
            txthowtodonate.Visible = false;
            txtafterdonation.Visible = true;
        }

        private void pnlknowledge_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
