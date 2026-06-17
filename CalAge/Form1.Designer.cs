namespace CalAge;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private DateTimePicker dtpDOB;
    private Button btnCalculate;
    private Label lblAge;

    private void InitializeComponent()
    {
        dtpDOB = new DateTimePicker();
        btnCalculate = new Button();
        lblAge = new Label();

        // Date of Birth Picker
        dtpDOB.Location = new Point(50, 50);
        dtpDOB.Name = "dtpDOB";
        dtpDOB.Size = new Size(200, 27);
        dtpDOB.Format = DateTimePickerFormat.Short;

        // Calculate Button
        btnCalculate.Location = new Point(50, 100);
        btnCalculate.Name = "btnCalculate";
        btnCalculate.Size = new Size(120, 35);
        btnCalculate.Text = "Calculate Age";
        btnCalculate.Click += BtnCalculate_Click;

        // Result Label
        lblAge.Location = new Point(50, 160);
        lblAge.AutoSize = true;
        lblAge.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        lblAge.Text = "Age: ";

        // Form
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(400, 250);
        Text = "Age Calculator";

        Controls.Add(dtpDOB);
        Controls.Add(btnCalculate);
        Controls.Add(lblAge);
    }

    #endregion
}
