using System;
using System.Collections;
using System.Windows.Forms;

namespace Biodata
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            string dob = dateTimePickerDOB.Value.ToString("dd MMMM yyyy");
            int age = DateTime.Now.Year - dateTimePickerDOB.Value.Year;
            if (dateTimePickerDOB.Value.Date > DateTime.Now.AddYears(age)) age--;

            ArrayList skills = new ArrayList();
            if (checkBoxNetworking.Checked) skills.Add("Networking");
            if (checkBoxPenetrationTest.Checked) skills.Add("Penetration Test");
            if (checkBoxCCNA.Checked) skills.Add("CCNA");

            string allSkills = "";
            for (int i = 0; i < skills.Count; i++)
            {
                if (i > 0) allSkills += ", ";
                allSkills += skills[i];
            }


            string biodata =
                "Full name : " + textBoxFullName.Text + "\r\n" +
                "Address : " + textBoxAddress.Text + "\r\n" +
                "Occupation : " + textBoxOccupation.Text + "\r\n" +
                "Sex : " + comboBoxSex.Text + "\r\n" +
                "Date of birth : " + dob + "\r\n" +
                "Age : " + age + " years old\r\n" +
                "Skills : " + allSkills;

            textBoxOutput.Text = biodata;
           
        }
    }
}
