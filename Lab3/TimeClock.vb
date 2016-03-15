Public Class TimeClock

	Public Property StartTime As DateTime
	Public Property StopTime As DateTime
	Public Property ClientName() As String


    Public ReadOnly Property TotalElapsed() As TimeSpan
        Get
            Return StopTime.Subtract(StartTime)
        End Get
    End Property



End Class
