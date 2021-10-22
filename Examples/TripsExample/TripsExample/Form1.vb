Option Strict Off
Public Class Form1

    Private Sub btnTrips_Click(sender As Object, e As EventArgs) Handles btnTrips.Click
        TblTripsTableAdapter1.Fill(TripsCopyDataSet.tblTrips)
        dgvInfo.DataSource = TripsCopyDataSet.tblTrips
    End Sub

    Private Sub btnCities_Click(sender As Object, e As EventArgs) Handles btnCities.Click
        TblCityTableAdapter1.Fill(TripsCopyDataSet.tblCity)
        dgvInfo.DataSource = TripsCopyDataSet.tblCity
    End Sub

    Private Sub btnChicago_Click(sender As Object, e As EventArgs) Handles btnChicago.Click
        ChicagoTripsTableAdapter1.Fill(TripsCopyDataSet.ChicagoTrips)
        dgvInfo.DataSource = TripsCopyDataSet.ChicagoTrips
    End Sub

    Private Sub btnNashville_Click(sender As Object, e As EventArgs) Handles btnSelectTrips.Click
        Dim str As String
        str = InputBox("Enter the City ID:", "City Selection", "Ch")

        TblTripsTableAdapter1.Fill(TripsCopyDataSet.tblTrips)

        Dim trips = (From t In TripsCopyDataSet.tblTrips
                     Where t.Destination = str
                     Select t.TripDate, t.Destination, t.BusinessPleasure).ToList

        dgvInfo.DataSource = trips
    End Sub

    Private Sub btnCountByCity_Click(sender As Object, e As EventArgs) Handles btnCountByCity.Click
        TblTripsTableAdapter1.Fill(TripsCopyDataSet.tblTrips)

        Dim gb = (From t In TripsCopyDataSet.tblTrips
                  Group By t.Destination Into Count()
                  Select Destination, CountTrips = Count).ToList

        dgvInfo.DataSource = gb
    End Sub
End Class
