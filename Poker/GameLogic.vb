Public Class GameLogic
    Implements IDisposable
    Private Property Cards As List(Of Card)
#Region "Routines"
    Sub New(cards As List(Of Card))
        Me.Cards = cards
    End Sub
    Public Function GetHandType() As HandType
        Dim handValue As Integer = Me.GetHandStrength
        If (handValue >= Convert.ToInt32(HandType.RoyalFlush)) Then
            Return HandType.RoyalFlush
        ElseIf (handValue >= HandType.StraightFlush) Then
            Return HandType.StraightFlush
        ElseIf (handValue >= HandType.FourOfAKind) Then
            Return HandType.FourOfAKind
        ElseIf (handValue >= HandType.FullHouse) Then
            Return HandType.FullHouse
        ElseIf (handValue >= HandType.Flush) Then
            Return HandType.Flush
        ElseIf (handValue >= HandType.Straight) Then
            Return HandType.Straight
        ElseIf (handValue >= HandType.ThreeOfAKind) Then
            Return HandType.ThreeOfAKind
        ElseIf (handValue >= HandType.TwoPair) Then
            Return HandType.TwoPair
        ElseIf (handValue >= HandType.OnePair) Then
            Return HandType.OnePair
        Else
            Return HandType.HighCard
        End If
    End Function
    Public Function GetHandStrength() As Integer
        If (Me.HasFlush AndAlso Me.HasStraight) Then
            If (Me.GetHighestCard.Rank = Rank.Ace) Then
                Return Me.GetRoyalFlushValue
            End If
            Return Me.GetStraightFlushValue
        ElseIf (Me.HasFourOfKind) Then
            Return Me.GetFourOfKindValue
        ElseIf (Me.HasFullHouse) Then
            Return Me.GetFullHouseValue
        ElseIf (Me.HasFlush) Then
            Return Me.GetFlushValue
        ElseIf (Me.HasStraight) Then
            Return Me.GetStraightValue
        ElseIf (Me.HasThreeOfKind) Then
            Return Me.GetThreeOfKindValue
        ElseIf (Me.HasTwoPair) Then
            Return GetTwoPairValue()
        ElseIf (Me.HasOnePair) Then
            Return GetOnePairValue()
        End If
        Return Me.GetHighCardValue
    End Function
    Public Function GetHighestCard() As Card
        If (Me.Cards.Any) Then
            Return Me.Cards.OrderByDescending(Function(x) x.Rank).First
        End If
        Throw New Exception("no cards")
    End Function
