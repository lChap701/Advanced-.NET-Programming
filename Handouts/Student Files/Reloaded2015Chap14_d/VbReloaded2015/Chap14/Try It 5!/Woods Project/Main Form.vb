' Project name:         Woods Project
' Project purpose:      Calculates the gross pay for salaried and 
'                       hourly employees and displays a report
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        ' displays the gross pay and a report

        ' declare variables
        Dim ourEmployee As Employee
        Dim annualSalary As Double
        Dim hours As Double
        Dim hourRate As Double
        Dim gross As Double

        ' instantiate an Employee object
        ourEmployee = New Employee(numTextBox.Text, nameTextBox.Text)

        ' determine the selected radio button
        If hourlyRadioButton.Checked Then
            ' calculate the gross pay for an hourly employee
            Double.TryParse(hoursListBox.SelectedItem.ToString, hours)
            Double.TryParse(rateListBox.SelectedItem.ToString, hourRate)
            gross = ourEmployee.GetGross(hours, hourRate)
        Else
            ' calculate the gross pay for a salaried employee
            Double.TryParse(salaryListBox.SelectedItem.ToString,
                            annualSalary)
            gross = ourEmployee.GetGross(annualSalary)
        End If

        ' display the gross pay and report
        grossLabel.Text = gross.ToString("C2")
        reportTextBox.Text = reportTextBox.Text &
          ourEmployee.EmpNumber.PadRight(6) &
          ourEmployee.EmpName.PadRight(25) &
          gross.ToString("N2").PadLeft(9) & ControlChars.NewLine

        numTextBox.Focus()
    End Sub

    Private Sub ClearLabel(sender As Object, e As EventArgs) Handles hoursListBox.SelectedValueChanged,
            rateListBox.SelectedValueChanged, salaryListBox.SelectedValueChanged
        grossLabel.Text = String.Empty
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub numTextBox_Enter(sender As Object, e As EventArgs) Handles numTextBox.Enter
        numTextBox.SelectAll()
    End Sub

    Private Sub nameTextBox_Enter(sender As Object, e As EventArgs) Handles nameTextBox.Enter
        nameTextBox.SelectAll()
    End Sub

    Private Sub hourlyRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles hourlyRadioButton.CheckedChanged
        ' displays the labels and list boxes used 
        ' to enter the number of hours worked and
        ' the rate of pay; hides the label and
        ' list box used to enter the salary

        grossLabel.Text = String.Empty
        hoursIdLabel.Visible = True
        hoursListBox.Visible = True
        rateIdLabel.Visible = True
        rateListBox.Visible = True
        salaryIdLabel.Visible = False
        salaryListBox.Visible = False
    End Sub

    Private Sub salariedRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles salariedRadioButton.CheckedChanged
        ' displays the label and list box used to 
        ' enter the salary; hides the labels and  
        ' list boxes used to enter the number of 
        ' hours worked and the rate of pay; 

        grossLabel.Text = String.Empty
        salaryIdLabel.Visible = True
        salaryListBox.Visible = True
        hoursIdLabel.Visible = False
        hoursListBox.Visible = False
        rateIdLabel.Visible = False
        rateListBox.Visible = False
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fills the list boxes with values and then
        ' selects a default item in each list box

        For salary As Double = 15000 To 35000 Step 1000
            salaryListBox.Items.Add(salary.ToString)
        Next salary

        For hour As Double = 0.5 To 40 Step 0.5
            hoursListBox.Items.Add(hour.ToString("N1"))
        Next hour

        For rate As Double = 7 To 14 Step 0.5
            rateListBox.Items.Add(rate.ToString("N2"))
        Next rate

        salaryListBox.SelectedItem = "20000"
        hoursListBox.SelectedItem = "40.0"
        rateListBox.SelectedItem = "10.00"
    End Sub
End Class
