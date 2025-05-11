<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmControl
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
        Me.btnTakeAway = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnTakeAway
        '
        Me.btnTakeAway.Location = New System.Drawing.Point(248, 130)
        Me.btnTakeAway.Name = "btnTakeAway"
        Me.btnTakeAway.Size = New System.Drawing.Size(160, 68)
        Me.btnTakeAway.TabIndex = 2
        Me.btnTakeAway.Text = "TakeAway"
        Me.btnTakeAway.UseVisualStyleBackColor = True
        '
        'frmControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 361)
        Me.Controls.Add(Me.btnTakeAway)
        Me.Name = "frmControl"
        Me.Text = "Control"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnTakeAway As System.Windows.Forms.Button
End Class
