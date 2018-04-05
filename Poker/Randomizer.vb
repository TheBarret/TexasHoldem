Module Randomizer
    Private Property Instance As Random
    Sub New()
        Randomizer.Instance = New Random(Environment.TickCount)
    End Sub
    Public Function Number(min As Integer, max As Integer) As Integer
        Return Randomizer.Instance.Next(min, max)
    End Function
End Module