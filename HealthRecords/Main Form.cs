using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthRecords
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //Calc functions:
        private void btnCalc_Click(object sender, EventArgs e)
        {
            HealthProfile hp = new HealthProfile();

            //hp.FName = txtFName.Text;
            //hp.LName = txtLName.Text;

            //rdo buttons....

            hp.Year = dateTimePicker1.Value.Year;
            hp.DobDayOfYear = dateTimePicker1.Value.DayOfYear;

            //hp.InchesHeight = Convert.ToInt32(txtHeight.Text);
            //hp.LBS = Convert.ToInt32(txtLBS.Text);

            lblAge.Text = hp.GetAge();
 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFName.Clear();
            txtLName.Clear();
            txtHeight.Clear();
            txtLBS.Clear();

            dateTimePicker1.ResetText();

            lblAge.Text = "";
            lblBMI.Text = "";
            lblBMIValuesChart.Text = "";
            lblFName.Text = "";
            lblMaxHeartRate.Text = "";
            lblTargetHeartRate.Text = "";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        //Height only accepts whole numbers:
        private void txtHeight_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtHeight.Text, "^[0-9]"))
            {
                txtHeight.Clear();
            }
        }

        //Weight only accepts whole numbers:
        private void txtLBS_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtLBS.Text, "^[0-9]"))
            {
                txtLBS.Clear();
            }
        }
    }
}
