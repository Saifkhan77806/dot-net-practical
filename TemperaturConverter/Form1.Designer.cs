namespace TemperaturConverter;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    private RadioButton rbCelsius;
    private RadioButton rbFahrenheit;
    private TextBox txtTemperature;
    private Button btnSubmit;
    private Label lblResult;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();

        rbCelsius = new RadioButton();
        rbFahrenheit = new RadioButton();
        txtTemperature = new TextBox();
        btnSubmit = new Button();
        lblResult = new Label();

        // Celsius Radio Button
        rbCelsius.AutoSize = true;
        rbCelsius.Location = new Point(50, 50);
        rbCelsius.Name = "rbCelsius";
        rbCelsius.Size = new Size(67, 24);
        rbCelsius.Text = "Celsius";
        rbCelsius.Checked = true;

        // Fahrenheit Radio Button
        rbFahrenheit.AutoSize = true;
        rbFahrenheit.Location = new Point(150, 50);
        rbFahrenheit.Name = "rbFahrenheit";
        rbFahrenheit.Size = new Size(98, 24);
        rbFahrenheit.Text = "Fahrenheit";

        // Temperature TextBox
        txtTemperature.Location = new Point(50, 100);
        txtTemperature.Name = "txtTemperature";
        txtTemperature.Size = new Size(200, 27);

        // Submit Button
        btnSubmit.Location = new Point(50, 150);
        btnSubmit.Name = "btnSubmit";
        btnSubmit.Size = new Size(100, 35);
        btnSubmit.Text = "Submit";
        btnSubmit.UseVisualStyleBackColor = true;
        btnSubmit.Click += BtnSubmit_Click;

        // Result Label
        lblResult.AutoSize = true;
        lblResult.Location = new Point(50, 210);
        lblResult.Name = "lblResult";
        lblResult.Size = new Size(0, 20);

        // Form
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(400, 300);
        Text = "Temperature Converter";

        Controls.Add(rbCelsius);
        Controls.Add(rbFahrenheit);
        Controls.Add(txtTemperature);
        Controls.Add(btnSubmit);
        Controls.Add(lblResult);
    }

    #endregion
}