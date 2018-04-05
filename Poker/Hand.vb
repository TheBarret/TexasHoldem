Public Class Hand
    Inherits Evaluator
    Sub New()
        Me.Cards = New List(Of Card)
    End Sub
    Sub New(cards As List(Of Card))
        Me.Cards = cards
        Me.Evaluate()
    End Sub
    Public Overrides Function ToString() As String
        Return String.Format("{0}[{1}]", Me.HandType, Me.Strength)
    End Function
End Class
