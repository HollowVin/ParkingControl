Public Class Parqueadero
    Dim counter As Integer
    Private Sub Ingreso_Click(sender As Object, e As EventArgs) Handles Check_inTab.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles AvailableSpotsLabel.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles BLastNameLabel.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles BNameLabel.Click

    End Sub

    Private Sub ParqueaderoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParqueaderoToolStripMenuItem.Click

    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        Datos_Parqueadero.Show()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles BNameTextBox.TextChanged

    End Sub

    Private Sub CChargeButton_Click(sender As Object, e As EventArgs) Handles CChargeButton.Click
        Dim Departure_Hour As String = DateTime.Now.ToString("HH:mm:ss")
        CDepartureHourLabel.Text = "Hora_Salida: " + Departure_Hour

    End Sub

    Private Sub CGenerateButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CIngresarButton_Click(sender As Object, e As EventArgs) Handles CIngresarButton.Click
        Dim Checkin_Hour As String = DateTime.Now.ToString("HH:mm:ss")
        CCheckinHourLabel.Text = "Hora_Ingreso: " + Checkin_Hour
    End Sub

    Private Sub BDateTextBox_TextChanged(sender As Object, e As EventArgs) Handles BDateTextBox.TextChanged

    End Sub

    Private Sub BAddressTextBox_TextChanged(sender As Object, e As EventArgs) Handles BAddressTextBox.TextChanged

    End Sub

    Private Sub BPhoneTextBox_TextChanged(sender As Object, e As EventArgs) Handles BPhoneTextBox.TextChanged

    End Sub

    Private Sub BDateLabel_Click(sender As Object, e As EventArgs) Handles BDateLabel.Click

    End Sub

    Private Sub BPhoneLabel_Click(sender As Object, e As EventArgs) Handles BPhoneLabel.Click

    End Sub

    Private Sub BAddressLabel_Click(sender As Object, e As EventArgs) Handles BAddressLabel.Click

    End Sub

    Private Sub BLastNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles BLastNameTextBox.TextChanged

    End Sub

    Private Sub BCI_RUCLabel_Click(sender As Object, e As EventArgs) Handles BCI_RUCLabel.Click

    End Sub

    Private Sub CPrintButton_Click(sender As Object, e As EventArgs) Handles CPrintButton.Click
        counter = +1
    End Sub

    Private Sub BFCButton_Click(sender As Object, e As EventArgs) Handles BFCButton.Click
        BNameTextBox.Text = "Consumidor"
        BLastNameTextBox.Text = "Final"
        BCI_RUCTextBox.Text = "99999999999"
        BPhoneTextBox.Text = "9999999999"
        BDateTextBox.Text = DateTime.Now.ToString("d")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BCleanAllButton.Click
        BNameTextBox.Text = " "
        BLastNameTextBox.Text = " "
        BCI_RUCTextBox.Text = " "
        BPhoneTextBox.Text = ""
    End Sub
End Class
