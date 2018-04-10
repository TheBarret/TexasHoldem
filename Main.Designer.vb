<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnDeal = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Display5 = New Poker.Display()
        Me.Display4 = New Poker.Display()
        Me.Display3 = New Poker.Display()
        Me.Display2 = New Poker.Display()
        Me.Display1 = New Poker.Display()
        Me.DisplayTable = New Poker.Display()
        Me.DisplayPlayer = New Poker.Display()
        Me.SuspendLayout()
        '
        'btnDeal
        '
        Me.btnDeal.Location = New System.Drawing.Point(216, 233)
        Me.btnDeal.Name = "btnDeal"
        Me.btnDeal.Size = New System.Drawing.Size(190, 38)
        Me.btnDeal.TabIndex = 0
        Me.btnDeal.Text = "Deal"
        Me.btnDeal.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(213, 205)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "..."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "..."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(213, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "..."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(409, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "..."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 205)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "..."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(409, 205)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "..."
        '
        'Display5
        '
        Me.Display5.BackColor = System.Drawing.Color.White
        Me.Display5.Location = New System.Drawing.Point(412, 164)
        Me.Display5.Name = "Display5"
        Me.Display5.Size = New System.Drawing.Size(190, 38)
        Me.Display5.TabIndex = 15
        '
        'Display4
        '
        Me.Display4.BackColor = System.Drawing.Color.White
        Me.Display4.Location = New System.Drawing.Point(20, 164)
        Me.Display4.Name = "Display4"
        Me.Display4.Size = New System.Drawing.Size(190, 38)
        Me.Display4.TabIndex = 13
        '
        'Display3
        '
        Me.Display3.BackColor = System.Drawing.Color.White
        Me.Display3.Location = New System.Drawing.Point(412, 33)
        Me.Display3.Name = "Display3"
        Me.Display3.Size = New System.Drawing.Size(190, 38)
        Me.Display3.TabIndex = 9
        '
        'Display2
        '
        Me.Display2.BackColor = System.Drawing.Color.White
        Me.Display2.Location = New System.Drawing.Point(216, 33)
        Me.Display2.Name = "Display2"
        Me.Display2.Size = New System.Drawing.Size(190, 38)
        Me.Display2.TabIndex = 8
        '
        'Display1
        '
        Me.Display1.BackColor = System.Drawing.Color.White
        Me.Display1.Location = New System.Drawing.Point(20, 33)
        Me.Display1.Name = "Display1"
        Me.Display1.Size = New System.Drawing.Size(190, 38)
        Me.Display1.TabIndex = 7
        '
        'DisplayTable
        '
        Me.DisplayTable.BackColor = System.Drawing.Color.White
        Me.DisplayTable.Location = New System.Drawing.Point(216, 103)
        Me.DisplayTable.Name = "DisplayTable"
        Me.DisplayTable.Size = New System.Drawing.Size(190, 38)
        Me.DisplayTable.TabIndex = 5
        '
        'DisplayPlayer
        '
        Me.DisplayPlayer.BackColor = System.Drawing.Color.White
        Me.DisplayPlayer.Location = New System.Drawing.Point(216, 164)
        Me.DisplayPlayer.Name = "DisplayPlayer"
        Me.DisplayPlayer.Size = New System.Drawing.Size(190, 38)
        Me.DisplayPlayer.TabIndex = 4
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 284)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Display5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Display4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Display3)
        Me.Controls.Add(Me.Display2)
        Me.Controls.Add(Me.Display1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DisplayTable)
        Me.Controls.Add(Me.DisplayPlayer)
        Me.Controls.Add(Me.btnDeal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Texas Holdem"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDeal As System.Windows.Forms.Button
    Friend WithEvents DisplayPlayer As Poker.Display
    Friend WithEvents DisplayTable As Poker.Display
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Display1 As Poker.Display
    Friend WithEvents Display2 As Poker.Display
    Friend WithEvents Display3 As Poker.Display
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Display4 As Poker.Display
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Display5 As Poker.Display

End Class
