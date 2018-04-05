Public Class Deck
    Public Property Cards As List(Of Card)
    Sub New(Optional shuffle As Boolean = False)
        Me.Cards = New List(Of Card)
        SyncLock Me.Cards
            For Each suit As Suit In [Enum].GetValues(GetType(Suit))
                For Each rank As Rank In [Enum].GetValues(GetType(Rank))
                    Me.Cards.Add(New Card(suit, rank))
                Next
            Next
        End SyncLock
        If (shuffle) Then Me.Shuffle()
    End Sub
    Public Function Deal(Optional amount As Integer = 5) As List(Of Card)
        If (Me.Cards.Any AndAlso Me.Cards.Count >= 5) Then
            Dim cards As New List(Of Card)
            For i As Integer = 0 To amount - 1
                cards.Add(Me.Deal)
            Next
            Return cards
        End If
        Throw New Exception("Deck is empty")
    End Function
    Public Function Deal() As Card
        If (Me.Cards.Any) Then
            Dim card As Card = Me.Cards.ElementAt(0)
            SyncLock Me.Cards
                Me.Cards.Remove(card)
            End SyncLock
            Return card
        End If
        Throw New Exception("Deck is empty")
    End Function
    Public Sub Shuffle()
        Dim n, r As Integer, value As Card
        n = Me.Cards.Count
        SyncLock Me.Cards
            For i As Integer = 0 To n - 1
                r = i + Randomizer.Number(0, n - i)
                value = Me.Cards(i)
                Me.Cards(i) = Me.Cards(r)
                Me.Cards(r) = value
            Next
        End SyncLock
    End Sub
End Class
