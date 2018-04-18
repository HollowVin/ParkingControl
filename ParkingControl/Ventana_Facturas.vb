Public Class Ventana_Facturas
    Private Sub Comebackbutton_Click(sender As Object, e As EventArgs) Handles Comebackbutton.Click
        Me.Hide()
    End Sub

    Private Sub Ventana_Facturas_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Hide()
    End Sub
End Class