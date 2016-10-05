<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Summary
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbSummary = New System.Windows.Forms.ListBox()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbSummary
        '
        Me.lbSummary.FormattingEnabled = True
        Me.lbSummary.Location = New System.Drawing.Point(37, 46)
        Me.lbSummary.Name = "lbSummary"
        Me.lbSummary.Size = New System.Drawing.Size(594, 290)
        Me.lbSummary.TabIndex = 0
        '
        'btnTotal
        '
        Me.btnTotal.Location = New System.Drawing.Point(676, 269)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(99, 66)
        Me.btnTotal.TabIndex = 1
        Me.btnTotal.Text = "Total"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'Summary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 353)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.lbSummary)
        Me.Name = "Summary"
        Me.Text = "Summary"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbSummary As ListBox
    Friend WithEvents btnTotal As Button
End Class
