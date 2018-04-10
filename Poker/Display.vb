Public Class Display
    Public Sub Assign(hand As Hand)
        Me.Reset()
        For i As Integer = 0 To hand.Cards.Count - 1
            Select Case i
                Case 0
                    Me.C1.BackgroundImage = hand.Cards(i).ToImage(Me.C1.Size, Me.Font)
                Case 1
                    Me.C2.BackgroundImage = hand.Cards(i).ToImage(Me.C2.Size, Me.Font)
                Case 2
                    Me.C3.BackgroundImage = hand.Cards(i).ToImage(Me.C3.Size, Me.Font)
                Case 3
                    Me.C4.BackgroundImage = hand.Cards(i).ToImage(Me.C4.Size, Me.Font)
                Case 4
                    Me.C5.BackgroundImage = hand.Cards(i).ToImage(Me.C5.Size, Me.Font)
            End Select
        Next
    End Sub
    Public Sub Reset()
        Me.C1.BackgroundImage = Nothing
        Me.C2.BackgroundImage = Nothing
        Me.C3.BackgroundImage = Nothing
        Me.C4.BackgroundImage = Nothing
        Me.C5.BackgroundImage = Nothing
    End Sub
    Protected Overrides Sub OnResize(e As EventArgs)
        Me.Size = New Drawing.Size(190, 38)
    End Sub
End Class
