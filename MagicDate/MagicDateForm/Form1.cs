using System;
using System.Windows.Forms;

namespace MagicDateForm;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Submit_Click(object sender, EventArgs e)
    {
        // 1. Extract values from input text boxes safely
        bool isMonthValid = int.TryParse(Month.Text, out int monthNum);
        bool isDayValid = int.TryParse(Day.Text, out int dayNum);
        bool isYearValid = int.TryParse(Year.Text, out int yearNum);

        // 2. Validate user inputs are actually numbers
        if (!isMonthValid || !isDayValid || !isYearValid)
        {
            MessageBox.Show("Please enter valid numeric integers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        // 3. Perform your calculation logic
        if (monthNum * dayNum == yearNum)
        {
            MessageBox.Show("The date is magic!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            MessageBox.Show("Not a magic date.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
