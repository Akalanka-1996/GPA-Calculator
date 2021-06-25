using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_2017__001
{
    public partial class Form3 : Form
        
    {
        public Form2 frm2;
        public Form3()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(cmbYear.Text != "" && txtCode.Text !="" && txtCredit.Text!="" && txtGrade.Text != "" )
            {
                frm2.ListData(cmbYear.Text, txtCode.Text, txtCredit.Text, txtGrade.Text);
                cmbYear.Text = "";
                txtCode.Text = "";
                txtCredit.Text = "";
                txtGrade.Text = "";
            }
            else
            {
                MessageBox.Show("Enetr all values!");
            }
        }
    }
}
