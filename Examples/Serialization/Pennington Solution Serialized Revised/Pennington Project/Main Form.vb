Option Explicit On
Option Strict On
Option Infer Off
' Project name:          Pennington Project
' Project purpose:       Display the total amount a customer owes
' Created/revised by:    <your name> on <current date>

'imports required to use i/o and serialization of objects
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Class MainForm

    Private customerSale As New BookSale    'used to create an from data entered
    Private myList As New List(Of BookSale) 'used to hold objects as they are read in from file

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        ' calculates the amount a customer owes for one or more books

        Integer.TryParse(quantityTextBox.Text, customerSale.Quantity)
        Decimal.TryParse(priceTextBox.Text, customerSale.Price)

        customerSale.CalculateTotalDue()
        myList.Add(customerSale)
        totalDueLabel.Text = customerSale.TotalDue.ToString("C2")
        quantityTextBox.Focus()
    End Sub

    Private Sub newButton_Click(sender As Object, e As EventArgs) Handles newButton.Click
        ' prepares the application for a new order

        customerSale.TotalDue = 0

        quantityTextBox.Text = String.Empty
        priceTextBox.Text = String.Empty
        totalDueLabel.Text = String.Empty
        quantityTextBox.Focus()

    End Sub

    Private Sub priceTextBox_Enter(sender As Object, e As EventArgs) Handles priceTextBox.Enter
        priceTextBox.SelectAll()
    End Sub

    Private Sub priceTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles priceTextBox.KeyPress
        ' allows the text box to accept numbers, the period, and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub quantityTextBox_Enter(sender As Object, e As EventArgs) Handles quantityTextBox.Enter
        quantityTextBox.SelectAll()
    End Sub

    Private Sub quantityTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles quantityTextBox.KeyPress
        ' allows the text box to accept numbers and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub ClearLabel(sender As Object, e As EventArgs) Handles quantityTextBox.TextChanged, priceTextBox.TextChanged
        totalDueLabel.Text = String.Empty
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        'display the objects by looping thru the list
        For Each item As BookSale In myList
            MessageBox.Show("Price: " & item.Price & " Quantity: " & item.Quantity)
        Next
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim infile As FileStream
        Dim bf As BinaryFormatter
        If File.Exists("booksale.ser") Then
            Try
                infile = New FileStream("booksale.ser", FileMode.Open, FileAccess.Read)
                bf = New BinaryFormatter()
                Dim b As BookSale

                While infile.Position < infile.Length
                    b = DirectCast(bf.Deserialize(infile), BookSale)
                    myList.Add(b)
                End While
                infile.Close()

            Catch exc As Exception
                MessageBox.Show(exc.ToString &
                                " - Could not open student grade file, application terminating")
                Me.Close()
            End Try
        End If

    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Dim outfile As FileStream
        Dim bf As BinaryFormatter
        Try
            outfile = New FileStream("booksale.ser", FileMode.Create, FileAccess.Write)
            bf = New BinaryFormatter()

            For Each item As Object In myList
                bf.Serialize(outfile, item)
            Next
            outfile.Close()
        Catch exc As Exception
            MessageBox.Show(exc.ToString &
                            " - Could not write to student grade file , application terminating")
        End Try

        Me.Close()

    End Sub
End Class

