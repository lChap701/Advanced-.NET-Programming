Option Strict Off
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'fill the Games, Ratings and JustNewGames dataset tables with data
        Me.TblJustNewGamesTableAdapter.Fill(Me.GamesRevisedDataSet.tblJustNewGames)
        Me.TblRatingTableAdapter.Fill(Me.GamesRevisedDataSet.tblRating)
        Me.TblGamesTableAdapter.Fill(Me.GamesRevisedDataSet.tblGames)

        'call method to fill in the rating description
        getRatingDescription()

    End Sub

    'search the Games table for rows whose price is >= to the entered price 
    Private Sub tsbSearch_Click(sender As Object, e As EventArgs) Handles tsbSearch.Click
        justNewGamesDataGridView.Visible = False
        TblGamesDataGridView.Visible = True
        'Dim num As Integer = 0
        Dim searchPrice As Double

        'if the entered price is numeric, search the games table
        'for the matching rows
        If Double.TryParse(txtPriceSearch.Text, searchPrice) Then
            Dim games =
            (From g In GamesRevisedDataSet.tblGames
             Where g.Price >= searchPrice
             Order By g.Price Descending
             Select g.ID, g.Title, g.Platform, g.Rating, g.Price, g.NewUsed, g.Quantity).ToList
            're-bind the data source to the games just found
            TblGamesBindingSource.DataSource = games
        Else
            Dim games =
            (From g In GamesRevisedDataSet.tblGames
             Order By g.ID
             Select g.ID, g.Title, g.Platform, g.Rating, g.Price, g.NewUsed, g.Quantity).ToList
            're-bind the data source to the games just found
            TblGamesBindingSource.DataSource = games
        End If

        'call method to fill in the rating description
        getRatingDescription()
    End Sub

    Private Sub getRatingDescription()
        Dim num As Integer = 0

        'TblGamesDataGridView.Columns.Add("RatingDesc", "RatingDescription")
        Try
            'loop thru each row of the datagrid
            For Each row As DataGridViewRow In TblGamesDataGridView.Rows
                If num < GamesRevisedDataSet.tblGames.Count Then   'ensure not past number of rows
                    'query the rating id in the rating table for the description
                    Dim ratings As EnumerableRowCollection(Of GamesRevisedDataSet.tblRatingRow) =
                        From r In GamesRevisedDataSet.tblRating
                        Where row.Cells.Item(3).Value.ToString = r.RatingID.ToString
                        Select r
                    'if found display rating description in datagrid cell, otherwise not found
                    If ratings.Any() Then
                        row.Cells.Item(7).Value = ratings(0).RatingDesc
                    Else
                        row.Cells.Item(7).Value = "RatingID not found"
                    End If
                End If
                num += 1
            Next
        Catch ex As Exception
            MessageBox.Show("error")
        End Try
    End Sub

    Private Sub tsbXBGames_Click(sender As Object, e As EventArgs) Handles tsbXBGames.Click
        justNewGamesDataGridView.Visible = False
        TblGamesDataGridView.Visible = True

        'since XBGamesQuery does not already have an adapter on the form, 
        'one has to be created in order to fill it's dataset table
        Dim ta As New GamesRevisedDataSetTableAdapters.XBGamesQueryTableAdapter
        ta.Fill(Me.GamesRevisedDataSet.XBGamesQuery)
        TblGamesBindingSource.DataSource = GamesRevisedDataSet.XBGamesQuery
        'call method to fill in the rating description
        getRatingDescription()

    End Sub

    Private Sub tsbNewGames_Click(sender As Object, e As EventArgs) Handles tsbNewGames.Click
        TblGamesDataGridView.Visible = False
        justNewGamesDataGridView.Visible = True
    End Sub

    Private Sub tsbViewRatings_Click(sender As Object, e As EventArgs) Handles tsbViewRatings.Click
        Dim ratingsForms As New Form2
        ratingsForms.ShowDialog()
    End Sub
End Class
