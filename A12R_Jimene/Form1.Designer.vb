<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Clock2 = New A12R_Jimene.Clock()
        Me.Clock1 = New A12R_Jimene.Clock()
        Me.SuspendLayout()
        '
        'Clock2
        '
        Me.Clock2.AlwaysActive = False
        Me.Clock2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Clock2.ClockType = A12R_Jimene.Clock.Type.Normal
        Me.Clock2.HowLong = "0:0"
        Me.Clock2.Location = New System.Drawing.Point(63, 140)
        Me.Clock2.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Clock2.Name = "Clock2"
        Me.Clock2.Size = New System.Drawing.Size(103, 23)
        Me.Clock2.TabIndex = 1
        '
        'Clock1
        '
        Me.Clock1.AlwaysActive = False
        Me.Clock1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Clock1.ClockType = A12R_Jimene.Clock.Type.Normal
        Me.Clock1.HowLong = "0:07"
        Me.Clock1.Location = New System.Drawing.Point(63, 63)
        Me.Clock1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Clock1.Name = "Clock1"
        Me.Clock1.Size = New System.Drawing.Size(91, 23)
        Me.Clock1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.Clock2)
        Me.Controls.Add(Me.Clock1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Clock1 As Clock
    Friend WithEvents Clock2 As Clock
End Class
