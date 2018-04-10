<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Display
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.C1 = New System.Windows.Forms.PictureBox()
        Me.C2 = New System.Windows.Forms.PictureBox()
        Me.C3 = New System.Windows.Forms.PictureBox()
        Me.C4 = New System.Windows.Forms.PictureBox()
        Me.C5 = New System.Windows.Forms.PictureBox()
        CType(Me.C1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1
        '
        Me.C1.Location = New System.Drawing.Point(3, 3)
        Me.C1.Name = "C1"
        Me.C1.Size = New System.Drawing.Size(32, 32)
        Me.C1.TabIndex = 0
        Me.C1.TabStop = False
        '
        'C2
        '
        Me.C2.Location = New System.Drawing.Point(41, 3)
        Me.C2.Name = "C2"
        Me.C2.Size = New System.Drawing.Size(32, 32)
        Me.C2.TabIndex = 1
        Me.C2.TabStop = False
        '
        'C3
        '
        Me.C3.Location = New System.Drawing.Point(79, 3)
        Me.C3.Name = "C3"
        Me.C3.Size = New System.Drawing.Size(32, 32)
        Me.C3.TabIndex = 2
        Me.C3.TabStop = False
        '
        'C4
        '
        Me.C4.Location = New System.Drawing.Point(117, 3)
        Me.C4.Name = "C4"
        Me.C4.Size = New System.Drawing.Size(32, 32)
        Me.C4.TabIndex = 3
        Me.C4.TabStop = False
        '
        'C5
        '
        Me.C5.Location = New System.Drawing.Point(155, 3)
        Me.C5.Name = "C5"
        Me.C5.Size = New System.Drawing.Size(32, 32)
        Me.C5.TabIndex = 4
        Me.C5.TabStop = False
        '
        'Display
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.C5)
        Me.Controls.Add(Me.C4)
        Me.Controls.Add(Me.C3)
        Me.Controls.Add(Me.C2)
        Me.Controls.Add(Me.C1)
        Me.Name = "Display"
        Me.Size = New System.Drawing.Size(190, 38)
        CType(Me.C1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1 As System.Windows.Forms.PictureBox
    Friend WithEvents C2 As System.Windows.Forms.PictureBox
    Friend WithEvents C3 As System.Windows.Forms.PictureBox
    Friend WithEvents C4 As System.Windows.Forms.PictureBox
    Friend WithEvents C5 As System.Windows.Forms.PictureBox

End Class
