namespace TemperaturConverter;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void BtnSubmit_Click(object? sender, EventArgs e)
    {
        if (!double.TryParse(txtTemperature.Text, out double temp))
        {
            MessageBox.Show("Please enter a valid number.");
            return;
        }

        double result;

        if (rbCelsius.Checked)
        {
            // Celsius to Fahrenheit
            result = (temp * 9 / 5) + 32;
            lblResult.Text = $"{temp} °C = {result:F2} °F";
        }
        else
        {
            // Fahrenheit to Celsius
            result = (temp - 32) * 5 / 9;
            lblResult.Text = $"{temp} °F = {result:F2} °C";
        }
    }
}
