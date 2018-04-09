Public Class Datos_Parqueadero
    Dim parks As ParkingControlClasses.ParkingSpot


    Private Sub DSaveButton_Click(sender As Object, e As EventArgs) Handles DSaveButton.Click
        parks.Name = DNameTextBox.Text()
        parks.Address = DAddressTextBox.Text()
        parks.Capacity = DCapacityTextBox.Text()
        parks.QuarterHourRate = DFare4TextBox.Text()
        parks.HalfHourRate = DFare2TextBox.Text()
        parks.HourRate = DFare1TextBox.Text()
        Me.Hide()
        Parqueadero.Show()
    End Sub

    Private Sub Datos_Parqueadero_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles DNameTextBox.TextChanged

    End Sub
End Class