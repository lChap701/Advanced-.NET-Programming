' Project name:         Discount Calculator Project
' Project purpose:      Displays a discount amount
' Created/revised by:	<your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub disc15Button_Click(sender As Object, e As EventArgs) Handles disc15Button.Click
        ' calculates and displays a 15% discount

        ' the Dim statements declare two procedure-level
        ' variables that can be used only within the 
        ' disc15Button_Click procedure
        Dim sales As Double
        Dim discount15 As Double

        ' the TryParse method converts the contents of
        ' the salesTextBox to Double and then stores the
        ' result in the procedure-level sales variable
        Double.TryParse(salesTextBox.Text, sales)

        ' the assignment statement multiplies the value
        ' stored in the procedure-level sales variable by
        ' the Double number 0.15 and then assigns the result
        ' to the procedure-level discount15 variable
        discount15 = sales * 0.15

        ' the Convert method converts the value stored in 
        ' the procedure-level discount15 variable to String,
        ' and the assignment statement assigns the result to
        ' the discountLabel's Text property
        discountLabel.Text = Convert.ToString(discount15)
    End Sub

    Private Sub disc20Button_Click(sender As Object, e As EventArgs) Handles disc20Button.Click
        ' calculates and displays a 20% discount

        ' the Dim statements declare two procedure-level
        ' variables that can be used only within the 
        ' disc20Button_Click procedure
        Dim sales As Double
        Dim discount20 As Double

        ' the TryParse method converts the contents of
        ' the salesTextBox to Double and then stores the
        ' result in the procedure-level sales variable
        Double.TryParse(salesTextBox.Text, sales)

        ' the assignment statement multiplies the value
        ' stored in the procedure-level sales variable by
        ' the Double number 0.15 and then assigns the result
        ' to the procedure-level discount20 variable
        discount20 = sales * 0.2

        ' the Convert method converts the value stored in 
        ' the procedure-level discount20 variable to String,
        ' and the assignment statement assigns the result to
        ' the discountLabel's Text property
        discountLabel.Text = Convert.ToString(discount20)
    End Sub
End Class
