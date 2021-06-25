using System;
using QRCoder;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_2017__001
{
    public partial class Form2 : Form
        
    {
        public int CountCredit = 0;
        public double GPA = 0;
        public double TemGPA = 0;
        public Form2()
        {
            InitializeComponent();
        }
        public void ListData(string yr, string cd, string CR, string GR)
        {
            ListViewItem lvi = new ListViewItem(cd);
            if (yr == "Year-1")
            {
                lvi.Group = listView1.Groups["Year-1"];
            }
            else if (yr == "Year-2")
            {
                lvi.Group = listView1.Groups["Year-2"];
            }
            else if (yr == "Year-3")
            {
                lvi.Group = listView1.Groups["Year-3"];
            }
            else if (yr == "Year-4")
            {
                lvi.Group = listView1.Groups["Year-4"];
            }
            lvi.SubItems.Add(CR);

            lvi.SubItems.Add(GR);
            listView1.Items.Add(lvi);

            if (GR == "A" || GR == "A+")
            {
                TemGPA = TemGPA + 4.0 * Convert.ToInt32(CR);
                CountCredit = CountCredit + int.Parse(CR);
            }
            if (GR == "A-")
            {
                TemGPA = TemGPA + 3.7 * Convert.ToInt32(CR);
                CountCredit = CountCredit + int.Parse(CR);
            }
            if (GR == "B+")
            {
                TemGPA = TemGPA + 3.3 * Convert.ToInt32(CR);
                CountCredit = CountCredit + int.Parse(CR);
            }
            if (GR == "B")
            {
                TemGPA = TemGPA + 3.0 * Convert.ToInt32(CR);
                CountCredit = CountCredit + int.Parse(CR);
            }
            if (GR == "B-")
            {
                TemGPA = TemGPA + 2.7 * Convert.ToInt32(CR);
                CountCredit = CountCredit + int.Parse(CR);
            }
            if (GR == "C+")
            {
                TemGPA = TemGPA + 2.3 * Convert.ToInt32(CR);
                CountCredit = CountCredit + int.Parse(CR);
            }
            if (GR == "C")
            {
                TemGPA = TemGPA + 2.0 * Convert.ToInt32(CR);
                CountCredit = CountCredit + int.Parse(CR);
            }
            if (GR == "C-")
            {
                TemGPA = TemGPA + 1.7 * Convert.ToInt32(CR);
                CountCredit = CountCredit + int.Parse(CR);
            }
            if (GR == "D+")
            {
                TemGPA = TemGPA + 1.3 * Convert.ToInt32(CR);
                CountCredit = CountCredit + int.Parse(CR);
            }
            if (GR == "D")
            {
                TemGPA = TemGPA + 1.0 * Convert.ToInt32(CR);
                CountCredit = CountCredit + int.Parse(CR);
            }
            if (GR == "E")
            {
                TemGPA = TemGPA + 0 * Convert.ToInt32(CR);
                CountCredit = CountCredit + int.Parse(CR);
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }
        public void SetNumber(string std_no)
        {
            lblNumber.Text = std_no;
        }

        private void lblNumber_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.frm2 = this;
            frm3.Show();
            
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            GPA = TemGPA / CountCredit;

            QRCodeGenerator QR = new QRCodeGenerator();
            QRCodeData Data = QR.CreateQrCode(Convert.ToString(GPA), QRCodeGenerator.ECCLevel.Q);
            QRCode Code = new QRCode(Data);
            pictureBox1.Image = Code.GetGraphic(6);
        }
    }
}
