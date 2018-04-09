Public Class Datos_Parqueadero
    Private Sub DSaveButton_Click(sender As Object, e As EventArgs) Handles DSaveButton.Click
        Dim nombre, direccion As String
        Dim capacidad As Integer
        Dim cuarto, Media, total As Decimal
        Dim parks As ParkingControlClasses.ParkingSpot = New ParkingControlClasses.ParkingSpot(1, nombre, direccion, capacidad, cuarto, media, total)

        nombre = DNameTextBox.Text
        direccion = DAddressTextBox.Text
        capacidad = CType(DCapacityTextBox.Text, Integer)
        cuarto = CType(DFare4TextBox.Text, Decimal)
        Media = CType(DFare2TextBox.Text, Decimal)
        total = CType(DFare1TextBox.Text, Decimal)
        Me.Hide()
        Parqueadero.Show()
    End Sub

    Private Sub Datos_Parqueadero_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles DNameTextBox.TextChanged

    End Sub
End Class