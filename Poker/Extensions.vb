Module Extensions
    <Runtime.CompilerServices.Extension>
    Public Sub SortByRank(cards As List(Of Card))
        Dim last As Integer = 0
        For i As Integer = 0 To cards.Count - 1
            last = i
            For j As Integer = i + 1 To cards.Count - 1
                If (cards(j).Rank < cards(last).Rank) Then
                    last = j
                End If
            Next
            Dim current As Card = cards(i)
            cards(i) = cards(last)
            cards(last) = current
        Next
    End Sub
    <Runtime.CompilerServices.Extension>
    Public Sub SortBySuit(cards As List(Of Card))
        Dim last As Integer = 0
        For i As Integer = 0 To cards.Count - 1
            last = i
            For j As Integer = i + 1 To cards.Count - 1
                If (cards(j).Suit < cards(last).Suit) Then
                    last = j
                End If
            Next
            Dim current As Card = cards(i)
            cards(i) = cards(last)
            cards(last) = current
        Next
    End Sub
    <Runtime.CompilerServices.Extension>
    Public Function Permutate(Of T)(Source As IEnumerable(Of T), Length As Integer) As IEnumerable(Of T())
        Dim Result As New List(Of T())
        If (Length = 0) Then
            Result.Add(New T(-1) {})
        Else
            Dim index As Integer = 1
            For Each item As T In Source
                Result.AddRange(Source.Skip(index).Permutate(Length - 1).Select(
                                Function(value() As T) (New T() {item}).Concat(value).ToArray()))
                index += 1
            Next
        End If
        Return Result
    End Function
    <Runtime.CompilerServices.Extension>
    Public Function Label(r As Rank) As String
        If (r = Rank.Ace) Then
            Return "A"
        ElseIf (r = Rank.King) Then
            Return "K"
        ElseIf (r = Rank.Queen) Then
            Return "Q"
        ElseIf (r = Rank.Jack) Then
            Return "J"
        ElseIf (r = Rank.Ten) Then
            Return "10"
        ElseIf (r = Rank.Nine) Then
            Return "9"
        ElseIf (r = Rank.Eight) Then
            Return "8"
        ElseIf (r = Rank.Seven) Then
            Return "7"
        ElseIf (r = Rank.Six) Then
            Return "6"
        ElseIf (r = Rank.Five) Then
            Return "5"
        ElseIf (r = Rank.Four) Then
            Return "4"
        ElseIf (r = Rank.Three) Then
            Return "3"
        ElseIf (r = Rank.Two) Then
            Return "2"
        Else
            Return "?"
        End If
    End Function
    <Runtime.CompilerServices.Extension>
    Public Function Label(s As Suit) As String
        If (s = Suit.Club) Then
            Return "♣"
        ElseIf (s = Suit.Diamond) Then
            Return "♦"
        ElseIf (s = Suit.Heart) Then
            Return "♥"
        ElseIf (s = Suit.Spade) Then
            Return "♠"
        Else
            Return "?"
        End If
    End Function
End Module
