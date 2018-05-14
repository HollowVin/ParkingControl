Imports System.Globalization
Public Class Datos_Parqueadero
    Public parks As ParkingControlClasses.ParkingSpot
    Public opt As ParkingControlClasses.OpenTime

    Private Sub DSaveButton_Click(sender As Object, e As EventArgs) Handles DSaveButton.Click

        Dim Ot As ParkingControlClasses.OpenTime
        Ot = New ParkingControlClasses.OpenTime(DDaysComboBox.SelectedIndex, DDaysComboBox2.SelectedIndex, DOpenHourComboBox.SelectedIndex, DCloseHourComboBox.SelectedIndex)
        parks = New ParkingControlClasses.ParkingSpot(1, "", "", 0, 0.00, 0.00, 0.00, Ot)

        parks.Name = DNameTextBox.Text
        parks.Address = DAddressTextBox.Text
        parks.Capacity = CType(DCapacityTextBox.Text, Integer)
        parks.QuarterHourRate = CType(DFare4TextBox.Text, Decimal)
        parks.HalfHourRate = CType(DFare2TextBox.Text, Decimal)
        parks.HourRate = CType(DFare1TextBox.Text, Decimal)
        Parqueadero.AvailableSpotsLabel.Text = "Disponibles: " + DCapacityTextBox.Text

        'Dim Connection As New ParkingSpotsDBConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\ParkingControl\ParkingControlWebSite\App_Data\db_parkingspots.mdb")
        Dim Connection As New ParkingSpotsDBConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Sergio\Source\Repos\ParkingControl\ParkingControlWebSite\App_Data\db_parkingspots.mdb")
        Connection.InsertParkingSpot(parks)

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

    Private Sub DDaysComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DDaysComboBox.SelectedIndexChanged

    End Sub
End Class