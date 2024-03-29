﻿Public Class Hand
    Inherits HandBase
    Sub New()
        Me.Cards = New List(Of Card)
    End Sub
    Sub New(cards As List(Of Card))
        Me.Cards = cards
        Me.Evaluate()
    End Sub
    Sub New(cards As Card())
        Me.Cards = cards.ToList
        Me.Evaluate()
    End Sub
    Public Overrides Function ToString() As String
        Return String.Format("{0} [{1}]", Me.Hand.Name, Me.Strength)
    End Function
End Class
