Public Class Datos_Parqueadero

    'ParkingControl.ParkingControlClasses obj = New ParkingControl.ParkingControlClasses()'



    Private Sub DSaveButton_Click(sender As Object, e As EventArgs) Handles DSaveButton.Click
        Me.Hide()
        Parqueadero.Show()
    End Sub

    Private Sub Datos_Parqueadero_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class