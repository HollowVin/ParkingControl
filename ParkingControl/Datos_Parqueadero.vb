Public Class Datos_Parqueadero
    Public parks As ParkingControlClasses.ParkingSpot

    Private Sub DSaveButton_Click(sender As Object, e As EventArgs) Handles DSaveButton.Click
        parks = New ParkingControlClasses.ParkingSpot(1, "", "", 0, 0.00, 0.00, 0.00)

        parks.Name = DNameTextBox.Text
        parks.Address = DAddressTextBox.Text
        parks.Capacity = CType(DCapacityTextBox.Text, Integer)
        parks.QuarterHourRate = CType(DFare4TextBox.Text, Decimal)
        parks.HalfHourRate = CType(DFare2TextBox.Text, Decimal)
        parks.HourRate = CType(DFare1TextBox.Text, Decimal)



        Parqueadero.AvailableSpotsLabel.Text = "Disponibles: " + DCapacityTextBox.Text

        Me.Hide()
        Parqueadero.Show()
    End Sub

    Private Sub Datos_Parqueadero_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles DNameTextBox.TextChanged

    End Sub

    Private Sub Datos_Parqueadero_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class