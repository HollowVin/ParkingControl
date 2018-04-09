Public Class Car
    Public Property CodeVal As String
    Public Property PlateNumber As String
    Public Property EnterTime As DateTime

    Public Sub New(CodeVal As String, PlateNumber As String)
        Me.CodeVal = CodeVal
        Me.PlateNumber = PlateNumber
        EnterTime = DateTime.Now
    End Sub
End Class
