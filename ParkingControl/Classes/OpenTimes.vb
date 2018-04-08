Public Class OpenTimes
    Private OpeningHour As DateTime
    Private ClosingHour As DateTime

    Public Sub New(OpeningHour As DateTime, ClosingHour As DateTime)
        Me.OpeningHour = OpeningHour
        Me.ClosingHour = ClosingHour
    End Sub
End Class
