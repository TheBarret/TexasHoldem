Public Class Card
    Public Property Suit As Suit
    Public Property Rank As Rank
    Sub New(suit As Suit, rank As Rank)
        Me.Suit = suit
        Me.Rank = rank
    End Sub
    Public Overrides Function ToString() As String
        Return String.Format("{0}{1}", Me.Suit.Label, Me.Rank.Label)
    End Function
End Class
