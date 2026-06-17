namespace CalAge;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private int CalculateAge(DateTime dob)
    {
        DateTime today = DateTime.Today;

        int age = today.Year - dob.Year;

        // Check if birthday has occurred this year
        if (dob.Date > today.AddYears(-age))
        {
            age--;
        }

        return age;
    }

    private void BtnCalculate_Click(object? sender, EventArgs e)
    {
        DateTime dob = dtpDOB.Value;

        int age = CalculateAge(dob);

        lblAge.Text = $"Age: {age} years";
    }
}
