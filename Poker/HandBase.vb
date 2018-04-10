Public MustInherit Class HandBase
    Public Property Hand As HandType
    Public Property Highcard As Card
    Public Property Strength As Integer
    Public Property Cards As List(Of Card)
    Sub New()
        Me.Strength = 0
    End Sub
    Public Sub Evaluate()
        If (Me.Cards.Any) Then
            Using ev As New Evaluator(Me.Cards)
                ev.Run(Me)
            End Using
        End If
    End Sub
    Public Sub EvaluateWith(table As List(Of Card))
        If (Me.Cards.Any AndAlso table.Any) Then
            Dim buffer As New List(Of Card)
            Using ev As New Evaluator(Me.Cards)
                ev.Run(Me)
            End Using
            buffer.AddRange(Me.Cards)
            buffer.AddRange(table)
            For Each serie In buffer.Permutate(5)
                If (Not table.Equal(serie)) Then
                    Using ev As New Evaluator(serie)
                        Dim temp As New Hand
                        ev.Run(temp)
                        If (Me.Strength < temp.Strength) Then
                            Me.Strength = temp.Strength
                            Me.Hand = temp.Hand
                        End If
                    End Using
                End If
            Next
        End If
    End Sub
    
End Class