#End Region
#Region "Hand Type"
    Private Function HasFlush() As Boolean
        If (Me.Cards.Count <> 5) Then Return False
        Me.Cards.SortBySuit()
        Return Me.Cards(0).Suit = Me.Cards(4).Suit
    End Function
    Private Function HasStraight() As Boolean
        If (Me.Cards.Count <> 5) Then Return False
        Me.Cards.SortByRank()
        Dim current As Integer = Me.Cards(0).Rank + 1
        For i As Integer = 1 To 4
            If (Me.Cards(i).Rank <> current) Then
                Return False
            End If
            current += 1
        Next
        Return True
    End Function
    Private Function HasFullHouse() As Boolean
        If (Me.Cards.Count <> 5) Then Return False
        Me.Cards.SortByRank()
        Dim a As Boolean = Me.Cards(0).Rank = Me.Cards(1).Rank AndAlso
                           Me.Cards(1).Rank = Me.Cards(2).Rank AndAlso
                           Me.Cards(3).Rank = Me.Cards(4).Rank
        Dim b As Boolean = Me.Cards(0).Rank = Me.Cards(1).Rank AndAlso
                           Me.Cards(2).Rank = Me.Cards(3).Rank AndAlso
                           Me.Cards(3).Rank = Me.Cards(4).Rank
        Return a Or b
    End Function
    Private Function HasFourOfKind() As Boolean
        If (Me.Cards.Count <> 5) Then Return False
        Me.Cards.SortByRank()
        Dim high As Boolean = Me.Cards(0).Rank = Me.Cards(1).Rank AndAlso
                              Me.Cards(1).Rank = Me.Cards(2).Rank AndAlso
                              Me.Cards(2).Rank = Me.Cards(3).Rank

        Dim low As Boolean = Me.Cards(1).Rank = Me.Cards(2).Rank AndAlso
                             Me.Cards(2).Rank = Me.Cards(3).Rank AndAlso
                             Me.Cards(3).Rank = Me.Cards(4).Rank
        Return high Or low
    End Function
    Private Function HasThreeOfKind() As Boolean
        If (Me.Cards.Count <> 5) Then Return False
        Me.Cards.SortByRank()
        Dim a As Boolean = Me.Cards(0).Rank = Me.Cards(1).Rank AndAlso
                           Me.Cards(1).Rank = Me.Cards(2).Rank AndAlso
                           Me.Cards(3).Rank <> Me.Cards(0).Rank AndAlso
                           Me.Cards(4).Rank <> Me.Cards(0).Rank AndAlso
                           Me.Cards(3).Rank <> Me.Cards(4).Rank
        Dim b As Boolean = Me.Cards(1).Rank = Me.Cards(2).Rank AndAlso
                           Me.Cards(2).Rank = Me.Cards(3).Rank AndAlso
                           Me.Cards(0).Rank <> Me.Cards(1).Rank AndAlso
                           Me.Cards(4).Rank <> Me.Cards(1).Rank AndAlso
                           Me.Cards(0).Rank <> Me.Cards(4).Rank
        Dim c As Boolean = Me.Cards(2).Rank = Me.Cards(3).Rank AndAlso
                           Me.Cards(3).Rank = Me.Cards(4).Rank AndAlso
                           Me.Cards(0).Rank <> Me.Cards(2).Rank AndAlso
                           Me.Cards(1).Rank <> Me.Cards(2).Rank AndAlso
                           Me.Cards(0).Rank <> Me.Cards(1).Rank
        Return a Or b Or c
    End Function
    Private Function HasTwoPair() As Boolean
        If (Me.Cards.Count <> 5) Then Return False
        If (Me.HasFourOfKind Or Me.HasFullHouse Or Me.HasThreeOfKind) Then
            Return False
        End If
        Me.Cards.SortByRank()
        Dim a As Boolean = Me.Cards(0).Rank = Me.Cards(1).Rank AndAlso
                           Me.Cards(2).Rank = Me.Cards(3).Rank
        Dim b As Boolean = Me.Cards(0).Rank = Me.Cards(1).Rank AndAlso
                           Me.Cards(3).Rank = Me.Cards(4).Rank
        Dim c As Boolean = Me.Cards(1).Rank = Me.Cards(2).Rank AndAlso
                           Me.Cards(3).Rank = Me.Cards(4).Rank
        Return a Or b Or c
    End Function
    Private Function HasOnePair() As Boolean
        If (Me.Cards.Count <> 5) Then Return False
        If (Me.HasFourOfKind Or Me.HasFullHouse Or Me.HasThreeOfKind Or Me.HasTwoPair) Then
            Return False
        End If
        Me.Cards.SortByRank()
        Dim a As Boolean = Me.Cards(0).Rank = Me.Cards(1).Rank
        Dim b As Boolean = Me.Cards(1).Rank = Me.Cards(2).Rank
        Dim c As Boolean = Me.Cards(2).Rank = Me.Cards(3).Rank
        Dim d As Boolean = Me.Cards(3).Rank = Me.Cards(4).Rank
        Return a Or b Or c Or d
    End Function
