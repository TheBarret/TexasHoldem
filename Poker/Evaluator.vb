Public MustInherit Class Evaluator
    Public Property Highcard As Card
    Public Property Cards As List(Of Card)
    Public Property Strength As Integer = 0
    Public Property HandType As HandType = HandType.Nothing
    Public Sub Evaluate()
        If (Me.Cards.Any) Then
            Using helper As New GameLogic(Me.Cards)
                Me.HandType = helper.GetHandType
                Me.Highcard = helper.GetHighestCard
                Me.Strength = helper.GetHandStrength
            End Using
        End If
    End Sub
    Public Sub Evaluate(table As List(Of Card))
        If (Me.Cards.Any AndAlso table.Any) Then
            Dim buffer As New List(Of Card)
            buffer.AddRange(Me.Cards)
            buffer.AddRange(table)
            For Each serie As Card() In buffer.Permutate(5)
                Using helper As New GameLogic(serie.ToList)
                    Dim strength As Integer = helper.GetHandStrength
                    If (strength > Me.Strength) Then
                        Me.Strength = strength
                        Me.HandType = helper.GetHandType
                    End If
                End Using
                Using helper As New GameLogic(Me.Cards)
                    Me.Highcard = helper.GetHighestCard
                End Using
            Next
        End If
    End Sub
End Class

