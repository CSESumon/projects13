using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculatorApp
{
    public partial class SalaryCalculatorUI : Form
    {
        public SalaryCalculatorUI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            Salary salary=new Salary();
            salary.name = nameTextBox.Text;
            salary.basicSalary = Convert.ToDouble(basicAmountTextBox.Text);
            salary.houseRentPercent = Convert.ToDouble(houseRentTextBox.Text);
            salary.medicalAllowancePercent = Convert.ToDouble(medicalAllowanceTextBox.Text);

           
            
            MessageBox.Show(salary.name + ", your salary is " + salary.GetSalary());

        }
    }
}
