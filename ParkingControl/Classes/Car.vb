Public Class Car
    Public Property CodeVal As String
    Public Property PlateNumber As String
    Public Property EnterHour As DateTime
    Public Property ExitHour As DateTime

    Public Sub New(CodeVal As String, PlateNumber As String)
        Me.CodeVal = CodeVal
        Me.PlateNumber = PlateNumber
        EnterHour = DateTime.Now
    End Sub

    Public Function Exits() As TimeSpan
        ExitHour = DateTime.Now
        Return ExitHour - EnterHour
        ' (ExitHour - EnterHour).GetMinutes
    End Function
End Class
