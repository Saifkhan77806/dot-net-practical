namespace MagicDateForm;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

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
        this.Submit = new System.Windows.Forms.Button();
        this.Year = new System.Windows.Forms.TextBox();
        this.Month = new System.Windows.Forms.TextBox();
        this.Day = new System.Windows.Forms.TextBox();
        this.SuspendLayout();
        
        // Submit Button
        this.Submit.Location = new System.Drawing.Point(208, 224);
        this.Submit.Name = "Submit";
        this.Submit.Size = new System.Drawing.Size(100, 30);
        this.Submit.Text = "Check Date";
        this.Submit.Click += new System.EventHandler(this.Submit_Click); // Links logic

        // Year TextBox
        this.Year.Location = new System.Drawing.Point(208, 176);
        this.Year.Name = "Year";
        this.Year.Size = new System.Drawing.Size(100, 23);

        // Month TextBox
        this.Month.Location = new System.Drawing.Point(208, 128);
        this.Month.Name = "Month";
        this.Month.Size = new System.Drawing.Size(100, 23);

        // Day TextBox
        this.Day.Location = new System.Drawing.Point(208, 72);
        this.Day.Name = "Day";
        this.Day.Size = new System.Drawing.Size(100, 23);

        // Form1 Setup
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        
        // CRITICAL: This puts your controls onto the screen
        this.Controls.Add(this.Submit);
        this.Controls.Add(this.Year);
        this.Controls.Add(this.Month);
        this.Controls.Add(this.Day);
        
        this.Text = "Magic Date Checker";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    // Class fields declared correctly as WinForms components
    private System.Windows.Forms.Button Submit;
    private System.Windows.Forms.TextBox Year;
    private System.Windows.Forms.TextBox Month;
    private System.Windows.Forms.TextBox Day;
}