#End Region
#Region "Hand Value"
    Private Function GetRoyalFlushValue() As Integer
        If (Me.Cards.Count <> 5) Then Return 0
        Return Convert.ToInt32(HandType.RoyalFlush) + Me.GetHighCardValue
    End Function
    Private Function GetStraightFlushValue() As Integer
        If (Me.Cards.Count <> 5) Then Return 0
        Return Convert.ToInt32(HandType.StraightFlush) + Me.GetHighCardValue
    End Function
    Private Function GetFlushValue() As Integer
        If (Me.Cards.Count <> 5) Then Return 0
        Return Convert.ToInt32(HandType.Flush) + Me.GetHighCardValue
    End Function
    Private Function GetStraightValue() As Integer
        If (Me.Cards.Count <> 5) Then Return 0
        Return Convert.ToInt32(HandType.Straight) + Me.GetHighCardValue
    End Function
    Private Function GetFourOfKindValue() As Integer
        If (Me.Cards.Count <> 5) Then Return 0
        Me.Cards.SortByRank()
        Return Convert.ToInt32(HandType.FourOfAKind) + Me.Cards(2).Rank
    End Function
    Private Function GetFullHouseValue() As Integer
        If (Me.Cards.Count <> 5) Then Return 0
        Me.Cards.SortByRank()
        Return Convert.ToInt32(HandType.FullHouse) + Me.Cards(2).Rank
    End Function
    Private Function GetThreeOfKindValue() As Integer
        If (Me.Cards.Count <> 5) Then Return 0
        Me.Cards.SortByRank()
        Return Convert.ToInt32(HandType.ThreeOfAKind) + Me.Cards(2).Rank
    End Function
    Private Function GetTwoPairValue() As Integer
        If (Me.Cards.Count <> 5) Then Return 0
        Dim value As Integer = 0
        Me.Cards.SortByRank()
        If (Me.Cards(0).Rank = Me.Cards(1).Rank AndAlso Me.Cards(2).Rank = Me.Cards(3).Rank) Then
            value = 14 * 14 *
                Me.Cards(2).Rank + 14 *
                Me.Cards(0).Rank + Me.Cards(4).Rank
        ElseIf (Me.Cards(0).Rank = Me.Cards(1).Rank AndAlso Me.Cards(3).Rank = Me.Cards(4).Rank) Then
            value = 14 * 14 *
                Me.Cards(3).Rank + 14 *
                Me.Cards(0).Rank + Me.Cards(2).Rank
        Else
            value = 14 * 14 *
                Me.Cards(3).Rank + 14 *
                Me.Cards(1).Rank + Me.Cards(0).Rank
        End If
        Return Convert.ToInt32(HandType.TwoPair) + value
    End Function
    Private Function GetOnePairValue() As Integer
        If (Me.Cards.Count <> 5) Then Return 0
        Dim value As Integer = 0
        Me.Cards.SortByRank()
        If (Me.Cards(0).Rank = Me.Cards(1).Rank) Then
            value = 14 * 14 * 14 *
                Me.Cards(0).Rank + Me.Cards(2).Rank + 14 *
                Me.Cards(3).Rank + 14 * 14 * Me.Cards(4).Rank
        ElseIf (Me.Cards(1).Rank = Me.Cards(2).Rank) Then
            value = 14 * 14 * 14 *
                Me.Cards(1).Rank + Me.Cards(0).Rank + 14 *
                Me.Cards(3).Rank + 14 * 14 * Me.Cards(4).Rank
        ElseIf (Me.Cards(2).Rank = Me.Cards(3).Rank) Then
            value = 14 * 14 * 14 *
                Me.Cards(2).Rank + Me.Cards(0).Rank + 14 *
                Me.Cards(1).Rank + 14 * 14 * Me.Cards(4).Rank
        Else
            value = 14 * 14 * 14 *
                Me.Cards(3).Rank + Me.Cards(0).Rank + 14 *
                Me.Cards(1).Rank + 14 * 14 * Me.Cards(2).Rank
        End If
        Return Convert.ToInt32(HandType.OnePair) + value
    End Function
    Private Function GetHighCardValue() As Integer
        If (Me.Cards.Count <> 5) Then Return 0
        Me.Cards.SortByRank()
        Return Me.Cards(0).Rank + 14 *
               Me.Cards(1).Rank + 14 * 14 *
               Me.Cards(2).Rank + 14 * 14 * 14 *
               Me.Cards(3).Rank + 14 * 14 * 14 * 14 * Me.Cards(3).Rank
    End Function
#End Region
#Region "IDisposable Support"
    Private disposedValue As Boolean
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                Me.Cards = Nothing
            End If
        End If
        Me.disposedValue = True
    End Sub
    Public Sub Dispose() Implements IDisposable.Dispose
        Me.Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region
End Class
