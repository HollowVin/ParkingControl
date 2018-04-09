Public Class Datos_Parqueadero
    Public parks As ParkingControlClasses.ParkingSpot

    Private Sub DSaveButton_Click(sender As Object, e As EventArgs) Handles DSaveButton.Click
        Dim nombre, direccion As String
        Dim capacidad As Integer
        Dim cuarto, Media, total As Decimal

        nombre = DNameTextBox.Text
        direccion = DAddressTextBox.Text
        capacidad = CType(DCapacityTextBox.Text, Integer)
        cuarto = CType(DFare4TextBox.Text, Decimal)
        Media = CType(DFare2TextBox.Text, Decimal)
        total = CType(DFare1TextBox.Text, Decimal)

        parks = New ParkingControlClasses.ParkingSpot(1, nombre, direccion, capacidad, cuarto, Media, total)

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