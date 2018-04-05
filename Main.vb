Imports Poker

Public Class Main
    Private Property Deck As Deck
    Private Property Player As Hand
    Private Property Table As List(Of Card)
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.btnDeal.PerformClick()
    End Sub
    Private Sub btnDeal_Click(sender As Object, e As EventArgs) Handles btnDeal.Click
        '// Create deck
        Me.Deck = New Deck(True)

        '// Create player
        Me.Player = New Hand(Me.Deck.Deal(5))

        '// Create table with additional 5 cards
        Me.Table = Me.Deck.Deal(5)

        '// Evaluate hand + table
        Me.Player.Evaluate(Me.Table)

        Me.Label1.Text = String.Format("Player: {0}", String.Join(" ", Me.Player.Cards.Select(Function(x) x.ToString)))
        Me.Label2.Text = String.Format("Table: {0}", String.Join(" ", Me.Table.Select(Function(x) x.ToString)))
        Me.Label3.Text = String.Format("Hand: {0} [{1}]", Me.Player.ToString, Me.Player.Highcard)

    End Sub
End Class
