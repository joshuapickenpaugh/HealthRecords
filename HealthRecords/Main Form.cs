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

            //Populates combo boxes for height and weight...:     
            //Height:
            for (int i = 12; i < 120; i++)
            {
                cmbHeight.Items.Add(i);
            }

            //Weight:
            for (int i = 1; i < 600; i++)
            {
                cmbLBS.Items.Add(i);
            }
        }

        //Calc functions:
        private void btnCalc_Click(object sender, EventArgs e)
        {
            HealthProfile hp = new HealthProfile();

            //Name entry:
            hp.FName = txtFName.Text;
            hp.LName = txtLName.Text;

            //Gender radio boxes selection:
            if (rdoMale.Checked)
            {
                hp.IsMale = true;
            }

            if (rdoFemale.Checked)
            {
                hp.IsFemale = true;
            }

            //Datetime picker, displays age:
            hp.Year = dateTimePicker1.Value.Year;
            hp.DobDayOfYear = dateTimePicker1.Value.DayOfYear;
            lblAge.Text = hp.GetAge();

            //Gets selected item from combo boxes, assigns it to 
            //the Health Profile object:
            Object selectedItem = cmbHeight.SelectedItem;
            hp.InchesHeight = Convert.ToDouble(selectedItem.ToString());

            Object selectedItem2 = cmbLBS.SelectedItem;
            hp.LBS = Convert.ToDouble(selectedItem2.ToString());

            //Displays BMI:
            lblBMI.Text = hp.GetBMI();
        }

        //Exit button:
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Clear button:
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFName.Clear();
            txtLName.Clear(); 

            dateTimePicker1.ResetText();

            lblAge.Text = "";
            lblBMI.Text = "";
            lblBMIValuesChart.Text = "";
            lblFName.Text = "";
            lblMaxHeartRate.Text = "";
            lblTargetHeartRate.Text = "";
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //...no code here...
        }

        //FName only accepts letters and spaces:
        private void txtFName_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtFName.Text, "^[a-zA-Z ]+$"))
            {
                txtFName.Clear();
            }
        }

        //LName only accepts letters and spaces:
        private void txtLName_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtLName.Text, "^[a-zA-Z ]+$"))
            {
                txtLName.Clear();
            }
        }
    }
}
