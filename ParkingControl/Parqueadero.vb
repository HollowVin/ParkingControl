Public Class Parqueadero
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
        CCodeTextBox.Enabled = True

    End Sub

    Private Sub CGenerateButton_Click(sender As Object, e As EventArgs) Handles CGenerateButton.Click
        CCodeTextBox.Clear()
        CCodeTextBox.Enabled = False
        Dim Hora As String = DateTime.Now.ToString("HH:mm:ss")
        CCheckinHourLabel.Text = "Hora_Ingreso: " + Hora
    End Sub
End Class
