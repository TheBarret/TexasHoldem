Imports Poker

Public Class Main
    Private Property Deck As Deck
    Private Property Self As Hand
    Private Property Table As Hand
    Private Property Players As List(Of Hand)
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.btnDeal.PerformClick()
    End Sub
    Private Sub btnDeal_Click(sender As Object, e As EventArgs) Handles btnDeal.Click
        '// Create deck
        Me.Deck = New Deck(True)

        '// Create player
        Me.Self = New Hand(Me.Deck.Deal(5))

        Me.Players = New List(Of Hand)
        Me.Players.Add(New Hand(Me.Deck.Deal(5)))
        Me.Players.Add(New Hand(Me.Deck.Deal(5)))
        Me.Players.Add(New Hand(Me.Deck.Deal(5)))
        Me.Players.Add(New Hand(Me.Deck.Deal(5)))
        Me.Players.Add(New Hand(Me.Deck.Deal(5)))

        '// Create table with additional 5 cards
        Me.Table = New Hand(Me.Deck.Deal(Randomizer.Number(1, 6)))

        Me.DisplayTable.Assign(Me.Table)

        '// Evaluate hands
        Me.Players(0).EvaluateWith(Me.Table.Cards)
        Me.Players(1).EvaluateWith(Me.Table.Cards)
        Me.Players(2).EvaluateWith(Me.Table.Cards)
        Me.Players(3).EvaluateWith(Me.Table.Cards)
        Me.Players(4).EvaluateWith(Me.Table.Cards)

        Me.Display1.Assign(Me.Players(0))
        Me.Display2.Assign(Me.Players(1))
        Me.Display3.Assign(Me.Players(2))
        Me.Display4.Assign(Me.Players(3))
        Me.Display5.Assign(Me.Players(4))

        Me.Label2.Text = Me.Players(0).ToString
        Me.Label3.Text = Me.Players(1).ToString
        Me.Label4.Text = Me.Players(2).ToString
        Me.Label5.Text = Me.Players(3).ToString
        Me.Label6.Text = Me.Players(4).ToString

        Me.Self.EvaluateWith(Me.Table.Cards)
        Me.DisplayPlayer.Assign(Me.Self)
        Me.Label1.Text = Me.Self.ToString
    End Sub
End Class
