Public Class Datos_Parqueadero
    Private Sub DSaveButton_Click(sender As Object, e As EventArgs) Handles DSaveButton.Click
        Me.Hide()
        Parqueadero.Show()
    End Sub

    Private Sub Datos_Parqueadero_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub
End Class