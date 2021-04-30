using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoLibrary.Models;
using DemoLibrary;

namespace UserInterface
{
    public partial class Dashboard : Form
    {
        List<Person> people;

        public Dashboard()
        {
            InitializeComponent();
            RebindDropdown();
        }

        private void RebindDropdown()
        {
            people = DataAccess.GetAllPeople();
            userComboBox.DataSource = null;
            userComboBox.DataSource = people;
            userComboBox.DisplayMember = "FullName";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtResults.Text = Calculator.Add((double)numericFirstNumber.Value, (double)numericLastNumber.Value).ToString();
            numericFirstNumber.Value = 0;
            numericLastNumber.Value = 0;
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            txtResults.Text = Calculator.Subtract((double)numericFirstNumber.Value, (double)numericLastNumber.Value).ToString();
            numericFirstNumber.Value = 0;
            numericLastNumber.Value = 0;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            txtResults.Text = Calculator.Multiply((double)numericFirstNumber.Value, (double)numericLastNumber.Value).ToString();
            numericFirstNumber.Value = 0;
            numericLastNumber.Value = 0;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            txtResults.Text = Calculator.Divide((double)numericFirstNumber.Value, (double)numericLastNumber.Value).ToString();
            numericFirstNumber.Value = 0;
            numericLastNumber.Value = 0;
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            DataAccess.AddNewPerson(new Person { FirstName = txtFirstName.Text, LastName = txtLastName.Text });

            txtFirstName.Text = "";
            txtLastName.Text = "";

            RebindDropdown();
        }
    }
}
