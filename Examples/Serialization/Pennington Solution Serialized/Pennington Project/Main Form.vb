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
    Private myList As List(Of BookSale) 'used to hold objects as they are read in from file

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        ' calculates the amount a customer owes for one or more books

        Integer.TryParse(quantityTextBox.Text, customerSale.Quantity)
        Decimal.TryParse(priceTextBox.Text, customerSale.Price)

        customerSale.CalculateTotalDue()
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

    Private Sub btnPersist_Click(sender As Object, e As EventArgs) Handles btnPersist.Click
        'FileStream object needed to define filename/location and use
        'sales.ser will be stored in the bin/debug folder by default
        'Append will create a new file if it does not exist, or open the file and position pointer at the end
        Dim fs As New FileStream("sales.ser", FileMode.Append)
        'BinaryFormatter object needed in order to convert objects to binary stream of data
        Dim bf As New BinaryFormatter

        'convert the object in customerSale to a binary object and write it to the file
        bf.Serialize(fs, customerSale)

        'close the file (will be re-opened each time by the FileMode.Append above)
        fs.Close()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        'FileStream object needed to define filename/location and use
        'sales.ser is stored in the bin/debug folder by default
        'Open will open the file and position pointer at the beginning
        Dim fs As New FileStream("sales.ser", FileMode.Open)
        'BinaryFormatter object needed in order to convert objects to binary stream of data
        Dim bf As New BinaryFormatter
        'create the List so objects can be added as they are read
        myList = New List(Of BookSale)
        'as long as there are objects left to read from file
        While fs.Position < fs.Length
            Dim obj As Object
            Dim book As BookSale
            obj = bf.Deserialize(fs)    'read an object from file
            book = CType(obj, BookSale) 'convert the generic object to a single BookSale object
            myList.Add(book)            'add the single BookSale object to the list
        End While
        fs.Close()  'close the file now that the objects are in the list, ready to use
        'display the objects by looping thru the list
        For Each item As BookSale In myList
            MessageBox.Show("Price: " & item.Price & " Quantity: " & item.Quantity)
        Next
    End Sub
End Class

