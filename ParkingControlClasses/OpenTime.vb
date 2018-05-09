Public Class OpenTime

    Enum Weekday
        Monday
        Tuesday
        Wednesday
        Thursday
        Friday
        Saturday
        Sunday
    End Enum

    Public Property FromDay As Weekday
    Public Property ToDay As Weekday
    Public Property OpeningHour As Integer
    Public Property ClosingHour As Integer

    Public Sub New(FromDay As Weekday, ToDay As Weekday, OpeningHour As Integer, ClosingHour As Integer)
        Me.FromDay = FromDay
        Me.ToDay = ToDay
        Me.OpeningHour = OpeningHour
        Me.ClosingHour = ClosingHour
    End Sub

    'Public Overrides Function ToString() As String
    '    Dim ReturnString As String
    '    ReturnString = "De " + WeekdayString(Me.FromDay) + " a " + WeekdayString(Me.ToDay)
    'End Function

    'Private Shared Function WeekdayString(Day As Weekday) As String
    '    Select Case Day
    '        Case Weekday.Sunday
    '            Return "Sunday"
    '        Case Weekday.Monday
    '            Return "Monday"
    '        Case Weekday.Sunday
    '            Return "Tuesday"
    '        Case Weekday.Monday
    '            Return "Wednesday"
    '        Case Weekday.Sunday
    '            Return "Thursday"
    '        Case Weekday.Monday
    '            Return "Friday"
    '        Case Else
    '            Return "Saturday"
    '    End Select
    'End Function

End Class
